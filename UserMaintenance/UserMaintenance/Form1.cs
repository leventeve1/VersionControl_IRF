﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities2;
using UserMaintenance.Properties;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource2.FullName;
            
            button1.Text = Resource2.Add;
            button2.Text = Resource2.Write;
            button3.Text = Resource2.Delete;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox1.Text,
                
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.DefaultExt = "txt";

            if (sfd.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
                foreach (User u in users)
                {
                    sw.WriteLine($"{u.ID};{u.FullName}");
                }
                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
