﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBUS_APP.Master_Form
{
    public partial class Employee : UserControl
    {
        private void design_Dgv()
        {
            dataGridView1.Rows.Add("1", "aasdasd", "aasd", "qweda");
            dataGridView1.Rows.Add("2", "aasdwed", "aas", "qweda");
            dataGridView1.Rows.Add("3", "aqwedqwe", "acwe", "qweda");
            dataGridView1.Rows.Add("4", "dqweda", "awec", "aqwed");
            dataGridView1.Rows.Add("5", "aqwed", "awec", "qweda");
            dataGridView1.Rows.Add("6", "aqwed", "weca", "qweda");
            dataGridView1.Rows.Add("7", "aqwed", "awc", "aqwed");

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 157, 252);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10, FontStyle.Bold);
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Consolas", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dataGridView1.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            design_Dgv();
        }
    }
}