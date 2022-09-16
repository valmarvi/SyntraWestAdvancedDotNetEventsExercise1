using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntraWestAdvancedDotNetEventsExercise1
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            GameButtonClick(((Button)sender));
        }
        private void Button_MouseHover(object sender, EventArgs e)
        {
            ChangeGameButtonColor(((Button)sender));
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is Button && ((Button)control).Text != "Reset")
                {
                    ((Button)control).Text = "";
                    ((Button)control).BackColor = default(Color);
                    ((Button)control).Enabled = true;
                }
            }
        }
        private void GameButtonClick(Button button)
        {
            if (button.Text == "")
            {
                button.Text = "O";
            }
            else
            {
                button.Text = "X";
                button.Enabled = false;
            }
        }
        private void ChangeGameButtonColor(Button button)
        {
            button.BackColor = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
        }
    }
}
