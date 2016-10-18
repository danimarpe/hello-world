using System.Collections.Generic;
using System.Linq;
using DuplicatesDetection.Entities;
using System;

namespace DuplicatesDetection.DuplicateDetectStrategy.IterationStrategies
{
    public class DetectSameAddress : IDuplicateDetect
    {
        public List<UserEntity> Detect(List<UserEntity> users)
        {
            List<UserEntity> duplicates = new List<UserEntity>();

            foreach (UserEntity user in users)
            {
                if (HasRepeatedAddress(user, users))
                    duplicates.Add(user);
            }

            return duplicates;
        }

        /// <summary>
        /// Iterates over a list, looking for a repeated Address of the current user
        /// </summary>
        /// <param name="currentUser"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        private bool HasRepeatedAddress(UserEntity currentUser, List<UserEntity> users)
        {
            foreach (UserEntity user in users)
            {
                if (user.UserName == currentUser.UserName &&
                    user.Address.Equals(currentUser.Address) &&
                    user.Credit_Card != currentUser.Credit_Card)
                    return true;
            }

            return false;
        }
    }
}
