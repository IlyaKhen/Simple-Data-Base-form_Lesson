namespace Lesson_8_SQL_ADO_NET
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
            this.comboBoxCites = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddName = new System.Windows.Forms.Button();
            this.txtBoxNames = new System.Windows.Forms.TextBox();
            this.btnPdfTable = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCites
            // 
            this.comboBoxCites.FormattingEnabled = true;
            this.comboBoxCites.Location = new System.Drawing.Point(279, 72);
            this.comboBoxCites.Name = "comboBoxCites";
            this.comboBoxCites.Size = new System.Drawing.Size(223, 24);
            this.comboBoxCites.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(394, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(649, 347);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(139, 65);
            this.btnCls.TabIndex = 3;
            this.btnCls.Text = "Close";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Names:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cities:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 362);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPdfTable);
            this.tabPage1.Controls.Add(this.listBoxNames);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxCites);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 16;
            this.listBoxNames.Location = new System.Drawing.Point(26, 72);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(224, 244);
            this.listBoxNames.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Names:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddCity);
            this.tabPage2.Controls.Add(this.txtBoxCity);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "City";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(193, 137);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(136, 37);
            this.btnAddCity.TabIndex = 4;
            this.btnAddCity.Text = "Add";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(173, 89);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(172, 22);
            this.txtBoxCity.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddName);
            this.tabPage3.Controls.Add(this.txtBoxNames);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(519, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Names";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(193, 137);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(136, 37);
            this.btnAddName.TabIndex = 3;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // txtBoxNames
            // 
            this.txtBoxNames.Location = new System.Drawing.Point(173, 89);
            this.txtBoxNames.Name = "txtBoxNames";
            this.txtBoxNames.Size = new System.Drawing.Size(172, 22);
            this.txtBoxNames.TabIndex = 1;
            // 
            // btnPdfTable
            // 
            this.btnPdfTable.Location = new System.Drawing.Point(394, 207);
            this.btnPdfTable.Name = "btnPdfTable";
            this.btnPdfTable.Size = new System.Drawing.Size(108, 44);
            this.btnPdfTable.TabIndex = 9;
            this.btnPdfTable.Text = "Get PDF Table";
            this.btnPdfTable.UseVisualStyleBackColor = true;
            this.btnPdfTable.Click += new System.EventHandler(this.btnPdfTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCites;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox txtBoxNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Button btnPdfTable;
    }
}

