using System.Collections.Generic;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy
{
    /// <summary>
    /// Detects duplicate users
    /// </summary>
    public class DuplicateIterationDetector
    {
        IDuplicateDetect sameAddress;
        IDuplicateDetect sameEmail;

        public DuplicateIterationDetector()
        {
            sameAddress = new IterationStrategies.DetectSameAddress();
            sameEmail = new IterationStrategies.DetectSameEmail();
        }

        public List<UserEntity> Detect(List<UserEntity> users)
        {
            List<UserEntity> duplicates = sameAddress.Detect(users);
            duplicates.AddRange(sameEmail.Detect(users));

            return duplicates;
        }
    }
}
