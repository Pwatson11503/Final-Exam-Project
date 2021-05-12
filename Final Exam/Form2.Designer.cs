namespace Final_Exam
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLife = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.lblHelloWorld = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLife
			// 
			this.btnLife.Location = new System.Drawing.Point(30, 115);
			this.btnLife.Name = "btnLife";
			this.btnLife.Size = new System.Drawing.Size(101, 27);
			this.btnLife.TabIndex = 0;
			this.btnLife.Text = "Make a New Life";
			this.btnLife.UseVisualStyleBackColor = true;
			this.btnLife.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// lblHelloWorld
			// 
			this.lblHelloWorld.AutoSize = true;
			this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHelloWorld.Location = new System.Drawing.Point(12, 9);
			this.lblHelloWorld.Name = "lblHelloWorld";
			this.lblHelloWorld.Size = new System.Drawing.Size(0, 25);
			this.lblHelloWorld.TabIndex = 1;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(166, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(412, 446);
			this.listBox1.TabIndex = 2;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(30, 89);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(100, 20);
			this.txtFirstName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter your first name!";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(30, 174);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear this Life!";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(30, 219);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(100, 23);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 482);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.lblHelloWorld);
			this.Controls.Add(this.btnLife);
			this.Name = "Form2";
			this.Text = "Life Simulator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLife;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		public System.Windows.Forms.Label lblHelloWorld;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		public System.Windows.Forms.ListBox listBox1;
	}
}