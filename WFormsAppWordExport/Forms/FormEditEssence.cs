﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormsAppWordExport.Forms
{
    public partial class FormEditEssence : Form
    {
        public FormEditEssence()
        {
            InitializeComponent();
        }


        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
