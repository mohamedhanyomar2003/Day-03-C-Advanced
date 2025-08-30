namespace Demo
{
    delegate T3 CustomFunc<in T1,in T2,out T3>(T1 x, T2 y);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 3, 0, 5, 1, 8, 4, 9, 0, 2];
            string[] names = ["Mohamed","Nader","Ali","Omar","Bahaa","Khaled","Ziad","Yaser"];
            // SortingAlgorithm.BubbleSort(arr,new DescComparer());
            CustomFunc<string,string,bool> func = ComparisonTypes.CompareGreater;
            //func = default!;
            SortingAlgorithm<string>.BubbleSort(names,(element1,element2) => element1.CompareTo(element2) > 0);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
