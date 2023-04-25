namespace PClasse
{
    partial class frmMensalista
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
            this.lblMatrícula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalMensal = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalMensal = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.gbxHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNão = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.btnInstanMensal = new System.Windows.Forms.Button();
            this.btnInstan = new System.Windows.Forms.Button();
            this.gbxHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatrícula
            // 
            this.lblMatrícula.AutoSize = true;
            this.lblMatrícula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrícula.Location = new System.Drawing.Point(29, 26);
            this.lblMatrícula.Name = "lblMatrícula";
            this.lblMatrícula.Size = new System.Drawing.Size(82, 22);
            this.lblMatrícula.TabIndex = 0;
            this.lblMatrícula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(29, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalMensal
            // 
            this.lblSalMensal.AutoSize = true;
            this.lblSalMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalMensal.Location = new System.Drawing.Point(29, 89);
            this.lblSalMensal.Name = "lblSalMensal";
            this.lblSalMensal.Size = new System.Drawing.Size(128, 22);
            this.lblSalMensal.TabIndex = 2;
            this.lblSalMensal.Text = "Salário Mensal";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(29, 121);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(242, 22);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data de Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(277, 23);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(215, 27);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(277, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 27);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalMensal
            // 
            this.txtSalMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalMensal.Location = new System.Drawing.Point(277, 86);
            this.txtSalMensal.Name = "txtSalMensal";
            this.txtSalMensal.Size = new System.Drawing.Size(215, 27);
            this.txtSalMensal.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(277, 118);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(215, 27);
            this.txtData.TabIndex = 7;
            // 
            // gbxHomeOffice
            // 
            this.gbxHomeOffice.BackColor = System.Drawing.Color.LightGray;
            this.gbxHomeOffice.Controls.Add(this.rbtnNão);
            this.gbxHomeOffice.Controls.Add(this.rbtnSim);
            this.gbxHomeOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHomeOffice.Location = new System.Drawing.Point(571, 26);
            this.gbxHomeOffice.Name = "gbxHomeOffice";
            this.gbxHomeOffice.Size = new System.Drawing.Size(200, 151);
            this.gbxHomeOffice.TabIndex = 8;
            this.gbxHomeOffice.TabStop = false;
            this.gbxHomeOffice.Text = "Trabalha em Home Office?";
            // 
            // rbtnNão
            // 
            this.rbtnNão.AutoSize = true;
            this.rbtnNão.Location = new System.Drawing.Point(19, 108);
            this.rbtnNão.Name = "rbtnNão";
            this.rbtnNão.Size = new System.Drawing.Size(61, 26);
            this.rbtnNão.TabIndex = 1;
            this.rbtnNão.Text = "Não";
            this.rbtnNão.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(19, 61);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(58, 26);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // btnInstanMensal
            // 
            this.btnInstanMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanMensal.Location = new System.Drawing.Point(138, 283);
            this.btnInstanMensal.Name = "btnInstanMensal";
            this.btnInstanMensal.Size = new System.Drawing.Size(176, 76);
            this.btnInstanMensal.TabIndex = 9;
            this.btnInstanMensal.Text = "Instanciar Mensalista";
            this.btnInstanMensal.UseVisualStyleBackColor = true;
            this.btnInstanMensal.Click += new System.EventHandler(this.BtnInstanMensal_Click);
            // 
            // btnInstan
            // 
            this.btnInstan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstan.Location = new System.Drawing.Point(489, 283);
            this.btnInstan.Name = "btnInstan";
            this.btnInstan.Size = new System.Drawing.Size(176, 76);
            this.btnInstan.TabIndex = 10;
            this.btnInstan.Text = "Instanciar com parametros";
            this.btnInstan.UseVisualStyleBackColor = true;
            this.btnInstan.Click += new System.EventHandler(this.BtnInstan_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstan);
            this.Controls.Add(this.btnInstanMensal);
            this.Controls.Add(this.gbxHomeOffice);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatrícula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHomeOffice.ResumeLayout(false);
            this.gbxHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatrícula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalMensal;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalMensal;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox gbxHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNão;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstanMensal;
        private System.Windows.Forms.Button btnInstan;
    }
}