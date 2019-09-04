namespace Pie
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.lblParam2 = new System.Windows.Forms.Label();
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.lblSquare = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cboxKnowing = new System.Windows.Forms.ComboBox();
            this.picBoxAngleAndArcLength = new System.Windows.Forms.PictureBox();
            this.picBoxStart = new System.Windows.Forms.PictureBox();
            this.lblProperties = new System.Windows.Forms.Label();
            this.picBoxArcLengthAndRadius = new System.Windows.Forms.PictureBox();
            this.lblParamTwo = new System.Windows.Forms.Label();
            this.picBoxRadiusAngle = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblParamThree = new System.Windows.Forms.Label();
            this.picBoxPie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAngleAndArcLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArcLengthAndRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRadiusAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wählen Sie Bekannte Optionen";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Location = new System.Drawing.Point(219, 80);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(55, 65);
            this.lblParam1.TabIndex = 1;
            this.lblParam1.Text = "r - radius\r\na - angle\r\nL - chord\r\np - arc\r\nS - square\r\n";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.Location = new System.Drawing.Point(219, 110);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(35, 13);
            this.lblParam2.TabIndex = 2;
            this.lblParam2.Text = "label3";
            this.lblParam2.Visible = false;
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(427, 77);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(100, 20);
            this.txtParam1.TabIndex = 3;
            this.txtParam1.Visible = false;
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(427, 110);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(100, 20);
            this.txtParam2.TabIndex = 4;
            this.txtParam2.Visible = false;
            // 
            // lblSquare
            // 
            this.lblSquare.AutoSize = true;
            this.lblSquare.Location = new System.Drawing.Point(222, 157);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(35, 13);
            this.lblSquare.TabIndex = 5;
            this.lblSquare.Text = "label4";
            this.lblSquare.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 196);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // cboxKnowing
            // 
            this.cboxKnowing.FormattingEnabled = true;
            this.cboxKnowing.Items.AddRange(new object[] {
            "Radius and angel",
            "Arc length and radius",
            "Angle and arc length",
            "Bogenlänge und Flächeninhalt"});
            this.cboxKnowing.Location = new System.Drawing.Point(389, 12);
            this.cboxKnowing.Name = "cboxKnowing";
            this.cboxKnowing.Size = new System.Drawing.Size(138, 21);
            this.cboxKnowing.TabIndex = 8;
            this.cboxKnowing.SelectedIndexChanged += new System.EventHandler(this.CboxKnowing_SelectedIndexChanged);
            // 
            // picBoxAngleAndArcLength
            // 
            this.picBoxAngleAndArcLength.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAngleAndArcLength.Image")));
            this.picBoxAngleAndArcLength.Location = new System.Drawing.Point(38, 45);
            this.picBoxAngleAndArcLength.Name = "picBoxAngleAndArcLength";
            this.picBoxAngleAndArcLength.Size = new System.Drawing.Size(157, 145);
            this.picBoxAngleAndArcLength.TabIndex = 9;
            this.picBoxAngleAndArcLength.TabStop = false;
            this.picBoxAngleAndArcLength.Visible = false;
            // 
            // picBoxStart
            // 
            this.picBoxStart.Image = ((System.Drawing.Image)(resources.GetObject("picBoxStart.Image")));
            this.picBoxStart.Location = new System.Drawing.Point(38, 45);
            this.picBoxStart.Name = "picBoxStart";
            this.picBoxStart.Size = new System.Drawing.Size(157, 145);
            this.picBoxStart.TabIndex = 10;
            this.picBoxStart.TabStop = false;
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Location = new System.Drawing.Point(219, 57);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(76, 13);
            this.lblProperties.TabIndex = 11;
            this.lblProperties.Text = "PROPERTIES";
            // 
            // picBoxArcLengthAndRadius
            // 
            this.picBoxArcLengthAndRadius.Image = ((System.Drawing.Image)(resources.GetObject("picBoxArcLengthAndRadius.Image")));
            this.picBoxArcLengthAndRadius.Location = new System.Drawing.Point(38, 45);
            this.picBoxArcLengthAndRadius.Name = "picBoxArcLengthAndRadius";
            this.picBoxArcLengthAndRadius.Size = new System.Drawing.Size(157, 145);
            this.picBoxArcLengthAndRadius.TabIndex = 12;
            this.picBoxArcLengthAndRadius.TabStop = false;
            this.picBoxArcLengthAndRadius.Visible = false;
            // 
            // lblParamTwo
            // 
            this.lblParamTwo.AutoSize = true;
            this.lblParamTwo.Location = new System.Drawing.Point(222, 176);
            this.lblParamTwo.Name = "lblParamTwo";
            this.lblParamTwo.Size = new System.Drawing.Size(35, 13);
            this.lblParamTwo.TabIndex = 13;
            this.lblParamTwo.Text = "label2";
            this.lblParamTwo.Visible = false;
            // 
            // picBoxRadiusAngle
            // 
            this.picBoxRadiusAngle.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRadiusAngle.Image")));
            this.picBoxRadiusAngle.Location = new System.Drawing.Point(38, 45);
            this.picBoxRadiusAngle.Name = "picBoxRadiusAngle";
            this.picBoxRadiusAngle.Size = new System.Drawing.Size(157, 145);
            this.picBoxRadiusAngle.TabIndex = 14;
            this.picBoxRadiusAngle.TabStop = false;
            this.picBoxRadiusAngle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // lblParamThree
            // 
            this.lblParamThree.AutoSize = true;
            this.lblParamThree.Location = new System.Drawing.Point(222, 196);
            this.lblParamThree.Name = "lblParamThree";
            this.lblParamThree.Size = new System.Drawing.Size(35, 13);
            this.lblParamThree.TabIndex = 16;
            this.lblParamThree.Text = "label3";
            this.lblParamThree.Visible = false;
            // 
            // picBoxPie
            // 
            this.picBoxPie.Location = new System.Drawing.Point(183, 225);
            this.picBoxPie.Name = "picBoxPie";
            this.picBoxPie.Size = new System.Drawing.Size(200, 200);
            this.picBoxPie.TabIndex = 17;
            this.picBoxPie.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 437);
            this.Controls.Add(this.picBoxPie);
            this.Controls.Add(this.lblParamThree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxRadiusAngle);
            this.Controls.Add(this.lblParamTwo);
            this.Controls.Add(this.picBoxArcLengthAndRadius);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.picBoxStart);
            this.Controls.Add(this.picBoxAngleAndArcLength);
            this.Controls.Add(this.cboxKnowing);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSquare);
            this.Controls.Add(this.txtParam2);
            this.Controls.Add(this.txtParam1);
            this.Controls.Add(this.lblParam2);
            this.Controls.Add(this.lblParam1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAngleAndArcLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArcLengthAndRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRadiusAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParam1;
        private System.Windows.Forms.Label lblParam2;
        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.Label lblSquare;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cboxKnowing;
        private System.Windows.Forms.PictureBox picBoxAngleAndArcLength;
        private System.Windows.Forms.PictureBox picBoxStart;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.PictureBox picBoxArcLengthAndRadius;
        private System.Windows.Forms.Label lblParamTwo;
        private System.Windows.Forms.PictureBox picBoxRadiusAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblParamThree;
        private System.Windows.Forms.PictureBox picBoxPie;
    }
}

