using EmployeeOOP.Exceptions;

namespace EmployeeOOP.Classes
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods

        public BaseCommissionEmployee() { }

        public override decimal GetValueToPay()
        {
            return ((CommissionPercentaje / 100) * Sales)+Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                    $"Salario Devengado: {(CommissionPercentaje / 100) * Sales:C2}\n\t";
        }

        #endregion
    }
}