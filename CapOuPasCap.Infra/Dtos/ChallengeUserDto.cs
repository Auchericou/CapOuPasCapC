using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapOuPasCap.Infra.Dtos
{
    public class ChallengeUserDto
    {

        public UserDto User { get; set; }

        public int UserID { get; set; }

        public ChallengeDto Challenge { get; set; }

        public int ChallengeID  { get; set; }



    }
}
