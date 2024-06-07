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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
 // إنشاء نموذج جديد للصفحة الثانية
            Form7 form7 = new Form7();

            // عرض الصفحة الثانية
            form7.Show();

            // إخفاء الصفحة الحالية
            this.Hide();
        }
    }
}
