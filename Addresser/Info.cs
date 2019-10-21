using System;

namespace Addresser
{
    [Serializable]
    class Info
    {
        private string name;
        private string number;

        public string Name{ get { return name; } 
            set 
            { 
                if(value.Length == 0)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("이름이 입력되지 않았습니다.");
                    Console.WriteLine("이름을 입력해 주십시오.");
                    Console.BackgroundColor = ConsoleColor.Black;

                    string name;
                    do
                    {
                        name = Console.ReadLine();
                    }while(name.Length == 0);
                    this.name = name;
                }
                else
                    name = value;
            }
        }
        public string Number{ 
            get { return number; } 
            set {
                int i;
                bool isInt;
                isInt = int.TryParse(value, out i);
                
                if(!isInt || value.Length != 11)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("번호의 형식이 잘못되었습니다.");
                    Console.WriteLine("11자리 10진수 값이 입력되어야 합니다.");
                    Console.WriteLine("다시 입력해 주십시오.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    
                    string num;                    
                    do
                    {
                        num = Console.ReadLine();
                        Console.WriteLine("{0}", num);
                        isInt = int.TryParse(num, out i);
                    }while(!isInt && value.Length != 11);

                    number = num;
                }
                else
                    number = value;
            }
        }
        public Info(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }
}