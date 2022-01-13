// See https://aka.ms/new-console-template for more information
using oops;
using oops.inheritance;
using oops.polymorphism.overriding;
using oops.polymorphism.overloading;
using oops.encapsulation;
using oops.Abstraction;
using oops.passbyvalueandref.pass_by_value;
using oops.passbyvalueandref.passbyreference;


/*
Car car1 = new Car();
car1.Start();
Console.WriteLine(car1.carName = "bmw");
car1.Stop();


Employee emp1 = new Employee();
emp1.empName = "peter";
emp1.empPhone = 5668;
emp1.Savings();
emp1.empSalary = 10000;
emp1.EmpBalance();


Calculation adding = new Calculation();

Console.WriteLine(adding.Add());
Console.WriteLine(adding.Add(4.5f, 5.6666));


Account acc1 = new Account();
acc1.AddAmount(5000.55);


Circle c1 = new Circle();
c1.DrawShape();

int i = 10;
PassByValue p1 = new PassByValue();
Console.WriteLine(i);
p1.PassValue(i);
Console.WriteLine("after passing value is" + i);
*/

int i = 10;
PassByRef pr1 = new PassByRef();
Console.WriteLine(i);
pr1.PassRef(ref i);
Console.WriteLine("after passing value is" + i);

