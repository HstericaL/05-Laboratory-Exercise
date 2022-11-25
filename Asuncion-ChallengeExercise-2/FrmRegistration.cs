using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asuncion_ChallengeExercise_2
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //VARIABLE GET INPUT
            string getInput = "Student No.: " + txtStudNo.Text + "\n" +
                                "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text + "\n" +
                                "Program: " + cbProgram.Text + "\n" +
                                "Gender: " + cbGender.Text + "\n" +
                                "Birhday: " + dBirthday.Text + "\n" +
                                "Contact No." + txtContact.Text;

            //DOCUMENT PATH
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,"sample.txt")))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
