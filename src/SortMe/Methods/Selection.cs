namespace SortMe.Methods;


internal class Selection {
    public static int[] Sort(int[] input) {

        //copy of input data
        var arr = new int[input.Length];
        Array.Copy(input, arr, input.Length);


        var l = arr.Length;

        //min value index
        var k = 0;
        var key = 0;
        //just to loop all the element
        for (var i = 0; i < l; i++) {

            //record key in temp min index
            key = arr[i];
            k = i;

            //scan in remaining and for min value
            for (var j = i + 1; j < l; j++) {
                if (arr[j] < arr[k]) {
                    k = j;
                }
            }

            if (k != i) {
                ArrayHelper.Swap(arr, k, i);
            }

        }
        return arr;
    }
}
