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
    public partial class Form3 : Form
    {
        double sumation=0;//กำหนดตัวเเปรที่เก็บค่า int เเละให้มีค่าเริ่มเป็น 0
        public Form3()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();//คำสั่งปิดโปรเเกรม
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sumation = sumation + double.Parse(textBox1.Text) * 35;//เเปลงค่าตัวเลขจาก textBox1 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเริ่มต้นจาก 0 เเละเก็บค่าไว้ใน sumation
            sumation = sumation + double.Parse(textBox2.Text) * 45;//เเปลงค่าตัวเลขจาก textBox2 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเท่ากับ sumation ในบรรทัดด้านบน เเละเก็บค่าไว้ใน sumation
            sumation = sumation + double.Parse(textBox3.Text) * 50;//เเปลงค่าตัวเลขจาก textBox3 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเท่ากับ sumation ในบรรทัดด้านบน เเละเก็บค่าไว้ใน sumation
            sumation = sumation + double.Parse(textBox4.Text) * 65;//เเปลงค่าตัวเลขจาก textBox4 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเท่ากับ sumation ในบรรทัดด้านบน เเละเก็บค่าไว้ใน sumation
            sumation = sumation + double.Parse(textBox5.Text) * 30;//เเปลงค่าตัวเลขจาก textBox5 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเท่ากับ sumation ในบรรทัดด้านบน เเละเก็บค่าไว้ใน sumation
            sumation = sumation + double.Parse(textBox6.Text) * 40;//เเปลงค่าตัวเลขจาก textBox6 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเท่ากับ sumation ในบรรทัดด้านบน เเละเก็บค่าไว้ใน sumation
            sumation = sumation + double.Parse(textBox7.Text) * 30;//เเปลงค่าตัวเลขจาก textBox7 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเท่ากับ sumation ในบรรทัดด้านบน เเละเก็บค่าไว้ใน sumation
            sumation = sumation + double.Parse(textBox8.Text) * 35;//เเปลงค่าตัวเลขจาก textBox8 เเละ คูณ ด้วย 35 บวกกับ sumation ที่ตัวเลขมีค่าเท่ากับ sumation ในบรรทัดด้านบน เเละเก็บค่าไว้ใน sumation
            sum.Text = sumation.ToString();//เเสดงค่าของ sumation ใน sum เเละแปลงค่าเป็น string 
            button1.Enabled = false;//เมื่อกดรวมราคาเเล้วให้ปุ่มปิดตัวลง
            button2.Enabled = true;//ให้ปุ่ม button2 เปิดใช้งาน
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
