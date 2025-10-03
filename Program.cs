//using System.ComponentModel.Design;
//using System.Linq.Expressions;

//try
//{
//    int x = int.Parse(Console.ReadLine());
//    int y = Convert.ToInt32(Console.ReadLine());
//    int res = x / y;
//    Console.WriteLine($"результат: {res}");
//}
//catch (DirectoryNotFoundException ex)
//{
//    Console.WriteLine($"ошибка: {ex.Message}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"ошибка: {ex.Message}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"ошибка: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("продолжение");
//}
//Console.WriteLine("конец программы");
//while (true)
//{
//    try
//    {
//    Console.WriteLine("введите первое число");
//    double num1 = double.Parse(Console.ReadLine());
//    Console.WriteLine("введите второе");
//    double num2 = double.Parse(Console.ReadLine());
//    Console.Write("введите операцию");
//    string? operation = Console.ReadLine();
//    double res = 0;
//    switch (operation)
//    {
//        case "+":
//            res = num1 + num2;
//            break;        
//        case "-":
//            res = num1 - num2;
//            break;
//        case "*":
//            res = num1 * num2;
//            break;
//        case "/":
//            if (num2 == 0)
//                throw new DivideByZeroException("делить на ноль нельзя");
//            res = num1 / num2;
//            break;
//        default:
//            Console.WriteLine("неизвестная операция");
//        break;
//    }
//}
//catch(FormatException ex)
//{
//    Console.WriteLine($"{ex.Message}");
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine($"{ex.Message}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"{ex.Message}");
//}
//finally
//{
//    Console.WriteLine("работа калькулятора завершена");
//}
//}
//int num = 12;
//Console.WriteLine(num.ToString());
//Console.WriteLine(num.GetType());
//bool test = true;
//Console.WriteLine(test.ToString());
//DateTime now = DateTime.Now;
//Console.WriteLine(now.ToString());
//object me = new();
//Console.WriteLine(me.ToString());
//int age = int.Parse("12");
//Console.WriteLine(age);
//DateTime brithday = DateTime.Parse("31 may 2005");
//Console.WriteLine(brithday);
//Console.WriteLine($"{brithday:D}");
//    string input = Console.ReadLine();
//    if (int.TryParse(input, out int res)){
//        Console.WriteLine(res);
//    }
//    else
//    {
//        Console.WriteLine("неккоректный результат");
//    }
//    checked { 
//        byte num = byte.MaxValue - 1;
//        Console.WriteLine(num);
//        num++;
//        Console.WriteLine(num);
//        num++;
//        Console.WriteLine(num);
//}

//double Add(double a, double b)
//{
//    return a * b;
//}
//double a = 4.5;
//double b = 2.5;
//Console.WriteLine(Add(a,b));

//Console.Write("введите сумму");
//string? amount = Console.ReadLine();
//try
//{
//    decimal amountValue = decimal.Parse(amount);
//} 
//catch (FormatException) when (amount.Contains("$"))
//{
//    Console.WriteLine("в суммaх нельзя использовать знак доллара");
//}
//catch (FormatException)
//{
//    Console.WriteLine("суммы должны содержать только цифры");
//}
//дз
//1
//Console.WriteLine("введите первое число");
//double num1 = double.Parse(Console.ReadLine());
//Console.WriteLine("введите второе");
//double num2 = double.Parse(Console.ReadLine());
//Console.Write("введите операцию");
//string? operation = Console.ReadLine();
//double res = 0;
//switch (operation)
//{
//    case "+":
//        res = num1 + num2;
//        break;
//    case "-":
//        res = num1 - num2;
//        break;
//    case "*":
//        res = num1 * num2;
//        break;
//    case "/":
//        if (num2 == 0)

//            throw new DivideByZeroException("делить на ноль нельзя");
//        res = num1 / num2;
//        break;
//    case "^":
//        res = Math.Pow(num1, num2);
//        break;
//    default:
//        Console.WriteLine("неизвестная операция");
//        break;
//}
//Console.WriteLine(res);
//3
//while (true)
//{
//    try
//    {
//        Console.Write("введите делимое ");
//        double num1 = double.Parse(Console.ReadLine());
//        double num2;
//        while (true)
//        {
//            Console.Write("введите делитель ");
//            num2 = double.Parse(Console.ReadLine());
//            if (num2 == 0)
//            {
//                Console.WriteLine("На ноль делить нельзя. Повторите ввод делителя ");
//                continue;
//            }
//            double res = num1 / num2;
//            Console.WriteLine(res);
//            break;
//        }
//        break;
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("введено не число");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}
//while (true)
//{
//    try
//    {
//        Console.WriteLine("введите целое число ");
//        int num = int.Parse(Console.ReadLine());
//        break;
//    }
//    catch
//    {
//        Console.WriteLine("ошибка, введите целое число ");
//    }

//}
//5
//калькулятор с ошибками
//while (true)
//{
//    try
//    {
//        Console.WriteLine("введите первое число");
//        int num1 = Convert.ToInt32(Console.ReadLine()); // неверное присваивание типа
//        Console.WriteLine("введите второе");
//        double num2 = double.Parse(Console.ReadLine());
//        Console.Write("введите операцию");
//        string? operation = Console.ReadLine();
//        double res = 0;
//        switch (operation)
//        {
//            case "+":
//                res = num1 + num2;
//                break;
//            case "-":
//                res = num1 - num2;
//                break;
//            case "*":
//                res = num1 * num2;
//                break;
//            case "/":
//                //Отсутствие проверки на деление на ноль
//                res = num / num2; //Присваивание неверной переменной
//                break;
//            case "^":
//                result = Step(number1, number2);
//                break;
//            default:
//                Console.WriteLine("неизвестная операция");
//                continue;
//        }
//        Console.WriteLine(res);
//        break;
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine($"{ex.Message}");
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"{ex.Message}");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"{ex.Message}");
//    }
//    finally
//    {
//        Console.WriteLine("работа калькулятора завершена");
//    }
//}
//правильный калькулятор
//while (true)
//{
//    try
//    {
//        Console.WriteLine("введите первое число");
//        double num1 = double.Parse(Console.ReadLine()); // неверное присваивание типа
//        Console.WriteLine("введите второе");
//        double num2 = double.Parse(Console.ReadLine());
//        Console.Write("введите операцию");
//        string? operation = Console.ReadLine();
//        double res = 0;
//        switch (operation)
//        {
//            case "+":
//                res = num1 + num2;
//                break;
//            case "-":
//                res = num1 - num2;
//                break;
//            case "*":
//                res = num1 * num2;
//                break;
//            case "/":
//                if (num2 == 0)
//                    throw new DivideByZeroException("делить на ноль нельзя");
//                res = num1 / num2;
//                break;
//            case "^":
//                result = Step(number1, number2);
//                break;
//            default:
//                Console.WriteLine("неизвестная операция");
//                continue;
//        }
//        Console.WriteLine(res);
//        break;
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine($"{ex.Message}");
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine($"{ex.Message}");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"{ex.Message}");
//    }
//    finally
//    {
//        Console.WriteLine("работа калькулятора завершена");
//    }
//}
