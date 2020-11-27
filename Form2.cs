using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace tmp2_2_
{
    public partial class Form2 : Form
    {
        [DllImport(
        @"C:\Users\Honor\Desktop\Lab2_3\Main\Laba2_3\bin\Debug\Plugins\Lib2-2-1.dll",
        EntryPoint = "FuncName",
        CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FuncName1();

        [DllImport(
        @"C:\Users\Honor\Desktop\Lab2_3\Main\Laba2_3\bin\Debug\Plugins\Lib2-2-2.dll",
        EntryPoint = "FuncName",
        CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FuncName2();

        [DllImport(
        @"C:\Users\Honor\Desktop\Lab2_3\Main\Laba2_3\bin\Debug\Plugins\Lib2-2-3.dll",
        EntryPoint = "FuncName",
        CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr FuncName3();

        [DllImport(
        @"C:\Users\Honor\Desktop\Lab2_3\Main\Laba2_3\bin\Debug\Plugins\MyCppDll.dll",
        EntryPoint = "FuncName",
        CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr FuncName4();

        [DllImport(
        @"C:\Users\Honor\Desktop\Lab2_3\Main\Laba2_3\bin\Debug\Plugins\MyCDll.dll",
        EntryPoint = "FuncName",
        CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr FuncName5();

        public Form2()
        {
            InitializeComponent();
            listBox1.Items.Add(Marshal.PtrToStringAnsi(FuncName1()));
            listBox1.Items.Add(Marshal.PtrToStringAnsi(FuncName2()));
            listBox1.Items.Add(Marshal.PtrToStringAnsi(FuncName3()));
            listBox1.Items.Add(Marshal.PtrToStringAnsi(FuncName4()));
            listBox1.Items.Add(Marshal.PtrToStringAnsi(FuncName5()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedIndex == 4)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                        !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                        !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        //this.Hide();
                        Form1 form1 = new Form1(listBox1.Text, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                        form1.Activate();
                        form1.Show();
                    }
                }
                else
                {
                    // this.Hide();
                    Form1 form1 = new Form1(listBox1.SelectedIndex, listBox1.Text);
                    form1.Activate();
                    form1.Show();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 4 )
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;

            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }
    }
}
