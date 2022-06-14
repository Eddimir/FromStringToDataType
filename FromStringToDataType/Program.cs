using System;
using System.Linq;

namespace FromStringToDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1,8,15.5,h,false,true,8,E,d,d,i,m,i,r,false";

            string[] datatypes = str.Split(',');

            dynamic[] arr = new dynamic[datatypes.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if(int.TryParse(datatypes[i], out int a)){
                    arr[i] = a;
                }
                else if(double.TryParse(datatypes[i], out double b))
                {
                    arr[i] = b;
                }             
                else if(char.TryParse(datatypes[i], out char d)){
                    arr[i] = d;
                }
                else if(bool.TryParse(datatypes[i], out bool e)){
                    arr[i] =e;
                }
            }
           
           foreach (var item in arr)
           {
                if(item is int entero){
                   Console.WriteLine($"Type: {entero.GetType()}\t\t Valor: {entero}");
                }
                else if(item is double f)
                {
                    Console.WriteLine($"Type: {f.GetType()}\t\t Valor: {f}");
                }
                else if(item is char c){
                    Console.WriteLine($"Type: {c.GetType()}\t\t Valor: {c}");
                }
                else if(item is bool bol){
                   Console.WriteLine($"Type: {bol.GetType()}\t\t Valor: {bol}");
                }
           }
        }
    }
}
