using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesDetection.Entities
{
    public class UserEntity
    {
        public int Order_ID { get; set; }
        public int Deal_ID { get; set; }
        public string Email { get; set; }
        public string Credit_Card { get; set; }
        public AddressEntity Address { get; set; }
    }
}
