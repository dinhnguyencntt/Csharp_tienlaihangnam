﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_tienlaihangnam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void txtsonamgui_TextChanged(object sender, EventArgs e)
        {
        
            {
             
            }
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double laisuat = Double.Parse(txtlaisuat.Text.Replace("%", "")) / 100;
            double sotien, sonamgui, ketqua;
            sotien = Convert.ToInt32(txtsotien.Text);
            sonamgui = Convert.ToInt32(txtsonamgui.Text);
            for(int i = 1; i <= sonamgui; i++)
            {
                ketqua = sotien * laisuat;
                lsbkq.Items.Add(" năm"+i+" số tiền là "+ txtsotien.Text+ " lãi suất= "+ketqua);
                sotien += ketqua;
            }
        }

        private void lsbkq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
