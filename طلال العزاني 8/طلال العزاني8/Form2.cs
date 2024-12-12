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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                Clipboard.SetText(textBox1.SelectedText);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.SelectedText= null;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.SelectionLength > 0)
            {
                textBox2.SelectedText=Clipboard.GetText();
            }
            else
            {
                int selectionstart = textBox2.SelectionStart;
                textBox2.Text = textBox2.Text.Insert(selectionstart, Clipboard.GetText());
                textBox2.SelectionStart = selectionstart+Clipboard.GetText().Length;
            }
        }
        private List<(string Text,string Text2)>undolist= new List<(string,string)>();

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveState();

        }
        private void SaveState()
        {
            if (undolist.Count == 10)
            {
                undolist.RemoveAt(0);
            }
            undolist.Add((textBox1.Text,textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (undolist.Count > 1)
            {
                undolist.RemoveAt(undolist.Count-1);
                var lastState = undolist[undolist.Count-1];


                textBox1.Text = lastState.Text;
                textBox2.Text = lastState.Text2;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox2.SelectionStart= textBox2.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SaveState();
        }
    }
}
