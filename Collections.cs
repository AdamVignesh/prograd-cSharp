namespace collections_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            var myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            Console.WriteLine("using List from collections");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            //hashSet
            var myHashSet = new HashSet<string>();
            myHashSet.Add("adam");
            myHashSet.Add("vignesh");
            myHashSet.Add("prabu");
            myHashSet.Add("navanee");
            myHashSet.Add("thas");
            myHashSet.Add("thas");
            Console.WriteLine("using HashSet from collections");
            foreach (var item in myHashSet)
            {
                Console.WriteLine(item);
            }

            //sortedSet
            var mySortedSet = new SortedSet<string>();
            mySortedSet.Add("adam");
            mySortedSet.Add("vignesh");
            mySortedSet.Add("prabu");
            mySortedSet.Add("navanee");
            mySortedSet.Add("thas");
            mySortedSet.Add("thas");
            Console.WriteLine("using SortedSet from collections");
            foreach (var item in mySortedSet)
            {
                Console.WriteLine(item);
            }

            //stack

            var stk = new Stack<int>();
            stk.Push(1);
            stk.Push(2);    
            stk.Push(3);
            stk.Push(4);
            stk.Push(5);
            Console.WriteLine("using stack from collections");
            while (stk.Count > 0)
            {
                Console.WriteLine(stk.Pop());
            }

            //queue

            var q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            Console.WriteLine("using queue from collections");
            while (q.Count>0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}