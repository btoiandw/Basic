using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x=10,y=20;
            //float z=10.2345f;
            //float a;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.ReadKey();
            /*Console.ReadLine(); //รอรับ enter เพื่อปิดโปรแกรม*/

            //Console.Write("input : ");
            //String result = Console.ReadLine(); //รับค่าจากคีย์บอร์ดใส่ในตัวแปร result
            //Console.WriteLine("output : {0}",result);

            //assignment BMI
            double weight, height;
            //Input
            Console.Write("input weight (kg): ");
            double.TryParse(Console.ReadLine(), out weight);
            Console.Write("input geight (cm): ");
            double.TryParse(Console.ReadLine(), out height);

            //Process
            height = height / 100;
            double bmi = weight / Math.Pow(height, 2);

            //Output
            Console.WriteLine("BMI = {0:F2}", bmi);
            Console.ReadKey();
        }
    }
}
