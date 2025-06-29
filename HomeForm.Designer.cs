namespace projectStudentManagement
{
    partial class HomeForm
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
            dataGridView1 = new DataGridView();
            Add_bt = new Button();
            Update_bt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(583, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Add_bt
            // 
            Add_bt.Font = new Font("Segoe UI", 13F);
            Add_bt.Location = new Point(12, 12);
            Add_bt.Name = "Add_bt";
            Add_bt.Size = new Size(121, 56);
            Add_bt.TabIndex = 1;
            Add_bt.Text = "Add";
            Add_bt.UseVisualStyleBackColor = true;
            Add_bt.Click += Add_bt_Click;
            // 
            // Update_bt
            // 
            Update_bt.Font = new Font("Segoe UI", 13F);
            Update_bt.Location = new Point(12, 74);
            Update_bt.Name = "Update_bt";
            Update_bt.Size = new Size(121, 56);
            Update_bt.TabIndex = 2;
            Update_bt.Text = "Update";
            Update_bt.UseVisualStyleBackColor = true;
            Update_bt.Click += Update_bt_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Update_bt);
            Controls.Add(Add_bt);
            Controls.Add(dataGridView1);
            Name = "HomeForm";
            Text = "Student Management - HOME";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Add_bt;
        private Button Update_bt;
    }
}