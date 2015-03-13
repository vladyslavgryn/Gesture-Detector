using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HandGestureRecognition
{
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            InitializeComponent();
            comboBox2.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadNewFile();
        }

        private void LoadNewFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Wybierz aplikację";
            ofd.Filter = "Aplikacja|*.exe";
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //userSelectedFilePath = ofd.FileName;
                foreach (string fileName in ofd.FileNames)
                {
                    userSelectedFilePath += fileName + Environment.NewLine;
                }
            }
        }


        public string userSelectedFilePath
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Enabled = false;
                textBox2.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = true;
                textBox2.Enabled = false;
                button1.Enabled = false;
            }
        }


    }
}
