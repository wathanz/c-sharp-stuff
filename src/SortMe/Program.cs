

/*
using SortMe.Methods;
int[] arr = { 23, 2, 5, 12, 4, 78, 100 };
var bubbleSorted = Bubble.Sort(arr);
var insertionSorted = Insertion.Sort(arr);
var selectionSorted = Insertion.Sort(arr);
var quickSorted = Quick.Sort(arr);

ArrayHelper.Print("BUBBLE-SORTED", arr, bubbleSorted, ',');
ArrayHelper.Print("INSERTION-SORTED", arr, insertionSorted, ',');
ArrayHelper.Print("SELECTION-SORTED", arr, selectionSorted, ',');
ArrayHelper.Print("QUICK-SORTED", arr, quickSorted, ',');
*/

using SortMe.Selection;

var arr = new int[] { 1, 2, 5, 6, 7,20,23,45 };
Combination.GenCombination(arr, 3);

