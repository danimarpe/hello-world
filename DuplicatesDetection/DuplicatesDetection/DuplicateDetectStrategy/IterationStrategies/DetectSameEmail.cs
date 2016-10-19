using System;
using System.Collections.Generic;
using System.Linq;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy.IterationStrategies
{
    public class DetectSameEmail : IDuplicateDetect
    {

        public List<UserEntity> Detect(List<UserEntity> users)
        {
            List<UserEntity> duplicates = new List<UserEntity>();

            foreach (UserEntity user in users)
            {
                if (HasRepeatedEmail(user, users)) //
                    duplicates.Add(user);
            }

            return duplicates;
        }

        /// <summary>
        /// Iterates over a list, looking for a repeated Email of the current user
        /// </summary>
        /// <param name="currentUser"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        private bool HasRepeatedEmail(UserEntity currentUser, List<UserEntity> users)
        {
            foreach (UserEntity user in users)
            {
                if (user.UserName == currentUser.UserName &&
                    user.Email == currentUser.Email &&
                    user.Credit_Card != currentUser.Credit_Card)
                    return true;
            }

            return false;
        }
    }
}
