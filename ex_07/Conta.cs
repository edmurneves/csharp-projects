using System.Globalization;

namespace ex_07;

class Conta {
    public int IdConta {get; private set;}
    public string Nome {get; set;}
    public double Saldo {get; private set;}

    
    public Conta(int idConta, string nome) {
        IdConta = idConta;
        Nome = nome;
        Saldo = 0.0;
    }
    public Conta(int idConta, string nome, double depInicial ) : this(idConta, nome) {
        Deposito(depInicial);
    }

    public void Deposito(double valor) {
        Saldo += valor;
    }

    public void Saque(double valor) {
        Saldo -= valor + 5.0;
    }

    public override string ToString()
    {
        return "Conta "
        + IdConta
        + " Titular: "
        + Nome
        + ", "
        + "Saldo: $ "
        + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }



}
