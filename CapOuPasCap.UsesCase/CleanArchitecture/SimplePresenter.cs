using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapOuPasCap.UsesCase.CleanArchitecture
{
    public class SimplePresenter<Tin> : IPresenter<Tin, Tin>
    {
        private Tin _Data;

        public Tin GetData()
        {
            return _Data;
        }

        public void Present(Tin data)
        {
            this._Data = data;
        }
    }
}
