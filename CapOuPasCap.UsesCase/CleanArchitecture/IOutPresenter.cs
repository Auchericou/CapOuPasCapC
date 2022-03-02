using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapOuPasCap.UsesCase.CleanArchitecture
{
    public interface IOutPresenter<out Tout>
    {
        public Tout GetData();
    }
}
