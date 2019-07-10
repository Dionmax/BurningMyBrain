namespace Aula130_Heranca_Polimorfismo.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee() { }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        => base.Payment() + (AdditionalCharge * 1.1);
    }
}
