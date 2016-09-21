namespace Calculator
{
    partial class Calculator
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
			this.calcdisplay = new System.Windows.Forms.TextBox();
			this.buttonCE = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.buttonbackspace = new System.Windows.Forms.Button();
			this.buttondivide = new System.Windows.Forms.Button();
			this.buttonmultiply = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.buttonsubtract = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.buttonadd = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonequals = new System.Windows.Forms.Button();
			this.buttondecimal = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.buttonnegative = new System.Windows.Forms.Button();
			this.buttonMC = new System.Windows.Forms.Button();
			this.buttonMR = new System.Windows.Forms.Button();
			this.buttonMP = new System.Windows.Forms.Button();
			this.buttonMM = new System.Windows.Forms.Button();
			this.buttonMS = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// calcdisplay
			// 
			this.calcdisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.calcdisplay.Cursor = System.Windows.Forms.Cursors.Default;
			this.calcdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.calcdisplay.Location = new System.Drawing.Point(13, 12);
			this.calcdisplay.MaxLength = 16;
			this.calcdisplay.Name = "calcdisplay";
			this.calcdisplay.ReadOnly = true;
			this.calcdisplay.Size = new System.Drawing.Size(198, 30);
			this.calcdisplay.TabIndex = 0;
			this.calcdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.calcdisplay.Enter += new System.EventHandler(this.calcdisplay_Enter);
			// 
			// buttonCE
			// 
			this.buttonCE.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCE.Location = new System.Drawing.Point(13, 84);
			this.buttonCE.Name = "buttonCE";
			this.buttonCE.Size = new System.Drawing.Size(45, 45);
			this.buttonCE.TabIndex = 1;
			this.buttonCE.Text = "CE";
			this.buttonCE.UseVisualStyleBackColor = true;
			this.buttonCE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCE_MouseDown);
			this.buttonCE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonCE_MouseUp);
			// 
			// buttonC
			// 
			this.buttonC.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.Location = new System.Drawing.Point(64, 84);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(45, 45);
			this.buttonC.TabIndex = 2;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = true;
			this.buttonC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonC_MouseDown);
			this.buttonC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonC_MouseUp);
			// 
			// buttonbackspace
			// 
			this.buttonbackspace.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonbackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonbackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonbackspace.Location = new System.Drawing.Point(115, 84);
			this.buttonbackspace.Name = "buttonbackspace";
			this.buttonbackspace.Size = new System.Drawing.Size(45, 45);
			this.buttonbackspace.TabIndex = 3;
			this.buttonbackspace.Text = "⌫ ";
			this.buttonbackspace.UseVisualStyleBackColor = true;
			this.buttonbackspace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonbackspace_MouseDown);
			this.buttonbackspace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonbackspace_MouseUp);
			// 
			// buttondivide
			// 
			this.buttondivide.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttondivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttondivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttondivide.Location = new System.Drawing.Point(166, 84);
			this.buttondivide.Name = "buttondivide";
			this.buttondivide.Size = new System.Drawing.Size(45, 45);
			this.buttondivide.TabIndex = 4;
			this.buttondivide.Text = "÷";
			this.buttondivide.UseVisualStyleBackColor = true;
			this.buttondivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttondivide_MouseDown);
			this.buttondivide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttondivide_MouseUp);
			// 
			// buttonmultiply
			// 
			this.buttonmultiply.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonmultiply.Location = new System.Drawing.Point(166, 135);
			this.buttonmultiply.Name = "buttonmultiply";
			this.buttonmultiply.Size = new System.Drawing.Size(45, 45);
			this.buttonmultiply.TabIndex = 5;
			this.buttonmultiply.Text = "×";
			this.buttonmultiply.UseVisualStyleBackColor = true;
			this.buttonmultiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonmultiply_MouseDown);
			this.buttonmultiply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonmultiply_MouseUp);
			// 
			// button9
			// 
			this.button9.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(115, 135);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(45, 45);
			this.button9.TabIndex = 6;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button9_MouseDown);
			this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button9_MouseUp);
			// 
			// button8
			// 
			this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(64, 135);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(45, 45);
			this.button8.TabIndex = 7;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
			this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button8_MouseUp);
			// 
			// button7
			// 
			this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(13, 135);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(45, 45);
			this.button7.TabIndex = 8;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
			this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button7_MouseUp);
			// 
			// buttonsubtract
			// 
			this.buttonsubtract.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonsubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonsubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonsubtract.Location = new System.Drawing.Point(166, 186);
			this.buttonsubtract.Name = "buttonsubtract";
			this.buttonsubtract.Size = new System.Drawing.Size(45, 45);
			this.buttonsubtract.TabIndex = 9;
			this.buttonsubtract.Text = "−";
			this.buttonsubtract.UseVisualStyleBackColor = true;
			this.buttonsubtract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonsubtract_MouseDown);
			this.buttonsubtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonsubtract_MouseUp);
			// 
			// button6
			// 
			this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(115, 186);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(45, 45);
			this.button6.TabIndex = 10;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
			this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
			// 
			// button5
			// 
			this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(64, 186);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(45, 45);
			this.button5.TabIndex = 11;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
			this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
			// 
			// button4
			// 
			this.button4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(13, 186);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(45, 45);
			this.button4.TabIndex = 12;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
			this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
			// 
			// buttonadd
			// 
			this.buttonadd.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonadd.Location = new System.Drawing.Point(166, 237);
			this.buttonadd.Name = "buttonadd";
			this.buttonadd.Size = new System.Drawing.Size(45, 45);
			this.buttonadd.TabIndex = 13;
			this.buttonadd.Text = "+";
			this.buttonadd.UseVisualStyleBackColor = true;
			this.buttonadd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonadd_MouseDown);
			this.buttonadd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonadd_MouseUp);
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(115, 237);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 45);
			this.button3.TabIndex = 14;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
			this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(64, 237);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 45);
			this.button2.TabIndex = 15;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
			this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(13, 237);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 45);
			this.button1.TabIndex = 16;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
			this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
			// 
			// buttonequals
			// 
			this.buttonequals.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonequals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonequals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonequals.Location = new System.Drawing.Point(166, 288);
			this.buttonequals.Name = "buttonequals";
			this.buttonequals.Size = new System.Drawing.Size(45, 45);
			this.buttonequals.TabIndex = 17;
			this.buttonequals.Text = "=";
			this.buttonequals.UseVisualStyleBackColor = true;
			this.buttonequals.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonequals_MouseDown);
			this.buttonequals.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonequals_MouseUp);
			// 
			// buttondecimal
			// 
			this.buttondecimal.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttondecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttondecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttondecimal.Location = new System.Drawing.Point(115, 288);
			this.buttondecimal.Name = "buttondecimal";
			this.buttondecimal.Size = new System.Drawing.Size(45, 45);
			this.buttondecimal.TabIndex = 18;
			this.buttondecimal.Text = ".";
			this.buttondecimal.UseVisualStyleBackColor = true;
			this.buttondecimal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttondecimal_MouseDown);
			this.buttondecimal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttondecimal_MouseUp);
			// 
			// button0
			// 
			this.button0.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button0.Location = new System.Drawing.Point(64, 288);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(45, 45);
			this.button0.TabIndex = 19;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button0_MouseDown);
			this.button0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button0_MouseUp);
			// 
			// buttonnegative
			// 
			this.buttonnegative.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonnegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonnegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonnegative.Location = new System.Drawing.Point(13, 288);
			this.buttonnegative.Name = "buttonnegative";
			this.buttonnegative.Size = new System.Drawing.Size(45, 45);
			this.buttonnegative.TabIndex = 20;
			this.buttonnegative.Text = "±";
			this.buttonnegative.UseVisualStyleBackColor = true;
			this.buttonnegative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonnegative_MouseDown);
			this.buttonnegative.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonnegative_MouseUp);
			// 
			// buttonMC
			// 
			this.buttonMC.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMC.Location = new System.Drawing.Point(13, 51);
			this.buttonMC.Name = "buttonMC";
			this.buttonMC.Size = new System.Drawing.Size(40, 23);
			this.buttonMC.TabIndex = 21;
			this.buttonMC.Text = "MC";
			this.buttonMC.UseVisualStyleBackColor = true;
			this.buttonMC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMC_MouseDown);
			this.buttonMC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMC_MouseUp);
			// 
			// buttonMR
			// 
			this.buttonMR.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMR.Location = new System.Drawing.Point(52, 51);
			this.buttonMR.Name = "buttonMR";
			this.buttonMR.Size = new System.Drawing.Size(41, 23);
			this.buttonMR.TabIndex = 22;
			this.buttonMR.Text = "MR";
			this.buttonMR.UseVisualStyleBackColor = true;
			this.buttonMR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMR_MouseDown);
			this.buttonMR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMR_MouseUp);
			// 
			// buttonMP
			// 
			this.buttonMP.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMP.Location = new System.Drawing.Point(91, 51);
			this.buttonMP.Name = "buttonMP";
			this.buttonMP.Size = new System.Drawing.Size(40, 23);
			this.buttonMP.TabIndex = 23;
			this.buttonMP.Text = "M+";
			this.buttonMP.UseVisualStyleBackColor = true;
			this.buttonMP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMP_MouseDown);
			this.buttonMP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMP_MouseUp);
			// 
			// buttonMM
			// 
			this.buttonMM.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMM.Location = new System.Drawing.Point(130, 51);
			this.buttonMM.Name = "buttonMM";
			this.buttonMM.Size = new System.Drawing.Size(41, 23);
			this.buttonMM.TabIndex = 24;
			this.buttonMM.Text = "M-";
			this.buttonMM.UseVisualStyleBackColor = true;
			this.buttonMM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMM_MouseDown);
			this.buttonMM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMM_MouseUp);
			// 
			// buttonMS
			// 
			this.buttonMS.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMS.Location = new System.Drawing.Point(170, 51);
			this.buttonMS.Name = "buttonMS";
			this.buttonMS.Size = new System.Drawing.Size(41, 23);
			this.buttonMS.TabIndex = 25;
			this.buttonMS.Text = "MS";
			this.buttonMS.UseVisualStyleBackColor = true;
			this.buttonMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMS_MouseDown);
			this.buttonMS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMS_MouseUp);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 345);
			this.Controls.Add(this.buttonMS);
			this.Controls.Add(this.buttonMM);
			this.Controls.Add(this.buttonMP);
			this.Controls.Add(this.buttonMR);
			this.Controls.Add(this.buttonMC);
			this.Controls.Add(this.buttonnegative);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.buttondecimal);
			this.Controls.Add(this.buttonequals);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.buttonadd);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.buttonsubtract);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.buttonmultiply);
			this.Controls.Add(this.buttondivide);
			this.Controls.Add(this.buttonbackspace);
			this.Controls.Add(this.buttonC);
			this.Controls.Add(this.buttonCE);
			this.Controls.Add(this.calcdisplay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Calculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcdisplay;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonbackspace;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.Button buttonmultiply;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonsubtract;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonequals;
        private System.Windows.Forms.Button buttondecimal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonnegative;
		private System.Windows.Forms.Button buttonMC;
		private System.Windows.Forms.Button buttonMR;
		private System.Windows.Forms.Button buttonMP;
		private System.Windows.Forms.Button buttonMM;
		private System.Windows.Forms.Button buttonMS;
	}
}

