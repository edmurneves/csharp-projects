using System;
using System.Globalization;

namespace Course;

class ConversorDeMoeda {

    public static double Iof = 6.0;
    public static double Conversor(double cotacao, double qte) {
        return qte * cotacao * ( 1 + Iof / 100.0);
    }
}