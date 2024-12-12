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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtselect_length.Text=txtall_text.Text.Trim().Length.ToString();
            //txtselect_length.Text = txtall_text.TextLength.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtall_text.SelectionLength = 0;
        }
        string myselectedtext = "";
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectedText.Length > 0)
            {
                myselectedtext = txtall_text.SelectedText;
                //Clipboard.SetText(txtall_text.SelectedText);
            }
            else
                MessageBox.Show("لايوجد نص");
            txtall_text.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtall_text.SelectedText.Length > 0)
            {
                txtselect_length.Text=txtall_text.SelectionLength.ToString();
                //txtselect_length.Text=txtall_text.SelectedText.Length.ToString();
            }
            else
            {
                MessageBox.Show("قم بتحديد النص ");
                txtselect_length.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] strword = txtall_text.Text.Split(' ');
            txtnum_word.Text=(strword.Length-1).ToString();
            //string [] strword = txtall_all.SelectedText.Split(' ');
           // int x = 0;
          //  for(int i = 0;i< strword.Length; i++)
          //  {
          //      if (strword[i] != "")
          //          x++; 
          //  }
           // txtnum_word.Text = x.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if(txtall_text.SelectionLength > 0)
            if (txtall_text.SelectionLength > 0)
            {
                //txtall_text.Text=txtall_text.Text.Remove(txtall_text.SelectionStart, txtall_text.SelectionLength);
                txtall_text.SelectedText = "";
            }
            else
                MessageBox.Show("قم بتحديد نص");
        }

        private void cut_btn_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectedText.Length > 0)
            {
                //myselectedtext=txtall_text.SelectedText;
                Clipboard.SetText(txtall_text.SelectedText);

                txtall_text.SelectedText = null;
                // txtall_text.SelectedText = "";
            }
            else
                MessageBox.Show("لايوجد نص مظلل");
            txtall_text.Cut();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtcopypast.Text += myselectedtext.Trim();
            //txtcopypast.Paste();
            //txtcopypast.Text += Clipboard.GetText();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtall_text.Undo();
            txtcopypast.Undo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtall_text.Clear();
            //txtall_text.Text= null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 0;
            for(int i = 0; i < txtall_text.Text.Length; i++)
            {
                if (txtall_text.Text[i] != ' ')
                {
                    x++;
                }
            }
            MessageBox.Show(x.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < txtall_text.Text.Length; i++)
            {
                if (txtall_text.SelectedText[i] != ' ')
                {
                    x++;
                }
            }
            MessageBox.Show(x.ToString());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectionLength > 0)
            {
                if (txtedite.Text.Trim() != "")
                {
                    // txtall_text.Text= txtall_text.Text.Replace(txtall_text.SelectedText,txtedite.Text);
                    txtall_text.SelectedText = txtedite.Text;
                }
                else
                    MessageBox.Show("ادخل النص الجديد");

            }
            else
            {
                MessageBox.Show("حدد النص المراد تعديله");

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtsearsh.Text.Trim() != "")
            {
                int indix = txtall_text.Text.IndexOf(txtsearsh.Text, 0);
                if (indix > -1)
                {
                    txtall_text.SelectionStart = indix;
                    txtall_text.SelectionLength = txtsearsh.Text.Length;

                    //txtall_text.Select(indix, txtall_text.Text.Length);
                    txtall_text.Focus();
                }
                else
                    MessageBox.Show("not found");
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txtsearsh.Focus();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtall_text.SelectionStart + "");
            if (txtsearsh.Text.Trim() != "")
            {
                int index = txtall_text.Text.IndexOf(txtsearsh.Text, txtall_text.SelectionStart + txtall_text.SelectionLength);
                if (index > -1)
                {
                    txtall_text.Focus();
                    txtall_text.Select(index, txtsearsh.Text.Length);

                }
                else
                    MessageBox.Show("not found");

            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txtsearsh.Focus();  
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtall_text.SelectionStart + "");
            if (txtsearsh.Text.Trim() != "")
            {
                int index = txtall_text.Text.LastIndexOf(txtsearsh.Text, txtall_text.SelectionStart - txtall_text.SelectionLength);

                if (index > -1)
                {
                    txtall_text.Focus();
                    txtall_text.Select(index, txtsearsh.Text.Length);
                }
                else
                    MessageBox.Show("not found");

            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txtsearsh.Focus();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBoxchar.Items.Clear();
            string s = txtall_text.SelectedText;
            char[] ch=s.ToCharArray();
            for(int i=0;i<ch.Length; i++)
                listBoxchar.Items.Add(ch[i]);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBoxword.Items.Clear();
            string[] s = txtall_text.SelectedText.Split(' ');
            for (int i = 0; i < s.Length; i++)
                listBoxword.Items.Add(s[i]);
        }
    }
}
