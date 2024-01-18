namespace convert_temperature
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Temp = new System.Windows.Forms.TextBox();
            this.txt_Eq = new System.Windows.Forms.TextBox();
            this.rbtn_Fe = new System.Windows.Forms.RadioButton();
            this.rbtn_Celsius = new System.Windows.Forms.RadioButton();
            this.btn_Con = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "equals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "degrees";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Temp
            // 
            this.txt_Temp.Location = new System.Drawing.Point(131, 127);
            this.txt_Temp.Name = "txt_Temp";
            this.txt_Temp.Size = new System.Drawing.Size(100, 22);
            this.txt_Temp.TabIndex = 3;
            // 
            // txt_Eq
            // 
            this.txt_Eq.Location = new System.Drawing.Point(131, 229);
            this.txt_Eq.Name = "txt_Eq";
            this.txt_Eq.Size = new System.Drawing.Size(100, 22);
            this.txt_Eq.TabIndex = 4;
            // 
            // rbtn_Fe
            // 
            this.rbtn_Fe.AutoSize = true;
            this.rbtn_Fe.Location = new System.Drawing.Point(307, 137);
            this.rbtn_Fe.Name = "rbtn_Fe";
            this.rbtn_Fe.Size = new System.Drawing.Size(94, 20);
            this.rbtn_Fe.TabIndex = 5;
            this.rbtn_Fe.TabStop = true;
            this.rbtn_Fe.Text = "Fahrenhieit";
            this.rbtn_Fe.UseVisualStyleBackColor = true;
            // 
            // rbtn_Celsius
            // 
            this.rbtn_Celsius.AutoSize = true;
            this.rbtn_Celsius.Location = new System.Drawing.Point(429, 137);
            this.rbtn_Celsius.Name = "rbtn_Celsius";
            this.rbtn_Celsius.Size = new System.Drawing.Size(72, 20);
            this.rbtn_Celsius.TabIndex = 6;
            this.rbtn_Celsius.TabStop = true;
            this.rbtn_Celsius.Text = "Celsius";
            this.rbtn_Celsius.UseVisualStyleBackColor = true;
            // 
            // btn_Con
            // 
            this.btn_Con.Location = new System.Drawing.Point(55, 316);
            this.btn_Con.Name = "btn_Con";
            this.btn_Con.Size = new System.Drawing.Size(75, 23);
            this.btn_Con.TabIndex = 7;
            this.btn_Con.Text = "Convert";
            this.btn_Con.UseVisualStyleBackColor = true;
            this.btn_Con.Click += new System.EventHandler(this.btn_Con_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(191, 316);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 8;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(347, 316);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Con);
            this.Controls.Add(this.rbtn_Celsius);
            this.Controls.Add(this.rbtn_Fe);
            this.Controls.Add(this.txt_Eq);
            this.Controls.Add(this.txt_Temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Temp;
        private System.Windows.Forms.TextBox txt_Eq;
        private System.Windows.Forms.RadioButton rbtn_Fe;
        private System.Windows.Forms.RadioButton rbtn_Celsius;
        private System.Windows.Forms.Button btn_Con;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Exit;
    }
}

