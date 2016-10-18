using System.Collections.Generic;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy
{
    /// <summary>
    /// Detects duplicate users
    /// </summary>
    public class DuplicateDetector
    {
        IDuplicateDetect sameAddress;
        IDuplicateDetect sameEmail;

        public DuplicateDetector()
        {
            sameAddress = new DetectSameAddress();
            sameEmail = new DetectSameEmail();
        }

        public List<UserEntity> Detect(List<UserEntity> orders)
        {
            List<UserEntity> fraudulent = sameAddress.Detect(orders);
            fraudulent.AddRange(sameEmail.Detect(orders));

            return fraudulent;
        }
    }
}
