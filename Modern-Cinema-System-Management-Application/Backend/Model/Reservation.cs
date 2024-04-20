using Backend.Data;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey("ScreeningId")]
        public int? ScreeningId { get; set; }
        public Screening? Screening { get; set; }

        public string? Seat { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public string? ConfirmationNumber { get; set; }
        public bool? IsReceived { get; set; } = false;
        public static List<string> GetReservedSeatsForScreening(int screeningId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Reservations
                        .Where(s => s.ScreeningId == screeningId && s.IsDeleted == false)
                        .Select(s => s.Seat)
                        .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetReservedSeatsForScreening method. " + ex.Message);
                }
            }
        }

        public static void MakeReservationForScreening(int userId, int screeningId, List<string> listOfSeats)
        {
            Random random = new Random();
            string confirmationNumber = random.Next(100000, 999999).ToString();

            using (var context = new DataContext())
            {
                try
                {
                    foreach (string seat in listOfSeats)
                    {
                        Reservation? currentReservation = (GetUserReservation(userId, screeningId));

                        if (currentReservation != null && currentReservation.ConfirmationNumber != null)
                        {
                            confirmationNumber = currentReservation.ConfirmationNumber;
                        }

                        Reservation reservation = new Reservation
                        {
                            UserId = userId,
                            ScreeningId = screeningId,
                            Seat = seat, 
                            ConfirmationNumber = confirmationNumber
                        };

                        context.Reservations.Add(reservation);
                    }

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<(string Title, string StartTime, string RoomNumber, string Seat)> GetUserReseervations(int userId)
        {
            using(var context = new DataContext())
            {
                try
                {
                    var userReservations = context.Reservations
                        .Where(r => r.UserId == userId && r.IsDeleted == false)
                        .Select(r => new
                        {
                            Title = r.Screening.Movie.Title,
                            StartTime = r.Screening.StartTime,
                            RoomNumber = r.Screening.Room.RoomNumber,
                            Seat = r.Seat
                        })
                        .ToList();

                    return userReservations
                        .Select(r => (r.Title, r.StartTime, r.RoomNumber, r.Seat))
                        .ToList();
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

        public static Reservation GetUserReservation(int userId, int screeningId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Reservations
                        .Include(r => r.Screening.Movie)
                        .Include(r => r.Screening.Room)
                        .Where(r => r.UserId == userId && r.ScreeningId == screeningId && r.IsDeleted == false)
                        .FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }


        public static void DeleteOldReservations()
        {
            using (var context = new DataContext())
            {
                try
                {
                    List<Reservation> reservations = context.Reservations
                        .Include(r => r.Screening)
                        .Include(r => r.Screening.Movie)
                        .ToList();

                    foreach (var reservation in reservations)
                    {
                        DateTime now = ParsingService.ParseStringToDateTimeWithTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

                        DateTime startTime = ParsingService.ParseStringToDateTimeWithTime(reservation.Screening.StartTime);

                        if (startTime.AddMinutes(-30) < now && reservation.IsDeleted == false && reservation.IsReceived != true)
                        {
                            reservation.IsDeleted = true;
                        } 
                        else if (startTime.AddMinutes(Double.Parse(reservation.Screening.Movie.Duaration.ToString())) < now)
                        {
                            reservation.IsDeleted = true;
                        }
                    }

                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

        public static void CancelReservation(int userId, string movieTitle, string screeningStartTime)
        {
            using (var context = new DataContext())
            {
                try
                {
                    List<Reservation> reservations = context.Reservations
                        .Include(r => r.Screening.Movie)
                        .Where(r => r.UserId == userId && r.Screening.Movie.Title == movieTitle && r.Screening.StartTime == screeningStartTime)
                        .ToList();

                    foreach(var reservation in reservations)
                    {
                        if(reservation.IsDeleted == false) reservation.IsDeleted = true;
                    }

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<Reservation> GetNotDeletedReservations()
        {
            using(var context = new DataContext())
            {
                try
                {
                    List<Reservation> reservations = context.Reservations
                        .Where(r => r.IsDeleted == false)
                        .Include(r => r.User)
                        .Include(r => r.Screening)
                        .Include(r => r.Screening!.Movie)
                        .Include(r => r.Screening!.Room)
                        .ToList();

                    return reservations;
                }
                catch(Exception ex)
                {
                    throw new Exception("Error in GetNotDeletedReservations method. ");
                }
            }
        }

        public static bool CheckConfirmationNumber(int reservationId, string givenConfirmationNumber)
        {
            using (var context = new DataContext())
            {
                try
                {
                    string correctConfirmationNumber = context.Reservations.FirstOrDefault(r => r.Id == reservationId).ConfirmationNumber;

                    if (correctConfirmationNumber == null) return false;                

                    if(correctConfirmationNumber == givenConfirmationNumber)    
                    {
                        return true;
                    }
                    else
                    {       
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in CheckConfirmationNumber method. " + ex);
                }
            }
        }

        public static void ConfirmReservation(int reservationId)
        {
            using(var context = new DataContext())
            {
                try
                {
                    Reservation reservation = context.Reservations.FirstOrDefault(r => r.Id == reservationId);

                    if (reservation == null)
                    {
                        throw new Exception();
                    }

                    if ((bool)reservation.IsReceived!) return;

                    reservation.IsReceived = true;

                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw new Exception("Error in ConfirmReservation method. " + ex);
                }
            }
        }

        public static Reservation GetReservationById(int reservationId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    Reservation reservation = context.Reservations.FirstOrDefault(r => r.Id.Equals(reservationId));

                    if(reservation == null) throw new Exception();

                    return reservation;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetReservationById method. " + ex);
                }
            }
        }

        public static List<Reservation> GetUserReservationsListByStartTimeAndRoomNumber(string email, string startTime, string roomNumber)
        {
            using (var context = new DataContext())
            {
                try
                {
                    List<Reservation> allReservations = context.Reservations
                        .Include(r => r.User)
                        .Include(r => r.Screening)
                        .Include(r => r.Screening!.Room)
                        .Where(r => r.IsDeleted == false && r.IsReceived == false)
                        .ToList();

                    List<Reservation> allUserReservationsForScreening = new List<Reservation>();

                    foreach (var item in allReservations)
                    {
                        if(item.Screening!.StartTime == startTime && item.Screening.Room.RoomNumber == roomNumber
                            && item.User!.Email == email)
                        {
                            allUserReservationsForScreening.Add(item);
                        }
                    }

                    return allUserReservationsForScreening;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetReservationsListByStartTimeAndRoomNumber method. " + ex);
                }
            }
        }

        public static int GetNumberOfReservedSeatsForScreening(int screeningId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Reservations
                        .Where(r => r.IsDeleted == false)
                        .Count(r => r.ScreeningId == screeningId);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetNumberOfReservedSeatsForScreening method. " + ex);
                }
            }
        }
    }
}
