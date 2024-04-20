using Backend.Data;
using Backend.Model.Enums;
using Backend.Services;
using iTextSharp.text.pdf.qrcode;
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
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get;set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Duaration { get; set; }
        public string? Director { get; set; }
        public string? ReleaseDate { get; set; }
        public string? WithdrawalDate { get; set; }
        public string? ImageFileName { get; set; }
        public bool IsArchived { get; set; } = false;
        public MovieCategory? Category { get; set; }
        public List<Screening> Screenings { get; set; }

        public static Movie GetMovieByTitle(string title)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Movies.FirstOrDefault(m => m.Title == title && m.IsArchived == false)!;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetMovieByTitle method. " + ex.Message);
                }
            }
        }

        public static void AddNewMovie(Movie movie)
        {
            using (var context = new DataContext())
            {
                try
                {
                    context.Movies.Add(movie);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in AddNewMovie method. " + ex.Message);
                }
            }
        }

        public static List<string> GetAllMovieTitles()
        {
            List<string> movieTitles = new List<string>();

            using (var context = new DataContext())
            {
                try
                {
                    var movies = context.Movies
                        .Where(r => r.IsArchived == false)
                        .ToList();

                    foreach(var movie in movies)
                    {
                        movieTitles.Add(movie.Title!);
                    }

                    return movieTitles;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetAllMoviesTitles method. " + ex.Message);
                }
            }
        }

        public static List<string> GetAllImageFileNames()
        {
            List<string> imageFileNames = new List<string>();

            using (var context = new DataContext())
            {
                try
                {
                    var movies = context.Movies.ToList();

                    foreach (var movie in movies)
                    {
                        imageFileNames.Add(movie.ImageFileName!);
                    }

                    return imageFileNames;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetAllMoviesTitles method. " + ex.Message);
                }
            }
        }

        public static void ArchiveMoviesToWithdraw()
        {
            using (var context = new DataContext())
            {
                try
                {
                    DateTime today = ParsingService.ParseStringToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));

                    List<Movie> moviesToArchive = context.Movies
                        .Where(movie => movie.WithdrawalDate != null)
                        .ToList();

                    foreach(Movie movie in moviesToArchive)
                    {
                        if(ParsingService.ParseStringToDateTime(movie.WithdrawalDate!) <= today)
                        {
                            movie.IsArchived = true;
                        }
                    }

                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    throw new Exception("Error in ArchiveMoviesToWithdraw method. " + ex.Message);
                }
            }
        }

        public static List<Movie> GetMoviesAvailableForScreening(DateTime screenigDate)
        {
            using (var context = new DataContext())
            {
                try
                {
                    List<Movie> allMovies = context.Movies
                        .Where(r => r.IsArchived == false)
                        .ToList();

                    List<Movie> availableMovies = new List<Movie>();

                    foreach (Movie movie in allMovies)
                    {
                        if(ParsingService.ParseStringToDateTime(movie.ReleaseDate!) <= screenigDate
                            && ParsingService.ParseStringToDateTime(movie.WithdrawalDate!) > screenigDate)
                        {
                            availableMovies.Add(movie);
                        }
                    }

                    return availableMovies;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetMoviesAvailableForScreening method. " + ex.Message);
                }
            }
        }

        public static string ArchiveMovie(string movieTitle)
        {
            using (var context = new DataContext())
            {
                try
                {
                    Movie? movieToArchive = context.Movies
                        .FirstOrDefault(m => m.Title == movieTitle && m.IsArchived == false);

                    List<Screening> currentScreenings = Screening.GetCurrentScreenings();

                    if (movieToArchive == null)
                    {
                        throw new Exception();
                    }

                    if(currentScreenings != null && currentScreenings.Count > 0)
                    {
                        foreach (Screening screening in currentScreenings)
                        {
                            if (screening.Movie.Id == movieToArchive.Id)
                            {
                                return "All screenings with this movie \nneed to be cancelled first";
                            }
                        }
                    } 

                    if (!movieToArchive.IsArchived)
                    {
                        movieToArchive.IsArchived = true;
                    }

                    context.SaveChanges();

                    return "Movie has been archived";
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in ArchiveMovie method. " + ex.Message);
                }
            }
        }
    }
}
