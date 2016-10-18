using DuplicatesDetection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesDetection.DuplicateDetectStrategy
{
    public abstract class DuplicateDetector
    {
        virtual public List<UserEntity> Detect(List<UserEntity> users)
        {
            throw new NotImplementedException();
        }
    }
}
