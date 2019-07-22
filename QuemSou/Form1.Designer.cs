namespace QuemSou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNomeComputador = new System.Windows.Forms.Label();
            this.labelIPLocal = new System.Windows.Forms.Label();
            this.labelUserWindows = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RedeLocalTeste = new System.Windows.Forms.Label();
            this.InternetTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeComputador
            // 
            this.labelNomeComputador.AutoSize = true;
            this.labelNomeComputador.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeComputador.Location = new System.Drawing.Point(15, 77);
            this.labelNomeComputador.Name = "labelNomeComputador";
            this.labelNomeComputador.Size = new System.Drawing.Size(169, 23);
            this.labelNomeComputador.TabIndex = 0;
            this.labelNomeComputador.Text = "NomeComputador";
            // 
            // labelIPLocal
            // 
            this.labelIPLocal.AutoSize = true;
            this.labelIPLocal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPLocal.Location = new System.Drawing.Point(15, 127);
            this.labelIPLocal.Name = "labelIPLocal";
            this.labelIPLocal.Size = new System.Drawing.Size(120, 23);
            this.labelIPLocal.TabIndex = 1;
            this.labelIPLocal.Text = "labelIPLocal";
            // 
            // labelUserWindows
            // 
            this.labelUserWindows.AutoSize = true;
            this.labelUserWindows.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserWindows.Location = new System.Drawing.Point(15, 28);
            this.labelUserWindows.Name = "labelUserWindows";
            this.labelUserWindows.Size = new System.Drawing.Size(158, 23);
            this.labelUserWindows.TabIndex = 2;
            this.labelUserWindows.Text = "UsuárioWindows";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 73);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "TI: 3897-2036 e 2011";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Computador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP:";
            // 
            // RedeLocalTeste
            // 
            this.RedeLocalTeste.AutoSize = true;
            this.RedeLocalTeste.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.RedeLocalTeste.Location = new System.Drawing.Point(238, 45);
            this.RedeLocalTeste.Name = "RedeLocalTeste";
            this.RedeLocalTeste.Size = new System.Drawing.Size(139, 18);
            this.RedeLocalTeste.TabIndex = 8;
            this.RedeLocalTeste.Text = "RedeLocalTeste";
            // 
            // InternetTest
            // 
            this.InternetTest.AutoSize = true;
            this.InternetTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.InternetTest.Location = new System.Drawing.Point(252, 86);
            this.InternetTest.Name = "InternetTest";
            this.InternetTest.Size = new System.Drawing.Size(107, 18);
            this.InternetTest.TabIndex = 9;
            this.InternetTest.Text = "InternetTest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 220);
            this.Controls.Add(this.InternetTest);
            this.Controls.Add(this.RedeLocalTeste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUserWindows);
            this.Controls.Add(this.labelIPLocal);
            this.Controls.Add(this.labelNomeComputador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quem Sou?";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeComputador;
        private System.Windows.Forms.Label labelIPLocal;
        private System.Windows.Forms.Label labelUserWindows;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RedeLocalTeste;
        private System.Windows.Forms.Label InternetTest;
    }
}

