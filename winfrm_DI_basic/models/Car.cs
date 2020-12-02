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
        public Car( string aId, string aStrIdEng )
        {
            id = aId;
            _engine = new Engine( aStrIdEng );
        }
        
        public void UpdEngHp( int aiHp )
        {
            _engine.updHp(aiHp);
        }

        public string getStrDet()
        {
            return id + " " + "engine " + _engine.GetStrDet();
        }
    }
}
