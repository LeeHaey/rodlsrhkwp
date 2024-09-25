namespace _4_1
{
    internal class program
    {
        static void Main(string[] args)
        {
            int level = 1;
            string name = "해용리";
            string job = "전사";
            int power = 10;
            int defense = 5;
            int health = 100;
            int gold = 1500;


            string[] inventory = { "무쇠갑옷 | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.", "스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.", "낡은 검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다." };

            while (true)
            {

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");

                Console.WriteLine("\n");
                Console.Write("원하시는 행동을 입력해주세요: ");
                string input = Console.ReadLine();


                if (input == "1")
                {
                    state(level, name, job, power, defense, health, gold);
                }
                else if (input == "2")
                {
                    // 인벤토리 화면
                }
                else if (input == "3")
                {
                    // 상점 화면
                }
                else
                {
                    Console.WriteLine("잘못 입력하였습니다. 다시 시도하세요.");
                }

                static void state(int level, string name, string job, int power, int defense, int health, int gold)
                {
                    Console.WriteLine($"level : {level}");
                    Console.WriteLine($"name : {name}");
                    Console.WriteLine($"job : {job}");
                    Console.WriteLine($"power : {power}");
                    Console.WriteLine($"defense : {defense}");
                    Console.WriteLine($"health : {health}");
                    Console.WriteLine($"gold : {gold}" + "G");
                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    Console.ReadLine();

                    //if (input == "0")
                    //{
                    //     return;
                    //}



                }
                static void Inventory(string inventory)
                {
                    Console.WriteLine("인벤토리");
                    Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]");
                    Console.WriteLine();
                    Console.WriteLine("1. 장착관리");
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                }
            }
        }
    }
}
