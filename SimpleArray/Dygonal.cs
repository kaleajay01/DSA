// using System;
// using System.Runtime.CompilerServices;

// class DygonalArray
// {
//     static void Main()
//     {
//         int[,] a =
//         {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         int[,] b =
//         {
//             {9, 8, 7},
//             {6, 5, 4},
//             {3, 2, 1}
//         };

//         int[,] dygonal = new int[3, 3];
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 if (i == j)
//                 {
//                     dygonal[i, j] = a[i, j];
//                     //Console.WriteLine("1");
//                 }
//                 else
//                 {
//                    // Console.WriteLine("0");
//                 }
//             }
//         }

//         Console.WriteLine("Dygonal Matrix:");
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 3; j++)
//             {
//                 Console.Write(dygonal[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }