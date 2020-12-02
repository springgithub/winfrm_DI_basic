using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfrm_DI_basic.models
{
    interface IEngine
    {
        void updHp(int aiHp);
        string GetStrDet();
    }
}
