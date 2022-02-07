using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class bordGame
    {
        static void Main(string[] args)
        {
            Random randint = new Random();
            int i = randint.Next(1, 2);
            string[] map =
            {
                "출발",
                "타이베이(대만)",
                "황금열쇠",
                "베이징(중국)",
                "마닐라(필리핀)",
                "제주도(대한민국)",
                "싱가포르",
                "황금열쇠",
                "카이로(이집트)",
                "이스탄불(터키)",
                "무인도",
                "아테네(그리스)",
                "황금열쇠",
                "코펜하겐(덴마크)",
                "스톡홀름(스웨덴)",
                "콩코드 여객기",
                "베른(스위스)",
                "황금열쇠",
                "베를린(독일)",
                "오타와(캐나다)",
                "사회복지기금 수령처",
                "부에노스아이레스(아르헨티나)",
                "황금열쇠",
                "상파울루(브라질)",
                "시드니(호주)",
                "부산(대한민국)",
                "하와이(미국)",
                "리스본(포르투갈)",
                "퀸 엘리자베스 호",
                "마드리드(스페인)",
                "우주여행",
                "도쿄(일본)",
                "컬럼비아호",
                "파리(프랑스)",
                "로마(이탈리아)",
                "황금열쇠",
                "런던(영국)",
                "뉴욕(미국)",
                "사호복지기금 접수처",
                "서울(대한민국)"

            };
            Dictionary<string, string> gold_key = new Dictionary<string, string>()
            {
                { "1", "병원비 지불" },
                { "2", "복권 당첨" },
                { "3", "무인도 탈출" },
                { "4", "무인도" },
                { "5", "파티 초대권" },
                { "6", "관광여행" },
                { "7", "과속운전 벌금" },
                { "8", "해외 유학" },
                { "9", "연금 혜택" },
                { "10", "이사" },
                { "11", "고속도로" },
                { "12", "우승" },
                { "13", "우대권" },
                { "14", "항공여행" },
                { "15", "건물수리비 지불" },
                { "16", "방범비" },
                { "17", "유람선 여행" },
                { "18", "관광 여행" },
                { "19", "생일 축하" },
                { "20", "장학금 혜택" },
                { "21", "정기 종합소득세" },
                { "22", "노벨평화상 수상" },
                { "23", "관광여행" },
                { "24", "반액대매출" },
                { "25", "우주여행 초청장" },
                { "26", "우대권" },
                { "27", "세계일주 초대권" },
                { "28", "이사" },
                { "29", "사회복지기금 배당" },
                { "30", "반액 대매출" },

            };

            bool com_turn = false;
            bool usr_turn = false;
           
            int com_location = 0;
            int usr_location = 0;

            string[] com_card = { };
            string[] usr_card = { };

            List<string> com_rand_list = new List<string>();

            Console.WriteLine("Black Marble");
            Console.WriteLine(i);
            Console.WriteLine();


            if (i == 1)
            {
                com_turn = true;
            }

            if (com_turn == true)
            {
                int dice = randint.Next(1, 7);
                Console.WriteLine($"주사위 숫자 : {dice}");
                com_location = com_location + dice;
                Console.WriteLine($"도착 위치 : {map[com_location]}");
                Console.WriteLine();

                int com_buy = randint.Next(1, 2);
                if (com_buy == 1)
                {
                    string rand = map[com_location];
                    if (rand != "황금열쇠")
                    {
                        com_rand_list.Add(rand);
                    }
                    if (String.Join(",", com_rand_list) == "")
                    {
                        Console.WriteLine("보유 땅 없음");
                    }
                    else
                    {
                        Console.WriteLine($"보유 땅 : {String.Join(", ", com_rand_list)}");
                    }

                }
            }


        }
    }
}
