﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);

        }
        // handle data error for a DataGridView control pg# 589
        private void productsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occured.\n" + "Row: " + row + "\n" + "Error: "
                + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");
        }
    }
}
