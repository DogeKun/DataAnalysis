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
            this.PhoneDataGrid = new System.Windows.Forms.DataGridView();
            this.BatteryComboBox = new System.Windows.Forms.ComboBox();
            this.BatteryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ScreenSizeComboBox = new System.Windows.Forms.ComboBox();
            this.StorageComboBox = new System.Windows.Forms.ComboBox();
            this.ResoliutionComboBox = new System.Windows.Forms.ComboBox();
            this.MemoryComboBox = new System.Windows.Forms.ComboBox();
            this.CameraComboBox = new System.Windows.Forms.ComboBox();
            this.CPUCoreComboBox = new System.Windows.Forms.ComboBox();
            this.AnalysisLength = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PhoneDataGrid, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 537);
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
            this.panel2.Location = new System.Drawing.Point(497, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(260, 531);
            this.panel2.TabIndex = 0;
            // 
            // PhoneDataGrid
            // 
            this.PhoneDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhoneDataGrid.Location = new System.Drawing.Point(3, 3);
            this.PhoneDataGrid.Name = "PhoneDataGrid";
            this.PhoneDataGrid.Size = new System.Drawing.Size(488, 396);
            this.PhoneDataGrid.TabIndex = 1;
            // 
            // BatteryComboBox
            // 
            this.BatteryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryComboBox.FormattingEnabled = true;
            this.BatteryComboBox.Location = new System.Drawing.Point(136, 8);
            this.BatteryComboBox.Name = "BatteryComboBox";
            this.BatteryComboBox.Size = new System.Drawing.Size(121, 24);
            this.BatteryComboBox.TabIndex = 0;
            // 
            // BatteryLabel
            // 
            this.BatteryLabel.AutoSize = true;
            this.BatteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatteryLabel.Location = new System.Drawing.Point(3, 11);
            this.BatteryLabel.Name = "BatteryLabel";
            this.BatteryLabel.Size = new System.Drawing.Size(53, 16);
            this.BatteryLabel.TabIndex = 1;
            this.BatteryLabel.Text = "Battery:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Camera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ram:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Screen size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Resoliution::";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Storage:";
            // 
            // ScreenSizeComboBox
            // 
            this.ScreenSizeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenSizeComboBox.FormattingEnabled = true;
            this.ScreenSizeComboBox.Location = new System.Drawing.Point(136, 188);
            this.ScreenSizeComboBox.Name = "ScreenSizeComboBox";
            this.ScreenSizeComboBox.Size = new System.Drawing.Size(121, 24);
            this.ScreenSizeComboBox.TabIndex = 8;
            // 
            // StorageComboBox
            // 
            this.StorageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StorageComboBox.FormattingEnabled = true;
            this.StorageComboBox.Location = new System.Drawing.Point(136, 158);
            this.StorageComboBox.Name = "StorageComboBox";
            this.StorageComboBox.Size = new System.Drawing.Size(121, 24);
            this.StorageComboBox.TabIndex = 9;
            // 
            // ResoliutionComboBox
            // 
            this.ResoliutionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResoliutionComboBox.FormattingEnabled = true;
            this.ResoliutionComboBox.Location = new System.Drawing.Point(136, 128);
            this.ResoliutionComboBox.Name = "ResoliutionComboBox";
            this.ResoliutionComboBox.Size = new System.Drawing.Size(121, 24);
            this.ResoliutionComboBox.TabIndex = 10;
            // 
            // MemoryComboBox
            // 
            this.MemoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryComboBox.FormattingEnabled = true;
            this.MemoryComboBox.Location = new System.Drawing.Point(136, 98);
            this.MemoryComboBox.Name = "MemoryComboBox";
            this.MemoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.MemoryComboBox.TabIndex = 11;
            // 
            // CameraComboBox
            // 
            this.CameraComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CameraComboBox.FormattingEnabled = true;
            this.CameraComboBox.Location = new System.Drawing.Point(136, 68);
            this.CameraComboBox.Name = "CameraComboBox";
            this.CameraComboBox.Size = new System.Drawing.Size(121, 24);
            this.CameraComboBox.TabIndex = 12;
            // 
            // CPUCoreComboBox
            // 
            this.CPUCoreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUCoreComboBox.FormattingEnabled = true;
            this.CPUCoreComboBox.Location = new System.Drawing.Point(136, 38);
            this.CPUCoreComboBox.Name = "CPUCoreComboBox";
            this.CPUCoreComboBox.Size = new System.Drawing.Size(121, 24);
            this.CPUCoreComboBox.TabIndex = 13;
            // 
            // AnalysisLength
            // 
            this.AnalysisLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalysisLength.Location = new System.Drawing.Point(161, 505);
            this.AnalysisLength.Name = "AnalysisLength";
            this.AnalysisLength.Size = new System.Drawing.Size(95, 23);
            this.AnalysisLength.TabIndex = 14;
            this.AnalysisLength.Text = "Find";
            this.AnalysisLength.UseVisualStyleBackColor = true;
            this.AnalysisLength.Click += new System.EventHandler(this.AnalysisLength_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDataGrid)).EndInit();
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
    }
}

