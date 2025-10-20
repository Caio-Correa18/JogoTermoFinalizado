namespace TermoOfIssac
{
    public partial class TermoOfIsaac : Form
    {
        public TermoOfIsaac()
        {
            InitializeComponent();
        }

        private void Teclado(object sender, KeyPressEventArgs e)
        {
            //*if (coluna > 5) return;
            //Botão do teclado 
            var button = (Button)sender;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            //Botão do tabuleiro
            var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.Text = button.Text;
            coluna++;
        }

        private void TermoOfIsaac_Load(object sender, EventArgs e)
        {

        }
    }
}
