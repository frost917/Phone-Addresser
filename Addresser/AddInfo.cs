using System;

namespace Addresser
{
    partial class Program
    {
        static void AddInfo()
        {
            string name, num;
            Console.Write("�̸�: ");
            name = Console.ReadLine();
                        
            Console.Write("��ȭ��ȣ: ");
            num = Console.ReadLine();
            
            Console.Clear();
            Addresser.Add(new Info(name, num));
            Console.WriteLine($"{Addresser[Addresser.Count - 1].Name} {Addresser[Addresser.Count - 1].Number}�� ���������� ��ϵǾ����ϴ�.");
            Console.WriteLine("��� �Ϸ��� �ƹ� Ű�� �����ּ���.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}