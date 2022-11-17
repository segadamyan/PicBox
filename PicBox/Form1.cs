using Microsoft.VisualBasic;
using System;

namespace PicBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            task2();
        }
        
        private void task2()
        {
            Random random = new System.Random();
            int n = 5;
            int m = 5;
            int[,] array = new int[n, m];

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    array[i, j] = random.Next(50);
            try {
                int a = array[10, 10];
            } catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("Error");
            }
        }
        private void task1()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int n = 5;
            int m = 5;
            Random random = new System.Random();
            int[,] array = new int[n, m];

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    array[i, j] = random.Next(50);

            var x = 0;
            var y = 0;
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (isPowThree(array[i, j]))
                        {
                            g.DrawString(array[i, j].ToString(), new Font("Tahoma", 15), Brushes.Green, new Point(x, y));
                        }
                        else
                        {
                            g.DrawString(array[i, j].ToString(), new Font("Tahoma", 15), Brushes.Black, new Point(x, y));
                        }
                        x += 50;
                    }
                    x = 0;
                    y += 50;
                }
            }
        }

        private bool isPowThree(int x)
        {
            for (int i = 0; i < Math.Log(x, 3) + 1; i++)
            {
                if (Math.Pow(3, i) == x)
                {
                    return true;
                }
            }
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}