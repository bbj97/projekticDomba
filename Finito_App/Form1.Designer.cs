
namespace Finito_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cUSUMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.varsPanel = new System.Windows.Forms.Panel();
            this.lclPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.check_One = new System.Windows.Forms.CheckBox();
            this.check_Two = new System.Windows.Forms.CheckBox();
            this.check_Three = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.database7DataSet = new Finito_App.Database7DataSet();
            this.tblmjerenjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_mjerenjaTableAdapter = new Finito_App.Database7DataSetTableAdapters.tbl_mjerenjaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lI487LTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIC201STMVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pI907PTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.varsPanel.SuspendLayout();
            this.lclPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmjerenjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 619);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Panel2.Controls.Add(this.varsPanel);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 619);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lI487LTDataGridViewTextBoxColumn,
            this.fIC201STMVDataGridViewTextBoxColumn,
            this.pI907PTDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblmjerenjaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUSUMToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(362, 30);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cUSUMToolStripMenuItem1
            // 
            this.cUSUMToolStripMenuItem1.Name = "cUSUMToolStripMenuItem1";
            this.cUSUMToolStripMenuItem1.Size = new System.Drawing.Size(73, 26);
            this.cUSUMToolStripMenuItem1.Text = "CUSUM";
            this.cUSUMToolStripMenuItem1.Click += new System.EventHandler(this.cUSUMToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 26);
            this.toolStripMenuItem1.Text = "EWMA";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(73, 26);
            this.toolStripMenuItem2.Text = "XCharts";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 26);
            this.toolStripMenuItem3.Text = "RCharts";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(67, 26);
            this.toolStripMenuItem4.Text = "Define";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // varsPanel
            // 
            this.varsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.varsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.varsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.varsPanel.Controls.Add(this.lclPanel);
            this.varsPanel.Controls.Add(this.check_One);
            this.varsPanel.Controls.Add(this.check_Two);
            this.varsPanel.Controls.Add(this.check_Three);
            this.varsPanel.Location = new System.Drawing.Point(420, 3);
            this.varsPanel.Name = "varsPanel";
            this.varsPanel.Size = new System.Drawing.Size(681, 98);
            this.varsPanel.TabIndex = 3;
            // 
            // lclPanel
            // 
            this.lclPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lclPanel.Controls.Add(this.label4);
            this.lclPanel.Controls.Add(this.label5);
            this.lclPanel.Controls.Add(this.textBox4);
            this.lclPanel.Controls.Add(this.textBox5);
            this.lclPanel.Controls.Add(this.textBox6);
            this.lclPanel.Controls.Add(this.label6);
            this.lclPanel.Location = new System.Drawing.Point(3, 3);
            this.lclPanel.Name = "lclPanel";
            this.lclPanel.Size = new System.Drawing.Size(153, 90);
            this.lclPanel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "K-var";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "UCL";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(51, 31);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 22);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(51, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 22);
            this.textBox6.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "LCL";
            // 
            // check_One
            // 
            this.check_One.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_One.AutoSize = true;
            this.check_One.Location = new System.Drawing.Point(580, 7);
            this.check_One.Name = "check_One";
            this.check_One.Size = new System.Drawing.Size(67, 21);
            this.check_One.TabIndex = 8;
            this.check_One.Text = "Ewma";
            this.check_One.UseVisualStyleBackColor = true;
            // 
            // check_Two
            // 
            this.check_Two.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_Two.AutoSize = true;
            this.check_Two.Location = new System.Drawing.Point(580, 35);
            this.check_Two.Name = "check_Two";
            this.check_Two.Size = new System.Drawing.Size(80, 21);
            this.check_Two.TabIndex = 7;
            this.check_Two.Text = "XCharts";
            this.check_Two.UseVisualStyleBackColor = true;
            // 
            // check_Three
            // 
            this.check_Three.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.check_Three.AutoSize = true;
            this.check_Three.Location = new System.Drawing.Point(579, 62);
            this.check_Three.Name = "check_Three";
            this.check_Three.Size = new System.Drawing.Size(81, 21);
            this.check_Three.TabIndex = 6;
            this.check_Three.Text = "RCharts";
            this.check_Three.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(3, 107);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1098, 305);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // database7DataSet
            // 
            this.database7DataSet.DataSetName = "Database7DataSet";
            this.database7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmjerenjaBindingSource
            // 
            this.tblmjerenjaBindingSource.DataMember = "tbl_mjerenja";
            this.tblmjerenjaBindingSource.DataSource = this.database7DataSet;
            // 
            // tbl_mjerenjaTableAdapter
            // 
            this.tbl_mjerenjaTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lI487LTDataGridViewTextBoxColumn
            // 
            this.lI487LTDataGridViewTextBoxColumn.DataPropertyName = "LI-487-LT";
            this.lI487LTDataGridViewTextBoxColumn.HeaderText = "LI-487-LT";
            this.lI487LTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lI487LTDataGridViewTextBoxColumn.Name = "lI487LTDataGridViewTextBoxColumn";
            this.lI487LTDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIC201STMVDataGridViewTextBoxColumn
            // 
            this.fIC201STMVDataGridViewTextBoxColumn.DataPropertyName = "FIC201ST:MV";
            this.fIC201STMVDataGridViewTextBoxColumn.HeaderText = "FIC201ST:MV";
            this.fIC201STMVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIC201STMVDataGridViewTextBoxColumn.Name = "fIC201STMVDataGridViewTextBoxColumn";
            this.fIC201STMVDataGridViewTextBoxColumn.Width = 125;
            // 
            // pI907PTDataGridViewTextBoxColumn
            // 
            this.pI907PTDataGridViewTextBoxColumn.DataPropertyName = "PI-907-PT";
            this.pI907PTDataGridViewTextBoxColumn.HeaderText = "PI-907-PT";
            this.pI907PTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pI907PTDataGridViewTextBoxColumn.Name = "pI907PTDataGridViewTextBoxColumn";
            this.pI907PTDataGridViewTextBoxColumn.Width = 125;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 624);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.varsPanel.ResumeLayout(false);
            this.varsPanel.PerformLayout();
            this.lclPanel.ResumeLayout(false);
            this.lclPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmjerenjaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel varsPanel;
        private System.Windows.Forms.Panel lclPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_One;
        private System.Windows.Forms.CheckBox check_Two;
        private System.Windows.Forms.CheckBox check_Three;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cUSUMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Database7DataSet database7DataSet;
        private System.Windows.Forms.BindingSource tblmjerenjaBindingSource;
        private Database7DataSetTableAdapters.tbl_mjerenjaTableAdapter tbl_mjerenjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lI487LTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIC201STMVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pI907PTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
    }
}

