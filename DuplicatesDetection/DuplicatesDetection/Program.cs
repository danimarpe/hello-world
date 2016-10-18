using System;
using System.Collections.Generic;
using DuplicatesDetection.Entities;
using DuplicatesDetection.DuplicateDetectStrategy;
using DuplicatesDetection.DataAccess;

namespace DuplicatesDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int totalLines = Convert.ToInt32(Console.ReadLine());
                List<UserEntity> users = new List<UserEntity>();

                for (int i = 0; i < totalLines; i++)
                {
                    users.Add(ConsoleData.GetUser(Console.ReadLine()));
                }

                DuplicateLinqDetector detector = new DuplicateLinqDetector();

                string output = ConsoleData.WriteUsers(detector.Detect(users));

                Console.WriteLine(output);
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
    }
}
