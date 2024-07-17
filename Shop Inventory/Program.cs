namespace Shop_Inventory;

class Program
{

    static Shop shop= new Shop();
    public static void Main(string[] args)

            {

            

                // MARK: Setup
                Console.WriteLine("Add your inventory items:");

                for(int index = 0; index < 3; index++)
                {
                    var item = Console.ReadLine();
                    AddItem(index, item);
                }
                
                // MARK: Result
                Console.WriteLine("Retrieve all stored items:");
                GetAllItems();
            }

            // MARK: Write your solution here
            public static void AddItem(int index, string name)
            {
                try
                {
                    shop[index] = name;
                }
                catch (System.Exception e)
                {
                    
                    Console.WriteLine(e.Message);
                }
            
            }

            // MARK: Write your solution here
            public static void GetAllItems()
            {
            for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        Console.WriteLine(shop[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
}

