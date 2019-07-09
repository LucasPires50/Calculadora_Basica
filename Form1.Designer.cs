namespace Calculadora_Basica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.bntSomar = new System.Windows.Forms.Button();
            this.bntSubtrair = new System.Windows.Forms.Button();
            this.bntMultiplicar = new System.Windows.Forms.Button();
            this.bntDividir = new System.Windows.Forms.Button();
            this.BntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculos Básicos";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.Lime;
            this.txt.Location = new System.Drawing.Point(39, 115);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(189, 25);
            this.txt.TabIndex = 1;
            this.txt.Text = "Digite o 1º número";
            // 
            // txtn
            // 
            this.txtn.AutoSize = true;
            this.txtn.BackColor = System.Drawing.Color.Transparent;
            this.txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.ForeColor = System.Drawing.Color.Lime;
            this.txtn.Location = new System.Drawing.Point(39, 162);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(189, 25);
            this.txtn.TabIndex = 2;
            this.txtn.Text = "Digite o 2º número";
            this.txtn.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.ForeColor = System.Drawing.Color.Red;
            this.txtnum1.Location = new System.Drawing.Point(263, 115);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(111, 30);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.ForeColor = System.Drawing.Color.Red;
            this.txtnum2.Location = new System.Drawing.Point(263, 159);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(111, 30);
            this.txtnum2.TabIndex = 4;
            this.txtnum2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtr
            // 
            this.txtr.AutoSize = true;
            this.txtr.BackColor = System.Drawing.Color.Transparent;
            this.txtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtr.ForeColor = System.Drawing.Color.Lime;
            this.txtr.Location = new System.Drawing.Point(68, 324);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(108, 25);
            this.txtr.TabIndex = 5;
            this.txtr.Text = "Resultado";
            this.txtr.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.ForeColor = System.Drawing.Color.Red;
            this.txtresultado.Location = new System.Drawing.Point(190, 324);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(184, 30);
            this.txtresultado.TabIndex = 6;
            this.txtresultado.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // bntSomar
            // 
            this.bntSomar.BackColor = System.Drawing.Color.YellowGreen;
            this.bntSomar.FlatAppearance.BorderSize = 0;
            this.bntSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.bntSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bntSomar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntSomar.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSomar.ForeColor = System.Drawing.Color.White;
            this.bntSomar.Location = new System.Drawing.Point(100, 210);
            this.bntSomar.Name = "bntSomar";
            this.bntSomar.Size = new System.Drawing.Size(48, 37);
            this.bntSomar.TabIndex = 7;
            this.bntSomar.Text = "+";
            this.bntSomar.UseVisualStyleBackColor = false;
            this.bntSomar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bntSubtrair
            // 
            this.bntSubtrair.BackColor = System.Drawing.Color.YellowGreen;
            this.bntSubtrair.FlatAppearance.BorderSize = 0;
            this.bntSubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.bntSubtrair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bntSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntSubtrair.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSubtrair.ForeColor = System.Drawing.Color.White;
            this.bntSubtrair.Location = new System.Drawing.Point(154, 210);
            this.bntSubtrair.Name = "bntSubtrair";
            this.bntSubtrair.Size = new System.Drawing.Size(48, 37);
            this.bntSubtrair.TabIndex = 8;
            this.bntSubtrair.Text = "-";
            this.bntSubtrair.UseVisualStyleBackColor = false;
            this.bntSubtrair.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bntMultiplicar
            // 
            this.bntMultiplicar.BackColor = System.Drawing.Color.YellowGreen;
            this.bntMultiplicar.FlatAppearance.BorderSize = 0;
            this.bntMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.bntMultiplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bntMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntMultiplicar.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMultiplicar.ForeColor = System.Drawing.Color.White;
            this.bntMultiplicar.Location = new System.Drawing.Point(100, 267);
            this.bntMultiplicar.Name = "bntMultiplicar";
            this.bntMultiplicar.Size = new System.Drawing.Size(48, 37);
            this.bntMultiplicar.TabIndex = 9;
            this.bntMultiplicar.Text = "*";
            this.bntMultiplicar.UseVisualStyleBackColor = false;
            this.bntMultiplicar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // bntDividir
            // 
            this.bntDividir.BackColor = System.Drawing.Color.YellowGreen;
            this.bntDividir.FlatAppearance.BorderSize = 0;
            this.bntDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.bntDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bntDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntDividir.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDividir.ForeColor = System.Drawing.Color.White;
            this.bntDividir.Location = new System.Drawing.Point(154, 267);
            this.bntDividir.Name = "bntDividir";
            this.bntDividir.Size = new System.Drawing.Size(48, 37);
            this.bntDividir.TabIndex = 10;
            this.bntDividir.Text = "/";
            this.bntDividir.UseVisualStyleBackColor = false;
            this.bntDividir.Click += new System.EventHandler(this.BntDividir_Click);
            // 
            // BntLimpar
            // 
            this.BntLimpar.BackColor = System.Drawing.Color.YellowGreen;
            this.BntLimpar.FlatAppearance.BorderSize = 0;
            this.BntLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BntLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BntLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BntLimpar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntLimpar.ForeColor = System.Drawing.Color.White;
            this.BntLimpar.Location = new System.Drawing.Point(224, 232);
            this.BntLimpar.Name = "BntLimpar";
            this.BntLimpar.Size = new System.Drawing.Size(150, 50);
            this.BntLimpar.TabIndex = 11;
            this.BntLimpar.Text = "Limpar";
            this.BntLimpar.UseVisualStyleBackColor = false;
            this.BntLimpar.Click += new System.EventHandler(this.BntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.Color.YellowGreen;
            this.bntSair.FlatAppearance.BorderSize = 0;
            this.bntSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.bntSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bntSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.ForeColor = System.Drawing.Color.White;
            this.bntSair.Location = new System.Drawing.Point(154, 374);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(118, 37);
            this.bntSair.TabIndex = 12;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.BntSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora_Basica.Properties.Resources.Captudasdasrar;
            this.ClientSize = new System.Drawing.Size(436, 432);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.BntLimpar);
            this.Controls.Add(this.bntDividir);
            this.Controls.Add(this.bntMultiplicar);
            this.Controls.Add(this.bntSubtrair);
            this.Controls.Add(this.bntSomar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txtn;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label txtr;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button bntSomar;
        private System.Windows.Forms.Button bntSubtrair;
        private System.Windows.Forms.Button bntMultiplicar;
        private System.Windows.Forms.Button bntDividir;
        private System.Windows.Forms.Button BntLimpar;
        private System.Windows.Forms.Button bntSair;
    }
}

