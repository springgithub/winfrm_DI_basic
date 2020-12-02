using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfrm_DI_basic.models
{
    class Boat
    {

        private IEngine _engine;
        public string id { get; set; }
        public Boat( string aId, string aStrEng, int aiEngHp )
        {
            id = aId;
            _engine = new Engine(aStrEng, aiEngHp);
        }
        public string GetStrDet()
        {
            return id + " " + _engine.GetStrDet();
        }

        public void UpdEngHp( int aiEngHp )
        {
            _engine.UpdHp(aiEngHp);
        }
    }
}
