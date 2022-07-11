using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso068ConceptsPOO
{
    public class CommissionEmployee : Employee
    {

        public float ComissionPercentaje { get; set; }

        public decimal Sales { get; set; }


        public override decimal GetValueToPay()
        {
            return (decimal)ComissionPercentaje * Sales;

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $" \n\tCommission Percentaje...: {$"{ComissionPercentaje:P2}", 15}"+
            $" \n\tSales...................: {$"{Sales:C2}",15}" +
            $" \n\tValue to pay............: {$"{GetValueToPay():C2}", 15}";

        }
    }
}
