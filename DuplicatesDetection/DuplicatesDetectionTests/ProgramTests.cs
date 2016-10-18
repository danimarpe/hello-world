using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuplicatesDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        private int totalRecords = 10000; //Configure this to get the max records to read in the file
        private string filePath = "C:\\SampleInput.txt"; //Configure this to get the input file path

        private List<UserEntity> input; //This is the input string, read from the input file

        public ProgramTests()
        {
            input = ReadInputFile();

            //Check to avoid out of range exceptions
            if (totalRecords > input.Count)
                totalRecords = input.Count;
        }

        private List<UserEntity> ReadInputFile()
        {
            StringBuilder fileContent = new StringBuilder("");
            List<UserEntity> users = new List<UserEntity>();

            var lines = File.ReadLines(this.filePath); // Read all lines of the file

            foreach (string line in lines)
            {
                users.Add(DataAccess.Data.GetUser(line)); // Convert each line into a User Object
            }

            return users;
        }

        [TestMethod()]
        public void DetectDuplicatesLINQTest()
        {
            var result = Program.DetectDuplicates(input, DuplicateDetectStrategy.DetectionMode.LINQ);
        }

        [TestMethod()]
        public void DetectDuplicatesITERATIONTest()
        {
            var result = Program.DetectDuplicates(input, DuplicateDetectStrategy.DetectionMode.ITERATION);
        }

    }
}