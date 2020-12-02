using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfrm_DI_basic.models
{
    class EngineNoDepInj
    {
        public string id { get; set; }
        public int hp { get; set; }
        public EngineNoDepInj( string id, int hp)
        {
            this.id = id;
            this.hp = hp;
        }
        public string getStrDet()
        {
            return id + " hp =" + hp;
        }
        public void updHp( int aiHp )
        {
            hp = aiHp;
        }
    }
}
