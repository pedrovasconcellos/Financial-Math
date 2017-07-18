using System;

// ============================================= 
// Author:    Pedro Henrique Vasconcellos 
// Create date: 26/04/2017 
// Description:  Devolve uma String com a formatação
// =============================================

namespace CalcFinanceiro
{
    public class FormatarValores
    {
        public string PercentFormat(int CasasDecimais)
        {
            string PercentFormat;
            switch (CasasDecimais)
            {
                case 1:
                    PercentFormat = "#0.0";
                    break;
                case 2:
                    PercentFormat = "#0.00";
                    break;
                case 3:
                    PercentFormat = "#0.000";
                    break;
                case 4:
                    PercentFormat = "#0.0000";
                    break;
                default:
                    PercentFormat = "#0.00";
                    break;
            }

            return PercentFormat;
        }

    }
}

