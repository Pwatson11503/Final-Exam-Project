//Coder Preston Watson
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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		/*I've created a program that simulates an honestly pretty bad life by 
		 running through a forloop and writing each line for what happened that year*/

		string name;

		private void btnGo_Click(object sender, EventArgs e)
		{
			LifeCreate();
			StartLife();
		}

		private void LifeCreate()
		{
			listBox1.Items.Clear();
			Life newLife = new Life();
			name = txtFirstName.Text;
			newLife.CreateName(name);
		}
		
		private void StartLife()
		{
			Random rand = new Random();
			int randomNumber;

			for (int cases = 1; cases <= 98; cases++)
			{
				int age = cases;
				randomNumber = rand.Next((9000 / 1000));
				//MessageBox.Show(randomNumber.ToString());
				if (randomNumber == 0)
				{
					string case0 = " and has had their computer blue screen.";
					listBox1.Items.Add(name + " is " + age + " years old" + case0);
				}
				if (randomNumber == 1)
				{
					string case1 = " and has Typhoid, shouldn't have crossed the river.";
					listBox1.Items.Add(name + " is " + age + " years old" + case1);
				}
				if (randomNumber == 2)
				{
					string case2 = " and has a new form of malware! Hooray!";
					listBox1.Items.Add(name + " is " + age + " years old" + case2);
				}
				if (randomNumber == 3)
				{
					string case3 = " and has received a Steam Gift! Oh no it's Bad Rats!";
					listBox1.Items.Add(name + " is " + age + " years old" + case3);
				}
				if (randomNumber == 4)
				{
					string case4 = " and has had their bank account hacked. :(";
					listBox1.Items.Add(name + " is " + age + " years old" + case4);
				}
				if (randomNumber == 5)
				{
					string case5 = " and has received a Steam Gift! Oh my, Elite Dangerous!";
					listBox1.Items.Add(name + " is " + age + " years old" + case5);
				}
				if (randomNumber == 6)
				{
					string case6 = " and has earned a 100 on their final exam!";
					listBox1.Items.Add(name + " is " + age + " years old" + case6);
				}
				if (randomNumber == 7)
				{
					string case7 = " and has filed bankruptcy! :(";
					listBox1.Items.Add(name + " is " + age + " years old" + case7);
				}
				if (randomNumber == 8)
				{
					string case8 = " and has died. Probably from that Typhoid you got, or Bad Rats.";
					listBox1.Items.Add(name + " is " + age + " years old" + case8);
					return;
				}
			}
		}

		private void ClearItAll()
		{
			txtFirstName.Text = "";
			listBox1.Items.Clear();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearItAll();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			CloseItAll();
		}
		private void CloseItAll()
		{
			MessageBox.Show("Have a good life!");
			this.Close();
		}
	}
}
