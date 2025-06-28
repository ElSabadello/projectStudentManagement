namespace projectStudentManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ViewGrid_bt = new Button();
            Insert_bt = new Button();
            Update_bt = new Button();
            button3 = new Button();
            button4 = new Button();
            RegNo_tx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Name_tx = new TextBox();
            Address_tx = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(781, 237);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ViewGrid_bt
            // 
            ViewGrid_bt.Location = new Point(12, 346);
            ViewGrid_bt.Name = "ViewGrid_bt";
            ViewGrid_bt.Size = new Size(94, 29);
            ViewGrid_bt.TabIndex = 1;
            ViewGrid_bt.Text = "View";
            ViewGrid_bt.UseVisualStyleBackColor = true;
            ViewGrid_bt.Click += ViewGrid_bt_Click;
            // 
            // Insert_bt
            // 
            Insert_bt.Location = new Point(112, 346);
            Insert_bt.Name = "Insert_bt";
            Insert_bt.Size = new Size(94, 29);
            Insert_bt.TabIndex = 2;
            Insert_bt.Text = "Insert";
            Insert_bt.UseVisualStyleBackColor = true;
            Insert_bt.Click += Insert_bt_Click;
            // 
            // Update_bt
            // 
            Update_bt.Location = new Point(212, 346);
            Update_bt.Name = "Update_bt";
            Update_bt.Size = new Size(94, 29);
            Update_bt.TabIndex = 3;
            Update_bt.Text = "Update";
            Update_bt.UseVisualStyleBackColor = true;
            Update_bt.Click += Update_bt_Click;
            // 
            // button3
            // 
            button3.Location = new Point(312, 346);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(412, 346);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = true;
            // 
            // RegNo_tx
            // 
            RegNo_tx.Location = new Point(12, 277);
            RegNo_tx.Name = "RegNo_tx";
            RegNo_tx.Size = new Size(173, 27);
            RegNo_tx.TabIndex = 15;
            RegNo_tx.TextChanged += RegNo_tx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 254);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 10;
            label1.Text = "Reg No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 254);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 11;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 254);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 12;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // Name_tx
            // 
            Name_tx.Location = new Point(191, 277);
            Name_tx.Name = "Name_tx";
            Name_tx.Size = new Size(173, 27);
            Name_tx.TabIndex = 13;
            // 
            // Address_tx
            // 
            Address_tx.Location = new Point(370, 277);
            Address_tx.Name = "Address_tx";
            Address_tx.Size = new Size(173, 27);
            Address_tx.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(Address_tx);
            Controls.Add(Name_tx);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegNo_tx);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Update_bt);
            Controls.Add(Insert_bt);
            Controls.Add(ViewGrid_bt);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ViewGrid_bt;
        private Button Insert_bt;
        private Button Update_bt;
        private Button button3;
        private Button button4;
        private TextBox RegNo_tx;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Name_tx;
        private TextBox Address_tx;
    }
}
