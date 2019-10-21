using System;
using System.Collections.Generic;

namespace Addresser
{
    partial class Program
    {
        static List<Info> Addresser = new List<Info>();
        static void Main(string[] args)
        {
            bool shutdown = false;
            while(!shutdown)
            {
                Console.Clear();
                Console.WriteLine("1. 정보 등록, 2. 정보 확인, 3. 정보 말소, 0: 종료");
                switch (int.Parse(Console.ReadLine()))
                {
                    //정보 등록
                    case 1:
                    {
                        Console.Clear();
                        AddInfo();
                        break;
                    }
                    
                    //정보 확인
                    case 2:
                    {
                        Console.Clear();
                        if(Addresser.Count == 0)
                        {
                            Console.WriteLine("등록된 정보가 없습니다.");
                            Console.WriteLine("정보등록으로 이동합니다.");
                            Console.WriteLine("계속하려면 아무 키나 눌러주세요.");
                            Console.ReadLine();
                            Console.Clear();

                            AddInfo();
                        }
                        else
                        {
                            for(int i = 0;i<Addresser.Count;i++)
                                Console.WriteLine($"이름: {Addresser[i].Name}, 전화번호: {Addresser[i].Number}");
                            
                            Console.WriteLine("계속하려면 아무 키를 눌러주세요.");
                            Console.ReadLine();
                        }
                        break;
                    }

                    //정보 말소
                    case 3:
                    {
                        Console.Clear();
                        if(Addresser.Count > 0)
                        {
                            int selector = 0;
                            Console.WriteLine("정보 말소를 실시합니다.");
                            Console.WriteLine("누구의 정보를 말소하시겠습니까?");

                            for(int i = 0;i<Addresser.Count;i++)
                            {
                                Console.WriteLine($"{i+1}: {Addresser[i].Name}");
                            }

                            if(!int.TryParse(Console.ReadLine(), out selector) ||
                            selector > Addresser.Count || selector < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("잘못된 값을 입력했습니다.");
                                Console.WriteLine("초기 화면으로 돌아갑니다.");
                                Console.ReadLine();
                                break;
                            }

                            Console.Clear();
                            selector--;
                            Console.WriteLine($"{Addresser[selector].Name}의 정보를 말소합니다.");
                            Console.WriteLine("경고: 되돌릴 수 없습니다.");
                            Console.WriteLine("계속하려면 yes를 입력해 주십시오.");
                            if(Console.ReadLine() == "yes")
                            {
                                Console.Clear();
                                Addresser.RemoveAt(selector);
                                Console.WriteLine("말소되었습니다.");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("취소되었습니다.");
                                Console.ReadLine();
                            }
                        }
                        break;
                    }

                    //프로그램 종료
                    case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("프로그램을 종료합니다.");
                        shutdown = true;
                        System.Threading.Thread.Sleep(100);

                        break;
                    }

                    default:
                        Console.Clear();
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            }
        }
    }
}
