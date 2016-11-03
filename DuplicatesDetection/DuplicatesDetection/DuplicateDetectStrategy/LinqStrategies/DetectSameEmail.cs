using System.Collections.Generic;
using System.Linq;
using DuplicatesDetection.Entities;

namespace DuplicatesDetection.DuplicateDetectStrategy.LinqStrategies
{
    class DetectSameEmail : IDuplicateDetect
    {
        public List<UserEntity> Detect(List<UserEntity> users)
        {
            /**NOTE: Separated in lines for easy debug **/
            var groupedUsers = users.GroupBy(u => new { u.Credit_Card,u.UserName, u.Email });
            var groupedByEmail = groupedUsers.GroupBy(g => new { g.Key.UserName, g.Key.Email });
            var duplicateGroups = groupedByEmail.Where(g => g.Count() > 1);
            var duplicateUsers = duplicateGroups.SelectMany(g => g.SelectMany(sg => sg.ToList()));

            return duplicateUsers.ToList();
        }
    }
}
