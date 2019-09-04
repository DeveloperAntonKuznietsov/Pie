﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                picBoxRadiusAngle.Visible = true;
                picBoxAngleAndArcLength.Visible = false;
                picBoxArcLengthAndRadius.Visible = false;
                picBoxStart.Visible = false;

                lblParam1.Text = "Winkel Kuchenstücks α";
                lblParam2.Text = "Schenkellänge r";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;
            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[1])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParam1.Text = "Kuchenstücks Bogenlänge p";
                lblParam2.Text = "Schenkellänge r";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = true;
                picBoxRadiusAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = false;
                picBoxStart.Visible = false;
            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[2])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParam1.Text = "Winkel Kuchenstücks α";
                lblParam2.Text = "Kuchenstücks Bogenlänge p";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = false;
                picBoxRadiusAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = true;
                picBoxStart.Visible = false;
            }
            if (cboxKnowing.SelectedItem == cboxKnowing.Items[3])
            {
                lblSquare.Visible = false;
                lblParamTwo.Visible = false;
                lblParam1.Text = "Flächeninhalt Kuchenstücks S";
                lblParam2.Text = "Kuchenstücks Bogenlänge p";
                lblProperties.Visible = false;
                lblParam2.Visible = true;
                txtParam1.Visible = true;
                txtParam2.Visible = true;

                picBoxArcLengthAndRadius.Visible = false;
                picBoxRadiusAngle.Visible = false;
                picBoxAngleAndArcLength.Visible = true;
                picBoxStart.Visible = false;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (cboxKnowing.SelectedItem != null)
            {
                if (cboxKnowing.SelectedItem == cboxKnowing.Items[0]&& !"".Equals(txtParam1.Text)&& !"".Equals(txtParam2.Text))
                {
                    AngleAndRadius();
                }
                else
                {
                    MessageBox.Show("Felder müssen Daten enthalten.", "Error", MessageBoxButtons.OK);
                }
                if (cboxKnowing.SelectedItem == cboxKnowing.Items[1])
                {
                    ArcLengthAndRadius();
                }
                if (cboxKnowing.SelectedItem == cboxKnowing.Items[2])
                {
                    AngleAndArcLength();
                }
                //if (cboxKnowing.SelectedItem == cboxKnowing.Items[3])
                //{
                //    lblSquare.Visible = true;
                //    lblParamTwo.Visible = true;
                //    square = Convert.ToDouble(txtParam1.Text);
                //    arcLength = Convert.ToDouble(txtParam2.Text);
                //    radius = square * 2 / arcLength;
                //    lblParamTwo.Text = "Kuchenstücks Schenkellänge = " + radius.ToString();
                //    angle = arcLength / radius;
                //    lblSquare.Text = "Winkel Kuchenstücks = " + angle.ToString();
                //    lblParamThree.Text = "Kuchenstücks Sekantenlänge = " + square.ToString();

                //    DrawChoceOfPie((float)angle);

                //}

            }
            else MessageBox.Show("Bitte wählen Sie Bekannte Optionen.", "Error", MessageBoxButtons.OK);
        }
        //this method processes information based on ANGLE and ARC
        private void AngleAndArcLength()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            angle = Convert.ToDouble(txtParam1.Text);
            arcLength = Convert.ToDouble(txtParam2.Text);
            radius = arcLength / angle;
            lblParamTwo.Text = "Kuchenstücks Schenkellänge = " + radius.ToString();
            square = Math.PI * Math.Pow(radius, 2) * (angle / MAXGRADUS);
            lblSquare.Text = "Flächeninhalt Kuchenstücks = " + square.ToString();

            DrawChoceOfPie((float)angle);
        }

        //this method processes information based on RADIUS and ARC
        private void ArcLengthAndRadius()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            radius = Convert.ToDouble(txtParam1.Text);
            arcLength = Convert.ToDouble(txtParam2.Text);
            square = (radius * arcLength) / 2;
            // result = Math.PI * Math.Pow(radius, 2) * (angle / MAXGRADUS);
            lblSquare.Text = "Flächeninhalt Kuchenstücks = " + square.ToString();
            angle = arcLength / radius;
            lblParamTwo.Text = "Winkel Kuchenstücks = " + angle.ToString();

            DrawChoceOfPie((float)angle);
        }
        //this method processes information based on ANGLE and RADIUS
        private void AngleAndRadius()
        {
            lblSquare.Visible = true;
            lblParamTwo.Visible = true;
            //lblParamThree.Visible = true;
            radius = Convert.ToDouble(txtParam2.Text);
            angle = Convert.ToDouble(txtParam1.Text);
            square = Math.PI * Math.Pow(radius, 2) * (angle / MAXGRADUS);
            lblSquare.Text = "Flächeninhalt Kuchenstücks = " + square.ToString();
            arcLength = radius * angle;
            lblParamTwo.Text = "Kuchenstücks Bogenlänge = " + arcLength.ToString();

            DrawChoceOfPie((float)angle);
            //chord = (2*radius)*Math.Sin(angle / 2);
            //lblParamThree.Text = "Kuchenstücks Sekantenlänge = "+chord.ToString(); 
        }

        //this method is responsible for rendering a piece of cake( „Kuchenstück“ graphisch)
        private void DrawChoceOfPie(float angle)
        {
            const int margin = 10;
            const int width = 150;
            Graphics gr = picBoxPie.CreateGraphics();
            Pen outline_pen = Pens.Red;
            Brush fill_brush = Brushes.LightGreen;

            using (Pen ellipse_pen = new Pen(Color.Blue))
            {
                ellipse_pen.DashPattern = new float[] { 5, 5 };

                Rectangle rect = new Rectangle(margin + 30, 10, width, width);
                gr.DrawEllipse(ellipse_pen, rect);
                gr.FillPie(fill_brush, rect, 300, angle);
                gr.DrawPie(outline_pen, rect, 300, angle);

            }
        }
    }
}