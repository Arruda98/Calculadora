namespace Calculator.API
{
    public class Calculator
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }

        public double Somar()
        {
            return NumberOne + NumberTwo;
        }

        public double Multiplicar()
        {
            return NumberOne * NumberTwo;
        }

        public double Dividir()
        {
            return NumberOne / NumberTwo;
        }

        public double Subtrair()
        {
            return NumberOne - NumberTwo;
        }

        public double Potencia()
        {
            return Math.Pow(NumberOne, NumberTwo);
        }

        public double Porcentagem()
        {
            return (NumberTwo * NumberOne) / 100;
        }
    }
}
