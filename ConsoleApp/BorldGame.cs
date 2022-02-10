using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class bordGame
    {
        static Random randint = new Random();
        static int i = randint.Next(1, 3);
        static string[] map =
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
        static Dictionary<int, string> gold_key = new Dictionary<int, string>()
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
        static Dictionary<string, string> gold_key_discription = new Dictionary<string, string>()
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
                { "항공여행", "콩코드 여객기를 타고 타이베이로 가세요 -(콩코드 여객기 소유주에게 탑승료를 지불합니다, 출발지를 지나갈 경우 월급을 받습니다.)" },
                { "건물수리비 지불", "정기적으로 건물을 수리하여야 합니다. -(호텔 10만 원, 빌딩 6만 원, 별장 3만 원)" },
                { "방범비", "방범비를 각 건물별로 다음과 같이 은행에 지불하세요. -(호텔 5만 원, 빌딩 3만 원, 별장 1만 원)" },
                { "유람선 여행", "퀸 엘리자베스호를 타고 베이징으로 가세요.-(퀸 엘리자베스호 소유주에게 탑승료를 지불합니다.\n출발지를 지나갈 경우 월급을 받습니다.) " },
                { "관광 여행", "{}으로 가세요. -(부산을 상대방이 가지고 있는 경우, 통행료를 지불합니다. 출발지를 지나갈 경우 월급을 받습니다.) " },
                { "생일 축하", "모두에게 생일 축하를 받으세요. -(전원에게 축하금 1만 원씩 받습니다. " },
                { "장학금 혜택", "장학금을 받으세요. -(장학금 10만 원을 은행에서 받습니다. )" },
                { "정기 종합소득세", "종합소득세를 각 건물별로 아래와 같이 지불하세요. -(호텔 15만 원, 빌딩 10만 원, 별장 3만 원)" },
                { "노벨평화상 수상", "당신은 세계 평화를 위하여 공헌하였습니다. - (수상금 30만 원을 은행에서 받습니다.)" },
                { "우주여행 초청장", "우주항공국에서 우주여행 초청장이 왔습니다. 우주정류장으로 가세요. -(무료이므로 컬럼비아호에 탑승료를 지불하지 않습니다, 출발지를 지나갈 경우 월급을 받습니다.)" },
                { "세계일주 초대권", "축하합니다. 현재 위치에서부터 한 바퀴 돌아오세요. -(다른 곳으로 갈 수 없습니다, 출발지를 지나가면서 월급을 받습니다. 사회복지기금을 지나가면서 모아놓은 기금을 받습니다.)" },
                { "이사", "뒤로 두 칸 옮기세요." },
                { "사회복지기금 배당", "사회복지기금 접수처로 가세요.- (출발지를 지나갈 경우, 월급을 받습니다.)" },
                { "반액 대매출", "당신의 부동산 중에서 가장 비싼 곳을 반액으로 은행에 파세요. -(건물이 지어진 경우, 반액으로 함께 처분합니다.)" },
            };
        static string value;


        static bool com_turn = false;
        static bool usr_turn = false;

        static int com_location = 0;
        static int usr_location = 0;

        static List<string> com_card = new List<string>();
        static List<string> usr_card = new List<string>();

        static List<string> com_rand_list = new List<string>();
        static List<string> usr_rand_list = new List<string>();

        static void throw_dice()
        {
            int dice = randint.Next(1, 7);
            Console.WriteLine($"주사위 숫자 : {dice}");
            com_location = com_location + dice;
            Console.WriteLine($"도착 위치 : {map[com_location]}");
            Console.WriteLine();
        }
        static void buy_or_get_key(List<string> rand_list, List<string> card_list)
        {
            string rand = map[com_location];
            if (rand != "황금열쇠")
            {
                rand_list.Add(rand);
            }
            else
            {
                int key_num = randint.Next(1, 31);
                bool havevalue = gold_key.TryGetValue(key_num, out value);
                if (havevalue)
                {
                    Console.WriteLine($"뽑은 카드 : { value }");
                    if (value == "관광 여행")
                    {
                        int choose_rand = randint.Next(1, 3);
                        if (choose_rand == 1)
                        {
                            Console.WriteLine(gold_key_discription[value].Replace("{}", "서울"));
                        }
                        else
                        {
                            Console.WriteLine(gold_key_discription[value].Replace("{}", "부산"));
                        }
                    }
                    else
                    {
                        Console.WriteLine(gold_key_discription[value]);
                    }
                    card_list.Add(value);
                }
                if (String.Join(",", rand_list) == "")
                {
                    Console.WriteLine("보유 땅 없음");
                }
            }
        }
        static void Main(string[] args)
        {
            

            Console.WriteLine("Black Marble");
            Console.WriteLine(i);
            Console.WriteLine();


            if (i == 1)
            {
                com_turn = true;
            }
            else
            {
                usr_turn = true;
            }

            if (com_turn == true)
            {
                throw_dice();

                // 돈이 충분하면 사는 것으로 알고리즘 변경 필요
                int com_buy = randint.Next(1, 2);
                if (com_buy == 1)
                {
                    buy_or_get_key(com_rand_list, com_card);
                    Console.WriteLine($"보유 땅 : {String.Join(", ", com_rand_list)}");
                }
            }
            else if (usr_turn == true)
            {
                throw_dice();
            }


        }
    }
}
