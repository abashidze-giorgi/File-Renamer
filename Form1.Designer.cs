namespace File_Renamer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_numbers = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_ext_list = new System.Windows.Forms.CheckedListBox();
            this.chk_ext = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_symb = new System.Windows.Forms.Panel();
            this.cmb_sym = new System.Windows.Forms.ComboBox();
            this.lbl_bef_aft = new System.Windows.Forms.Label();
            this.txt_beaf_1 = new System.Windows.Forms.TextBox();
            this.txt_beaf_2 = new System.Windows.Forms.TextBox();
            this.check_add_sym = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_folder = new System.Windows.Forms.Button();
            this.lbl_folder = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_rename = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_symb.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.47929F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.52071F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_rename, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Controls.Add(this.panel2);
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(525, 53);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(486, 453);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_numbers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 41);
            this.panel1.TabIndex = 4;
            // 
            // chk_numbers
            // 
            this.chk_numbers.AutoSize = true;
            this.chk_numbers.Location = new System.Drawing.Point(250, 5);
            this.chk_numbers.Name = "chk_numbers";
            this.chk_numbers.Size = new System.Drawing.Size(15, 14);
            this.chk_numbers.TabIndex = 4;
            this.chk_numbers.UseVisualStyleBackColor = true;
            this.chk_numbers.CheckedChanged += new System.EventHandler(this.chk_numbers_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rename To Numbers 1...99...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chk_ext_list);
            this.panel2.Controls.Add(this.chk_ext);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 152);
            this.panel2.TabIndex = 5;
            // 
            // chk_ext_list
            // 
            this.chk_ext_list.FormattingEnabled = true;
            this.chk_ext_list.Location = new System.Drawing.Point(6, 36);
            this.chk_ext_list.Name = "chk_ext_list";
            this.chk_ext_list.Size = new System.Drawing.Size(259, 109);
            this.chk_ext_list.TabIndex = 5;
            // 
            // chk_ext
            // 
            this.chk_ext.AutoSize = true;
            this.chk_ext.Location = new System.Drawing.Point(250, 4);
            this.chk_ext.Name = "chk_ext";
            this.chk_ext.Size = new System.Drawing.Size(15, 14);
            this.chk_ext.TabIndex = 4;
            this.chk_ext.UseVisualStyleBackColor = true;
            this.chk_ext.CheckedChanged += new System.EventHandler(this.chk_ext_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rename Files With Extension Only";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnl_symb);
            this.panel3.Controls.Add(this.check_add_sym);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 133);
            this.panel3.TabIndex = 6;
            // 
            // pnl_symb
            // 
            this.pnl_symb.Controls.Add(this.cmb_sym);
            this.pnl_symb.Controls.Add(this.lbl_bef_aft);
            this.pnl_symb.Controls.Add(this.txt_beaf_1);
            this.pnl_symb.Controls.Add(this.txt_beaf_2);
            this.pnl_symb.Location = new System.Drawing.Point(3, 25);
            this.pnl_symb.Name = "pnl_symb";
            this.pnl_symb.Size = new System.Drawing.Size(367, 100);
            this.pnl_symb.TabIndex = 8;
            // 
            // cmb_sym
            // 
            this.cmb_sym.FormattingEnabled = true;
            this.cmb_sym.Items.AddRange(new object[] {
            "Before",
            "After",
            "Before and After"});
            this.cmb_sym.Location = new System.Drawing.Point(3, 3);
            this.cmb_sym.Name = "cmb_sym";
            this.cmb_sym.Size = new System.Drawing.Size(360, 21);
            this.cmb_sym.TabIndex = 5;
            this.cmb_sym.SelectedIndexChanged += new System.EventHandler(this.cmb_sym_SelectedIndexChanged);
            // 
            // lbl_bef_aft
            // 
            this.lbl_bef_aft.AutoSize = true;
            this.lbl_bef_aft.Location = new System.Drawing.Point(159, 35);
            this.lbl_bef_aft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbl_bef_aft.Name = "lbl_bef_aft";
            this.lbl_bef_aft.Size = new System.Drawing.Size(42, 13);
            this.lbl_bef_aft.TabIndex = 7;
            this.lbl_bef_aft.Text = "+ name";
            // 
            // txt_beaf_1
            // 
            this.txt_beaf_1.Location = new System.Drawing.Point(3, 30);
            this.txt_beaf_1.Name = "txt_beaf_1";
            this.txt_beaf_1.Size = new System.Drawing.Size(146, 20);
            this.txt_beaf_1.TabIndex = 6;
            // 
            // txt_beaf_2
            // 
            this.txt_beaf_2.Location = new System.Drawing.Point(216, 30);
            this.txt_beaf_2.Name = "txt_beaf_2";
            this.txt_beaf_2.Size = new System.Drawing.Size(147, 20);
            this.txt_beaf_2.TabIndex = 6;
            // 
            // check_add_sym
            // 
            this.check_add_sym.AutoSize = true;
            this.check_add_sym.Location = new System.Drawing.Point(250, 5);
            this.check_add_sym.Name = "check_add_sym";
            this.check_add_sym.Size = new System.Drawing.Size(15, 14);
            this.check_add_sym.TabIndex = 4;
            this.check_add_sym.UseVisualStyleBackColor = true;
            this.check_add_sym.CheckedChanged += new System.EventHandler(this.check_add_sym_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add Symbols";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(525, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(486, 44);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rename Parameters";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_folder);
            this.flowLayoutPanel1.Controls.Add(this.lbl_folder);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(516, 44);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(3, 3);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_folder.TabIndex = 0;
            this.btn_folder.Text = "Folder";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // lbl_folder
            // 
            this.lbl_folder.AutoSize = true;
            this.lbl_folder.Location = new System.Drawing.Point(84, 5);
            this.lbl_folder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbl_folder.Name = "lbl_folder";
            this.lbl_folder.Size = new System.Drawing.Size(16, 13);
            this.lbl_folder.TabIndex = 1;
            this.lbl_folder.Text = "...";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 453);
            this.listBox1.TabIndex = 2;
            // 
            // btn_rename
            // 
            this.btn_rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rename.Location = new System.Drawing.Point(525, 512);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(189, 45);
            this.btn_rename.TabIndex = 4;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_symb.ResumeLayout(false);
            this.pnl_symb.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Label lbl_folder;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_numbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox chk_ext_list;
        private System.Windows.Forms.CheckBox chk_ext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_symb;
        private System.Windows.Forms.ComboBox cmb_sym;
        private System.Windows.Forms.Label lbl_bef_aft;
        private System.Windows.Forms.TextBox txt_beaf_1;
        private System.Windows.Forms.TextBox txt_beaf_2;
        private System.Windows.Forms.CheckBox check_add_sym;
        private System.Windows.Forms.Label label4;
    }
}

