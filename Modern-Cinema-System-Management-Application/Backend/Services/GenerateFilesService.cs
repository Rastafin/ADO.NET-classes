using Backend.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public static class GenerateFilesService
    {
        public static void GeneratePDFWithReservation(Person client, Reservation reservation, string seats, string filePath)
        {
            try
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                Paragraph title = new Paragraph("Reservation Details", new Font(Font.FontFamily.HELVETICA, 30, Font.BOLD))
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 40f 
                };
                document.Add(title);

                PdfPTable table = new PdfPTable(2);
                table.AddCell("Client Name");
                table.AddCell(client.Name);
                table.AddCell("Client Last Name");
                table.AddCell(client.LastName);
                table.AddCell("Start Time");
                table.AddCell(reservation.Screening.StartTime);
                table.AddCell("Title");
                table.AddCell(reservation.Screening!.Movie.Title);
                table.AddCell("Room Number");
                table.AddCell(reservation.Screening.Room.RoomNumber);
                table.AddCell("Seats");
                table.AddCell(seats);

                Font font = FontFactory.GetFont(FontFactory.HELVETICA, 20);
                foreach (PdfPCell cell in table.Rows.SelectMany(r => r.GetCells()))
                {
                    cell.Phrase = new Phrase(cell.Phrase.Content, font);
                }

                document.Add(table);

                Paragraph codeParagraph = new Paragraph("To confirm your reservation with ID " + reservation.Id +
                " you need to enter this code: " + reservation.ConfirmationNumber + " before payment.", new Font(Font.FontFamily.HELVETICA, 25))
                {
                    SpacingBefore = 50f 
                };

                document.Add(codeParagraph);


                document.Close();
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
