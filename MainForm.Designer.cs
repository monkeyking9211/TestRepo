namespace DataFusion6p0TestApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataFusionVisualizationControl1 = new WindowsForms.DataFusion1VisualizationControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.applicationHostControl1 = new Baselabs.Design.UI.ApplicationHostControl();
            this.applicationHost1 = new Baselabs.Design.UI.ApplicationHost();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationControl1 = new Baselabs.Design.UI.ApplicationControl();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationHostControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1178, 746);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1178, 795);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.applicationControl1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 746);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualization";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataFusionVisualizationControl1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1164, 714);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataFusionVisualizationControl1
            // 
            this.dataFusionVisualizationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFusionVisualizationControl1.Location = new System.Drawing.Point(650, 0);
            this.dataFusionVisualizationControl1.Margin = new System.Windows.Forms.Padding(0);
            this.dataFusionVisualizationControl1.Name = "dataFusionVisualizationControl1";
            this.tableLayoutPanel1.SetRowSpan(this.dataFusionVisualizationControl1, 2);
            this.dataFusionVisualizationControl1.Size = new System.Drawing.Size(514, 714);
            this.dataFusionVisualizationControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.applicationHostControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1170, 718);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // applicationHostControl1
            // 
            this.applicationHostControl1.ApplicationHost = this.applicationHost1;
            this.applicationHostControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicationHostControl1.Location = new System.Drawing.Point(3, 3);
            this.applicationHostControl1.Name = "applicationHostControl1";
            this.applicationHostControl1.Size = new System.Drawing.Size(1164, 712);
            this.applicationHostControl1.TabIndex = 0;
            // 
            // applicationHost1
            // 
            this.applicationHost1.ApplicationFile = "Application.adl";
            this.applicationHost1.Application.Components["egovehicleview"].PropertyValues["PictureBox"] = pictureBox1;
            this.applicationHost1.Application.Components["datafusion1visualization"].PropertyValues["Control"] =
                dataFusionVisualizationControl1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationControl1
            // 
            this.applicationControl1.ApplicationHost = this.applicationHost1;
            this.applicationControl1.Dock = System.Windows.Forms.DockStyle.None;
            this.applicationControl1.Location = new System.Drawing.Point(3, 24);
            this.applicationControl1.Name = "applicationControl1";
            this.applicationControl1.Size = new System.Drawing.Size(263, 25);
            this.applicationControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 795);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BASELABS Create | Data Fusion Application";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationHostControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Baselabs.Design.UI.ApplicationHostControl applicationHostControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Baselabs.Design.UI.ApplicationControl applicationControl1;
        private Baselabs.Design.UI.ApplicationHost applicationHost1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsForms.DataFusion1VisualizationControl dataFusionVisualizationControl1;
    }
}

