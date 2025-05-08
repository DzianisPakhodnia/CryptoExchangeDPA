using CryptoExchangeDPA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchangeDPA.Domain.Entities
{
    public class User : Entity<Guid>
    {
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string UserName { get; private set; }

        public DateTime RegisteredAt { get; private set; }
        
    }

}
