namespace Shemet_Non_linear_equation
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RelaxationOptionButton = new System.Windows.Forms.RadioButton();
            this.SimpleIterationOptionButton = new System.Windows.Forms.RadioButton();
            this.NewtonModOptionButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IterationsListBox = new System.Windows.Forms.ListBox();
            this.FindRootButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RelaxationOptionButton);
            this.groupBox1.Controls.Add(this.SimpleIterationOptionButton);
            this.groupBox1.Controls.Add(this.NewtonModOptionButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 181);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Method";
            // 
            // RelaxationOptionButton
            // 
            this.RelaxationOptionButton.AutoSize = true;
            this.RelaxationOptionButton.Location = new System.Drawing.Point(14, 81);
            this.RelaxationOptionButton.Name = "RelaxationOptionButton";
            this.RelaxationOptionButton.Size = new System.Drawing.Size(136, 34);
            this.RelaxationOptionButton.TabIndex = 7;
            this.RelaxationOptionButton.Text = "Relaxation";
            this.RelaxationOptionButton.UseVisualStyleBackColor = true;
            // 
            // SimpleIterationOptionButton
            // 
            this.SimpleIterationOptionButton.AutoSize = true;
            this.SimpleIterationOptionButton.Checked = true;
            this.SimpleIterationOptionButton.Location = new System.Drawing.Point(14, 41);
            this.SimpleIterationOptionButton.Name = "SimpleIterationOptionButton";
            this.SimpleIterationOptionButton.Size = new System.Drawing.Size(190, 34);
            this.SimpleIterationOptionButton.TabIndex = 7;
            this.SimpleIterationOptionButton.TabStop = true;
            this.SimpleIterationOptionButton.Text = "Simple iteration";
            this.SimpleIterationOptionButton.UseVisualStyleBackColor = true;
            // 
            // NewtonModOptionButton
            // 
            this.NewtonModOptionButton.AutoSize = true;
            this.NewtonModOptionButton.Location = new System.Drawing.Point(14, 121);
            this.NewtonModOptionButton.Name = "NewtonModOptionButton";
            this.NewtonModOptionButton.Size = new System.Drawing.Size(114, 34);
            this.NewtonModOptionButton.TabIndex = 0;
            this.NewtonModOptionButton.Text = "Newton";
            this.NewtonModOptionButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Initial approximation";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(17, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 37);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "0,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Accuracy";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(17, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 37);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0,0001";
            // 
            // IterationsListBox
            // 
            this.IterationsListBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IterationsListBox.FormattingEnabled = true;
            this.IterationsListBox.ItemHeight = 30;
            this.IterationsListBox.Location = new System.Drawing.Point(289, 12);
            this.IterationsListBox.Name = "IterationsListBox";
            this.IterationsListBox.Size = new System.Drawing.Size(1011, 784);
            this.IterationsListBox.TabIndex = 19;
            // 
            // FindRootButton
            // 
            this.FindRootButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindRootButton.Location = new System.Drawing.Point(17, 12);
            this.FindRootButton.Name = "FindRootButton";
            this.FindRootButton.Size = new System.Drawing.Size(253, 99);
            this.FindRootButton.TabIndex = 18;
            this.FindRootButton.Text = "Find root";
            this.FindRootButton.UseVisualStyleBackColor = true;
            this.FindRootButton.Click += new System.EventHandler(this.FindRootButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 815);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IterationsListBox);
            this.Controls.Add(this.FindRootButton);
            this.Name = "MainForm";
            this.Text = "Lab 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RelaxationOptionButton;
        private RadioButton SimpleIterationOptionButton;
        private RadioButton NewtonModOptionButton;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private ListBox IterationsListBox;
        private Button FindRootButton;
    }
}