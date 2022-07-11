namespace Curso068ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
            // Acá puedo sacar deducciones de nómina, seguridad, retención, etc
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $" \n\tValue to pay............: { $"{GetValueToPay():C2}", 15 }";

        }
    }
}
