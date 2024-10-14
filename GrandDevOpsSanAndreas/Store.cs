using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandDevOpsSanAndreas
{
    public partial class Store : Form
    {
        Form1 jogo;
        PictureBox energia;
        Label lblDinheiro;
        PictureBox pbEstrelas;
        public Store(Form1 f, PictureBox pb, Label lblDinheiro, PictureBox pbEstrelas)
        {
            InitializeComponent();
            jogo = f;
            energia = pb;
            this.lblDinheiro = lblDinheiro;
            this.pbEstrelas = pbEstrelas;

            try
            {
                SoundPlayer som = new SoundPlayer(@"songs\welcome.wav");
                som.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao reproduzir o som: " + ex);
            }
        }

        private void pbTapioca_Click(object sender, EventArgs e)
        {
            if (jogo.energia < 114)
            {
                if (jogo.dinheiro >= 100)
                {
                    jogo.energia = 114;
                    energia.Width = 114;
                    jogo.dinheiro -= 100;
                    lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();

                    try
                    {
                        SoundPlayer som = new SoundPlayer(@"songs\merchant_thankyou.wav");
                        som.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao reproduzir o som: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tá sem dinheiro, faz o pix irmão!");
                }
            }
            else
            {
                MessageBox.Show("Sua energia já está completa!");
            }
        }

        private void pbBook_Click(object sender, EventArgs e)
        {
            if (jogo.estrelas > 0)
            {

                if (jogo.dinheiro >= 200)
                {
                    jogo.estrelas--;
                    jogo.dinheiro -= 200;
                    lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();

                    switch (jogo.estrelas)
                    {
                        case 0:
                            pbEstrelas.Visible = false;
                            break;
                        case 1:
                            pbEstrelas.Image = Properties.Resources.one_star;
                            break;
                        case 2:
                            pbEstrelas.Image = Properties.Resources.two_stars;
                            break;
                        case 3:
                            pbEstrelas.Image = Properties.Resources.three_stars;
                            break;
                        case 4:
                            pbEstrelas.Image = Properties.Resources.four_stars;
                            break;
                        case 5:
                            pbEstrelas.Image = Properties.Resources.five_stars;
                            break;
                    }
                    try
                    {
                        SoundPlayer som = new SoundPlayer(@"songs\merchant_thankyou.wav");
                        som.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao reproduzir o som: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Tá sem dinheiro, faz o pix irmão!");
                }
            }
            else
            {
                MessageBox.Show("Você não está sendo procurado!");
            }
        }

        private void pbCola_Click(object sender, EventArgs e)
        {
            if (jogo.energia < 114)
            {
                if (jogo.dinheiro >= 10)
                {
                    if (jogo.energia < 110)
                    {
                        jogo.energia += 5;
                        energia.Width += 5;
                        jogo.dinheiro -= 10;
                        lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();
                    }
                    else
                    {
                        jogo.energia = 114;
                        energia.Width = 114;
                        jogo.dinheiro -= 10;
                        lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();
                    }
                    try
                    {
                        SoundPlayer som = new SoundPlayer(@"songs\merchant_thankyou.wav");
                        som.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao reproduzir o som: " + ex);
                    }

                }
                else
                {
                    MessageBox.Show("Tá sem dinheiro, faz o pix irmão!");
                }
            }
            else
            {
                MessageBox.Show("Sua energia já está completa!");
            }
        }

        private void pbMilho_Click(object sender, EventArgs e)
        {
            if (jogo.energia < 114)
            {
                if (jogo.dinheiro >= 20)
                {
                    if (jogo.energia < 105)
                    {
                        jogo.energia += 10;
                        energia.Width += 10;
                        jogo.dinheiro -= 20;
                        lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();
                    }
                    else
                    {
                        jogo.energia = 114;
                        energia.Width = 114;
                        jogo.dinheiro -= 20;
                        lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();
                    }
                    try
                    {
                        SoundPlayer som = new SoundPlayer(@"songs\merchant_thankyou.wav");
                        som.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao reproduzir o som: " + ex);
                    }

                }
                else
                {
                    MessageBox.Show("Tá sem dinheiro, faz o pix irmão!");
                }
            }
            else
            {
                MessageBox.Show("Sua energia já está completa!");
            }
        }

        private void pbBis_Click(object sender, EventArgs e)
        {
            if (jogo.energia < 114)
            {
                if (jogo.dinheiro >= 50)
                {
                    if (jogo.energia < 100)
                    {
                        jogo.energia += 15;
                        energia.Width += 15;
                        jogo.dinheiro -= 50;
                        lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();
                    }
                    else
                    {
                        jogo.energia = 114;
                        energia.Width = 114;
                        jogo.dinheiro -= 50;
                        lblDinheiro.Text = "R$" + jogo.dinheiro.ToString();
                    }
                    try
                    {
                        SoundPlayer som = new SoundPlayer(@"songs\merchant_thankyou.wav");
                        som.Play();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Erro ao reproduzir o som: " + ex);
                    }

                }
                else
                {
                    MessageBox.Show("Tá sem dinheiro, faz o pix irmão!");
                }
            }
            else
            {
                MessageBox.Show("Sua energia já está completa!");
            }
        }

        private void pbBis_MouseEnter(object sender, EventArgs e)
        {
            if (!lblBisValor.Visible)
            {
                lblBisValor.Visible = true;
            }
        }

        private void pbBis_MouseLeave(object sender, EventArgs e)
        {
            if (lblBisValor.Visible)
            {
                lblBisValor.Visible = false;
            }
        }

        private void pbTapioca_MouseEnter(object sender, EventArgs e)
        {
            if (!lblTapiocaValor.Visible)
            {
                lblTapiocaValor.Visible = true;
            }
        }

        private void pbTapioca_MouseLeave(object sender, EventArgs e)
        {
            if (lblTapiocaValor.Visible)
            {
                lblTapiocaValor.Visible = false;
            }
        }

        private void pbMilho_MouseEnter(object sender, EventArgs e)
        {
            if (!lblMilhoValor.Visible)
            {
                lblMilhoValor.Visible = true;
            }
        }

        private void pbMilho_MouseLeave(object sender, EventArgs e)
        {
            if (lblMilhoValor.Visible)
            {
                lblMilhoValor.Visible = false;
            }
        }

        private void pbCola_MouseEnter(object sender, EventArgs e)
        {
            if (!lblColaValor.Visible)
            {
                lblColaValor.Visible = true;
            }
        }

        private void pbCola_MouseLeave(object sender, EventArgs e)
        {
            if (lblColaValor.Visible)
            {
                lblColaValor.Visible = false;
            }
        }

        private void pbBook_MouseEnter(object sender, EventArgs e)
        {
            if (!lblBookValor.Visible)
            {
                lblBookValor.Visible = true;
            }
        }

        private void pbBook_MouseLeave(object sender, EventArgs e)
        {
            if (lblBookValor.Visible)
            {
                lblBookValor.Visible = false;
            }
        }
    }
}
