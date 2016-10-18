using System.Collections.Generic;
using System.Linq;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy.LinqStrategies
{
    class DetectSameEmail : IDuplicateDetect
    {
        public List<UserEntity> Detect(List<UserEntity> orders)
        {
            /**NOTE: Separated in lines for easy debug **/
            var groupedUsers = orders.GroupBy(o => new { o.Credit_Card, o.UserName, o.Email });
            var firsts = groupedUsers.Select(o => o.First());
            var groupedByEmail = firsts.GroupBy(o => new { o.UserName, o.Email });
            var duplicates = groupedByEmail.Where(g => g.Count() > 1).SelectMany(g => g.ToList());

            return duplicates.ToList();
        }
    }
}
