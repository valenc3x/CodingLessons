using System;

namespace LeetCode {
    public class FrogJump {
        public static bool CanJump(int[] stones) {
            int jump_distance = 1;
            int last = stones[0];
            int this_jump = 0;

            for (int i=1; i<stones.Length; i++) {
                this_jump = last + jump_distance;
                Console.WriteLine(jump_distance);
                if (i < stones.Length-2 ) {
                    if (this_jump+1 == stones[i+1]) {
                        Console.WriteLine("+1i->" + stones[i+1]);
                        jump_distance++;
                        i++;
                        last = stones[i];
                        continue;
                    }
                }

                if (this_jump-1 == stones[i]) {
                    jump_distance--;
                    Console.WriteLine("-1 ->" + stones[i]);
                } else if (this_jump == stones[i]) {
                    // continue
                    Console.WriteLine("+0 ->" + stones[i]);
                } else if (this_jump+1 == stones[i]) {
                    jump_distance++;
                    Console.WriteLine("+1 ->" + stones[i]);
                } else {
                    return false;
                }
                last = stones[i];
            }
            return true;
        }

        public static void Main(){
            int[] stones = new int[] {0, 1, 3, 5, 6, 8, 12, 17};
            Console.WriteLine( CanJump(stones) );
        }
    }
}
