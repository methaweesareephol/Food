using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();//เปิด Form 2 ใหม่
            f2.Show();//โชว์ Form2 โดยหากไม่ปิด Form2 จะไม่สามารถใช้ Formอื่นได้
            this.Hide();//ซ้อน Form หน้านี้
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            สั่งอาหาร f3 = new สั่งอาหาร();//เปิด Form สั่งอาหาร ใหม่
            f3.Show();//โชว์ Form สั่งอาหาร โดยหากไม่ปิด Form สั่งอาหาร จะไม่สามารถใช้ Formอื่นได้
            this.Hide();//ซ้อน Form หน้านี้
        }
    }
}
