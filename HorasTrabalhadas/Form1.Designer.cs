namespace HorasTrabalhadas
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
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblVh = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtVh = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblHt = new System.Windows.Forms.Label();
            this.txtHt = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(60, 79);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(346, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblVh
            // 
            this.lblVh.AutoSize = true;
            this.lblVh.Location = new System.Drawing.Point(60, 149);
            this.lblVh.Name = "lblVh";
            this.lblVh.Size = new System.Drawing.Size(65, 15);
            this.lblVh.TabIndex = 2;
            this.lblVh.Text = "Valor Hora:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(407, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(130, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtVh
            // 
            this.txtVh.Location = new System.Drawing.Point(131, 146);
            this.txtVh.Name = "txtVh";
            this.txtVh.Size = new System.Drawing.Size(121, 23);
            this.txtVh.TabIndex = 5;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(295, 354);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 15);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(346, 351);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(120, 23);
            this.txtSalario.TabIndex = 7;
            // 
            // lblHt
            // 
            this.lblHt.AutoSize = true;
            this.lblHt.Location = new System.Drawing.Point(295, 152);
            this.lblHt.Name = "lblHt";
            this.lblHt.Size = new System.Drawing.Size(106, 15);
            this.lblHt.TabIndex = 8;
            this.lblHt.Text = "Horas Trabalhadas:";
            // 
            // txtHt
            // 
            this.txtHt.Location = new System.Drawing.Point(407, 152);
            this.txtHt.Name = "txtHt";
            this.txtHt.Size = new System.Drawing.Size(130, 23);
            this.txtHt.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(97, 248);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 27);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(131, 76);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(121, 23);
            this.txtCpf.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 449);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtHt);
            this.Controls.Add(this.lblHt);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtVh);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblVh);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCpf;
        private Label lblNome;
        private Label lblVh;
        private TextBox txtNome;
        private TextBox txtVh;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblHt;
        private TextBox txtHt;
        private Button btnCalc;
        private MaskedTextBox txtCpf;
    }
}