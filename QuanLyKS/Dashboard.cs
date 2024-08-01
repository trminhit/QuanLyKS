﻿using QuanLyKS.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Addroom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnAddRoom.Left;
            uC_Addroom1.Visible = true;
            uC_Addroom1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerRes.Left;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();

        }
    }
}
