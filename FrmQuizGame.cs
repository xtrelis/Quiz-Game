using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class FrmQuizGame : Form
    {
        public FrmQuizGame()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FrmPlay newFormPlay = new FrmPlay();
            newFormPlay.Show();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            FrmInfo newFormInfo = new FrmInfo();
            newFormInfo.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
