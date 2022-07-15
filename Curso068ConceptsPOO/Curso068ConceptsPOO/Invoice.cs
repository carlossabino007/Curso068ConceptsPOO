namespace Curso068ConceptsPOO
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}\n\t" +
                $"Quantity.........{$"{Quantity:N2}",15}" +
                $"Price............{$"{Price:C2}",15}" +
                $"GetValueToPlay...{$"{GetValueToPay():C2}",15}";

        }
    }
}
