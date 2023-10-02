using EmployeeOOP.Exceptions;

namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public decimal CommissionPercentaje { get; set; }
        public int Sales { get; set; }
        #endregion

        #region Methods

        public CommissionEmployee() { }

        public override decimal GetValueToPay()
        {
            return (CommissionPercentaje / 100) * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                    $"Salario Devengado: {GetValueToPay():C2}\n\t";
        }

        #endregion
    }
}