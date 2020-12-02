using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfrm_DI_basic.models
{
    class CarNoDepInj
    {
        public string id { get; set; }

        private EngineNoDepInj _engine;

        public CarNoDepInj( string aId )
        {
            id = aId;
            _engine = new EngineNoDepInj( "xyz", 200);

        }

        public void updEngHp( int aiHp )
        {
            _engine.updHp(aiHp);
        }
         
        public string getStrDet()
        {
            return id + " " + "engine " + _engine.getStrDet();
        }
    }
}
