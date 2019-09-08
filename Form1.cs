using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pie
{
    public partial class Form1 : Form
    {
        private double radius;
        private double angle;
        private double arcLength;
        private double square;
        private double chord;
        private const double MAXGRADUS = 360;
        public Form1()
        {
            InitializeComponent();
          
        }


        private void CboxKnowing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[0])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParamThree.Visible = false;
                lblParam1.Text = "Winkel Kuchenstücks α";
                lblParam2.Text = "Schenkellänge r";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxRadiusAngle.Visible = true;
                picBoxAngleAndArcLength.Visible = false;
                picBoxArcLengthAndRadius.Visible = false;
                picBoxArcLengthAndSquare.Visible = false;
                picBoxSecantAndAngle.Visible = false;
                picBoxSecantAndRadius.Visible = false;
                picBoxStart.Visible = false;

            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[1])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParamThree.Visible = false;
                lblParam1.Text = "Kuchenstücks Bogenlänge p";
                lblParam2.Text = "Schenkellänge r";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = true;
                picBoxRadiusAngle.Visible = false;
                picBoxArcLengthAndSquare.Visible = false;
                picBoxSecantAndAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = false;
                picBoxSecantAndRadius.Visible = false;
                picBoxStart.Visible = false;
            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[2])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParamThree.Visible = false;
                lblParam1.Text = "Winkel Kuchenstücks α";
                lblParam2.Text = "Kuchenstücks Bogenlänge p";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = false;
                picBoxRadiusAngle.Visible = false;
                picBoxArcLengthAndSquare.Visible = false;
                picBoxSecantAndAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = true;
                picBoxSecantAndRadius.Visible = false;
                picBoxStart.Visible = false;
            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[3])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParamThree.Visible = false;
                lblParam1.Text = "Flächeninhalt Kuchenstücks S";
                lblParam2.Text = "Kuchenstücks Bogenlänge p";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = false;
                picBoxRadiusAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = false;
                picBoxSecantAndAngle.Visible = false;
                picBoxArcLengthAndSquare.Visible = true;
                picBoxSecantAndRadius.Visible = false;
                picBoxStart.Visible = false;
            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[4])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParamThree.Visible = false;
                lblParam1.Text = "Kuchenstücks Sekantenlänge L";
                lblParam2.Text = "Kuchenstücks Schenkellänge r";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = false;
                picBoxRadiusAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = false;
                picBoxArcLengthAndSquare.Visible = false;
                picBoxSecantAndAngle.Visible = false;
                picBoxSecantAndRadius.Visible = true;
                picBoxStart.Visible = false;
            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[5])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParamThree.Visible = false;
                lblParam1.Text = "Kuchenstücks Sekantenlänge L";
                lblParam2.Text = "Winkel Kuchenstücks α";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = false;
                picBoxRadiusAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = false;
                picBoxArcLengthAndSquare.Visible = false;
                picBoxSecantAndRadius.Visible = false;
                picBoxSecantAndAngle.Visible = true;
                picBoxStart.Visible = false;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (cboxKnowing.SelectedItem != null)
            {
                if (!"".Equals(txtParam1.Text) && !"".Equals(txtParam2.Text) && !"0".Equals(txtParam1.Text) && !"0".Equals(txtParam2.Text))
                {
                    if (cboxKnowing.SelectedItem == cboxKnowing.Items[0])
                    {
                        AngleAndRadius();
                    }
                    if (cboxKnowing.SelectedItem == cboxKnowing.Items[1])
                    { 
                        ArcLengthAndRadius();
                    }
                    if (cboxKnowing.SelectedItem == cboxKnowing.Items[2])
                    {
                        AngleAndArcLength();
                    }
                    if (cboxKnowing.SelectedItem == cboxKnowing.Items[3])
                    {
                        ArcLengthAndSquare();
                    }
                    if (cboxKnowing.SelectedItem == cboxKnowing.Items[4])
                    {
                        SecantAndRadius();
                    }
                    if (cboxKnowing.SelectedItem == cboxKnowing.Items[5])
                    {
                        SecantAndAngle();
                    }
                }
                else
                {
                   MessageBox.Show("Felder müssen Daten enthalten.\nDer Wert in den Feldern darf nicht 0 sein", "Error", MessageBoxButtons.OK);
                }

            }
            else MessageBox.Show("Bitte wählen Sie Bekannte Optionen.", "Error", MessageBoxButtons.OK);
        }

        private void SecantAndAngle()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;

            chord = Convert.ToDouble(txtParam1.Text);
            angle = Convert.ToDouble(txtParam2.Text);

            double b = angle * (Math.PI/MAXGRADUS);
            double c = (b * (Math.PI)) / 180; // converting value to radians
            double d = Math.Sin(c);
            arcLength = chord *(d/c);
            lblSquare.Text = "Kuchenstücks Bogenlänge = " + arcLength.ToString();

            double diametr= arcLength/b;
            radius = diametr / 2;
            lblParamTwo.Text = "Kuchenstücks Schenkellänge = " + radius.ToString();

            DrawChoceOfPie((float)angle);
        }

        //this method processes information based on Secant and Radius
        private void SecantAndRadius()//new method
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            
            chord = Convert.ToDouble(txtParam1.Text);
            radius = Convert.ToDouble(txtParam2.Text);
            double b = chord / (2 * radius);
            double c = (b * (Math.PI)) / 180; // converting value to radians
            double d = Math.Asin(c);
            arcLength = 2*radius*d;
            lblParamTwo.Text = "Kuchenstücks Bogenlänge = " + arcLength.ToString();

            angle = d*(MAXGRADUS/Math.PI);
            lblSquare.Text = "Winkel Kuchenstücks = " + angle.ToString();

            DrawChoceOfPie((float)angle);
        }

        //this method processes information based on Square and ARC Length
        private void ArcLengthAndSquare()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            square = Convert.ToDouble(txtParam1.Text);
            arcLength = Convert.ToDouble(txtParam2.Text);
            radius = square * 2 / arcLength;
            lblParamTwo.Text = "Kuchenstücks Schenkellänge = " + radius.ToString();
            angle = arcLength / radius;
            lblSquare.Text = "Winkel Kuchenstücks = " + angle.ToString();

            DrawChoceOfPie((float)angle);
        }

        //this method processes information based on ANGLE and ARC
        private void AngleAndArcLength()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            lblParamThree.Visible = true;
            angle = Convert.ToDouble(txtParam1.Text);
            arcLength = Convert.ToDouble(txtParam2.Text);
            double b = angle * (Math.PI / MAXGRADUS);
            radius = (arcLength / b)/2;
            lblParamTwo.Text = "Kuchenstücks Schenkellänge = " + radius.ToString();
            square = Math.PI * Math.Pow(radius, 2) * (angle / MAXGRADUS);
            lblSquare.Text = "Flächeninhalt Kuchenstücks = " + square.ToString();
            
            double c = (b * (Math.PI)) / 180; // converting value to radians
            chord = 2 * radius * Math.Sin(c);
            lblParamThree.Text = "Sekantenlänge = " + chord.ToString();

            DrawChoceOfPie((float)angle);
        }

        //this method processes information based on RADIUS and ARC
        private void ArcLengthAndRadius()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            lblParamThree.Visible = true;
            radius = Convert.ToDouble(txtParam1.Text);
            arcLength = Convert.ToDouble(txtParam2.Text);
            square = (radius * arcLength) / 2;
            lblSquare.Text = "Flächeninhalt Kuchenstücks = " + square.ToString();
            angle = arcLength / radius;
            lblParamTwo.Text = "Winkel Kuchenstücks = " + angle.ToString();
            double b = arcLength / (2 * radius);
            double c = (b * (Math.PI)) / 180; // converting value to radians
            chord = 2 * radius * Math.Sin(c);
            lblParamThree.Text = "Sekantenlänge = " + chord.ToString();

            DrawChoceOfPie((float)angle);
        }
        //this method processes information based on ANGLE and RADIUS
        private void AngleAndRadius()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            lblParamThree.Visible = true;
            radius = Convert.ToDouble(txtParam2.Text);
            angle = Convert.ToDouble(txtParam1.Text);
            square = Math.PI * Math.Pow(radius, 2) * (angle / MAXGRADUS);
            lblSquare.Text = "Flächeninhalt Kuchenstücks = " + square.ToString();
            arcLength = (radius * angle*Math.PI)/180;//changed Formula
            lblParamTwo.Text = "Kuchenstücks Bogenlänge = " + arcLength.ToString();
            double b = angle / 2;
            double c = (b * (Math.PI)) / 180; // converting value to radians
            double d = Math.Sin(c);
            chord = 2 * radius * d;//added new Formula for chord
            lblParamThree.Text = "Sekantenlänge = " +chord.ToString();//=====

            DrawChoceOfPie((float)angle);
        }

        //this method is responsible for rendering a piece of cake( „Kuchenstück“ graphisch)
        private void DrawChoceOfPie(float angle)
        {
            const int margin = 10;
            const int width = 150;
            Graphics gr = picBoxPie.CreateGraphics();
            gr.Clear(Color.White);
            Pen outline_pen = Pens.Red;
            Brush fill_brush = Brushes.LightGreen;
            lblIhreKuchenstücks.Visible = true;
            using (Pen ellipse_pen = new Pen(Color.Blue))
            {
                ellipse_pen.DashPattern = new float[] { 5, 5 };

                Rectangle rect = new Rectangle(margin + 30, 10, width, width);
                gr.DrawEllipse(ellipse_pen, rect);
                gr.FillPie(fill_brush, rect, 300, angle);
                gr.DrawPie(outline_pen, rect, 300, angle);
                
            }
            
        }
        //regex to field txtParam1
        private void TxtParam1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtParam1.Text, "[^0-9-,]"))
            {
                txtParam1.Text = txtParam1.Text.Remove(txtParam1.Text.Length - 1);
                txtParam1.SelectionStart = txtParam1.TextLength;
            }
        }
        //regex to field txtParam2
        private void TxtParam2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtParam2.Text, "[^0-9-,]"))
            {
                txtParam2.Text = txtParam2.Text.Remove(txtParam2.Text.Length - 1);
                txtParam2.SelectionStart = txtParam2.TextLength;
            }
        }
    }
}
