

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variable Declaration
            //int Number;
            //Number = 10;
            //Console.WriteLine(Number);

            //Variable : 
            //DataType: int
            //name : number
            //size : 4 Bytes
            //Value : 10
            //Address: Hexa-Decimal

            //int Number = 10;
            //int Number1 = 10, Number2 = 11, Number3 = 12; 
            //int Age = 19;
            //int class; //Invalid
            // int int
            //int namespace

            //Name Convention:
            //Pascal Case --> FirstName, C#
            //Camel Case  --> firstName
            //Kabab Case --> first_name


            #endregion

            #region Datatype - value Type (Primitive)
            //Datatype - value Type (primitive)

            //int Number;
            //Console.WriteLine(Number);
            //Int32 Number1 = 12;
            //Number = Number1;
            //Console.WriteLine(Number);
            //Console.WriteLine(Number1);
            #endregion

            #region Datatype - Reference Type (NonPrimitive)
            //Point P1;
            //Declare 
            //P1 = new Point();
            //Point P2 = new Point();
            //P2 = P1;
            //P2.x = 6;
            //Console.WriteLine(P1.x);//6
            //Console.WriteLine(P2.x);//6
            //Console.WriteLine(P2.y);//0
            #endregion

            #region Object
            //Point p1 = new Point();
            //p1.ToString();
            //p1.GetHashCode();
            //p1.Equals();
            //p1.GetType();


            //object O1;
            //O1 = new object();
            //O1 = new Point();
            //O1 = new string("Ahmed");
            //O1 = 1 ;
            //O1 = "Ahmed";
            //O1 = true ;
            //O1 = 3.14;

            //object O1 = new object();
            //object O2 = new object();

            //O2 = O1;

            //Console.WriteLine(O1.GetHashCode());//54267293
            //Console.WriteLine(O2.GetHashCode());//18643596 
            #endregion

            #region Implicit Casting Explicit Casting
            //int x = 4;
            //double y = x;

            //int x =5;
            //long y = x;

            //2.Explicit

            //int x = 5;
            //long Y = 22626262262226262626626262;
            //x = (int) Y;
            //Console.WriteLine(x); // -1327026069


            //int x = 5;  // 4 Bytes
            //long Y;  // 8 Bytes
            //checked
            //{
            //    unchecked
            //    {
            //        Y = 22626262262226262626626262;
            //    }
            //    x = (int)Y;
            //}
            //Console.WriteLine(x);// -1327026069 
            #endregion

            #region Parse & TryParse Function And Convert Class
            //string Name = Console.ReadLine();
            //Console.WriteLine("Hello" + Name);

            //int x= int.Parse("123");
            //Console.WriteLine(x+5);

            //Console.Write("Enter Your Name: ");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Your Age: ");

            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Name : " + Name);
            //Console.WriteLine("Age : " + Age);

            //Console.Write("Enter Your GPA");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Name : " + Name);
            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("GPA : " + GPA);

            //Convert
            //Console.WriteLine("Enter Your Name: ");
            //string Name = Console.ReadLine();

            //Console.WriteLine("Enter Your Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Your GPA: ");

            //double GPA = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Name : " + Name);
            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("GPA : " + GPA);

            //int Age = int.Parse(Console.ReadLine());
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine( Age);

            //int Age;
            //int.TryParse(s: Console.ReadLine(), out Age);
            //Console.WriteLine(Flag);
            //Console.WriteLine(Age);

            //Console.WriteLine("Hello After Error"); 
            #endregion

            #region Fractions And Discards
            // Fractions 
            //2.5 ---> Double
            //12 --> int
            //double x = 12.5;
            //float y = 1.5f;
            //decimal z = 2.5m;

            //Discards
            //long X = 100_000_000_000;
            //Console.WriteLine(X); 
            #endregion

            #region Operators

            //++
            //int x = 10;
            //Console.WriteLine(++x);// 11
            //////////
            //Console.WriteLine(x++);// 10
            //Console.WriteLine(x);//11


            //--
            //int x = 10;
            //Console.WriteLine(--x);// 9
            //////////
            //Console.WriteLine(x--);// 10
            //Console.WriteLine(x);//9

            //==================================
            //2.Binary Operators
            //+ = / * %

            //int sum, mul, sub, mod
            //int Number01 = 2, Number02 = 6;
            //sum = Number01 + Number02;//8
            //mul = Number01 * Number02;//12
            //sub = Number01 - Number02;//-4
            //mod = mul % mul;//2
            //23%3=2
            //==================================
            //4.Relational Operators
            //int x = 6, y = 5;
            //Console.WriteLine(x==y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x <= y);

            //5. Logical Operators
            //Console.WriteLine(!false);// ! -> Not
            //Console.WriteLine(false && true);// && -> AND short Circuit
            //Console.WriteLine(false || true);// || -> OR short Circuit

            //6. Bitwise Operators
            //Console.WriteLine(!false);// ! -> Not
            //Console.WriteLine(false & true);// && -> AND Long Circuit
            //Console.WriteLine(false | true);// || -> OR Long Circuit

            //7. Ternary Operators
            //bool flag = 4 > 2;
            //Console.WriteLine(flag);
            //string flag =4< 2 ? "Correct" : "Not Correct";
            //Console.WriteLine(flag);
            #endregion 

            #region Operators Priorty

            //int a = 20;
            //int b = 10;
            //int c = 15;
            //int d = 30;
            //int e;
            //e = (a + b) * c / d;
            //e = ((a + b) * c) / d;
            //e = (a + b) * (a / d);
            //e = a + (b * c) / b;

            #endregion
        }
    }
}
