using GrandDevOpsSanAndreas.DataAccess;
using GrandDevOpsSanAndreas.Model;

namespace GrandDevOpsSanAndreas
{
    public partial class Form1 : Form
    {
        int questaoAtual, acertos, erros, respostaCorreta, questaoEscolhida;
        List<Questoes> listaQuestoes = new List<Questoes>(); // Todas as questões

        public Form1()
        {
            InitializeComponent();

            questaoAtual = 1; // Ao iniciar, a questão será sempre a primeira

            // 1 - PEGA TODAS AS QUESTÕES DO BANCO DE DADOS
            QuestoesDAO qdao = new QuestoesDAO();
            listaQuestoes = qdao.ReadQuestions();

            // 2 - SORTEIO PARA SABER QUAL QUESTÃO COMEÇA PRIMEIRO
            Random aleatorio = new Random();
            questaoEscolhida = aleatorio.Next(0,listaQuestoes.Count); // Temos a questão escolhida

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

                    if (randomValue%2==0)
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


    }
}
