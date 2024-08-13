using productmanagement;

productmath productmath = new productmath();
int choice = 0;
do
{

    Console.WriteLine("enter choice");
    Console.WriteLine("for add data enter 1");
    Console.WriteLine("for delete data enter 2");
    Console.WriteLine("for update data enter 3");
    Console.WriteLine("for display data enter 4");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            product product = new product();
            Console.WriteLine("enter product name");
            product.productname = Console.ReadLine();
            Console.WriteLine("enter product price");
            product.price = Convert.ToDouble(Console.ReadLine());
            productmath.addproduct(product);
            break;

        case 2:
            Console.WriteLine("enter id for delete data");
            int id = Convert.ToInt32(Console.ReadLine());
            productmath.deleteproduct(id);
            break;
        case 3:
            Console.WriteLine("enter id for change data");
            int pid = Convert.ToInt32(Console.ReadLine());
            product product1 = new product();
            product1.id = pid;  
            Console.WriteLine("enter product name");
            product1.productname = Console.ReadLine();
            Console.WriteLine("enter product price");
            product1.price = Convert.ToDouble(Console.ReadLine());
            productmath.updateproduct(product1);
            break;
        case 4:
            var d = productmath.GetAllproduct();
            foreach (var item in d)
            {
                Console.WriteLine(item.productname);
                Console.WriteLine(item.price);
            }
            break;
    }
} while (choice < 4);