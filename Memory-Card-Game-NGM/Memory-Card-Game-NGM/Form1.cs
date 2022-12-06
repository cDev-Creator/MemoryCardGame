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
    public partial class Form1 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "b","b", "E","E", "!", "!", "k", "k",
            "m", "m", "w", "w", "X", "X", "p", "p"
        };

        Label firstClick, secondClick;


        public Form1()
        {
            InitializeComponent();
            AssignIcons();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AssignIcons()
        {
            Label label;
            int randNum;

            for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randNum = random.Next(0, icons.Count);
                label.Text = icons[randNum];

                icons.RemoveAt(randNum);
            }
        }
    }

}
