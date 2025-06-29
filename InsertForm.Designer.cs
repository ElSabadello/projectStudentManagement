namespace projectStudentManagement
{
    partial class InsertForm
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
            RegNo_tx = new TextBox();
            Name_tx = new TextBox();
            Address_tx = new TextBox();
            Save_bt = new Button();
            Cancel_bt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // RegNo_tx
            // 
            RegNo_tx.Location = new Point(36, 58);
            RegNo_tx.Name = "RegNo_tx";
            RegNo_tx.Size = new Size(125, 27);
            RegNo_tx.TabIndex = 0;
            // 
            // Name_tx
            // 
            Name_tx.Location = new Point(167, 58);
            Name_tx.Name = "Name_tx";
            Name_tx.Size = new Size(125, 27);
            Name_tx.TabIndex = 1;
            // 
            // Address_tx
            // 
            Address_tx.Location = new Point(298, 58);
            Address_tx.Name = "Address_tx";
            Address_tx.Size = new Size(125, 27);
            Address_tx.TabIndex = 2;
            // 
            // Save_bt
            // 
            Save_bt.Location = new Point(229, 104);
            Save_bt.Name = "Save_bt";
            Save_bt.Size = new Size(94, 29);
            Save_bt.TabIndex = 3;
            Save_bt.Text = "Save";
            Save_bt.UseVisualStyleBackColor = true;
            Save_bt.Click += Save_bt_Click;
            // 
            // Cancel_bt
            // 
            Cancel_bt.Location = new Point(329, 104);
            Cancel_bt.Name = "Cancel_bt";
            Cancel_bt.Size = new Size(94, 29);
            Cancel_bt.TabIndex = 4;
            Cancel_bt.Text = "Cancel";
            Cancel_bt.UseVisualStyleBackColor = true;
            Cancel_bt.Click += Cancel_bt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "Reg No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 35);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // InsertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 151);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cancel_bt);
            Controls.Add(Save_bt);
            Controls.Add(Address_tx);
            Controls.Add(Name_tx);
            Controls.Add(RegNo_tx);
            Name = "InsertForm";
            Text = "InsertForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegNo_tx;
        private TextBox Name_tx;
        private TextBox Address_tx;
        private Button Save_bt;
        private Button Cancel_bt;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}