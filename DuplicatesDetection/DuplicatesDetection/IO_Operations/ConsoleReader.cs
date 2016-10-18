using System;
using System.Collections.Generic;
using System.Linq;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DataAccess
{
    /// <summary>
    /// Takes the responsability of convert the console input into objects
    /// </summary>
    class ConsoleReader
    {


        public static UserEntity GetUser(string line)
        {
            try
            {
                List<string> fields = line.Split(',').ToList();

                return new UserEntity
                {
                    User_ID = Convert.ToInt32(fields[0]),
                    UserName = fields[1],
                    Email = fields[2],
                    Address = new AddressEntity
                    {
                        Street = fields[3],
                        City = fields[4],
                        State = fields[5],
                        Zip_Code = fields[6]
                    },
                    Credit_Card = fields[7]
                };
            }
            catch (Exception ex)
            {
                throw new FormatException("Format Error: Check all the fields are separated by commas\nDebug info: " + ex.Message);
            }
        }
    }
}
