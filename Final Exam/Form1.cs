using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Make sure to add this!

namespace Final_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void btnStart_Click(object sender, EventArgs e)
		{
			LetsGoForm2();
		}

		private void LetsGoForm2()
		{
			Form2 mySecondForm = new Form2();
			mySecondForm.lblHelloWorld.Text = "Hello World";
			mySecondForm.ShowDialog();
			this.Close();
		}


		/*A. If you are going to use more than one line of code to do something.  It needs to be a method.
		B. Nothing should show an error when it is clicked unless it is a planned error.
		C. I want no errors on the error log when I open visual studio.
		*/
	}
}
