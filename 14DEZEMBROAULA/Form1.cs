using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14DEZEMBROAULA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)// se if for <50 inaceitavel
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60) // se placar for < 60 fraca
                    return ForcaDaSenha.Fraca;
                else if (placar < 80) // se placar for <80 aceitavel
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte; // se placar for < 100 forte
                else
                    return ForcaDaSenha.Segura;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            senha.Text = "";
            label1Mensagem.Text = "";
        }

        private void VerificaCaracter(object sender, KeyEventArgs e) // O Verificacaracteresta no textbox para verificar a sua senha
        {
            ChecaForcaSenha Verifica = new ChecaForcaSenha();// essa linha acessa a classe para verifica a checaforcasenha
            ChecaForcaSenha.ForcaDaSenha forca;// essa linha e pra criar objto que vai guarda os valores 
            forca = Verifica.GetForcaDaSenha(senha.Text); // essa linha consegue verificar o metedo classe somando pra ver se a senha esta forte esta no textbox na propriedade
            label1Mensagem.Text = forca.ToString();// essa linha é o nome da label e forca guarda as variaveis, mostra como vai aparecer
        }
    }
}
