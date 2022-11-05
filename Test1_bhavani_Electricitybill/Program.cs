// See https://aka.ms/new-console-template for more information
using Test1_bhavani_Electricitybill;

Console.WriteLine("Hello, World!");
ElectricityBill objElectricityBill = new ElectricityBill();
objElectricityBill.ElectricityBillMethod();
Console.WriteLine("Enter customer name:");
String Cname = Console.ReadLine();
Console.WriteLine("Enter number:");
 int Meternumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter Units:");
objElectricityBill.Units=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("your service type is domestic enter 'd' or 'D' \n" + "your service type is commertial enter 'C' or 'c '");

objElectricityBill.ServiceType = Console.ReadLine();
objElectricityBill.ElectricityBillMethod();
