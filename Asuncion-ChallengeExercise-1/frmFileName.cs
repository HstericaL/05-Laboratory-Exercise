using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuncion_ChallengeExercise_1
{
    public partial class frmFileName : Form
    {
        public frmFileName()
        {
            InitializeComponent();
        }

        public static string SetFileName;
        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            Close();
        }
    }
}
