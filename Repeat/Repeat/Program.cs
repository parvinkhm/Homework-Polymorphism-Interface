
using Repeat;
using Repeat.Controllers;
using Repeat.Services;
using Repeat.Services.Interfaces;

//Bird bird = new();

//bird.Sound();

//Bird bird = new Bird();

//Animal animl = new Bird();

//Person person = new Person();

//Employee emp = new Employee();
//emp.MyProperty = 88;

//Console.WriteLine(emp.GetAddress());


ICustomMathService customMathService = new CustomMathService();

//customMathService.Sum(4, 7);

//Console.WriteLine(customMathService.GetNumbersofSum(new int[] { 1, 2, 3, 4 }));

//IEmployeeService employeeService = new EmployeeService();
//employeeService.Search ("e");

//Console.WriteLine(customMathService.SquareOfNum(6));
//Console.WriteLine(customMathService.PowOfNum(2,4));

AccountController accountController = new AccountController();

accountController.Login();


