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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int red, green;//กำหนดตัวเเปรที่รับค่า int 
        private void button1_Click(object sender, EventArgs e)
        {     
            if (button1.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button1 มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button1.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++; green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1    
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else 
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button1.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--; green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1  

            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;//กำหนดให้ Button1 มีสีพื่้นหลังเป็นสี green
            button2.BackColor = Color.Green;//กำหนดให้ Button2 มีสีพื่้นหลังเป็นสี green
            button3.BackColor = Color.Green;//กำหนดให้ Button3 มีสีพื่้นหลังเป็นสี green
            button4.BackColor = Color.Green;//กำหนดให้ Button4 มีสีพื่้นหลังเป็นสี green
            button5.BackColor = Color.Green;//กำหนดให้ Button5 มีสีพื่้นหลังเป็นสี green
            button6.BackColor = Color.Green;//กำหนดให้ Button6 มีสีพื่้นหลังเป็นสี green
            button7.BackColor = Color.Green;//กำหนดให้ Button7 มีสีพื่้นหลังเป็นสี green
            button8.BackColor = Color.Green;//กำหนดให้ Button8 มีสีพื่้นหลังเป็นสี green
            button9.BackColor = Color.Green;//กำหนดให้ Button9 มีสีพื่้นหลังเป็นสี green
            button10.BackColor = Color.Green;//กำหนดให้ Button10 มีสีพื่้นหลังเป็นสี green
            button11.BackColor = Color.Green;//กำหนดให้ Button11 มีสีพื่้นหลังเป็นสี green
            button12.BackColor = Color.Green;//กำหนดให้ Button12 มีสีพื่้นหลังเป็นสี green
            button13.BackColor = Color.Green;//กำหนดให้ Button13 มีสีพื่้นหลังเป็นสี green
            button14.BackColor = Color.Green;//กำหนดให้ Button14 มีสีพื่้นหลังเป็นสี green
            button15.BackColor = Color.Green;//กำหนดให้ Button15 มีสีพื่้นหลังเป็นสี green
            button16.BackColor = Color.Green;//กำหนดให้ Button16 มีสีพื่้นหลังเป็นสี green
            button17.BackColor = Color.Red;//กำหนดให้ Button17 มีสีพื่้นหลังเป็นสี red
            if (button1.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 1 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button2.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 2 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button3.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 3 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button4.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 4 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button5.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 5 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button6.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 6 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button7.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 7 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button8.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 8 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button9.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 9 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button10.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 10 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button11.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 11 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button12.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 12 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button13.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 13 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button14.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 14 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
            if (button15.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button ที่ 15 มีสีพื้นหลังเป็นสีเขียวให้เข้าเงื่อนไข
            {
                green++;//ให้ตัวเเปร green เพิ่มขึ้น 1
                button16.Text = green.ToString();//ให้เเสดงค่าใน Button ที่ 16 เเละเเปลงค่าเป็น string 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button2 มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button2.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++; green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1 

            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else 
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button2.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button3 มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button3.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button3.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button4 มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button4.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button4.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button5.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button5.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button10.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button10.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button9.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button9.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button8.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green --;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button8.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button7.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button7.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button6.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button6.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button15.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button15.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button14.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button14.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button13.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button13.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button12.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button12.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();//ให้ f1 คือการเปิด Form1 ใหม่
            f1.Show();//โชว์ Form1 ขึ้นมา
            this.Hide();//ซ้อน Form หน้านี้
        }

        private void button18_Click(object sender, EventArgs e)
        {
            สั่งอาหาร f3 = new สั่งอาหาร();//ให้ f3 คือการเปิด Form สั่งอาหาร ใหม่
            f3.Show();//โชว์ From สั่งอาหาร ขึ้นมา
            this.Hide();//ซ้อน Form หน้านี้
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Green)//กำหนดเงื่อนไข ถ้า Button มีสีพื้นหลังเป็นสี Green ให้เข้าสู่เงื่อนไข
            {
                if (MessageBox.Show("คุณต้องการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button11.BackColor = Color.Red;//ให้สีพื้นหลังเปลี่ยนเป็นสีเเดง
                red++;green--;//ให้ช่องสีเเดงเพิ่มค่า เเละลดค่าสีเขียวลงที่ละ 1
            }
            else//ถ้าไม่เข้าเงื่อนไขใน if จะให้ทำใน else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการจองโต๊ะใช่หรือไม่", " ", MessageBoxButtons.OKCancel) == DialogResult.OK)//กำหนดเงื่อนไขเมื่อ MessageBox โชว์ คำว่า คุณต้องการยกเลิกจองโต๊ะใช่หรือไม่ เเละมีตัวเลือกให้กดใน MessageBox โชว์ มี OK เเละ Cancel เมื่อกด OK ให้เข้าเงื่อนไข
                    button11.BackColor = Color.Green;//ให้สีพื้นหลังเปลี่ยนเป็นสีเขียว
                red--;green++;//ให้ช่องสีเเดงลดลง เเละเพิ่มค่าสีเขียวลงที่ละ 1
            }
            button16.Text = green.ToString();//ให้ Button ที่ 16 เเสดงค่าของ green
            button17.Text = red.ToString();//ให้ Button ที่ 17 เเสดงค่าของ red
        }
    }
}
