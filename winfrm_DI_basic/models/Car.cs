using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfrm_DI_basic.models
{
    class Car
    {
        private IEngine _engine;

        public string id { get; set; }
        public Car( string aId, string aStrIdEng, int aiEngHp )
        {
            id = aId;
            _engine = new Engine( aStrIdEng, aiEngHp );
        }
        
        public void UpdEngHp( int aiHp )
        {
            _engine.UpdHp(aiHp);
        }

        public string GetStrDet()
        {
            return id + " " + "engine " + _engine.GetStrDet();
        }
    }
}
