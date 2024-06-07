using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();

            // عرض الصفحة الثانية
            form10.Show();

            // إخفاء الصفحة الحالية
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();

            // عرض الصفحة الثانية
            form10.Show();

            // إخفاء الصفحة الحالية
            this.Hide();
        }
    }
}
