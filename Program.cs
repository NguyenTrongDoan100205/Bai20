using System;
using System.Text.Json;

namespace CircleCalculator
{
    class Program
    {
        // Hàm tính toán và trả về chuỗi JSON
        static string CalculateCircleProperties(double r)
        {
            double dienTich = Math.PI * Math.Pow(r, 2);
            double chuVi = 2 * Math.PI * r;
            double duongKinh = 2 * r;

            var result = new
            {
                dien_tich = dienTich,
                chu_vi = chuVi,
                duong_kinh = duongKinh
            };

            return JsonSerializer.Serialize(result);
        }

        static void Main(string[] args)
        {
            double r;
            while (true)
            {
                Console.Write("Nhap ban kinh r (lon hon 0): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out r) && r > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le. Vui long nhap lai!\n");
                }
            }

            string resultJson = CalculateCircleProperties(r);
            Console.WriteLine("Ket qua: " + resultJson);
        }
    }
}