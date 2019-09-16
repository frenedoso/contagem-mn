using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemMicroNucleo
{
    public class ContagemMN_106_Resultado
    {
        public decimal ValorContado10_4 { get; set; }
        public decimal ValorContado10_6 { get; set; }
        public decimal Celulas10_6 { get; set; }
        public decimal FrascoMililitro { get; set; }
        public decimal FrascoMicrolitro { get; set; }
        public decimal FrascoQuantidade { get; set; }
    }

    public class ContagemMN_106
    {

        public int SomatorioQuadrantes { get; set; }

        public ContagemMN_106_Resultado Calcular()
        {
            ContagemMN_106_Resultado resultado = new ContagemMN_106_Resultado();
            resultado.ValorContado10_4 = SomatorioQuadrantes / 4;
            resultado.ValorContado10_6 = resultado.ValorContado10_4 / 100;
            resultado.Celulas10_6 = resultado.ValorContado10_6 * 5;
            resultado.FrascoMililitro = 10 / resultado.Celulas10_6;
            resultado.FrascoMicrolitro = resultado.FrascoMililitro * 1000;
            resultado.FrascoQuantidade = 10000 / resultado.FrascoMicrolitro;

            return resultado;
        }
    }
}
