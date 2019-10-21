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
                    Console.WriteLine("�̸��� �Էµ��� �ʾҽ��ϴ�.");
                    Console.WriteLine("�̸��� �Է��� �ֽʽÿ�.");
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
                    Console.WriteLine("��ȣ�� ������ �߸��Ǿ����ϴ�.");
                    Console.WriteLine("11�ڸ� 10���� ���� �ԷµǾ�� �մϴ�.");
                    Console.WriteLine("�ٽ� �Է��� �ֽʽÿ�.");
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