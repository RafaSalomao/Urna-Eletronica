namespace UrnaEletronica {
    public partial class frmUrnaEletronica : Form {
        public frmUrnaEletronica() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            txtDigito1.Text = "";
            txtDigito2.Text = "";
            txtDigito1.Focus();
        }

        private void btnConfirma_Click(object sender, EventArgs e) {

        }

        private void pnVoto_Paint(object sender, PaintEventArgs e) {

        }

        private void txtDigito1_TextChanged(object sender, EventArgs e) {

        }

        private void txtDigito2_TextChanged(object sender, EventArgs e) {

        }
         
        private void RegistrarDigito (string digito){

            if (string.IsNullOrEmpty(txtDigito1.Text)) {
                txtDigito1.Text = digito;
            }
            else {
                txtDigito2.Text = digito;
            }

        }
    }
}