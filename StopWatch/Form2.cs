using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form2 : Form
    {
        public Form2(List<ScoresModel> topScores)
        {
            InitializeComponent();
            int number = 1;
            label1.Text = "";
            foreach (var item in topScores)
            {
                label1.Text += number.ToString() + ": " + item.Name + " " + item.Score + "\n";
                number++;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
