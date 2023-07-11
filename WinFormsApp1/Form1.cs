namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string escolhaUsuario;
        private string escolhaMaquina;
        private string[] opcoes =
        {
            "Pedra",
            "Papel",
            "Tesoura"

        };
        private int pontosUsuario, pontosMaquina;
        public Form1()
        {
            InitializeComponent();
        }


        private void SalvaSelecao(string selecao)
        {
            escolhaUsuario = selecao;
            txt_usuario.Text = escolhaUsuario;

            SorteiaSelecaoComputador();

            Comparacao();
        }

        private void SorteiaSelecaoComputador()
        {
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);
            escolhaMaquina = opcoes[sorteio];
            txt_maquina.Text = escolhaMaquina;
        }

        private void Comparacao()
        {
            if (escolhaUsuario == escolhaMaquina)
            {
                txt_resultado.Text = "Deu empate!!!";
            }
            else if (escolhaUsuario == opcoes[0] && escolhaMaquina == opcoes[2])
            {
                pontosUsuario++;
                txt_resultado.Text = "VOCÊ VENCEU!";
            }
            else if (escolhaUsuario == opcoes[1] && escolhaMaquina == opcoes[0])
            {
                pontosUsuario++;
                txt_resultado.Text = "VOCÊ VENCEU!";
            }
            else if (escolhaUsuario == opcoes[2] && escolhaMaquina == opcoes[1])
            {
                pontosUsuario++;
                txt_resultado.Text = "VOCÊ VENCEU!";
            }
            else
            {
                pontosMaquina++;
                txt_resultado.Text = "Você perdeu";
            }
            placar_maquina.Text = pontosMaquina.ToString();
            placar_usuario.Text = pontosUsuario.ToString();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[1]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_TESOURA_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[2]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}