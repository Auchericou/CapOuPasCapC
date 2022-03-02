using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapOuPasCap.Infra.Dtos
{
    public class UserDto
    {

        public ICollection<UserDto> Users { get; set; } = new HashSet<UserDto>();

        public int Id { get; set; }

        public string username { get; set; }

        public string password { get; set; }   
    }
}
