﻿using System.Collections.Generic;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy
{
    /// <summary>
    /// Detects duplicate users
    /// </summary>
    public class DuplicateLinqDetector
    {
        IDuplicateDetect sameAddress;
        IDuplicateDetect sameEmail;

        public DuplicateLinqDetector()
        {
            sameAddress = new LinqStrategies.DetectSameAddress();
            sameEmail = new LinqStrategies.DetectSameEmail();
        }

        public List<UserEntity> Detect(List<UserEntity> users)
        {
            List<UserEntity> duplicates = sameAddress.Detect(users);
            duplicates.AddRange(sameEmail.Detect(users));

            return duplicates;
        }
    }
}