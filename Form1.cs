using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Media;

namespace FlashCard
{
    public partial class Form1 : Form
    {
        private string Pfad = string.Empty;
        private static int posicao = 0;
        private static bool bTeste = false;
        private static bool bAutomatico = false;
        private static int posicaoRandom = 0;
        private string pathSom = String.Empty;
        private SoundPlayer simpleSound = new SoundPlayer();
        private int contador = 0;

        private List<Word> listaPalavras = new List<Word>();

        public Form1()
        {
            InitializeComponent();
            mostraPosicao();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            this.listaPalavras.Clear();
            this.btnSound.Enabled = false;
            if (this.openFileDialogFlashCard.ShowDialog() == DialogResult.OK)
            {
                Pfad = this.openFileDialogFlashCard.FileName;

                string[] consulta = File.ReadAllLines(Pfad, System.Text.Encoding.UTF7);
                foreach (string item in consulta)
                {
                    string[] campos = item.Split('#');
                    
                    Word word = new Word();
                    word.PalavraOrigem = campos[0];
                    word.PalavraTraduzida = campos[1];
                    if (campos.Length > 2)
                    {
                        word.FileSom = campos[2];
                        this.btnSound.Enabled = true;
                    }

                    this.listaPalavras.Add(word);
                }
                
            }

        }

        private void mostraPosicao()
        {
            lblPosicao.Text = String.Format("Posição:{0:0000}      Total:{1:0000}", this.listaPalavras.Count > 0 ? (bTeste ? posicaoRandom : posicao) + 1 : 0, this.listaPalavras.Count);
        }

        private void exibir()
        {
            
            if (this.listaPalavras.Count > 0)
            {
                Random random = new Random();
                posicaoRandom = random.Next(0, this.listaPalavras.Count - 1);
                mostraPosicao();

                if (bTeste == false)
                {
                   
                    this.textMean.Text = "";
                    this.textMean.Update();
                    playSom();
                    this.txtWord.Text = this.listaPalavras[posicao].PalavraOrigem;
                    if (this.txtWord.Text.Contains("der "))
                    {
                        this.txtWord.ForeColor = Color.Blue;
                    }
                    else if (this.txtWord.Text.Contains("die "))
                    {
                        this.txtWord.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.txtWord.ForeColor = Color.Green;
                    }

                    this.txtWord.Update();
                    Update();
                    
                    Thread.Sleep(1000);
                    this.textMean.Text = this.listaPalavras[posicao].PalavraTraduzida;
                }
                else
                {
                    this.txtWord.Text = String.Empty;
                    
                    this.textMean.Text = this.listaPalavras[posicaoRandom].PalavraTraduzida;
                }
            }
            this.lblResultado.Text = "";


        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            posicao = 0;
            bTeste = false;
            this.txtWord.BackColor = this.textMean.BackColor;
            this.exibir();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            posicao = 0;
            this.exibir();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(posicao > 0 )
                posicao--;
            this.exibir();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (posicao < (this.listaPalavras.Count-1))
                posicao++;
            this.exibir();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            posicao = this.listaPalavras.Count - 1;
            this.exibir();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            bTeste = true;
            this.txtWord.BackColor = Color.WhiteSmoke;
            this.exibir();

        }

        private void txtWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (bTeste)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    string palavra = this.listaPalavras[posicaoRandom].PalavraOrigem;
                    string digitado = this.txtWord.Text;

                    if (palavra.Equals(digitado))
                    {
                        this.lblResultado.Text = "Correto!";
                    }
                    else
                    {
                        this.lblResultado.Text = "Errado!";
                    }

                }
                else
                {
                    this.lblResultado.Text = "";
                }
                
            }
            else
            {
                this.lblResultado.Text = "";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (bTeste)
            {
                this.lblResultado.Text = this.listaPalavras[posicaoRandom].PalavraOrigem;
            }
        }

        private void btnAutomatico_Click(object sender, EventArgs e)
        {
            bAutomatico = !bAutomatico;
            bTeste = false;
            if (bAutomatico)
            {
                this.btnAutomatico.Text = "Parar...";
                posicao = 0;
                
                while (bAutomatico)
                {
                    if (posicao == 0)
                    {
                        contador++;
                        this.lblContador.Text = String.Format("{0:000}", contador);
                    }

                    if (posicao < (this.listaPalavras.Count - 1))
                        posicao++;
                    else
                        posicao = 0;
                    
                    this.exibir();
                    Application.DoEvents();
                    Thread.Sleep(Decimal.ToInt32(numericUpDown1.Value));
                    Application.DoEvents();
                }
            }
            contador=0;
            this.lblContador.Text = String.Format("{0:000}", contador);
            this.btnAutomatico.Text = "Automático...";
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pathSom = folderBrowserDialog1.SelectedPath.ToString();
            }
           

        }

        private void playSom()
        {


            string pathFullSom = String.Format(@"{0}\{1}", this.pathSom, this.listaPalavras[posicao].FileSom);
            this.simpleSound.SoundLocation = pathFullSom;

            try
            {
                simpleSound.Play();
            }
            catch { }

            
        }

        private void nmUp_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)(this.nmUp.Value/100);
            
            this.Update();
        }
    }
}