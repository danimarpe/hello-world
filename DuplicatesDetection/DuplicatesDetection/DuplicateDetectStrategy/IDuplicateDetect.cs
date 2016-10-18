using System.Collections.Generic;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy
{
    /// <summary>
    /// Main Strategy
    /// </summary>
    interface IDuplicateDetect
    {
        List<UserEntity> Detect(List<UserEntity> orders);
    }
}
