namespace SortMe.Methods;


internal class ArrayHelper {
    public static void Swap<T>(T[] array, int i, int j) {
        if (i == j) {
            return;
        }

        var t = array[i];
        array[i] = array[j];
        array[j] = t;
    }

    public static void Print<T>(string name, T[] before, T[] after, char seperator)
        => Console.WriteLine($"==== {name} ====" +
            $"{Environment.NewLine}" +
            $"ORG    :[{string.Join(seperator, before)}]" +
            $"{Environment.NewLine}" +
            $"SORTED :[{string.Join(seperator, after)}]" +
            $"{Environment.NewLine}");
}
