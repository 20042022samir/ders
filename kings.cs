
using System.Globalization;
using System.Text.RegularExpressions;

class CheckPasword
{
    CheckPasword(string username, string pasword)
    {
        public string pasword = ("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");
    public string username;
    public string Username
    {
        get => username;
        set
        {
            if (username != value)
            {
                Console.WriteLine("olmaz");
            }
        }
    }



    public string Pasword
    {
        get => pasword;
        set
        {

            if (value.Length > 8)
            {
                Console.WriteLine("uygundur");
            }
        }
    }
}

   

