using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DragNDropExample
{
    public partial class Form1 : Form
    {
        bool dragstate = false;
        public Form1()
        {
            InitializeComponent();
            
            // ��������� ������ ����� ��������� ����������
            listBox1.AllowDrop = true;
        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // ��� ��������� ������� ���� ��������� ����������
            // ����������� ���������
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            // ��� ��������� �� ������� ��������� ��������������� ������ 
            // ��� �������
            if (e.Data.GetDataPresent(DataFormats.StringFormat)) 
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
        }
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            // ��� ���������� ������ ���������� ����������� ������ � ������� ������
            listBox1.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            dragstate = false;
        }

      
                
        
        

    }
}