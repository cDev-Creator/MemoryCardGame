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
    public partial class hardestLvl : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "b","b", "E","E", "!", "!", "k", "k","G", "G","O","O","Y","Y","j","j","z","z",
            "m", "m", "w", "w", "X", "X", "p", "p", "T","T","U","U","K","K","N","N","t","t"
        };

        Label firstClick, secondClick;
        public hardestLvl()
        {
            InitializeComponent();
            AssignIcons();
        }
        private void hardestLvl_Load(object sender, EventArgs e){}

        private void u_Click(object sender, EventArgs e){}

       
       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int clickCount = 0;

    private void label_click(object sender, EventArgs e)
    {
            clickCount++;
            if (clickCount > 5)
                if (firstClick != null && secondClick != null)
                    return;

            Label clickedLabel = sender as Label;

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black)
                return;

            if (firstClick == null)
            {
                firstClick = clickedLabel;
                firstClick.ForeColor = Color.Black;
                return;
            }

            secondClick = clickedLabel;
            secondClick.ForeColor = Color.Black;

            WinCheck();
           if (clickCount > 80) { 
            
              String attempts = clickCount.ToString();
              MessageBox.Show("You lost. It took you " + attempts + " attempts. Better luck next Time.");
              Close();
            }

            if (firstClick.Text == secondClick.Text)
            {
                firstClick = null;
                secondClick = null;
            }
            else
                timer1.Start();
        }

        private void WinCheck()
        {
            Label label;
            for (int s = 0; s < tableLayoutPanel1.Controls.Count; s++)
            {
                label = tableLayoutPanel1.Controls[s] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            String attempts = clickCount.ToString();
            MessageBox.Show("You found all of the matches in " + attempts + " guesses! Congrats!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClick.ForeColor = firstClick.BackColor;
            secondClick.ForeColor = secondClick.BackColor;

            firstClick = null;
            secondClick = null;
        }

        private void AssignIcons()
        {
            Label label;
            int randNum;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
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
