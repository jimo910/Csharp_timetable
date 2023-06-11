using System;

namespace ConsoleApp{

    class Program{

        //Numerator types in c#.
        enum CarColor: byte{
            Orange =1,
            Blue, Green, Red, Yellow
        }
            static void PaintCar ( CarColor cc){
                Console.WriteLine(" the car was painted {0} with the code {1}", cc, (int)cc);
            }
            private static void sayHello(){
                string? name = "";
                Console.Write("what is your name:");
                name = Console.ReadLine();
                Console.WriteLine("Hello  {0}", name);           
             }
            static double infiniteParamSum (params double [] nums){
                int sum =0;
                foreach(int i in nums){
                    sum  += i;
                }
                return sum;
            }

            static void doubleIt(int x, out int solution){
                    solution = x*2;
            }
            static double GetSum( double x =1, double y = 1){
                return x+y;
            }
             static void PrintArray(int [] intarray,  string message){
                    foreach( int k in intarray){
                            Console.WriteLine("{0}: {1}", k, message);
                    }
                }
            static void Swap (ref int x,  ref int y){
                int temp = x;
                x=y;
                y=temp;
            }
                static double doDivision(double x, double y){
                    if(y==0){
                        throw new System.DivideByZeroException();
                    }
                    return x/y;

                }
            static void Main(string[] args){
             /*   Tutorials on functions
              sayHello();
                int solution;
                doubleIt (15, out solution);
                Console.WriteLine("this functions helps return value without a return type  : {0}", solution);
                int x = 24;
                Swap(ref solution,  ref x);
                Console.WriteLine("the number is swapped, solutions takes the value  {0}  ", solution); */ 


                /*Console.WriteLine("Hello world");
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.White;
                string name = Console.ReadLine(); // use to collect input from user
                Console.WriteLine($"hello {name}"); // use to print variable and text together  
                Console.WriteLine("currency {0:c}", 23.455) ;*/
              /* 
               tutorials on  string formatiing
               string randString = "this is a string";
                Console.WriteLine("string length: {0}", randString.Length); // to find the number of length in a string
                Console.WriteLine("String Contains is : {0}", randString.Contains("is")); // to know if string contains a particular words.
                Console.WriteLine("index of a word in a string: {0}", randString.IndexOf("is")); // to get the index of a word in a sentence.
                Console.WriteLine("remove string : {0}", randString.Remove(10, 6));
                Console.WriteLine ( "Insert string :  {0}", randString.Insert(10, "short"));
                Console.WriteLine ("Replace String : {0}", randString.Replace ("string", "sentence"));
                string newString  = String.Format("{0} saw a {1} {2} in the {3}", "mub", "sof", "playing", "mosque");
                Console.WriteLine(@"exactly what i typed\n"); // @ is used to override the escape sequence.

                */
                   /*
                   TUTORIALS ON ARRAY.
                    int[] favNums = new int[3];
                    favNums[0] = 23;
                    Console.WriteLine ("favNums[0] : {0}", favNums[0]);
                    string [] customers = {"sade", "tola", "bola"};
                    var employees  = new[] { "Mike", "Paul", "Rick"} ;
                    object [] random_array = {"Paul", 45, 1.2345};
                    string [ , ]  multi_string = new string[2,2] { {"jk",  "shsh"}, {"Te", "dhgsdhs" }};
                    Console.WriteLine ("the  values of the array  0,0 is :{0}" , multi_string[0,0]);
                    int [] hello = {4,5,5,6,3,1,2};
                    string mess  = "is an element of  the array";
                    Array.Sort(hello);
                    PrintArray(hello, mess);
                    int age = 18;
                    bool canDrive = age>=16 ?true: false;*/
                /*
                Tutorials on how to use While Loop
                    Random rand =  new Random();
                    int secretNumber = rand.Next(1,5);
                    int guessedNumber=0;
                    int count=0;
                   
                    do{
                        Console.WriteLine("what is the guessed number");
                        guessedNumber = Convert.ToInt32(Console.ReadLine());
                        count =  count+1;

                    }while(secretNumber !=guessedNumber);
                    Console.WriteLine($"Congratulations you got it right after{count} times");*/

                    /* 
                    *** Tutorials on Exception handling ***

                    double num1 =5; double num2 = 0;
                    try{
                        Console.WriteLine("Division of x and y is {0}", doDivision(num1, num2));
                    }
                    catch(DivideByZeroException ex){
                            Console.WriteLine("YOU CAN NOT DIVIDE BY ZERO");
                            Console.WriteLine(ex.GetType().Name);

                    }
                    finally {
                        Console.WriteLine("Cleaning up");
                    }*/

            PaintCar(CarColor.Blue);
            // ShapeMath  shaping = new ShapeMath();
          //   double x = shaping.GetArea("Rectangle", 10, 12);
            double x  = ShapeMath.GetArea("Rectangle", 10, 12);
             Console.WriteLine("The area of the rectangle is {0}", x);
             }

    }

}
