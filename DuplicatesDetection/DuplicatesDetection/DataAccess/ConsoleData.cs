using System.Collections.Generic;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DataAccess
{
    public class ConsoleData
    {
        private static ConsoleWriter writer { get; }
        private static ConsoleReader reader { get; }

        /// <summary>
        /// Read a line and convert it into a User object
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static UserEntity GetUser(string line)
        {
            return ConsoleReader.GetUser(line);
        }

        /// <summary>
        /// Read a list of User objects and convert it into a string of all the User_IDs separated by commas
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public static string WriteUsers(List<UserEntity> orders)
        {
            return ConsoleWriter.WriteUsers(orders);
        }


    }
}
