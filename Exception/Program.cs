namespace Exceptionn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter First number: ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //try
            //{
            //    int result = num1 / num2;
            //    Console.WriteLine("Division result is: {0}", result);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divid a number by zero");
            //    Console.WriteLine(ex.Message);
            //}




            //Console.WriteLine("Remaining statement 1");
            //Console.WriteLine("Remaining statement 2");
            //Console.WriteLine("Remaining statement 3");


            //...........

            //int[] arr=new int[3];


            //try
            //{
            //    arr[0] = 1;
            //    arr[1] = 2;
            //    arr[2] = 3;
            //    arr[3] = 4;
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Array's Range is exceeded");
            //    Console.WriteLine(ex.Message);
            //}

            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //.................

            //try
            //{
            //    string? name = null;
            //    Console.WriteLine(name.Length);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("String is Null.....");
            //    //Console.WriteLine(ex.Message);
            //}

            //......................


            //Console.WriteLine("Enter a number");
            //string number = Console.ReadLine();
            //try
            //{
            //    int num = int.Parse(number);
            //    Console.WriteLine("Number is " + number);
            //}
            //catch(FormatException ex) 
            //{
            //    Console.WriteLine("String format is invalid");
            //    Console.WriteLine(ex.Message);
            //}


            //.....................


            //try
            //{
            //    //string a = null;
            //    //Console.WriteLine(a.Length);

            //    int[] arr=new int[3];
            //    arr[0]=1;
            //    arr[1]=2;
            //    arr[2]=3;
            //    arr[3]=4;
            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //.....................


            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int c = a / b;
            //}

            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            //finally
            //{
            //    Console.WriteLine("Finally block executed");
            //}



            //...............

            //Console.WriteLine("Enter your age: ");
            //int age=int.Parse(Console.ReadLine());
            //try
            //{
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("You are eligible for voting");
            //    }
            //    else
            //    {
            //        throw new Exception("You are not eligible for voting");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}



            int account_balance = 5000;
            int withdrawl_amount = 4000;
            //Console.WriteLine("Enter Amount: ");
            try
            {
                if (withdrawl_amount <= account_balance)
                {
                    account_balance -= withdrawl_amount;
                    Console.WriteLine("Transaction successfull");
                    Console.WriteLine("Remaining amount is "+ account_balance);

                }
                else
                {
                    throw new Exception("Insufficient Balance");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}