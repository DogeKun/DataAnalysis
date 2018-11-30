namespace DataAnalysisTask1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AnalysisLength = new System.Windows.Forms.Button();
            this.CPUCoreComboBox = new System.Windows.Forms.ComboBox();
            this.CameraComboBox = new System.Windows.Forms.ComboBox();
            this.MemoryComboBox = new System.Windows.Forms.ComboBox();
            this.ResoliutionComboBox = new System.Windows.Forms.ComboBox();
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            this.ScreenSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BatteryLabel = new System.Windows.Forms.Label();
            this.BatteryComboBox = new System.Windows.Forms.ComboBox();
            this.PhoneDataGrid = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.PhonePage = new System.Windows.Forms.TabPage();
            this.AprioriPage = new System.Windows.Forms.TabPage();
            this.AprioriMine = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AprioriBrowse = new System.Windows.Forms.Button();
            this.AprioriData = new System.Windows.Forms.ListBox();
            this.AprioriCollection = new System.Windows.Forms.ListBox();
            this.AprioriDataMining = new System.Windows.Forms.Button();
            this.AprioriCalculation = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDataGrid)).BeginInit();
            this.TabControl.SuspendLayout();
            this.PhonePage.SuspendLayout();
            this.AprioriPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.92481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.07519F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PhoneDataGrid, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, -3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1231, 686);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AnalysisLength);
            this.panel2.Controls.Add(this.CPUCoreComboBox);
            this.panel2.Controls.Add(this.CameraComboBox);
            this.panel2.Controls.Add(this.MemoryComboBox);
            this.panel2.Controls.Add(this.ResoliutionComboBox);
            this.panel2.Controls.Add(this.StorageComboBox);
            this.panel2.Controls.Add(this.ScreenSizeComboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BatteryLabel);
            this.panel2.Controls.Add(this.BatteryComboBox);
            this.panel2.Location = new System.Drawing.Point(864, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(363, 678);
            this.panel2.TabIndex = 0;
            // 
            // AnalysisLength
            // 
            this.AnalysisLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalysisLength.Location = new System.Drawing.Point(181, 606);
            this.AnalysisLength.Margin = new System.Windows.Forms.Padding(4);
            this.AnalysisLength.Name = "AnalysisLength";
            this.AnalysisLength.Size = new System.Drawing.Size(127, 28);
            this.AnalysisLength.TabIndex = 14;
            this.AnalysisLength.Text = "Find";
            this.AnalysisLength.UseVisualStyleBackColor = true;
            this.AnalysisLength.Click += new System.EventHandler(this.AnalysisLength_Click);
            // 
            // CPUCoreComboBox
            // 
            this.CPUCoreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUCoreComboBox.FormattingEnabled = true;
            this.CPUCoreComboBox.Location = new System.Drawing.Point(181, 47);
            this.CPUCoreComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CPUCoreComboBox.Name = "CPUCoreComboBox";
            this.CPUCoreComboBox.Size = new System.Drawing.Size(160, 28);
            this.CPUCoreComboBox.TabIndex = 13;
            // 
            // CameraComboBox
            // 
            this.CameraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraComboBox.FormattingEnabled = true;
            this.CameraComboBox.Location = new System.Drawing.Point(181, 84);
            this.CameraComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CameraComboBox.Name = "CameraComboBox";
            this.CameraComboBox.Size = new System.Drawing.Size(160, 28);
            this.CameraComboBox.TabIndex = 12;
            // 
            // MemoryComboBox
            // 
            this.MemoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryComboBox.FormattingEnabled = true;
            this.MemoryComboBox.Location = new System.Drawing.Point(181, 121);
            this.MemoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryComboBox.Name = "MemoryComboBox";
            this.MemoryComboBox.Size = new System.Drawing.Size(160, 28);
            this.MemoryComboBox.TabIndex = 11;
            // 
            // ResoliutionComboBox
            // 
            this.ResoliutionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResoliutionComboBox.FormattingEnabled = true;
            this.ResoliutionComboBox.Location = new System.Drawing.Point(181, 158);
            this.ResoliutionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResoliutionComboBox.Name = "ResoliutionComboBox";
            this.ResoliutionComboBox.Size = new System.Drawing.Size(160, 28);
            this.ResoliutionComboBox.TabIndex = 10;
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(181, 194);
            this.StorageComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(160, 28);
            this.StorageComboBox.TabIndex = 9;
            // 
            // ScreenSizeComboBox
            // 
            this.ScreenSizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenSizeComboBox.FormattingEnabled = true;
            this.ScreenSizeComboBox.Location = new System.Drawing.Point(181, 231);
            this.ScreenSizeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScreenSizeComboBox.Name = "ScreenSizeComboBox";
            this.ScreenSizeComboBox.Size = new System.Drawing.Size(160, 28);
            this.ScreenSizeComboBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Storage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Resoliution::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Screen size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ram:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Camera:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cores:";
            // 
            // BatteryLabel
            // 
            this.BatteryLabel.AutoSize = true;
            this.BatteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLabel.Location = new System.Drawing.Point(4, 14);
            this.BatteryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BatteryLabel.Name = "BatteryLabel";
            this.BatteryLabel.Size = new System.Drawing.Size(68, 20);
            this.BatteryLabel.TabIndex = 1;
            this.BatteryLabel.Text = "Battery:";
            // 
            // BatteryComboBox
            // 
            this.BatteryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryComboBox.FormattingEnabled = true;
            this.BatteryComboBox.Location = new System.Drawing.Point(181, 10);
            this.BatteryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BatteryComboBox.Name = "BatteryComboBox";
            this.BatteryComboBox.Size = new System.Drawing.Size(160, 28);
            this.BatteryComboBox.TabIndex = 0;
            // 
            // PhoneDataGrid
            // 
            this.PhoneDataGrid.AllowUserToAddRows = false;
            this.PhoneDataGrid.AllowUserToDeleteRows = false;
            this.PhoneDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhoneDataGrid.Location = new System.Drawing.Point(4, 4);
            this.PhoneDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneDataGrid.Name = "PhoneDataGrid";
            this.PhoneDataGrid.ReadOnly = true;
            this.PhoneDataGrid.Size = new System.Drawing.Size(852, 506);
            this.PhoneDataGrid.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PhonePage);
            this.TabControl.Controls.Add(this.AprioriPage);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(0, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1240, 708);
            this.TabControl.TabIndex = 1;
            // 
            // PhonePage
            // 
            this.PhonePage.Controls.Add(this.tableLayoutPanel1);
            this.PhonePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PhonePage.Location = new System.Drawing.Point(4, 25);
            this.PhonePage.Name = "PhonePage";
            this.PhonePage.Size = new System.Drawing.Size(1232, 679);
            this.PhonePage.TabIndex = 0;
            this.PhonePage.Text = "Phone selection";
            this.PhonePage.UseVisualStyleBackColor = true;
            // 
            // AprioriPage
            // 
            this.AprioriPage.BackColor = System.Drawing.Color.DarkGray;
            this.AprioriPage.Controls.Add(this.AprioriCalculation);
            this.AprioriPage.Controls.Add(this.AprioriDataMining);
            this.AprioriPage.Controls.Add(this.AprioriCollection);
            this.AprioriPage.Controls.Add(this.AprioriData);
            this.AprioriPage.Controls.Add(this.AprioriBrowse);
            this.AprioriPage.Controls.Add(this.AprioriMine);
            this.AprioriPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AprioriPage.Location = new System.Drawing.Point(4, 25);
            this.AprioriPage.Name = "AprioriPage";
            this.AprioriPage.Padding = new System.Windows.Forms.Padding(3);
            this.AprioriPage.Size = new System.Drawing.Size(1232, 679);
            this.AprioriPage.TabIndex = 1;
            this.AprioriPage.Text = "Apriori";
            // 
            // AprioriMine
            // 
            this.AprioriMine.FormattingEnabled = true;
            this.AprioriMine.ItemHeight = 25;
            this.AprioriMine.Location = new System.Drawing.Point(335, 7);
            this.AprioriMine.Name = "AprioriMine";
            this.AprioriMine.Size = new System.Drawing.Size(889, 254);
            this.AprioriMine.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 679);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NaN";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AprioriBrowse
            // 
            this.AprioriBrowse.Location = new System.Drawing.Point(8, 7);
            this.AprioriBrowse.Name = "AprioriBrowse";
            this.AprioriBrowse.Size = new System.Drawing.Size(153, 39);
            this.AprioriBrowse.TabIndex = 1;
            this.AprioriBrowse.Text = "Browse";
            this.AprioriBrowse.UseVisualStyleBackColor = true;
            this.AprioriBrowse.Click += new System.EventHandler(this.AprioriBrowse_Click);
            // 
            // AprioriData
            // 
            this.AprioriData.FormattingEnabled = true;
            this.AprioriData.ItemHeight = 25;
            this.AprioriData.Location = new System.Drawing.Point(8, 52);
            this.AprioriData.Name = "AprioriData";
            this.AprioriData.Size = new System.Drawing.Size(321, 604);
            this.AprioriData.TabIndex = 2;
            // 
            // AprioriCollection
            // 
            this.AprioriCollection.FormattingEnabled = true;
            this.AprioriCollection.ItemHeight = 25;
            this.AprioriCollection.Location = new System.Drawing.Point(335, 338);
            this.AprioriCollection.Name = "AprioriCollection";
            this.AprioriCollection.Size = new System.Drawing.Size(879, 254);
            this.AprioriCollection.TabIndex = 3;
            // 
            // AprioriDataMining
            // 
            this.AprioriDataMining.Location = new System.Drawing.Point(336, 268);
            this.AprioriDataMining.Name = "AprioriDataMining";
            this.AprioriDataMining.Size = new System.Drawing.Size(166, 37);
            this.AprioriDataMining.TabIndex = 4;
            this.AprioriDataMining.Text = "Data Mining";
            this.AprioriDataMining.UseVisualStyleBackColor = true;
            this.AprioriDataMining.Click += new System.EventHandler(this.AprioriDataMining_Click);
            // 
            // AprioriCalculation
            // 
            this.AprioriCalculation.Location = new System.Drawing.Point(336, 599);
            this.AprioriCalculation.Name = "AprioriCalculation";
            this.AprioriCalculation.Size = new System.Drawing.Size(166, 45);
            this.AprioriCalculation.TabIndex = 5;
            this.AprioriCalculation.Text = "Calculate";
            this.AprioriCalculation.UseVisualStyleBackColor = true;
            this.AprioriCalculation.Click += new System.EventHandler(this.AprioriCalculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1240, 720);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDataGrid)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.PhonePage.ResumeLayout(false);
            this.AprioriPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox BatteryComboBox;
        private System.Windows.Forms.DataGridView PhoneDataGrid;
        private System.Windows.Forms.Label BatteryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CPUCoreComboBox;
        private System.Windows.Forms.ComboBox CameraComboBox;
        private System.Windows.Forms.ComboBox MemoryComboBox;
        private System.Windows.Forms.ComboBox ResoliutionComboBox;
        private System.Windows.Forms.ComboBox StorageComboBox;
        private System.Windows.Forms.ComboBox ScreenSizeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AnalysisLength;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage PhonePage;
        private System.Windows.Forms.TabPage AprioriPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox AprioriMine;
        private System.Windows.Forms.Button AprioriBrowse;
        private System.Windows.Forms.ListBox AprioriData;
        private System.Windows.Forms.Button AprioriDataMining;
        private System.Windows.Forms.ListBox AprioriCollection;
        private System.Windows.Forms.Button AprioriCalculation;
    }
}

