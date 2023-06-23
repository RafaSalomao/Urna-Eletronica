using System;
using System.Drawing;

namespace UrnaEletronica {
    public partial class frmUrnaEletronica : Form {

        private Dictionary<string, Candidato> _dicCandidato;

        public frmUrnaEletronica() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            Image imgCiro = Image.FromFile("D:\\Estudos\\Progamação\\C#\\Projeto Urna Eletronica\\UrnaEletronica\\UrnaEletronica\\img\\cadidatos\\ciro.jpg");
            Image imgLula = Image.FromFile("D:\\Estudos\\Progamação\\C#\\Projeto Urna Eletronica\\UrnaEletronica\\UrnaEletronica\\img\\cadidatos\\lula.jpg");
            Image imgPadre = Image.FromFile("D:\\Estudos\\Progamação\\C#\\Projeto Urna Eletronica\\UrnaEletronica\\UrnaEletronica\\img\\cadidatos\\padre.jpeg");
            Image imgBolsonaro = Image.FromFile("D:\\Estudos\\Progamação\\C#\\Projeto Urna Eletronica\\UrnaEletronica\\UrnaEletronica\\img\\cadidatos\\bolsonaro.jpeg");


            //Adiciona os candidatos no dicionário "_dicCandidato"
            _dicCandidato = new Dictionary<string, Candidato>();
            _dicCandidato.Add("12", new Candidato() { Id = "12", Nome = "Ciro Gomes", Partido = "PDT", Foto = imgCiro });
            _dicCandidato.Add("13", new Candidato() { Id = "13", Nome = "Lula", Partido = "PT", Foto = imgLula });
            _dicCandidato.Add("14", new Candidato() { Id = "14", Nome = "Padre Kelmon", Partido = "PTB", Foto = imgPadre });
            _dicCandidato.Add("22", new Candidato() { Id = "22", Nome = "Jair Bolsonaro", Partido = "PL", Foto = imgBolsonaro });

        }

        private void frmUrnaEletronica_Load(object sender, EventArgs e) {

        }

        private void btn0_Click(object sender, EventArgs e) {
            RegistrarDigito("0");
        }

        private void btn1_Click(object sender, EventArgs e) {
            RegistrarDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e) {
            RegistrarDigito("2");
        }

        private void btn3_Click(object sender, EventArgs e) {
            RegistrarDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e) {
            RegistrarDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e) {
            RegistrarDigito("5");

        }

        private void btn6_Click(object sender, EventArgs e) {
            RegistrarDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e) {
            RegistrarDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e) {
            RegistrarDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e) {
            RegistrarDigito("9");
        }

        private void btnBranco_Click(object sender, EventArgs e) {

        }

        private void btnCorrige_Click(object sender, EventArgs e) {
            Limpar();
        }

        private void btnConfirma_Click(object sender, EventArgs e) {

        }

        private void pnVoto_Paint(object sender, PaintEventArgs e) {

        }

        //
        private void RegistrarDigito(string digito) {

            if (string.IsNullOrEmpty(txtDigito1.Text)) {
                txtDigito1.Text = digito;
            }
            else {
                txtDigito2.Text = digito;
                PreencherCandidato(txtDigito1.Text, txtDigito2.Text);
            }

        }

        private void PreencherCandidato(string digito1, string digito2) {

            if (_dicCandidato.ContainsKey(digito1 + digito2)) {

                lbNome.Text = ($"Nome: {_dicCandidato[digito1 + digito2].Nome}");
                lbPartido.Text = ($"Partido: {_dicCandidato[digito1 + digito2].Partido}");
                pbFoto.Image = _dicCandidato[digito1 + digito2].Foto;
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                MessageBox.Show("Candidato não encontrado");
                Limpar();
            }

        }

        private void Limpar() {
            txtDigito1.Text = "";
            txtDigito2.Text = "";
            txtDigito1.Focus();
            lbNome.Text = "Nome: ";
            lbPartido.Text = "Partido: ";
            pbFoto.Image = null;
        }


    }
}