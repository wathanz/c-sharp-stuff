namespace SortMe.Methods;
using System;

internal class Insertion {
    public static int[] Sort(int[] input) {
        //copy of input data
        var arr = new int[input.Length];
        Array.Copy(input, arr, input.Length);


        var l = arr.Length;
        var j = 0;
        var key = 0;

        // try to insert from second element
        for (var i = 1; i < l; i++) {

            //to be inserted
            key = arr[i];

            //to be scaned in the existing values
            j = i - 1;

            //looking for the right slot to filled in
            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;

        }
        return arr;
    }
}
