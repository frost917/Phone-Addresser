using System;

namespace Addresser
{
    partial class Program
    {
        static void AddInfo()
        {
            string name, num;
            Console.Write("이름: ");
            name = Console.ReadLine();
                        
            Console.Write("전화번호: ");
            num = Console.ReadLine();
            
            Console.Clear();
            Addresser.Add(new Info(name, num));
            Console.WriteLine($"{Addresser[Addresser.Count - 1].Name} {Addresser[Addresser.Count - 1].Number}가 정상적으로 등록되었습니다.");
            Console.WriteLine("계속 하려면 아무 키나 눌러주세요.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}