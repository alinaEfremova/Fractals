using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fract;
            try
            {
                fract = comboBox1.SelectedItem.ToString();
            }
            catch(Exception)
            {
                fract = "";
            }
            try
            {
                switch (fract)
                {
                    case "Koch snowflake":
                        if (Int32.Parse(textBox1.Text) > 7)
                        { textBox2.Text = "Enter a lower number: from 0 to 7"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 7";
                            Koh.DrawKoh(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }
                        break;
                    case "Sierpiński triangle":
                        if (Int32.Parse(textBox1.Text) > 7)
                        { textBox2.Text = "Enter a lower number: from 0 to 7"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 7";
                            Serp.DrawSerp(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }
                        break;
                    case "Dragon curve":
                        if (Int32.Parse(textBox1.Text) > 16)
                        { textBox2.Text = "Enter a lower number: from 0 to 16"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 16";
                            Dragon.DrawDragon(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Inscribed circle":
                        if (Int32.Parse(textBox1.Text) > 7)
                        { textBox2.Text = "Enter a lower number: from 0 to 7"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 7";
                            Circ.DrawCirc(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Cantor set":
                        if (Int32.Parse(textBox1.Text) > 7)
                        { textBox2.Text = "Enter a lower number: from 0 to 7"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 7";
                            Kant.DrawKant(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Pythagoras tree":
                        if (Int32.Parse(textBox1.Text) > 255)
                        { textBox2.Text = "Enter a lower number: from 0 to 255"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 255";
                            Pif.DrawPif(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }
                        break;
                    case "Spiral rotating squares":
                        if (Int32.Parse(textBox1.Text) > 40)
                        { textBox2.Text = "Enter a lower number: from 0 to 40"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 40";
                            SpirSq.DrawSpirSq(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Fibonacci word":
                        if (Int32.Parse(textBox1.Text) > 23)
                        { textBox2.Text = "Enter a lower number: from 10 to 23"; }
                        else if (Int32.Parse(textBox1.Text) < 10 && Int32.Parse(textBox1.Text) > 0)
                        { textBox2.Text = "Enter a higher number: from 10 to 23"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 10 to 23";
                            Fib.DrawFib(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Sierpiński carpet":
                        if (Int32.Parse(textBox1.Text) > 6)
                        { textBox2.Text = "Enter a lower number: from 0 to 6"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 6";
                            Serp1.DrawSerp1(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Sierpiński triangle (stochastic)":
                        if (Int32.Parse(textBox1.Text) > 6)
                        { textBox2.Text = "Enter a lower number: from 0 to 6"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 6";
                            Serp2.DrawSerp2(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Lévy":
                        if (Int32.Parse(textBox1.Text) > 14)
                        { textBox2.Text = "Enter a lower number: from 0 to 14"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 0 to 14";
                            Levi.DrawLevi(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "Barnsley fern":
                        if (Int32.Parse(textBox1.Text) > 85)
                        { textBox2.Text = "Enter a lower number: from 1 to 85"; }
                        else if (Int32.Parse(textBox1.Text) < 1)
                        { textBox2.Text = "Enter a higher number: from 1 to 85"; }
                        else if (Int32.Parse(textBox1.Text) < 0)
                        {
                            throw new FormatException();
                        }
                        else
                        {
                            textBox2.Text = "Enter the number of iterations: from 1 to 85";
                            Barn.DrawBarn(pictureBox1, colorDialog1.Color, Int32.Parse(textBox1.Text));
                        }                        
                        break;
                    case "":
                        break;
                }
            }
            catch(FormatException)
            {
                textBox2.Text = "Enter a non-negative integer";
            }
            catch (Exception)
            {
                textBox2.Text = "Enter a non-negative integer";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
            }
        }
    }
}
