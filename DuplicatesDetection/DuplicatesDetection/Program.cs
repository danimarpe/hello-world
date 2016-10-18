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
                Console.WriteLine(DetectWithLinq(DetectionMode.LINQ)); //Change this line to swap between the Linq or the Iteration strategies
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

        private static string DetectWithLinq(DetectionMode mode)
        {
            int totalLines = Convert.ToInt32(Console.ReadLine());
            List<UserEntity> users = new List<UserEntity>();

            for (int i = 0; i < totalLines; i++)
            {
                users.Add(ConsoleData.GetUser(Console.ReadLine()));

            }
            IDuplicateDetect detector;

            if (mode == DetectionMode.LINQ)
                detector = (IDuplicateDetect)new DuplicateLinqDetector();
            else
                detector = (IDuplicateDetect)new DuplicateIterationDetector();

            return ConsoleData.WriteUsers(detector.Detect(users));
        }
    }
}
