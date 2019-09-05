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
            this.picBoxPie = new System.Windows.Forms.PictureBox();
            this.picBoxArcLengthAndSquare = new System.Windows.Forms.PictureBox();
            this.lblIhreKuchenstücks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAngleAndArcLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArcLengthAndRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRadiusAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArcLengthAndSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wählen Sie Bekannte Optionen";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Location = new System.Drawing.Point(180, 75);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(86, 65);
            this.lblParam1.TabIndex = 1;
            this.lblParam1.Text = "r - Radius\r\na - Winkel\r\nL - Sekante\r\np - Bogen\r\nS - Flächeninhalt\r\n";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.Location = new System.Drawing.Point(180, 105);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(35, 13);
            this.lblParam2.TabIndex = 2;
            this.lblParam2.Text = "label3";
            this.lblParam2.Visible = false;
            // 
            // txtParam1
            // 
            this.txtParam1.Location = new System.Drawing.Point(388, 72);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(100, 20);
            this.txtParam1.TabIndex = 3;
            this.txtParam1.Visible = false;
            this.txtParam1.TextChanged += new System.EventHandler(this.TxtParam1_TextChanged);
            // 
            // txtParam2
            // 
            this.txtParam2.Location = new System.Drawing.Point(388, 105);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(100, 20);
            this.txtParam2.TabIndex = 4;
            this.txtParam2.Visible = false;
            this.txtParam2.TextChanged += new System.EventHandler(this.TxtParam2_TextChanged);
            // 
            // lblSquare
            // 
            this.lblSquare.AutoSize = true;
            this.lblSquare.Location = new System.Drawing.Point(183, 152);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(35, 13);
            this.lblSquare.TabIndex = 5;
            this.lblSquare.Text = "label4";
            this.lblSquare.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(57, 191);
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
            "Radius und Winkel",
            "Bogenlänge und Radius",
            "Winkel und Bogenlänge",
            "Bogenlänge und Flächeninhalt"});
            this.cboxKnowing.Location = new System.Drawing.Point(350, 7);
            this.cboxKnowing.Name = "cboxKnowing";
            this.cboxKnowing.Size = new System.Drawing.Size(138, 21);
            this.cboxKnowing.TabIndex = 8;
            this.cboxKnowing.SelectedIndexChanged += new System.EventHandler(this.CboxKnowing_SelectedIndexChanged);
            // 
            // picBoxAngleAndArcLength
            // 
            this.picBoxAngleAndArcLength.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAngleAndArcLength.Image")));
            this.picBoxAngleAndArcLength.Location = new System.Drawing.Point(-1, 40);
            this.picBoxAngleAndArcLength.Name = "picBoxAngleAndArcLength";
            this.picBoxAngleAndArcLength.Size = new System.Drawing.Size(157, 145);
            this.picBoxAngleAndArcLength.TabIndex = 9;
            this.picBoxAngleAndArcLength.TabStop = false;
            this.picBoxAngleAndArcLength.Visible = false;
            // 
            // picBoxStart
            // 
            this.picBoxStart.Image = ((System.Drawing.Image)(resources.GetObject("picBoxStart.Image")));
            this.picBoxStart.Location = new System.Drawing.Point(-1, 40);
            this.picBoxStart.Name = "picBoxStart";
            this.picBoxStart.Size = new System.Drawing.Size(157, 145);
            this.picBoxStart.TabIndex = 10;
            this.picBoxStart.TabStop = false;
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Location = new System.Drawing.Point(180, 52);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(76, 13);
            this.lblProperties.TabIndex = 11;
            this.lblProperties.Text = "PROPERTIES";
            // 
            // picBoxArcLengthAndRadius
            // 
            this.picBoxArcLengthAndRadius.Image = ((System.Drawing.Image)(resources.GetObject("picBoxArcLengthAndRadius.Image")));
            this.picBoxArcLengthAndRadius.Location = new System.Drawing.Point(-1, 40);
            this.picBoxArcLengthAndRadius.Name = "picBoxArcLengthAndRadius";
            this.picBoxArcLengthAndRadius.Size = new System.Drawing.Size(157, 145);
            this.picBoxArcLengthAndRadius.TabIndex = 12;
            this.picBoxArcLengthAndRadius.TabStop = false;
            this.picBoxArcLengthAndRadius.Visible = false;
            // 
            // lblParamTwo
            // 
            this.lblParamTwo.AutoSize = true;
            this.lblParamTwo.Location = new System.Drawing.Point(183, 171);
            this.lblParamTwo.Name = "lblParamTwo";
            this.lblParamTwo.Size = new System.Drawing.Size(35, 13);
            this.lblParamTwo.TabIndex = 13;
            this.lblParamTwo.Text = "label2";
            this.lblParamTwo.Visible = false;
            // 
            // picBoxRadiusAngle
            // 
            this.picBoxRadiusAngle.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRadiusAngle.Image")));
            this.picBoxRadiusAngle.Location = new System.Drawing.Point(-1, 40);
            this.picBoxRadiusAngle.Name = "picBoxRadiusAngle";
            this.picBoxRadiusAngle.Size = new System.Drawing.Size(157, 145);
            this.picBoxRadiusAngle.TabIndex = 14;
            this.picBoxRadiusAngle.TabStop = false;
            this.picBoxRadiusAngle.Visible = false;
            // 
            // picBoxPie
            // 
            this.picBoxPie.Location = new System.Drawing.Point(128, 220);
            this.picBoxPie.Name = "picBoxPie";
            this.picBoxPie.Size = new System.Drawing.Size(200, 200);
            this.picBoxPie.TabIndex = 17;
            this.picBoxPie.TabStop = false;
            // 
            // picBoxArcLengthAndSquare
            // 
            this.picBoxArcLengthAndSquare.Image = ((System.Drawing.Image)(resources.GetObject("picBoxArcLengthAndSquare.Image")));
            this.picBoxArcLengthAndSquare.Location = new System.Drawing.Point(-1, 40);
            this.picBoxArcLengthAndSquare.Name = "picBoxArcLengthAndSquare";
            this.picBoxArcLengthAndSquare.Size = new System.Drawing.Size(157, 145);
            this.picBoxArcLengthAndSquare.TabIndex = 18;
            this.picBoxArcLengthAndSquare.TabStop = false;
            this.picBoxArcLengthAndSquare.Visible = false;
            // 
            // lblIhreKuchenstücks
            // 
            this.lblIhreKuchenstücks.AutoSize = true;
            this.lblIhreKuchenstücks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIhreKuchenstücks.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIhreKuchenstücks.Location = new System.Drawing.Point(350, 237);
            this.lblIhreKuchenstücks.Name = "lblIhreKuchenstücks";
            this.lblIhreKuchenstücks.Size = new System.Drawing.Size(132, 16);
            this.lblIhreKuchenstücks.TabIndex = 19;
            this.lblIhreKuchenstücks.Text = "Ihre Kuchenstücks";
            this.lblIhreKuchenstücks.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 432);
            this.Controls.Add(this.lblIhreKuchenstücks);
            this.Controls.Add(this.picBoxArcLengthAndSquare);
            this.Controls.Add(this.picBoxPie);
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
            this.MaximumSize = new System.Drawing.Size(530, 470);
            this.MinimumSize = new System.Drawing.Size(530, 470);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Berechnung eines Kuchenstücks (Kreisausschnitt)";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAngleAndArcLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArcLengthAndRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRadiusAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArcLengthAndSquare)).EndInit();
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
        private System.Windows.Forms.PictureBox picBoxPie;
        private System.Windows.Forms.PictureBox picBoxArcLengthAndSquare;
        private System.Windows.Forms.Label lblIhreKuchenstücks;
    }
}

