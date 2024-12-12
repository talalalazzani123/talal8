using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الثامنة
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            RandomNumbers();
        }
        private void RandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(1, 101); // Random number between 1 and 100
                listBox1.Items.Add(randomNumber);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                if (number > 100)
                {
                    MessageBox.Show("الرقم يجب أن يكون 100 أو أقل.");
                }
                else if (!listBox1.Items.Contains(number))
                {
                    if (listBox1.Items.Count >= 20)
                    {
                        listBox1.Items.RemoveAt(0); // Remove the oldest item
                    }
                    listBox1.Items.Add(number);
                }
                else
                {
                    MessageBox.Show("الرقم مكرر.");
                }
            }
            else
            {
                MessageBox.Show("يرجى إدخال رقم صالح.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("يرجى تحديد عنصر للحذف.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = listBox1.Items.Cast<int>().Sum();
            textBox2.Text=sum.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                double average = listBox1.Items.Cast<int>().Average();
                textBox3.Text=average.ToString();
            }
            else
            {
                MessageBox.Show("القائمة فارغة.");
            }
        }
    }
}
