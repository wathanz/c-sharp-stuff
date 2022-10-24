namespace SortMe.Methods;

internal class Bubble {
    public static int[] Sort(int[] input) {

        //copy of input data
        var arr = new int[input.Length];
        Array.Copy(input, arr, input.Length);


        var swapped = 0;
        var l = arr.Length;

        //just to loop all the element
        for (var i = 0; i < l; i++) {
            swapped = 0;
            //swaping until unsorted element
            for (var j = 0; j < l - 1 - i; j++) {
                if (arr[j] > arr[j + 1]) {
                    ArrayHelper.Swap(arr, j, j + 1);
                    swapped++;
                }
            }
            //early all sorted detected
            if (swapped == 0) {
                break;
            }
        }
        return arr;
    }
}
