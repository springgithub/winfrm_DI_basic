using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfrm_DI_basic.models
{
    class Engine : IEngine
    {
        public string id { get; set; }
        public int hp { get; set; }
        public Engine( string aStrId )
        {
            id = aStrId;
        }
        public void updHp(int aiHp)
        {
            hp = aiHp;
        }
        public string GetStrDet()
        {
            return id + " hp =" + hp;
        }
    }
}
