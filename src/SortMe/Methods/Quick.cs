namespace SortMe.Methods;
using System;

internal class Quick {
    public static int[] Sort(int[] input) {

        //copy of input data
        var arr = new int[input.Length];
        Array.Copy(input, arr, input.Length);
        SortRecursive(arr, 0, arr.Length-1);
        return arr;
    }

    private static void SortRecursive(int[] input, int l, int h) {
        if (l < h) {
            var pivort = Partition(input, l, h);
            SortRecursive(input, l, pivort - 1);
            SortRecursive(input, pivort + 1, h);
        }
    }

    public static int Partition(int[] input, int l, int h) {
        var pivot = input[h];
        var i = l - 1;
        for (var j = l; j < h; j++) {
            if (input[j] < pivot) {
                i++;
                ArrayHelper.Swap(input, i, j);
            }
        }
        var pivotIndex = i + 1;
        ArrayHelper.Swap(input, pivotIndex, h);
        return pivotIndex;
    }
}
