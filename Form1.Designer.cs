namespace FlashCard
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
            this.btnLer = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textMean = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.openFileDialogFlashCard = new System.Windows.Forms.OpenFileDialog();
            this.btnTeste = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAutomatico = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.btnSound = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblContador = new System.Windows.Forms.Label();
            this.nmUp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(12, 12);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 0;
            this.btnLer.Text = "Ler arquivo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(324, 12);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtWord);
            this.panel1.Location = new System.Drawing.Point(17, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 141);
            this.panel1.TabIndex = 2;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.SystemColors.Menu;
            this.txtWord.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWord.Location = new System.Drawing.Point(3, 3);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(952, 131);
            this.txtWord.TabIndex = 0;
            this.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWord_KeyUp);
            this.txtWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWord_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textMean);
            this.panel2.Location = new System.Drawing.Point(17, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 159);
            this.panel2.TabIndex = 3;
            // 
            // textMean
            // 
            this.textMean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textMean.BackColor = System.Drawing.SystemColors.Menu;
            this.textMean.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMean.ForeColor = System.Drawing.Color.MediumPurple;
            this.textMean.Location = new System.Drawing.Point(3, 3);
            this.textMean.Multiline = true;
            this.textMean.Name = "textMean";
            this.textMean.Size = new System.Drawing.Size(952, 149);
            this.textMean.TabIndex = 1;
            this.textMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(162, 428);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(243, 428);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(324, 428);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(405, 428);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // openFileDialogFlashCard
            // 
            this.openFileDialogFlashCard.FileName = "Escolha Arquivo";
            this.openFileDialogFlashCard.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(472, 223);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(75, 23);
            this.btnTeste.TabIndex = 8;
            this.btnTeste.Text = "Teste!";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(19, 234);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 50);
            this.lblResultado.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(553, 223);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show!";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAutomatico
            // 
            this.btnAutomatico.Location = new System.Drawing.Point(405, 12);
            this.btnAutomatico.Name = "btnAutomatico";
            this.btnAutomatico.Size = new System.Drawing.Size(75, 23);
            this.btnAutomatico.TabIndex = 11;
            this.btnAutomatico.Text = "Automático";
            this.btnAutomatico.UseVisualStyleBackColor = true;
            this.btnAutomatico.Click += new System.EventHandler(this.btnAutomatico_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(502, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(553, 22);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(68, 13);
            this.lblSegundos.TabIndex = 13;
            this.lblSegundos.Text = "Milisegundos";
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(14, 414);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(48, 13);
            this.lblPosicao.TabIndex = 14;
            this.lblPosicao.Text = "Posição:";
            // 
            // btnSound
            // 
            this.btnSound.Enabled = false;
            this.btnSound.Location = new System.Drawing.Point(93, 12);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(75, 23);
            this.btnSound.TabIndex = 15;
            this.btnSound.Text = "Som";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(251, 5);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 30);
            this.lblContador.TabIndex = 16;
            // 
            // nmUp
            // 
            this.nmUp.Location = new System.Drawing.Point(583, 428);
            this.nmUp.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmUp.Name = "nmUp";
            this.nmUp.Size = new System.Drawing.Size(38, 20);
            this.nmUp.TabIndex = 17;
            this.nmUp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmUp.ValueChanged += new System.EventHandler(this.nmUp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Transparência:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(992, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmUp);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAutomatico);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnLer);
            this.Name = "Form1";
            this.Opacity = 0.99;
            this.Text = "FlashCard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.OpenFileDialog openFileDialogFlashCard;
        private System.Windows.Forms.TextBox textMean;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAutomatico;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.NumericUpDown nmUp;
        private System.Windows.Forms.Label label1;
    }
}

