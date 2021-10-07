using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label hello_label = new Label();
            hello_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            hello_label.ImageIndex = 1;
            hello_label.ImageAlign = ContentAlignment.TopLeft;
            hello_label.UseMnemonic = true;
            hello_label.Text = "Hello World";
            hello_label.Size = new Size(hello_label.PreferredWidth, hello_label.PreferredHeight);
            this.Controls.Add(hello_label);
        }
    }
}
