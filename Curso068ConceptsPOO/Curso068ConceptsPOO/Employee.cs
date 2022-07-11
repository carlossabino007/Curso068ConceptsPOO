namespace Curso068ConceptsPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        /* Acá hay composición */
        /* Mi clase Employee está compuesta de: */
        /* Tengo 2 propiedades que son de la clase Date*/
        public Date BirthDay { get; set; }  /* Date es mi clase,la que creé*/

        public Date HiringDate { get; set; } /* Date es mi clase,la que creé*/

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();  // Método abstracto

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}," +
                $" Birth: {BirthDay}," +
                $" Hiring {HiringDate}," +
                $" Is Active: {IsActive}";
        }

    }
}