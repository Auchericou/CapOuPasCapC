using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapOuPasCap.Infra.Dtos
{
    public class ChallengeDto
    {
        public UserDto User { get; set; }

        public int UserId { get; set; }

        public int Id { get; set; }

        public bool Masked { get; set; }

        public string Description { get; set; }


    }
}
