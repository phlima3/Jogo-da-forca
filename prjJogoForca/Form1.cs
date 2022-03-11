using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lista = new List<string>(){
           "ABAJUR","ABRIDOR","BACIA","BALANCA","CABIDE","CADEADO","DADO","DARDO","ESCADA","ENXADA","FACA","FICHA","GAIOLA","GAITA","HARPA","HASTE","IMPRESSORA","ISCA","JALECO","JOIA","LAMINA","LAMPADA","MACHADO","MARTELO","NOTEBOOK","NAVALHA","OCULOS","OMBREIRA","PA","PANELA","QUADRICICLO","QUADRO","RADIO","RALADOR","SACO","SALEIRO","TABUA","TABULEIRO","URNA","UNIFORME","VARA","VARAL","WEBCAM","ZIPER"
       };
        Forca jogo;
        private void Form1_Load(object sender, EventArgs e)
        {
            jogo = new Forca(lista);
            jogo.Sortear();
            MessageBox.Show(jogo.DevolvePalavra());
        }
    }
}
