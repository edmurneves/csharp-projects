using System;
using System.Globalization;

namespace course;

class ContaBancaria {
    public int Numero { get; private set;}
    public string Nome { get; set;}
    public double Saldo { get; private set;}

    public ContaBancaria(int numero, string nome) {
        Numero = numero;
        Nome = nome;
    }

    public ContaBancaria(int numero, string nome, double quantia) : this (numero, nome) {
        Deposito(quantia);
    }

    public void Deposito(double quantia) {
        Saldo += quantia;
    }

    public void Saque(double quantia) {
        Saldo -= quantia + 5;
    }

    public override string ToString() {    
        return "Conta "
        + Numero
        + ", "
        + "Titular: " + Nome
        + ", "
        + "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }

}
