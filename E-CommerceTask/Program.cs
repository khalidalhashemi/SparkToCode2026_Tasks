using E_CommerceTask.Models;
using System.Reflection.Metadata;

namespace E_CommerceTask
{
    public class Program
    {
        static AppDBContext context = new AppDBContext();

        static int loggedInUserID = 0;


        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddNewCategory(); break;
                    case 4: AddNewProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReviewForOrder(); break;
                    case 10: ViewAllReviewsForProduct(); break;
                    case 11: Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }


            static void RegisterUser()
            {
                Console.WriteLine("\n--------------Register New User--------------");

                User newUser = new User();

                Console.WriteLine("Enter Your Name: ");
                newUser.userName = Console.ReadLine();

                Console.WriteLine("Enter Your Email: ");
                newUser.userEmail = Console.ReadLine();

                Console.WriteLine("Enter Your Email Password: ");
                newUser.userPassword = Console.ReadLine();

                context.users.Add(newUser);
                context.SaveChanges();

                Console.WriteLine("Registration Successfully!");
            }


            static void Login()
            {
                Console.WriteLine("\n--------------Login User--------------");

                Console.WriteLine("Enter your email: ");
                string inputEmail = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                string inputPassword = Console.ReadLine();

                User checkEmail = context.users.FirstOrDefault(e => e.userEmail == inputEmail);

                if (checkEmail == null)
                {
                    Console.WriteLine("Email not found.");
                }
                else
                {
                    User checkPassword = context.users.FirstOrDefault(p => p.userEmail == inputPassword);

                    if (checkPassword == null)
                    {
                        Console.WriteLine("Incorrect password.");
                    }
                    else
                    {
                        loggedInUserID = checkEmail.userID;
                        Console.WriteLine("Login Successful!");
                    }
                }
            }


            static void AddNewCategory()
            {
                Console.WriteLine("\n--------------Add New Category--------------");

                Category newCategory = new Category();

                Console.WriteLine("Enter Category Name: ");
                newCategory.categName = Console.ReadLine();

                context.categories.Add(newCategory);
                context.SaveChanges();
            }


            static void AddNewProduct()
            {
                Console.WriteLine("\n--------------Add New Product--------------");

                Product newProduct = new Product();

                Console.WriteLine("Enter Product Name: ");
                newProduct.productName = Console.ReadLine();

                Console.WriteLine("Enter Product Price: ");
                newProduct.price = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Category Name: ");
                string userCategName = Console.ReadLine();

                Category checkCategory = context.categories.FirstOrDefault(g => g.categName == userCategName);

                if (checkCategory == null)
                {
                    Console.WriteLine("Category does not exists.");
                    return;
                }

                    context.products.Add(newProduct);
                    context.SaveChanges();

                    Console.WriteLine("Product added.");
            }


            static void ViewAllProducts()
            {
                Console.WriteLine("\n--------------View All Existing Products--------------");

                foreach (Product products in context.products)
                {
                    Console.WriteLine(products.productID);
                    Console.WriteLine(products.productName);
                    Console.WriteLine(products.price);
                    Console.WriteLine(products.categoryOFproduct);
                }
            }


            static void PlaceOrder()
            {
                Console.WriteLine("\n--------------Place an Order--------------");

                if (loggedInUserID == 0)
                {
                    Console.WriteLine("Please loggin first.");
                    return;
                }
                else
                {
                    ViewAllProducts();

                    Order inputOrder = new Order();

                    inputOrder.userID = loggedInUserID;

                    inputOrder.orderDate = DateTime.Now;

                    bool Exit = false;

                    while (false)
                    {
                        Console.WriteLine("Do you want to choose product? (Y/N).");
                        string userChoise = Console.ReadLine().ToUpper();

                        if (userChoise == "N")
                        {
                            Exit = true;
                        }

                        if (userChoise == "Y")
                        {
                            OrderProduct newOrder = new OrderProduct();

                            Console.WriteLine("Enter product ID: ");
                            int inputProductID = int.Parse(Console.ReadLine());

                            if (inputProductID == null)
                            {
                                Console.WriteLine("Product not found.");
                                return;
                            }

                            Console.WriteLine("Enter quantity: ");
                            int inputQuantity = int.Parse(Console.ReadLine());

                            context.orderProducts.Add(newOrder);
                            context.SaveChanges();
                        }
                    }
                }
            }


