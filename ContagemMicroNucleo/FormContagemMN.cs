using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContagemMicroNucleo
{
    public partial class FormContagemMN : Form
    {
        public FormContagemMN()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            ContagemMN_106 contagem = new ContagemMN_106();
            contagem.SomatorioQuadrantes = int.Parse(txtSomatorioQuad.Text);
            ContagemMN_106_Resultado resultado = contagem.Calcular();

            AtribuiResultado(resultado);
        }

        private void AtribuiResultado(ContagemMN_106_Resultado resultado)
        {
            txtValorContado10_4.Text = Converter(resultado.ValorContado10_4, 2);
            txtValorContado10_6.Text = Converter(resultado.ValorContado10_6, 2);
            txtCelulas10_6.Text = Converter(resultado.Celulas10_6, 2);
            txtFrascoVolume.Text = Converter(resultado.FrascoMililitro, 3) +
                " ml = " +
                Converter(resultado.FrascoMicrolitro, 3) +
                " ul";
            txtFrascoQuantidade.Text = Converter(resultado.FrascoQuantidade, 2);
        }

        private string Converter(Decimal valor, int casasDecimais)
        {
            return Decimal.Round(valor, casasDecimais).ToString();
        }
    }
}
