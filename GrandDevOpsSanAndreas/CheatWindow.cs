using GrandDevOpsSanAndreas.DataAccess;
using GrandDevOpsSanAndreas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandDevOpsSanAndreas
{
    public partial class CheatWindow : Form
    {
        public CheatWindow()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            QuestoesDAO qdao = new QuestoesDAO();
            Questoes questaoBuscada = qdao.SearchQuestion(txtPalavraChave.Text);

            lblQuestaoBuscada.Text = questaoBuscada.Question;
            lblRespostaCorreta.Text = questaoBuscada.Option1;



        }
    }
}
