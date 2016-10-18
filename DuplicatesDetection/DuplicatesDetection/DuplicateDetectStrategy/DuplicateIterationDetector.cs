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

        public List<UserEntity> Detect(List<UserEntity> orders)
        {
            List<UserEntity> fraudulent = sameAddress.Detect(orders);
            fraudulent.AddRange(sameEmail.Detect(orders));

            return fraudulent;
        }
    }
}
