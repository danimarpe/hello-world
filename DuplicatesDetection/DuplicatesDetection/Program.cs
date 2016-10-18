using System;
using System.Collections.Generic;
using DuplicatesDetection.Entities;
using DuplicatesDetection.DuplicateDetectStrategy;
using DuplicatesDetection.DataAccess;
using System.Linq;
using System.IO;
using System.Text;

namespace DuplicatesDetection
{
    public class Program
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void Main(string[] args)
        {
            try
            {
                int totalLines = Convert.ToInt32(Console.ReadLine());
                List<UserEntity> users = new List<UserEntity>();

                for (int i = 0; i < totalLines; i++)
                {
                    users.Add(Data.GetUser(Console.ReadLine()));

                }

                List<UserEntity> duplicates = DetectDuplicates(users, DetectionMode.LINQ); //Change this line to swap between the Linq or the Iteration strategies
                Console.WriteLine(Data.WriteUsers(duplicates)); 
                Console.ReadKey();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error: " + ex.Message);
                Console.ReadKey();
            }
        }

        public static List<UserEntity> DetectDuplicates(List<UserEntity> users, DetectionMode mode)
        {
            DuplicateDetector detector;

            if (mode == DetectionMode.LINQ)
                detector = new DuplicateLinqDetector();
            else
                detector = new DuplicateIterationDetector();

            return detector.Detect(users);
        }

        /// <summary>
        /// This function was used to create the SampleInput.txt file
        /// </summary>
        private static void CreateTestFile()
        {
            using (var file = File.Create("c:\\SampleInput.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    string lineUser = i.ToString() + "," +
                    RandomString(10) + "," +
                    RandomString(6) + "@" + RandomString(5) + "." + RandomString(3) + "," +
                    RandomNumber(2) + " " + RandomString(10) + "St." + "," +
                    RandomString(10) + "," +
                    RandomString(2) + "," +
                    RandomNumber(5) + "," +
                    RandomNumber(14) + "\n";
                    file.Write(Encoding.ASCII.GetBytes(lineUser), 0, lineUser.Length);
                }
                Console.WriteLine(file.Length);
            }
        }
    }
}
