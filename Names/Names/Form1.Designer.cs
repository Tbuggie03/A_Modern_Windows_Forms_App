namespace Names
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
            lstNames = new ListBox();
            label1 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 15;
            lstNames.Location = new Point(8, 22);
            lstNames.Margin = new Padding(2, 2, 2, 2);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(85, 79);
            lstNames.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Names";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 16);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(71, 23);
            txtName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(97, 33);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 20);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lstNames);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNames;
        private Label label1;
        private TextBox txtName;
        private Button btnAdd;
    }
}
