using Backend.Data;
using Backend.Model;
using Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Backend.Services
{
    public static class ValidationService
    {
        public static bool ValidateClientRegisterProcess(string name, string lastName, string birthday, string phoneNumber, string country, string city,
            string street, string houseNumber, string zipCode, out string message)
        {
            if(name ==  null || name.Length == 0 || lastName == null || lastName.Length == 0 || birthday == null
                || birthday.Length == 0 || phoneNumber == null || phoneNumber.Length == 0 || country == null
                || country.Length == 0 || city == null | city.Length == 0 || street == null
                || street.Length == 0 || houseNumber == null || houseNumber.Length == 0 || zipCode == null
                || zipCode.Length == 0)
            {
                message = "Not every form field is filled";
                return false;
            }

            if(name.Length > 40)
            {
                message = "Name field is too long";
                return false;
            }

            if (lastName.Length > 40)
            {
                message = "Last name field is too long";
                return false;
            }

            if (phoneNumber.Length != 9)
            {
                message = "Phone number is incorrect";
                return false;
            }

            if (country.Length > 40)
            {
                message = "Country field is too long";
                return false;
            }

            if (city.Length > 40)
            {
                message = "City field is too long";
                return false;
            }

            if (street.Length > 40)
            {
                message = "Street field is too long";
                return false;
            }

            if (!Regex.IsMatch(zipCode, @"^\d{2}-\d{3}$"))
            {
                message = "Invalid zip code format. Please use format '00-000'";
                return false;
            }

            if (!Regex.IsMatch(houseNumber, @"^[0-9a-zA-Z]+$"))
            {
                message = "Invalid house number format. Please use only alphanumeric characters";
                return false;
            }

            if (!DateTime.TryParseExact(birthday, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                message = "Invalid birthday format. Please use format 'dd/MM/yyyy'";
                return false;
            }

            if (parsedDate > DateTime.Now)
            {
                message = "Birthday cannot be in the future";
                return false;
            }

            message = string.Empty;
            return true;
        }

        public static bool ValidateUserRegisterProcess(string login, string password, string email, out string message)
        {
            if(login == null || login.Length  == 0 || password == null || password.Length == 0 || email == null || email.Length == 0)
            {
                message = "Not every form field is filled";
                return false;
            }

            if(login.Length < 5)
            {
                message = "Login must contain at least 5 characters";
                return false;

            }
            
            if (login.Length > 20)
            {
                message = "Login can contain max 20 characters";
                return false;

            }

            if(password.Length < 5)
            {
                message = "Password must contain at least 5 characters";
                return false;
            }

            if (password.Length > 20)
            {
                message = "Password can contain max 20 characters";
                return false;

            }

            if (!password.Any(char.IsDigit))
            {
                message = "Password must contain at least one digit";
                return false;
            }

            if(!IsValidEmail(email))
            {
                message = "Invalid email format";
                return false;
            }

            using(var context = new DataContext())
            {
                if(context.Users.Any(u => u.Login == login))
                {
                    message = "Login already exists";
                    return false;
                }

                if (context.Users.Any(u => u.Email == email))
                {
                    message = "Email already exists";
                    return false;
                }
            }
            message = string.Empty;
            return true;
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static bool ValidatePersonalDataChange(Person _client, string login, string email, string name, string lastName, string birthday,
            string sex, string phoneNumber, string country, string city, string street, string houseNumber, string zipCode, out string message)
        {
            if (login == _client.User.Login &&
            email == _client.User.Email &&
            name == _client.Name &&
            lastName == _client.LastName &&
            birthday == _client.Birthday &&
            sex == _client.Sex.ToString() &&
            phoneNumber == _client.PhoneNumber &&
            country == _client.Country &&
            city == _client.City &&
            street == _client.Street &&
            houseNumber == _client.HouseNumber &&
            zipCode == _client.ZipCode)
            {
                message = "No value has been changed";
                return false;
            }

            if(!ValidateClientRegisterProcess(name, lastName, birthday, phoneNumber, country, city, street, houseNumber, zipCode, out message))
            {
                return false;
            }


            if (login == null || login.Length == 0 || email == null || email.Length == 0)
            {
                message = "Not every form field is filled";
                return false;
            }

            if (login.Length < 5)
            {
                message = "Login must contain at least 5 characters";
                return false;

            }

            if (login.Length > 20)
            {
                message = "Login can contain max 20 characters";
                return false;

            }



            if (!IsValidEmail(email))
            {
                message = "Invalid email format";
                return false;
            }

            using (var context = new DataContext())
            {
                if(login != _client.User.Login)
                {
                    if (context.Users.Any(u => u.Login == login))
                    {
                        message = "Login already exists";
                        return false;
                    }
                }

                if(email != _client.User.Email)
                {
                    if (context.Users.Any(u => u.Email == email))
                    {
                        message = "Email already exists";
                        return false;
                    }
                }
            }

            message = String.Empty;
            return true;
        }

        public static bool ValidateUserPassword(string password, out string message)
        {
            if (password.Length < 5)
            {
                message = "Password must contain \nmin 5 characters";
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                message = "Password must contain \nat least one digit";
                return false;
            }

            if (password.Length > 20)
            {
                message = "Password can contain \nmax 20 characters";
                return false;

            }

            message = String.Empty;
            return true; 
        }

        public static bool ValidateMovieAddProcess(string title, string description, string duration, string director, string releaseDate,
            string withdrawalDate, string imageFileName, out string message)
        {
            try
            {
                if (title == null || title.Length == 0 || description == null || description.Length == 0 ||
                    director == null || director.Length == 0 || releaseDate == null || releaseDate.Length == 0 ||
                    withdrawalDate == null || withdrawalDate.Length == 0 || imageFileName == null || imageFileName.Length == 0)
                {
                    message = "Not every form field is filled";
                    return false;
                }

                if (!int.TryParse(duration, out int parsedDuration) || parsedDuration <= 0)
                {
                    message = "Invalid duration format.\nPlease enter a valid positive integer.";
                    return false;
                }

                try
                {
                    if (ParsingService.ParseStringToDateTime(releaseDate) >= ParsingService.ParseStringToDateTime(withdrawalDate))
                    {
                        message = "Withdrawal date must be later than release date";
                        return false;
                    }

                    List<string> allMovieTitles = Movie.GetAllMovieTitles();

                    if (allMovieTitles.Contains(title))
                    {
                        message = "Movie title must be unique";
                        return false;
                    }

                    List<string> imageFileNames = Movie.GetAllImageFileNames();

                    if (imageFileNames.Contains(imageFileName))
                    {
                        message = "Change your image file name";
                        return false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                message = String.Empty;
                return true;

            }
            catch(Exception ex)
            {
                throw new Exception("Error in ValidateMovieAddProccess. " + ex.Message);
            }
        }

        public static bool ValidateScreeningAddProcess(Movie movie, DateTime screeningDate, 
            string screeningHour, out string message)
        {
            try
            {
                if (!IsValidTimeFormat(screeningHour))
                {
                    message = "Invalid time format";
                    return false;
                }

                DateTime startRange = DateTime.ParseExact(screeningHour, "HH:mm", CultureInfo.InvariantCulture);

                if(startRange.TimeOfDay < TimeSpan.FromHours(10) 
                    || startRange.TimeOfDay > TimeSpan.FromHours(22))
                {
                    message = "Screening must be between\n10:00 and 22:00";
                    return false;
                }

                if(screeningDate.Date < DateTime.Now.Date)
                {
                    message = "Screening date cannot be\nearlier than today.";
                    return false;
                }

                DateTime endRange = startRange.AddMinutes((double)movie.Duaration! + 30);

                List<Screening> screeningsForSelectedDate = Screening.GetScreeningsForSelectedDate(screeningDate);

                foreach(Screening screening in screeningsForSelectedDate)
                {
                    DateTime existingStart = DateTime.ParseExact(ParsingService.ParseStartTime(screening.StartTime),
                        "HH:mm", CultureInfo.InvariantCulture);
                    DateTime existingEnd = existingStart.AddMinutes((double)screening.Movie.Duaration! + 30);

                    if(!(endRange <= existingStart || startRange >= existingEnd))
                    {
                        message = "This term conflicts with\nexisting screening";
                        return false;
                    }
                }



                message = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in ValidateScreeningAddProcess method. " + ex.Message);
            }
        }

        private static bool IsValidTimeFormat(string time)
        {
            return DateTime.TryParseExact(time, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