            static void ViewMyOrders()
            {
                Console.WriteLine("\n--------------View All Your Orders--------------");

                if (loggedInUserID == 0)
                {
                    Console.WriteLine("Please loggin first.");
                    return;
                }

                var myOrders = context.orders.Where(o => o.userID == loggedInUserID).ToList();

                if (myOrders.Count == 0)
                {
                    Console.WriteLine("You don't have any orders.");
                    return;
                }
                else
                {
                    foreach (var orders in myOrders)
                    {
                        Console.WriteLine(orders.orderID);
                        Console.WriteLine(orders.orderDate);
                    }
                }
            }


            static void ViewOrderDetails()
            {
                Console.WriteLine("\n--------------View Orders Details--------------");

                Console.WriteLine("Enter order ID: ");
                int inputOrderID = int.Parse(Console.ReadLine());

                var details = context.orderProducts.Where(o => o.orderID == inputOrderID).ToList();

                foreach (OrderProduct item in details)
                {
                    Console.WriteLine(item.orderID);
                    Console.WriteLine(item.productID);
                    Console.WriteLine(item.products.productName);
                    Console.WriteLine(item.quantity);
                    Console.WriteLine(item.products.price);
                }
            }


            static void AddReviewForOrder()
            {
                Console.WriteLine("\n--------------Add a Review for an Order--------------");

                if (loggedInUserID == 0)
                {
                    Console.WriteLine("Please loggin first.");
                    return;
                }
                else
                {
                    var findUser = context.users.Where(u => u.userID == loggedInUserID).ToList();

                    Console.WriteLine("Enter Order ID: ");
                    int inputOrderID = int.Parse(Console.ReadLine());

                    Order findOrder = context.orders.Find(inputOrderID);

                    if (findOrder == null)
                    {
                        Console.WriteLine("Order not found.");
                        return;
                    }

                    if (findOrder.userID != loggedInUserID)
                    {
                        Console.WriteLine("This order not belong to you.");
                        return;
                    }
                    else
                    {
                        Review newReview = new Review();

                        Console.WriteLine("Rate the order (1 - 5): ");
                        newReview.rating = int.Parse(Console.ReadLine());

                        Console.WriteLine("Write Your Comments: ");
                        newReview.comments = Console.ReadLine();

                        if (newReview != null)
                        {
                            Console.WriteLine("You already have a review.");
                        }
                        else
                        {
                            context.reviews.Add(newReview);
                            context.SaveChanges();

                            Console.WriteLine("Your review is saved.");
                        }
                    }
                }
            }


            static void ViewAllReviewsForProduct()
            {
                Console.WriteLine("\n--------------View Product Review--------------");

                Console.WriteLine("Enter a product ID: ");
                int inputProduct = int.Parse(Console.ReadLine());

                Product findProduct = context.products.Find(inputProduct);

                if (findProduct == null)
                {
                    Console.WriteLine("Product not found.");
                    return;
                }
                else
                {
                    var searchOrder = context.orderProducts.Where(o => o.productID == inputProduct);

                    if (searchOrder.Count() == 0)
                    {
                        Console.WriteLine("This product has never been ordered.");
                        return;
                    }

                    foreach (OrderProduct product in searchOrder)
                    {
                        Review review = context.reviews.FirstOrDefault(r => r.orderID == product.orderID);

                        Console.WriteLine(searchOrder);

                        if (review == null)
                        {
                            Console.WriteLine("No reviews.");
                        }
                        else
                        {
                            Console.WriteLine("Rating: " + review.rating);
                            Console.WriteLine("Comments: " + review.comments);
                        }
                    }

                }
            }


            static void Logout()
            {
                Console.WriteLine("\n--------------Your Logging Out--------------");

                loggedInUserID = 0;

                Console.WriteLine("Log out successfully!");
                Console.WriteLine("Thanks for using E-Commerce Console App.");
            }

        }
    }
}
