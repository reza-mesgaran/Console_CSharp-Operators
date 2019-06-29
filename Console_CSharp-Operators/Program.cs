using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Note:
 1.Ternary operator OR conditional operator  ?: 
                           Boolean Expression ? First Statement : Second Statement

 2.null-coalescing operator ??
                           a=b??c  If b if not null => b=a;
                                   If b is null => b=c;
                           
 
 */
namespace Console_CSharp_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators.null_coalescing_operator();
            Console.WriteLine("\n");
            Operators.null_conditional_operators();
            Console.ReadKey();
        }
    }

    class Operators
    {
        public static void Ternary_Operators()  // Ternary operator OR conditional operator  ?: 
        {
            bool e;
            int FirstValue, SecondValue;
            Console.Write("Enter 1st value:");
            e = int.TryParse(Console.ReadLine(), out FirstValue);
            Console.Write("Enter 2st value:");
            e = int.TryParse(Console.ReadLine(), out SecondValue);

            string Compare = (FirstValue == SecondValue) ? "Your input are Equal" : "Your input are NOT Eual"; /// ****
            Console.WriteLine(Compare);
        }
        public static void null_coalescing_operator() // null-coalescing operator ??
        {
            int? Value = 50;   //Change it to null            
            int Result = Value ?? 10;     //***
            Console.WriteLine(Result);
        }

        public static void null_conditional_operators()  // null_conditional_operators OR Elvis operator
        {
            Person p = new Person();     // First Condition
            //Person p = null;               // Second Condition
            //p.id = 100;

            /* Here, we check :
            if (p!=null) means (p as Person's Instance is available )
                strId=p.id.ToString(); 
            else 
                strId=null;                
            */
            string strId = p?.id.ToString();   // if p==nul no error occur! BCOZ we checked p

            /* Here, we check :
            if (p.id!=null) means (id's property of p is available )
                strId=p.id.ToString(); 
            else 
                id=null;                
*/
            //strId = p.id?.ToString();        // if p==nul error occur! BCOZ we checked id only


            //strId = p?.id?.ToString();    // if p==nul and && id==null no error occur! BCOZ we checked both id and p

            Console.WriteLine("Id:"+strId);

        }
    }
    class Person
    {
        public int? id { get; set; }

    }

}
