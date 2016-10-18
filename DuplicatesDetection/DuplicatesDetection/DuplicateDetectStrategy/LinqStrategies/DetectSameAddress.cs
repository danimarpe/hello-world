using System.Collections.Generic;
using System.Linq;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy.LinqStrategies
{
    class DetectSameAddress : IDuplicateDetect
    {
        public List<UserEntity> Detect(List<UserEntity> users)
        {
            /**NOTE: Separated in lines for easy debug **/
            var groupedUsers = users.GroupBy(o => new { o.Credit_Card, o.UserName, o.Address });
            var firsts = groupedUsers.Select(o => o.First());
            var groupedByAddress = firsts.GroupBy(o => new { o.UserName, o.Address });
            var duplicates = groupedByAddress.Where(g => g.Count() > 1).SelectMany(g => g.ToList());

            return duplicates.ToList();
        }
    }
}
