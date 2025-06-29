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
            label1 = new Label();
            RegNo_tx = new TextBox();
            Save_bt = new Button();
            Name_tx = new TextBox();
            label2 = new Label();
            Aaddress_tx = new TextBox();
            label3 = new Label();
            Cancel_bt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Reg No.";
            // 
            // RegNo_tx
            // 
            RegNo_tx.Location = new Point(12, 32);
            RegNo_tx.Name = "RegNo_tx";
            RegNo_tx.Size = new Size(179, 27);
            RegNo_tx.TabIndex = 1;
            // 
            // Save_bt
            // 
            Save_bt.Location = new Point(367, 77);
            Save_bt.Name = "Save_bt";
            Save_bt.Size = new Size(94, 29);
            Save_bt.TabIndex = 2;
            Save_bt.Text = "Save";
            Save_bt.UseVisualStyleBackColor = true;
            // 
            // Name_tx
            // 
            Name_tx.Location = new Point(197, 32);
            Name_tx.Name = "Name_tx";
            Name_tx.Size = new Size(179, 27);
            Name_tx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 9);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // Aaddress_tx
            // 
            Aaddress_tx.Location = new Point(382, 32);
            Aaddress_tx.Name = "Aaddress_tx";
            Aaddress_tx.Size = new Size(179, 27);
            Aaddress_tx.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 9);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // Cancel_bt
            // 
            Cancel_bt.Location = new Point(467, 77);
            Cancel_bt.Name = "Cancel_bt";
            Cancel_bt.Size = new Size(94, 29);
            Cancel_bt.TabIndex = 7;
            Cancel_bt.Text = "Cancel";
            Cancel_bt.UseVisualStyleBackColor = true;
            // 
            // InsertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 126);
            Controls.Add(Cancel_bt);
            Controls.Add(Aaddress_tx);
            Controls.Add(label3);
            Controls.Add(Name_tx);
            Controls.Add(label2);
            Controls.Add(Save_bt);
            Controls.Add(RegNo_tx);
            Controls.Add(label1);
            Name = "InsertForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RegNo_tx;
        private Button Save_bt;
        private TextBox Name_tx;
        private Label label2;
        private TextBox Aaddress_tx;
        private Label label3;
        private Button Cancel_bt;
    }
}