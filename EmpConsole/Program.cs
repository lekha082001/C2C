// See https://aka.ms/new-console-template for more information
using EmpLib;
using System.Net.Http.Headers;

Person Rohit = new Person();
Rohit.Name = "Rohit";
Console.WriteLine(Rohit.Eat());

Person Lekha = new Person();
Lekha.Name = "Lekha";
Console.WriteLine(Lekha.Work());

Person Rushabh = new Employee() { Designation = "Intern", DOJ = DateTime.Now.AddMonths(-1)};
Rushabh.Name = "Rushabh";
((Employee)Rushabh).Designation = "Analyst";
Console.WriteLine(Rushabh.Work());
Console.WriteLine($"EmpId for {Rushabh.Name} is {((Employee)Rushabh).EmpId}");

Console.WriteLine(((Employee)Rushabh).AttendTraining("C2C"));

//Polymorphism
Father SharmajisFather = new Father();
Console.WriteLine($"Sharnmaji's Father: {SharmajisFather.Settle()}");
Console.WriteLine($"Sharmaji's Father gets married: {SharmajisFather.GetMarried()}");
Console.WriteLine($"Sharmaji's father's concept of drawing (Using abstract): {SharmajisFather.Drawing()}");
Console.WriteLine($"Sharmaji's father's concept of drawing (Using abstract): {SharmajisFather.WhatIsDating()}");

//using virtual, modifications are allowed using override. Overriden behaviour is executed below
Father SharmaJi = new Child();
Console.WriteLine($"Sharmaji: {SharmajisFather.Settle()}");
Console.WriteLine($"Sharmaji gets married: {SharmajisFather.GetMarried()}");
Console.WriteLine($"Sharmaji's concept of drawing (using abstract): {SharmaJi.Drawing()}");
Console.WriteLine($"Sharmaji's concept of drawing (using abstract): {SharmaJi.WhatIsDating()}");

//no virtual, modification disallowed by base class, forced modify using "new keyword". Forced execution of derived class using typecasting ((child)sharmajiv2).GetMarried()
Father SharmajiV2 = new Child();
Console.WriteLine($"Sharmaji V2 gets married: {((Child)SharmajiV2).GetMarried()}");

//see overloading-compile-time-polymorphism
Employee Vidyasagar = new Employee();
Vidyasagar.Name = "Vidyasagar";
Vidyasagar.Designation = "Security Systems Analyst";
Console.WriteLine(Vidyasagar.Work());
Console.WriteLine(Vidyasagar.Work("Solving bugs"));

//exposing non-public information through public methods
Employee Srikar = new Employee();
Srikar.SetTaxInfo("I'm eligible in the 20% tax payer category");
Console.WriteLine(Srikar.GetTaxInfo());

//calling one constructor from another
Person Sricharan = new Person("ABC456IHJ239DF09", "+91 8105210957");
//this constructor should call the construcor that sets aadhar number
Console.WriteLine($"Aadhar : {Sricharan.Aadhar} | MobileNumber: {Sricharan.MobileNumber}");

Employee Nanditha = new Employee("BCHJ234IHG678UHG", "+91 1234567891");
Console.WriteLine($"Aadhar : {Nanditha.Aadhar} | MobileNumber: {Nanditha.MobileNumber}");

Console.WriteLine($"Total Employee Count: {EmpUtils.EmpCount}");

//Adding employee to a temporary db - using static list<employee>
EmpUtils.EmpDb.Add(Srikar);
EmpUtils.EmpDb.Add(Vidyasagar);
EmpUtils.EmpDb.Add(new Employee("AAEEBHUI87129456", "+91 1246578963") { Name = "Nida", Designation = "Analyst", Salary = 600000 });
EmpUtils.EmpDb.Add(new Employee("AAEEBHU657129456", "+91 1246575963") { Name = "Ajay", Designation = "SrAnalyst", Salary = 600000 });
EmpUtils.EmpDb.Add(new Employee("AAEEBHUI87122f56", "+91 1246578963") { Name = "Abhi", Designation = "GDC", Salary = 600000 });
//get all employees whose aadhar starts with AA
var resultList = EmpUtils.EmpDb.Where((emp) => emp.Aadhar != null && emp.Aadhar.StartsWith("AA"));
resultList.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} | {emp.Aadhar}"));
//get all employees with salary > 600000
var resultList2 = EmpUtils.EmpDb.Where((emp) => emp.Salary != null && emp.Salary > 59999);
resultList.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} | {emp.Salary}"));
