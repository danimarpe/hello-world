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
            var groupedUsers = users.GroupBy(u => new { u.Credit_Card, u.UserName, u.Address });
            var groupedByAddress = groupedUsers.GroupBy(g => new { g.Key.UserName, g.Key.Address });
            var duplicateGroups = groupedByAddress.Where(g => g.Count() > 1);
            var duplicateUsers = duplicateGroups.SelectMany(g => g.SelectMany(sg => sg.ToList()));

            return duplicateUsers.ToList();
        }
    }
}
