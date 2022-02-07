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
            Dictionary<int, string> gold_key = new Dictionary<int, string>()
            {
                { 1, "병원비 지불" },
                { 2, "복권 당첨" },
                { 3, "무인도 탈출" },
                { 4, "무인도" },
                { 5, "파티 초대권" },
                { 6, "관광여행" },
                { 7, "과속운전 벌금" },
                { 8, "해외 유학" },
                { 9, "연금 혜택" },
                { 10, "이사" },
                { 11, "고속도로" },
                { 12, "우승" },
                { 13, "우대권" },
                { 14, "항공여행" },
                { 15, "건물수리비 지불" },
                { 16, "방범비" },
                { 17, "유람선 여행" },
                { 18, "관광 여행" },
                { 19, "생일 축하" },
                { 20, "장학금 혜택" },
                { 21, "정기 종합소득세" },
                { 22, "노벨평화상 수상" },
                { 23, "관광여행" },
                { 24, "반액대매출" },
                { 25, "우주여행 초청장" },
                { 26, "우대권" },
                { 27, "세계일주 초대권" },
                { 28, "이사" },
                { 29, "사회복지기금 배당" },
                { 30, "반액 대매출" },

            };
            Dictionary<string, string> gold_key_discription = new Dictionary<string, string>()
            {
                { "병원비 지불", "병원에서 건강진단을 받았습니다. - (병원비 5만 원을 은행에 납부합니다.)" },
                { "복권 당첨", "축하합니다. 복권에 당첨되었습니다. - (당첨금 20만원을 은행에서 받습니다.)" },
                { "무인도 탈출", "특수 무전기- (무인도에 갇혀 있을 때 사용할 수 있습니다, 1회 사용 후 반납합니다, 타인에게 팔 수 있습니다.) " },
                { "무인도", "폭풍을 만났습니다. 무인도로 곧장 가세요 - (출발지를 지나더라도 월급을 받을 수 없습니다.) " },
                { "파티 초대권", "대중 앞에서 장기자랑을 하세요 - (다른 게임 참가자들이 정한 상금을 은행에서 지불합니다.)" },
                { "과속운전 벌금", "과속운전을 하였습니다. -(벌칙금 5만 원을 은행에 납부합니다.)" },
                { "해외 유학", "학교 등록금을 내세요 -(등록금 10만원을 은행에 납부합니다.)" },
                { "연금 혜택", "노후연금을 받으세요 - (연금 5만원을 은행에서 받습니다.)" },
                { "고속도로", "출발지까지 곧바로 가세요. - (출발지에서 월급을 받습니다.)" },
                { "우승", "자동차 경주에서 챔피언이 되었습니다. - (상금 10만 원을 은행에서 받습니다.)" },
                { "우대권", "상대방이 소유한 장소에 통행료 없이 머무를 수 있습니다. - (1회 사용 후, 황금 열쇠함에 반납합니다, 중요한 순간에 쓰세요.)" },
                { "항공여행" },
                { "건물수리비 지불" },
                { "방범비" },
                { "유람선 여행" },
                { "관광 여행" },
                { "생일 축하" },
                { "장학금 혜택" },
                { "정기 종합소득세" },
                { "노벨평화상 수상" },
                { "우주여행 초청장" },
                { "세계일주 초대권" },
                { "이사" },
                { "사회복지기금 배당" },
                { "반액 대매출" },
            }
            string value;


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
                    else
                    {
                        int key_num = randint.Next(1, 31);
                        string dic_key = Convert.ToString(key_num);
                        bool havevalue = gold_key.TryGetValue(dic_key, out value);
                        if (havevalue)
                        {
                            Console.WriteLine($"뽑은 카드 : { value }");
                            if (value == "병원비 지불")
                            {
                                Console.WriteLine();
                            }
                        }
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
