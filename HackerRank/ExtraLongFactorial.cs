using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Numerics;

class ExtraLongFactorial {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger result = new BigInteger(1);

        for(int i = 1; i < n; i++){
            result = BigInteger.Multiply(result, new BigInteger(i));
        }
        System.Console.WriteLine(result);
    }
}
