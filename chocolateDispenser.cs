using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace chocolateDispenser
{

    internal class Program
    {
        List<string> myList = new List<string>();

        public void addChocolates(string clr, int qnty)     //adding chocolates on top of the dispenser
        {
            for (int i = 0; i < qnty; i++)
            {
                myList.Insert(0, clr);
            }
        }

        public string[] removeChocolates(int qnty)              //removing from top
        {
            string[] arr = new string[qnty];
            for (int i = 0; i < qnty; i++)
            {

                arr[i] = myList[0];
                myList.RemoveAt(0);

            }
            return arr;
        }

        public string[] dispenseChocolates(int qnty)
        {
            string[] arr = new string[qnty];                //dispense chocolates from bottom
            for (int i = 0; i < qnty; i++)
            {
                int len = myList.Count();
                arr[i] = myList[len - 1];
                myList.RemoveAt(len - 1);

            }
            return arr;

        }
        public  string[] dispenseChocolatesOfColor(int qnty, string color)
        {
            int length = myList.Count();
            string[] arr = new string[qnty];
            int qnty_count = 0;                                     //dispense chocolate based on color
            for (int iter = length - 1; iter >= 0; iter--)
            {
                if (myList[iter] == color)
                {
                    arr[qnty_count++] = color;
                    myList.RemoveAt(iter);
                }

            }
            return arr;
        }
        public Dictionary<string,int> noOfChocolates()
        {
            Dictionary<string, int> dict = new Dictionary<string,int>();
            int noOfRed = 0, noOfGreen = 0, noOfBlue = 0, noOfBlack = 0, noOfYellow = 0;
            foreach(string listItem in myList)
            {                                                           
                if(listItem =="red")                      //finding no. of chocolates
                {
                    noOfRed++;  
                }
                else if (listItem == "green")
                {
                    noOfGreen++;
                }
                else if (listItem == "blue")
                {
                    noOfBlue++;
                }
                else if (listItem == "black")
                {
                    noOfBlack++;
                }
                else if (listItem == "yellow")
                {
                    noOfYellow++;
                }
            }
            dict.Add("red", noOfRed);
            dict.Add("blue", noOfBlue);
            dict.Add("green", noOfGreen);
            dict.Add("black", noOfBlack);
            dict.Add("yellow", noOfYellow);

            return dict;
        }
        public void sortChocolateBasedOnQuantity(Dictionary<string, int> dict)
        {
            var mySortedList = dict.OrderBy(x => x.Value).ToList();
            foreach (var item in mySortedList)
            {
                if(item.Value!=0)
                Console.WriteLine(item);
            }
        }

        public void changeChocolateCount(int number, string color, string finalColor)
        {
            int count = 0;                                          //Alter chocolate color
            for (int item =0;item< myList.Count;item++)
            {
                if (count<number && myList[item]==color)
                {
                    count++;
                    myList[item] = finalColor;
                }
            }
        }

        public void changeChocolateColorAllOfxCount(string color, string finalColor)
        {
            for (int item = 0; item < myList.Count; item++)
            {
                if (myList[item] == color)                       //change all given color to final color
                {
                    myList[item] = finalColor;
                }
            }
        }

        public void removeChocolateOfColor(string color)
        {
            for(int item =0;item< myList.Count;item++)
            {
                if (myList[item] == color)                    //removing a single fav color chocolate
                {
                    Console.WriteLine($"here is a {color} chocolate for you");
                    myList.RemoveAt(item);
                    break;
                }
            }
        }
        public void display()
        {
            foreach (string listItem in myList)
            {
                Console.WriteLine(listItem);
            }
        }


    
            static void Main(string[] args)
            {
                var obj = new Program();
                obj.addChocolates("red", 1);
                obj.addChocolates("blue", 1);
                obj.addChocolates("green", 1);
                obj.addChocolates("blue", 2);
                obj.addChocolates("red", 1);
                obj.addChocolates("black", 1);
                obj.addChocolates("blue", 1);
                obj.addChocolates("blue", 1);
                obj.addChocolates("yellow", 1);
                obj.addChocolates("red", 1);
            //string[] removalFromTop = obj.removeChocolates(2);
            //string [] removalFromBottom =obj.dispenseChocolates(3);
            //string [] removalBasedOnColor = obj.dispenseChocolatesOfColor(2, "red");
            //Dictionary<string, int> d = obj.noOfChocolates();
            /*foreach(KeyValuePair<string,int> kvp in d)
            {
                Console.WriteLine(kvp.Value +"nos of "+kvp.Key+" chocolate is available" );
            }*/

            //obj.sortChocolateBasedOnQuantity(d);
            /*foreach (string listItem in removalBasedOnColor)
            {
                Console.WriteLine(listItem + " ");
            }*/
            /*obj.display();
            Console.WriteLine();
            obj.changeChocolateCount(2, "blue", "yellow");
            obj.changeChocolateColorAllOfxCount("red","blue");*/

            //obj.removeChocolateOfColor("red");
            obj.display();
        }
     }
    
}