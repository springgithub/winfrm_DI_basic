using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winfrm_DI_basic.models;


//  https://www.claudiobernasconi.ch/2019/01/24/the-ultimate-list-of-net-dependency-injection-frameworks/
//  https://www.youtube.com/watch?v=fvPPlY31glk&ab_channel=ClaudioBernasconi

namespace winfrm_DI_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarNoDepInj car = new CarNoDepInj( "Camry");

            tbxMsg.AppendText("hhhhh" + Environment.NewLine );
            tbxMsg.AppendText( car.GetStrDet() + Environment.NewLine );

            car.UpdEngHp(300);
            tbxMsg.AppendText(car.GetStrDet() + Environment.NewLine);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDepInj_Click(object sender, EventArgs e)
        {
            Car car = new Car( "350Z", "nisseng", 349 );
            tbxMsg.AppendText(car.GetStrDet() + Environment.NewLine);
            car.UpdEngHp(1370);
            tbxMsg.AppendText(car.GetStrDet() + Environment.NewLine);

            tbxMsg.AppendText(Environment.NewLine);

            Boat boat = new Boat("SeagulPlus", "Envirude", 120);
            tbxMsg.AppendText(boat.GetStrDet() + Environment.NewLine);
            boat.UpdEngHp(240);
            tbxMsg.AppendText(boat.GetStrDet() + Environment.NewLine);



        }
    }
}
