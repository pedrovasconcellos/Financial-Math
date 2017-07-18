using System;
using Microsoft.VisualBasic;

// ============================================= 
// Author:    Pedro Henrique Vasconcellos 
// Create date: 26/04/2017 
// Description:  Cálculos Financeiro
// =============================================

namespace CalcFinanceiro
{
    public class TaxaInternaRetorno
    {
        public int Parcelas { get; set; }
        public float ValorParcela { get; set; }
        public float ValorFinanciado { get; set; }
        public int CasasDecimais { get; set; }

        // Taxa Interna De Retorno TIR
        public double CalcularTaxa()
        {
            double[] Valores = new double[Parcelas + 1];
            Valores[0] = ValorFinanciado * (-1);
            for (int i = 1; i < Parcelas + 1; i++)
            {
                Valores[i] = ValorParcela;
            }
            //TIR - Utilizando taxa de advinhação de 10%
            double Guess = 0.1;
            double CalcRetRate = Financial.IRR(ref Valores, Guess) * 100;

            FormatarValores FormatarValores = new FormatarValores();
            return Double.Parse(Strings.Format(CalcRetRate, FormatarValores.PercentFormat(CasasDecimais)));
        }
    }
}