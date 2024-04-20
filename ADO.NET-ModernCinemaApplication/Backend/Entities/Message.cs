using Backend.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    [Table("Messages")]
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string? Date { get; set; }
        public string? Contents { get; set; }
        public bool? IsRead { get; set; } = false;
        public int? UserId { get; set; }

        public Message() { }
        public Message(string date, string contents, int userId)
        {
            Date = date;
            Contents = contents;
            UserId = userId;
        }

        // METODY DO PRZEROBIENIA I PRZENIESIENIA DO REPOSITORIES

        /*public static List<Message> GetNotReadUserMessages(int userId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Messages
                        .Where(m => m.UserId == userId && m.IsRead == false)
                        .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetUserMessages method. " + ex);
                }
            }
        }

        public static void MarkMessageAsRead(string date, string contents, int userId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    Message message = context.Messages
                        .FirstOrDefault(r => r.Date == date && r.Contents == contents && r.UserId == userId && 
                        r.IsRead == false)!;

                    if(message == null)
                    {
                        throw new Exception();
                    }

                    message.IsRead = true;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetUserMessages method. " + ex);
                }
            }
        }

        public static void AddNewMessages(List<int?> userIds, Screening screening)
        {
            using (var context = new DataContext())
            {
                try
                {
                    if(userIds == null || userIds.Count == 0 || screening == null)
                    {
                        throw new Exception() ;
                    }

                    foreach(int userId in userIds)
                    {
                        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        string contents = $"Your reservation/s on {screening.Movie.Title} {screening.StartTime}\n were deleted" +
                            $" due to cancellation\n of the screening";

                        Message message = new Message(date, contents, userId);
                        context.Messages.Add(message);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetUserMessages method. " + ex);
                }
            }
        }*/
    }
}
