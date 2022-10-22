using System;
using System.Globalization;

namespace ex_04;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto *= 1 + porcentagem / 100;   

    }

    public override string ToString()
    {
        return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

    }
}