using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finito_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database7DataSet.tbl_mjerenja' table. You can move, or remove it, as needed.
            this.tbl_mjerenjaTableAdapter.Fill(this.database7DataSet.tbl_mjerenja);

        }

        private void cUSUMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (varsPanel.Visible == false)
            {
                varsPanel.Visible = true;
            }
            if (varsPanel.Visible == true)
            {
                varsPanel.Visible = false;
            }

            chart1.Visible = true;
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (varsPanel.Visible == false)
            {
                varsPanel.Visible = true;
            }
            if (varsPanel.Visible == true)
            {
                varsPanel.Visible = false;
            }

            chart1.Visible = true;
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (varsPanel.Visible == false)
            {
                varsPanel.Visible = true;
            }
            if (varsPanel.Visible == true)
            {
                varsPanel.Visible = false;
            }
            chart1.Visible = true;
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (varsPanel.Visible == false)
            {
                varsPanel.Visible = true;
            }
            if (varsPanel.Visible == true)
            {
                varsPanel.Visible = false;
            }
            chart1.Visible = true;
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (varsPanel.Visible == false)
            {
                varsPanel.Visible = true;
            }
            if (varsPanel.Visible == true)
            {
                varsPanel.Visible = false;
            }
            chart1.Visible = true;
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
        }
    }
}
