namespace SortMe.Selection;

internal class Combination {

    public static void GenCombination(int[] numbs, int count) {
        var data = new int[count];
        GenCombination(numbs, data, count, 0, 0, numbs.Length);
    }
    private static void GenCombination(int[] numbs, int[] data, int count, int scanStart, int dataIndex, int len) {
        var remaining = count - dataIndex;
        //one match with count
        if (dataIndex == count) {
            Console.WriteLine(string.Join(",", data));
            return;
        }

        for (var i = scanStart; i < len - remaining + 1; i++) {
            data[dataIndex] = numbs[i];
            GenCombination(numbs, data, count, i + 1, dataIndex + 1, len);
        }
    }

}
