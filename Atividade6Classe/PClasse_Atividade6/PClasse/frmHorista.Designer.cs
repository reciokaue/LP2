namespace PClasse
{
    partial class frmHorista
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.entradaEmpresa = new System.Windows.Forms.TextBox();
            this.faltas = new System.Windows.Forms.TextBox();
            this.salarioHora = new System.Windows.Forms.TextBox();
            this.numeroHoras = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.matricula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário por hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de entrada na empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dias de falta";
            // 
            // entradaEmpresa
            // 
            this.entradaEmpresa.Location = new System.Drawing.Point(236, 177);
            this.entradaEmpresa.Name = "entradaEmpresa";
            this.entradaEmpresa.Size = new System.Drawing.Size(100, 20);
            this.entradaEmpresa.TabIndex = 10;
            // 
            // faltas
            // 
            this.faltas.Location = new System.Drawing.Point(236, 203);
            this.faltas.Name = "faltas";
            this.faltas.Size = new System.Drawing.Size(100, 20);
            this.faltas.TabIndex = 11;
            // 
            // salarioHora
            // 
            this.salarioHora.Location = new System.Drawing.Point(236, 116);
            this.salarioHora.Name = "salarioHora";
            this.salarioHora.Size = new System.Drawing.Size(100, 20);
            this.salarioHora.TabIndex = 12;
            // 
            // numeroHoras
            // 
            this.numeroHoras.Location = new System.Drawing.Point(236, 145);
            this.numeroHoras.Name = "numeroHoras";
            this.numeroHoras.Size = new System.Drawing.Size(100, 20);
            this.numeroHoras.TabIndex = 13;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(236, 86);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 15;
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(236, 59);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(100, 20);
            this.matricula.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 68);
            this.button1.TabIndex = 16;
            this.button1.Text = "Instanciar Horista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(593, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha home office";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(40, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "não";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.numeroHoras);
            this.Controls.Add(this.salarioHora);
            this.Controls.Add(this.faltas);
            this.Controls.Add(this.entradaEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.FrmHorista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox entradaEmpresa;
        private System.Windows.Forms.TextBox faltas;
        private System.Windows.Forms.TextBox salarioHora;
        private System.Windows.Forms.TextBox numeroHoras;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}