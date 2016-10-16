using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class TaumAndBDay {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_b = Console.ReadLine().Split(' ');
            long b = Convert.ToInt64(tokens_b[0]);
            long w = Convert.ToInt64(tokens_b[1]);
            string[] tokens_x = Console.ReadLine().Split(' ');
            // black
            long x = Convert.ToInt64(tokens_x[0]);
            // white
            long y = Convert.ToInt64(tokens_x[1]);
            // convert
            long z = Convert.ToInt64(tokens_x[2]);
            long cost = 0;
            // convert is too expensive
            if(x > (y+z)){
                // black more expensive than white + convert
                cost += w * y;
                cost += (y + z) * b;
            } else if (y > (x+z)){
                // white is more expensive than black + convert
                cost += b * x;
                cost += (x + z) * w;
            } else {
                 cost += (b*x) + (w*y);
            }
            System.Console.WriteLine(cost);
        }
    }
}

            // if((z > x && z > y) || (z == x && z == y)){
            //     cost += (b*x) + (w*y);
            // }else if(x > (y+z)){
            //     // black more expensive than white + convert
            //     cost += w * y;
            //     cost += (y + z) * b;
            // } else if (y > (x+z)){
            //     // white is more expensive than black + convert
            //     cost += b * x;
            //     cost += (x + z) * w;
            // }
/*
    10
    384 887
    2778 6916 7794
    336 387
    493 6650 1422
    363 28
    8691 60 7764
    927 541
    3427 9173 5737
    212 369
    2568 6430 5783
    531 863
    5124 4068 3136
    930 803
    4023 3059 3070
    168 394
    8457 5012 8043
    230 374
    4422 4920 3785
    538 199
    4325 8316 4371


7201244
906753
2841792
8134553
2917086
6231528
6197767
3395504
2857140
3981734

*/
