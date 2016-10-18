using System;
using System.Collections.Generic;
using System.Linq;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DataAccess
{
    /// <summary>
    /// Takes the responsability of convert objects into console output
    /// </summary>
    class ConsoleWriter
    {
        public static string WriteUsers(List<UserEntity> orders)
        {
            List<int> usersIDs = orders.Select(o => o.User_ID).Distinct().ToList();
            return string.Join(",", usersIDs);
        }
    }
}
