namespace laba_6
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
            this.variable = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.sorts = new System.Windows.Forms.Button();
            this.array_list_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variable
            // 
            this.variable.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variable.Location = new System.Drawing.Point(12, 12);
            this.variable.Name = "variable";
            this.variable.Size = new System.Drawing.Size(277, 74);
            this.variable.TabIndex = 0;
            this.variable.TextChanged += new System.EventHandler(this.variable_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(277, 39);
            this.add.TabIndex = 1;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(295, 12);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(283, 159);
            this.result.TabIndex = 2;
            this.result.Text = "";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // sorts
            // 
            this.sorts.Location = new System.Drawing.Point(12, 134);
            this.sorts.Name = "sorts";
            this.sorts.Size = new System.Drawing.Size(277, 39);
            this.sorts.TabIndex = 3;
            this.sorts.Text = "сортировать";
            this.sorts.UseVisualStyleBackColor = true;
            this.sorts.Click += new System.EventHandler(this.sorts_Click);
            // 
            // array_list_view
            // 
            this.array_list_view.Location = new System.Drawing.Point(12, 179);
            this.array_list_view.Name = "array_list_view";
            this.array_list_view.Size = new System.Drawing.Size(566, 39);
            this.array_list_view.TabIndex = 4;
            this.array_list_view.Text = "Призвать в этот мир Array List";
            this.array_list_view.UseVisualStyleBackColor = true;
            this.array_list_view.Click += new System.EventHandler(this.array_list_view_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 224);
            this.Controls.Add(this.array_list_view);
            this.Controls.Add(this.sorts);
            this.Controls.Add(this.result);
            this.Controls.Add(this.add);
            this.Controls.Add(this.variable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "sortlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox variable;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button sorts;
        private System.Windows.Forms.Button array_list_view;
    }
}

