

using System.Text.RegularExpressions;

CheckPasword operation = CheckPasword();
Console.WriteLine("salam zehmet olmasa sifreni daxil edin");
operation.Pasword = Console.ReadLine();

Console.WriteLine("zehmet olmasa istifadeci adinizi daxil edin");
operation.username = Console.ReadLine();

new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");
