using GrandDevOpsSanAndreas.DataAccess;
using GrandDevOpsSanAndreas.Model;
using GrandDevOpsSanAndreas.Properties;
using System;
using System.Media;
using System.Windows.Forms.VisualStyles;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace GrandDevOpsSanAndreas
{
    public partial class Form1 : Form
    {
        public int questaoAtual = 0, totQuestoes = 0, acertos = 0, erros = 0, respostaCorreta, questaoEscolhida, energia = 114, estrelas, dinheiro = 1;
        List<Questoes> listaQuestoes = new List<Questoes>(); // Todas as questões

        public Form1()
        {
            InitializeComponent();

            // 1 - PEGA TODAS AS QUESTÕES DO BANCO DE DADOS
            QuestoesDAO qdao = new QuestoesDAO();
            listaQuestoes = qdao.ReadQuestions();
            totQuestoes = listaQuestoes.Count;
            CarregarQuestao();

        }

        public void CarregarQuestao()
        {
            questaoAtual++; // Ao iniciar, a questão será sempre a primeira



            // 2 - SORTEIO PARA SABER QUAL QUESTÃO COMEÇA PRIMEIRO
            Random aleatorio = new Random();
            questaoEscolhida = aleatorio.Next(0, listaQuestoes.Count); // Temos a questão escolhida

            // 3 - SORTEIO PARA SABER QUAL DAS 4 ALTERNATIVAS SERÁ A CORRETA
            respostaCorreta = aleatorio.Next(1, 4); // Temos a posição da questão correta



            // 4 - EXIBIR OS DADOS NO WINDOW FORM
            lblQuestion.Text = listaQuestoes[questaoEscolhida].Question; // Exibe a questão na form
            lblQuestionNum.Text = questaoAtual.ToString(); // Exibe a contagem das questões

            int randomValue = aleatorio.Next(1, 10); // Gera um valor aleatório para embaralhar as alternativas incorretas
            switch (respostaCorreta) // Exibe as alternativas de forma aleatória
            {
                case 1: // Caso 1, as incorretas serão as alternativas 2,3,4
                    lblAlt1.Text = listaQuestoes[questaoEscolhida].Option1;

                    if (randomValue % 2 == 0)
                    {
                        lblAlt2.Text = listaQuestoes[questaoEscolhida].Option4;
                        lblAlt3.Text = listaQuestoes[questaoEscolhida].Option2;
                        lblAlt4.Text = listaQuestoes[questaoEscolhida].Option3;
                    }
                    else
                    {
                        lblAlt2.Text = listaQuestoes[questaoEscolhida].Option3;
                        lblAlt3.Text = listaQuestoes[questaoEscolhida].Option4;
                        lblAlt4.Text = listaQuestoes[questaoEscolhida].Option2;
                    }
                    break;

                case 2:
                    lblAlt2.Text = listaQuestoes[questaoEscolhida].Option1;

                    if (randomValue % 2 == 0)
                    {
                        lblAlt1.Text = listaQuestoes[questaoEscolhida].Option2;
                        lblAlt3.Text = listaQuestoes[questaoEscolhida].Option3;
                        lblAlt4.Text = listaQuestoes[questaoEscolhida].Option4;
                    }
                    else
                    {
                        lblAlt1.Text = listaQuestoes[questaoEscolhida].Option4;
                        lblAlt3.Text = listaQuestoes[questaoEscolhida].Option2;
                        lblAlt4.Text = listaQuestoes[questaoEscolhida].Option3;
                    }
                    break;

                case 3:
                    lblAlt3.Text = listaQuestoes[questaoEscolhida].Option1;

                    if (randomValue % 2 == 0)
                    {
                        lblAlt1.Text = listaQuestoes[questaoEscolhida].Option3;
                        lblAlt2.Text = listaQuestoes[questaoEscolhida].Option4;
                        lblAlt4.Text = listaQuestoes[questaoEscolhida].Option2;
                    }
                    else
                    {
                        lblAlt1.Text = listaQuestoes[questaoEscolhida].Option2;
                        lblAlt2.Text = listaQuestoes[questaoEscolhida].Option3;
                        lblAlt4.Text = listaQuestoes[questaoEscolhida].Option4;
                    }
                    break;

                case 4:
                    lblAlt4.Text = listaQuestoes[questaoEscolhida].Option1;

                    if (randomValue % 2 == 0)
                    {
                        lblAlt1.Text = listaQuestoes[questaoEscolhida].Option3;
                        lblAlt2.Text = listaQuestoes[questaoEscolhida].Option4;
                        lblAlt3.Text = listaQuestoes[questaoEscolhida].Option2;
                    }
                    else
                    {
                        lblAlt1.Text = listaQuestoes[questaoEscolhida].Option2;
                        lblAlt2.Text = listaQuestoes[questaoEscolhida].Option3;
                        lblAlt3.Text = listaQuestoes[questaoEscolhida].Option4;
                    }
                    break;
            }
        }

        public void ClearAlternatives()
        {
            pbAlt1.Image = Properties.Resources.alternative;
            pbAlt2.Image = Properties.Resources.alternative;
            pbAlt3.Image = Properties.Resources.alternative;
            pbAlt4.Image = Properties.Resources.alternative;
        }

        private void pbAlt1_Click(object sender, EventArgs e)
        {


            if (pbNext.Visible == false)
            {
                if (questaoAtual < totQuestoes)
                {
                    if (respostaCorreta == 1) // Se estiver correta
                    {
                       

                        Random random = new Random();

                        acertos++;
                        pbAlt1.Image = Properties.Resources.alt_correct;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1,9)%2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }
                        

                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();
                    }
                    else // Se estiver errada
                    {
                        erros++;
                        pbAlt1.Image = Properties.Resources.alt_incorrect;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 2:
                                pbAlt2.Image = Properties.Resources.alt_correct;
                                break;
                            case 3:
                                pbAlt3.Image = Properties.Resources.alt_correct;
                                break;
                            case 4:
                                pbAlt4.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                        }
                        if (estrelas < 6)
                        {
                            estrelas++;
                        }
                    }
                }
                else
                {
                    if (respostaCorreta == 1) // Se estiver correta AQUI
                    {
                        Random random = new Random();

                        acertos++;
                        pbAlt1.Image = Properties.Resources.alt_correct;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1, 9) % 2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }


                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        pbAlt1.Enabled = false;
                        pbAlt2.Enabled = false;
                        pbAlt3.Enabled = false;
                        pbAlt4.Enabled = false;
                        pbNext.Enabled = false;
                        pictureBox2.Enabled = false;

                        new MissaoConcluida(acertos, erros).Show();
                    }
                    else
                    {
                        erros++;
                        pbAlt1.Image = Properties.Resources.alt_incorrect;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 2:
                                pbAlt2.Image = Properties.Resources.alt_correct;
                                break;
                            case 3:
                                pbAlt3.Image = Properties.Resources.alt_correct;
                                break;
                            case 4:
                                pbAlt4.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                            else
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new MissaoConcluida(acertos, erros).Show();
                            }
                        }

                        if (estrelas < 6)
                        {
                            estrelas++;
                        }

                    } // AQUI
                }
                
            }
            else
            {
                MessageBox.Show("Clique em next para continuar!");
            }


        }

        private void pbAlt2_Click(object sender, EventArgs e)
        {
            if (pbNext.Visible == false)
            {
                if (questaoAtual < totQuestoes)
                {
                    if (respostaCorreta == 2) // Se estiver correta
                    {
                        Random random = new Random();

                        acertos++;
                        pbAlt2.Image = Properties.Resources.alt_correct;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1, 9) % 2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }


                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();
                    }
                    else // Se estiver errada
                    {
                        erros++;
                        pbAlt2.Image = Properties.Resources.alt_incorrect;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 1:
                                pbAlt1.Image = Properties.Resources.alt_correct;
                                break;
                            case 3:
                                pbAlt3.Image = Properties.Resources.alt_correct;
                                break;
                            case 4:
                                pbAlt4.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                        }
                        if (estrelas < 6)
                        {
                            estrelas++;
                        }

                    }
                }
                else
                {
                    if (respostaCorreta == 2) // Se estiver correta AQUI
                    {
                        Random random = new Random();

                        acertos++;
                        pbAlt2.Image = Properties.Resources.alt_correct;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1, 9) % 2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }


                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        pbAlt1.Enabled = false;
                        pbAlt2.Enabled = false;
                        pbAlt3.Enabled = false;
                        pbAlt4.Enabled = false;
                        pbNext.Enabled = false;
                        pictureBox2.Enabled = false;

                        new MissaoConcluida(acertos, erros).Show();
                    }
                    else
                    {
                        erros++;
                        pbAlt2.Image = Properties.Resources.alt_incorrect;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 1:
                                pbAlt1.Image = Properties.Resources.alt_correct;
                                break;
                            case 3:
                                pbAlt3.Image = Properties.Resources.alt_correct;
                                break;
                            case 4:
                                pbAlt4.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                            else
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new MissaoConcluida(acertos, erros).Show();
                            }
                        }

                        if (estrelas < 6)
                        {
                            estrelas++;
                        }

                    } // AQUI
                }

                
            }
            else
            {
                MessageBox.Show("Clique em next para continuar!");
            }
        }

        private void pbAlt3_Click(object sender, EventArgs e)
        {
            if (pbNext.Visible == false)
            {
                if (questaoAtual < totQuestoes)
                {
                    if (respostaCorreta == 3) // Se estiver correta
                    {
                        Random random = new Random();

                        acertos++;
                        pbAlt3.Image = Properties.Resources.alt_correct;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1, 9) % 2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }


                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();
                    }
                    else // Se estiver errada
                    {
                        erros++;
                        pbAlt3.Image = Properties.Resources.alt_incorrect;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 1:
                                pbAlt1.Image = Properties.Resources.alt_correct;
                                break;
                            case 2:
                                pbAlt3.Image = Properties.Resources.alt_correct;
                                break;
                            case 4:
                                pbAlt4.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                        }
                        if (estrelas < 6)
                        {
                            estrelas++;
                        }
                    }
                }
                else
                {
                    if (respostaCorreta == 3) // Se estiver correta AQUI
                    {
                        Random random = new Random();

                        acertos++;
                        pbAlt3.Image = Properties.Resources.alt_correct;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1, 9) % 2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }


                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        pbAlt1.Enabled = false;
                        pbAlt2.Enabled = false;
                        pbAlt3.Enabled = false;
                        pbAlt4.Enabled = false;
                        pbNext.Enabled = false;
                        pictureBox2.Enabled = false;

                        new MissaoConcluida(acertos, erros).Show();
                    }
                    else
                    {
                        erros++;
                        pbAlt3.Image = Properties.Resources.alt_incorrect;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 1:
                                pbAlt1.Image = Properties.Resources.alt_correct;
                                break;
                            case 2:
                                pbAlt2.Image = Properties.Resources.alt_correct;
                                break;
                            case 4:
                                pbAlt4.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                            else
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new MissaoConcluida(acertos, erros).Show();
                            }
                        }

                        if (estrelas < 6)
                        {
                            estrelas++;
                        }

                    } // AQUI
                }

                
            }
            else
            {
                MessageBox.Show("Clique em next para continuar!");
            }
        }

        private void pbAlt4_Click(object sender, EventArgs e)
        {
            if (pbNext.Visible == false)
            {
                if (questaoAtual < totQuestoes)
                {
                    if (respostaCorreta == 4) // Se estiver correta
                    {
                        Random random = new Random();

                        acertos++;
                        pbAlt4.Image = Properties.Resources.alt_correct;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1, 9) % 2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }


                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();
                    }
                    else // Se estiver errada
                    {
                        erros++;
                        pbAlt4.Image = Properties.Resources.alt_incorrect;
                        pbNext.Visible = true;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 1:
                                pbAlt1.Image = Properties.Resources.alt_correct;
                                break;
                            case 2:
                                pbAlt2.Image = Properties.Resources.alt_correct;
                                break;
                            case 3:
                                pbAlt3.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                        }

                        if (estrelas < 6)
                        {
                            estrelas++;
                        }
                    }
                }
                else
                {
                    if (respostaCorreta == 4) // Se estiver correta
                    {
                        Random random = new Random();

                        acertos++;
                        pbAlt4.Image = Properties.Resources.alt_correct;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\certo.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        // Mais dinheiro                        
                        if (random.NextInt64(1, 9) % 2 == 0)
                        {
                            dinheiro = dinheiro + Convert.ToInt32(random.NextInt64(1, 100));
                        }


                        if (dinheiro == 0)
                        {
                            dinheiro = 1;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        pbAlt1.Enabled = false;
                        pbAlt2.Enabled = false;
                        pbAlt3.Enabled = false;
                        pbAlt4.Enabled = false;
                        pbNext.Enabled = false;
                        pictureBox2.Enabled = false;

                        new MissaoConcluida(acertos, erros).Show();
                    }
                    else
                    {
                        erros++;
                        pbAlt4.Image = Properties.Resources.alt_incorrect;

                        // Exibe o som
                        try
                        {
                            SoundPlayer som = new SoundPlayer(@"songs\errado.wav");
                            som.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao reproduzir o som: " + ex);
                        }

                        switch (respostaCorreta) // Marcando qual a resposta correta
                        {
                            case 1:
                                pbAlt1.Image = Properties.Resources.alt_correct;
                                break;
                            case 2:
                                pbAlt2.Image = Properties.Resources.alt_correct;
                                break;
                            case 3:
                                pbAlt3.Image = Properties.Resources.alt_correct;
                                break;
                        }

                        // Menos dinheiro
                        Random random = new Random();
                        dinheiro = Convert.ToInt32(Math.Round((float)dinheiro - (dinheiro / random.NextInt64(2, 3))));
                        if (dinheiro < 0)
                        {
                            dinheiro = 0;
                        }
                        lblCash.Text = "R$" + dinheiro.ToString();

                        // Diminuir energia
                        if (pbVest.Visible) // Se estiver com colete
                        {

                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    pbVest.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    pbVest.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    pbVest.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    pbVest.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    pbVest.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    pbStars.Image = Properties.Resources.six_stars;
                                    pbVest.Width -= 45;
                                    break;
                                default:
                                    pbVest.Width -= 50;
                                    break;
                            }
                            if (pbVest.Width <= 0) // Se o colete tiver nível 0
                            {
                                pbVest.Visible = false;
                            }
                        }
                        else // Se estiver só com barra de vida
                        {
                            switch (estrelas) // Verifica o nível de procurado
                            {
                                case 0:
                                    energia = pbHealth.Width -= 20;
                                    pbStars.Visible = true;
                                    pbStars.Image = Properties.Resources.one_star;
                                    break;
                                case 1:
                                    energia = pbHealth.Width -= 25;
                                    pbStars.Image = Properties.Resources.two_stars;
                                    break;
                                case 2:
                                    energia = pbHealth.Width -= 30;
                                    pbStars.Image = Properties.Resources.three_stars;
                                    break;
                                case 3:
                                    energia = pbHealth.Width -= 35;
                                    pbStars.Image = Properties.Resources.four_stars;
                                    break;
                                case 4:
                                    energia = pbHealth.Width -= 40;
                                    pbStars.Image = Properties.Resources.five_stars;
                                    break;
                                case 5:
                                    energia = pbHealth.Width -= 45;
                                    pbStars.Image = Properties.Resources.six_stars;
                                    break;
                                default:
                                    energia = pbHealth.Width -= 50;
                                    break;
                            }
                            if (energia <= 0) // Se a energia acabar. Fim de jogo
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new GameOver().Show();
                            }
                            else
                            {
                                pbAlt1.Enabled = false;
                                pbAlt2.Enabled = false;
                                pbAlt3.Enabled = false;
                                pbAlt4.Enabled = false;
                                pbNext.Enabled = false;
                                pictureBox2.Enabled = false;

                                new MissaoConcluida(acertos, erros).Show();
                            }
                        }

                        if (estrelas < 6)
                        {
                            estrelas++;
                        }

                    }

                    
                }
                
            }
            else
            {
                MessageBox.Show("Clique em next para continuar!");
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            listaQuestoes.RemoveAt(questaoEscolhida);
            pbNext.Visible = false;
            CarregarQuestao();
            ClearAlternatives();
        }

        private void pbNext_MouseEnter(object sender, EventArgs e)
        {
            if (pbNext.Visible)
            {
                pbNext.Image = Properties.Resources.next_button_on;
            }
        }

        private void pbNext_MouseLeave(object sender, EventArgs e)
        {
            if (pbNext.Visible)
            {
                pbNext.Image = Properties.Resources.next_button;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            new Store(this,pbHealth,lblCash,pbStars).Show();
        }
    }
}
