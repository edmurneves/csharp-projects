using System;
using System.Globalization;

namespace Course;

class ConversorDeMoeda {

    public static double Conversor(double cotacao, double qte) {
        return qte * cotacao * 1.06;
    }
}