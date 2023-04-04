namespace Atividade_5
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
            System.Windows.Forms.GroupBox groupBox1;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextSalary = new System.Windows.Forms.MaskedTextBox();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.Calc_button = new System.Windows.Forms.Button();
            this.AliquotaINNS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AliquotaIRPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SalarioFamilia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SalarioLiquido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChildrenAmount = new System.Windows.Forms.NumericUpDown();
            this.RadioCasado = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de filhos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Bruto";
            // 
            // TextSalary
            // 
            this.TextSalary.Location = new System.Drawing.Point(158, 70);
            this.TextSalary.Mask = "99990,00";
            this.TextSalary.Name = "TextSalary";
            this.TextSalary.Size = new System.Drawing.Size(100, 20);
            this.TextSalary.TabIndex = 3;
            // 
            // TextUserName
            // 
            this.TextUserName.Location = new System.Drawing.Point(158, 37);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(100, 20);
            this.TextUserName.TabIndex = 4;
            this.TextUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TextUserName_Validating);
            // 
            // Calc_button
            // 
            this.Calc_button.Location = new System.Drawing.Point(59, 140);
            this.Calc_button.Name = "Calc_button";
            this.Calc_button.Size = new System.Drawing.Size(199, 39);
            this.Calc_button.TabIndex = 6;
            this.Calc_button.Text = "Verificar Desconto";
            this.Calc_button.UseVisualStyleBackColor = true;
            this.Calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // AliquotaINNS
            // 
            this.AliquotaINNS.Location = new System.Drawing.Point(162, 286);
            this.AliquotaINNS.Name = "AliquotaINNS";
            this.AliquotaINNS.Size = new System.Drawing.Size(100, 20);
            this.AliquotaINNS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aliquota INSS";
            // 
            // AliquotaIRPF
            // 
            this.AliquotaIRPF.Location = new System.Drawing.Point(162, 317);
            this.AliquotaIRPF.Name = "AliquotaIRPF";
            this.AliquotaIRPF.Size = new System.Drawing.Size(100, 20);
            this.AliquotaIRPF.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aliquota IRPF";
            // 
            // SalarioFamilia
            // 
            this.SalarioFamilia.Location = new System.Drawing.Point(162, 350);
            this.SalarioFamilia.Name = "SalarioFamilia";
            this.SalarioFamilia.Size = new System.Drawing.Size(100, 20);
            this.SalarioFamilia.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salário Família";
            // 
            // SalarioLiquido
            // 
            this.SalarioLiquido.Location = new System.Drawing.Point(162, 384);
            this.SalarioLiquido.Name = "SalarioLiquido";
            this.SalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.SalarioLiquido.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salário Liquido";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.radioButton2);
            groupBox1.Controls.Add(this.radioButton1);
            groupBox1.Location = new System.Drawing.Point(317, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(200, 103);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Feminino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(416, 314);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Desconto IRPF";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(416, 283);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Desconto INSS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioCasado);
            this.panel1.Location = new System.Drawing.Point(317, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 20;
            // 
            // ChildrenAmount
            // 
            this.ChildrenAmount.Location = new System.Drawing.Point(158, 106);
            this.ChildrenAmount.Name = "ChildrenAmount";
            this.ChildrenAmount.Size = new System.Drawing.Size(104, 20);
            this.ChildrenAmount.TabIndex = 21;
            // 
            // RadioCasado
            // 
            this.RadioCasado.AutoSize = true;
            this.RadioCasado.Location = new System.Drawing.Point(16, 46);
            this.RadioCasado.Name = "RadioCasado";
            this.RadioCasado.Size = new System.Drawing.Size(61, 17);
            this.RadioCasado.TabIndex = 0;
            this.RadioCasado.TabStop = true;
            this.RadioCasado.Text = "Casado";
            this.RadioCasado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 586);
            this.Controls.Add(this.ChildrenAmount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.SalarioLiquido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SalarioFamilia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AliquotaIRPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AliquotaINNS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Calc_button);
            this.Controls.Add(this.TextUserName);
            this.Controls.Add(this.TextSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TextSalary;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.Button Calc_button;
        private System.Windows.Forms.TextBox AliquotaINNS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AliquotaIRPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SalarioFamilia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SalarioLiquido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown ChildrenAmount;
        private System.Windows.Forms.RadioButton RadioCasado;
    }
}

