﻿using System;

namespace Selection_Sort_100_Messy
{
    class SelectionSort
    {
        static void Main()
        {

            int[] array = new int[] { 4923, 714, 2033, 2208, 6151, 4245, 3151, 3756, 6723, 9260,
                9452, 6423, 6331, 8912, 9951, 1023, 321, 3653, 5379, 1156,
                4585, 8478, 3752, 3998, 5586, 2646, 4357, 3613, 7358, 5743,
                8472, 6019, 5427, 3606, 7474, 4943, 60, 5772, 6754, 408,
                6543,9338, 8871, 758, 3249, 6812, 6333, 8013, 344, 7502,
                6286,4244,5161, 3913, 1981, 3021, 3841, 8430, 6300, 5894,
                1935, 4358,6240,8190, 5381, 3000, 9076, 8789, 2249, 6873,
                5558, 4633, 68, 4711,5337, 2696, 8010, 629, 5503, 3276,
                4841, 7360, 3483, 6731, 6328, 6700, 4384, 6220, 6548, 4295,
                7692, 6686, 4865, 1560, 856, 1232, 5557, 2922, 9578, 4837 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) // swap items
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++) // print sorted array
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
