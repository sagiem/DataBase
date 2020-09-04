namespace WindowsFormsApp2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataBoxAdd = new System.Windows.Forms.DateTimePicker();
            this.ContractBoxAdd = new System.Windows.Forms.TextBox();
            this.NameBoxAdd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Договор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата";
            // 
            // DataBoxAdd
            // 
            this.DataBoxAdd.Location = new System.Drawing.Point(120, 139);
            this.DataBoxAdd.Name = "DataBoxAdd";
            this.DataBoxAdd.Size = new System.Drawing.Size(249, 22);
            this.DataBoxAdd.TabIndex = 3;
            // 
            // ContractBoxAdd
            // 
            this.ContractBoxAdd.Location = new System.Drawing.Point(120, 94);
            this.ContractBoxAdd.Name = "ContractBoxAdd";
            this.ContractBoxAdd.Size = new System.Drawing.Size(249, 22);
            this.ContractBoxAdd.TabIndex = 4;
            // 
            // NameBoxAdd
            // 
            this.NameBoxAdd.Location = new System.Drawing.Point(120, 44);
            this.NameBoxAdd.Name = "NameBoxAdd";
            this.NameBoxAdd.Size = new System.Drawing.Size(249, 22);
            this.NameBoxAdd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(664, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameBoxAdd);
            this.Controls.Add(this.ContractBoxAdd);
            this.Controls.Add(this.DataBoxAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DataBoxAdd;
        private System.Windows.Forms.TextBox ContractBoxAdd;
        private System.Windows.Forms.TextBox NameBoxAdd;
        private System.Windows.Forms.Button button1;
    }
}

