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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();

            try
            {
                SoundPlayer som = new SoundPlayer(@"songs\wasted.wav");
                som.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao reproduzir o som: " + ex);
            }
        }
    }
}
