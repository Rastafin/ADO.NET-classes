using Backend.Data;
using Backend.Model;
using Backend.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class ChartDataCalculator
    {
        public static (double malePercentage, double femalePercentage, double otherPercentage) GetUsersSexDataCounts()
        {
            using (var context = new DataContext())
            {
                try
                {
                    var people = context.Users.ToList();

                    int maleCount = context.Clients.Count(u => u.Sex == Sex.Man);
                    int femaleCount = context.Clients.Count(u => u.Sex == Sex.Woman);
                    int otherCount = context.Clients.Count(u => u.Sex == Sex.Other);

                    int totalSexCount = maleCount + femaleCount + otherCount;

                    double malePercentage = (maleCount / (double)totalSexCount) * 100;
                    double femalePercentage = (femaleCount / (double)totalSexCount) * 100;
                    double otherPercentage = (otherCount / (double)totalSexCount) * 100;

                    return (malePercentage, femalePercentage, otherPercentage);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetUsersSexDataCounts method. " + ex.Message);
                }
            }
        }

        public static (double comedyPercentage, double actionPercentage, double adventurePercentage, 
            double dramaPercentage, double horrorPercentage, double thrillerPercentage) GetMoviesCategoryDataCounts()
        {
            using (var context = new DataContext())
            {
                try
                {
                    var movies = context.Movies.Where(m => !m.IsArchived).ToList();

                    int comedyCount = movies.Count(m => m.Category == MovieCategory.Comedy);
                    int actionCount = movies.Count(m => m.Category == MovieCategory.Action);
                    int adventureCount = movies.Count(m => m.Category == MovieCategory.Adventure);
                    int dramaCount = movies.Count(m => m.Category == MovieCategory.Drama);
                    int horrorCount = movies.Count(m => m.Category == MovieCategory.Horror);
                    int thrillerCount = movies.Count(m => m.Category == MovieCategory.Thriller);

                    int totalMovieCount = comedyCount + actionCount + adventureCount + dramaCount + horrorCount + thrillerCount;

                    double comedyPercentage = (comedyCount / (double)totalMovieCount) * 100;
                    double actionPercentage = (actionCount / (double)totalMovieCount) * 100;
                    double adventurePercentage = (adventureCount / (double)totalMovieCount) * 100;
                    double dramaPercentage = (dramaCount / (double)totalMovieCount) * 100;
                    double horrorPercentage = (horrorCount / (double)totalMovieCount) * 100;
                    double thrillerPercentage = (thrillerCount / (double)totalMovieCount) * 100;

                    return (comedyPercentage, actionPercentage, adventurePercentage, dramaPercentage, horrorPercentage, thrillerPercentage);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetMoviesCategoryDataCounts method. " + ex.Message);
                }
            }
        }

        public static Dictionary<string, int> GetAgeGroupsDistribution()
        {
            try
            {
                Dictionary<string, int> ageGroupsDistribution = new Dictionary<string, int>();

                var ageGroups = new[]
                {
                (0, 18, "Under 18"),
                (18, 25, "18-24"),
                (25, 35, "25-34"),
                (35, 45, "35-44"),
                (45, 55, "45-54"),
                (55, 65, "55-64"),
                (65, int.MaxValue, "65+")
            };

                foreach (var ageGroup in ageGroups)
                {
                    ageGroupsDistribution.Add(ageGroup.Item3, 0);
                }


                List<(Person client, int age)> clientsWithAge = Person.GetClientsWithAge();

                foreach (var (client, age) in clientsWithAge)
                {
                    foreach (var ageGroup in ageGroups)
                    {
                        if (age >= ageGroup.Item1 && age < ageGroup.Item2)
                        {
                            ageGroupsDistribution[ageGroup.Item3]++;
                            break;
                        }
                    }
                }

                return ageGroupsDistribution;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAgeGroupsDistribution method. " + ex.Message);
            }
        }
    }
}
