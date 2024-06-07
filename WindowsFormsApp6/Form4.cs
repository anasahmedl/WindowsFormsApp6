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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // إنشاء نموذج جديد للصفحة الثانية
            Form6 form6 = new Form6();

            // عرض الصفحة الثانية
            form6.Show();

            // إخفاء الصفحة الحالية
            this.Hide();
        }
    }
}
