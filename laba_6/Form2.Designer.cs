namespace laba_6
{
    partial class Form2
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
            this.one = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 12);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(276, 20);
            this.one.TabIndex = 0;
            this.one.TextChanged += new System.EventHandler(this.one_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 38);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(276, 40);
            this.add.TabIndex = 6;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(295, 12);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(266, 303);
            this.result.TabIndex = 7;
            this.result.Text = "";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(13, 84);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(276, 231);
            this.sort.TabIndex = 8;
            this.sort.Text = "сортировать";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 327);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.result);
            this.Controls.Add(this.add);
            this.Controls.Add(this.one);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button sort;
    }
}