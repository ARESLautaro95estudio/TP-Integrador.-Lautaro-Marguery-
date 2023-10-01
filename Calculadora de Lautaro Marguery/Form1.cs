using Entidades;

namespace Calculadora_de_Lautaro_Marguery
{
    public partial class Form1 : Form
    {
        private Numeracion resultado, primerOperando, segundoOperando;
        private ESistema sistema;
        private operacion calculadora;
        public Form1()
        {
            InitializeComponent();
        }
        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

            this.txtPrimerOperador.TabIndex = 1;
            this.cmbOperacion.TabIndex = 2;
            this.txtSegundoOperador.TabIndex = 3;
            this.btnOperar.TabIndex = 4;
            this.btnLimpiar.TabIndex = 5;
            this.btnCerrar.TabIndex = 6;

            this.cmbOperacion.Items.Add('+');
            this.cmbOperacion.Items.Add('-');
            this.cmbOperacion.Items.Add('*');
            this.cmbOperacion.Items.Add('/');
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.lblFResultado.Text = string.Empty;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show(
            //    "Queres cerrar"
            //    , "Cierra"
            //    , MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question);

            //if (dialogResult == DialogResult.No)
            //{
            //    this.Close();
            //}
        }

        private void setResultado()
        {
            //this.resultado.Sistem;
            this.lblFResultado.Text = this.resultado.ConvertirA(this.sistema);

        }
        private void btnOperar_Click(object sender, EventArgs e)
        {

            this.primerOperando = new Numeracion(this.txtPrimerOperador.Text, ESistema.Decimal);
            this.segundoOperando = new Numeracion(this.txtSegundoOperador.Text, ESistema.Decimal);
            this.calculadora = new operacion(this.primerOperando, this.segundoOperando);
            char oper = (char)this.cmbOperacion.SelectedItem;
            double.TryParse(this.calculadora.Operar(oper), out double aux);

            if (this.rdbBinario.Checked)
            {
                this.sistema = ESistema.Binario;
            }
            else
            {
                this.sistema = ESistema.Decimal;
            }
            this.resultado = new Numeracion(aux, ESistema.Decimal);
            this.setResultado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
              "Queres cerrar"
              , "Cierra"
              , MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}