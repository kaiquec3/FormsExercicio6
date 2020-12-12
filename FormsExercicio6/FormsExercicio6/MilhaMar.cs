using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExercicio6
{
    class MilhaMar
    {
        double valor;
        double convertido;

        public MilhaMar()
        {
            this.valor = 0;
        }

        public MilhaMar(double valor)
        {
            this.valor = valor;
        }
        public void SetValor(double valor)
        {
            this.valor = valor;
        }

        public double GetValor()
        {
            return this.valor;
        }

        public double GetConvertido()
        {
            return this.convertido;
        }

        public double ConverterMilhaMarParaMetros()
        {
            this.convertido = this.valor * 1852;
            return this.convertido;
        }

    }
}
