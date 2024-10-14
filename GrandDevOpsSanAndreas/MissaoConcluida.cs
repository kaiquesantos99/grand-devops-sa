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
    public partial class MissaoConcluida : Form
    {
        public MissaoConcluida(int acertos, int erros)
        {
            InitializeComponent();

            lblAcertos.Text = acertos.ToString();
            lblErros.Text = erros.ToString();

            try
            {
                SoundPlayer som = new SoundPlayer(@"songs\missao_concluida.wav");
                som.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao reproduzir o som: " + ex);
            }
        }
    }
}
