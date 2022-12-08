using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Card_Game_NGM
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hardLvl = new hardLvl();
            hardLvl.Closed += (s, args) => this.Close();
            hardLvl.Show();
        }

        private void harderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var harderLvl = new harderLvl();
            harderLvl.Closed += (s, args) => this.Close();
            harderLvl.Show();
        }

        private void hardestBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hardestLvl = new hardestLvl();
            hardestLvl.Closed += (s, args) => this.Close();
            hardestLvl.Show();
        }
    }
}
