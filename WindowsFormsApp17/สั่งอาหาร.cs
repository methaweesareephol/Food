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
    public partial class สั่งอาหาร : Form
    {
        public สั่งอาหาร()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();//ให้ f1 คือการเปิด Form1 ใหม่
            f1.Show();//โชว์ Form1 ขึ้นมาเเละไม่สามารถใช้ Form อื่นได้จนกว่าจะออกจาก Form1
            this.Hide();//ซ้อน Form หน้านี้
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3();//ให้ f3 คือการเปิด Form3 ใหม่
            f3.textBox1.Text = numericUpDown1.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown1 มาเเสดงใน textBox1 ที่อยู่ใน Form3
            f3.textBox2.Text = numericUpDown3.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown3 มาเเสดงใน textBox2 ที่อยู่ใน Form3
            f3.textBox3.Text = numericUpDown2.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown2 มาเเสดงใน textBox3 ที่อยู่ใน Form3
            f3.textBox4.Text = numericUpDown8.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown8 มาเเสดงใน textBox4 ที่อยู่ใน Form3
            f3.textBox5.Text = numericUpDown4.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown4 มาเเสดงใน textBox5 ที่อยู่ใน Form3
            f3.textBox6.Text = numericUpDown5.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown5 มาเเสดงใน textBox6 ที่อยู่ใน Form3
            f3.textBox7.Text = numericUpDown6.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown6 มาเเสดงใน textBox7 ที่อยู่ใน Form3
            f3.textBox8.Text = numericUpDown7.Value.ToString();//ให้ดึงข้อมูลตัวเลขจาก numericUpDown7 มาเเสดงใน textBox8 ที่อยู่ใน Form3
            f3.Show();//โชว์ Form3 ขึ้นมาเเละไม่สามารถใช้ Form อื่นได้จนกว่าจะออกจาก Form3
            this.Hide();//ซ้อน Form หน้านี้


        }
    }
}
