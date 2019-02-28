using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace LinearAlgebra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double[,] a1= new double[3, 3]
            {
                {1,2,3 },{2,3,4},{4,5,6}
            };
            Matrix mt = new Matrix(a1);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBox1.Text += mt[i, j]+ "\r\n";
                }
            }
            Matrix mt_I = mt.Inverse();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBox1.Text += mt_I[i, j]+"\r\n";
                }
            }
            Matrix mt_T = mt.Transpose();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBox1.Text += mt_T[i, j] + "\r\n";
                }
            }

            Matrix muti = mt * mt_I;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBox1.Text += muti[i, j] + "\r\n";
                }
            }
        }
    }
}
