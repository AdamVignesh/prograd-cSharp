namespace bullets_heroAndVillian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The game starts here:");
            Console.WriteLine("Enter the number of bullets HERO has: ");
            int hero_bullets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of bullets VILLIAN has: ");
            int villian_bullets = Convert.ToInt32(Console.ReadLine());

            var hero_stk = new Stack<int>();
            var villian_stk = new Stack<int>(); 

            for(int i=1;i<=hero_bullets;i++)
            {
                hero_stk.Push(i);
            }
            for (int i = 1; i <=villian_bullets; i++)
            {
                villian_stk.Push(i);
            }

            while(true)
            {
                Console.WriteLine("Press 1 to exit");
                Console.WriteLine("Press 2 for the hero to shoot");
                int value = Convert.ToInt32(Console.ReadLine());
                if(value == 1)
                {
                    break;
                }
                else if(value == 2)
                {
                    if(hero_stk.Count!=0)
                    {
                        Console.Write(hero_stk.Pop()+" ");
                        Console.WriteLine();
                        for(int j=0;j<3;j++)
                        {
                            if (villian_stk.Count != 0)
                            {
                                Console.Write(villian_stk.Pop()+" ");
                                Console.WriteLine();    
                            }
                            else
                            {
                                Console.WriteLine("villian is dead");
                                break;
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("hero is dead");
                        break;
                    }
                }
            }
        }
    }
}
