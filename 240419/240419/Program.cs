// 7. 시간지연

Console.WriteLine("시작");

Thread.Sleep(3000);

Console.WriteLine("종료");

// 실습
// 도서관리 시스템
// 기능1. 도서등록 -> "퓨처셀프", "3,1" 입력 -> Dictionary<string, string> library에 저장
// 기능2. 도서검색 -> "퓨처셀프" 검색 -> 위치(3,1) 출력 -> library사용 검색
// 기능3. 회원등록 -> "회원명", "회원번호(임의의 번호)"  -> Dictionary<string, int> members에 저장
// 기능4. 예약대출 -> 도서검색(빌려간 책)인 경우 "이름","책이름" Queue에 저장 -> Queue<string> waitings

// 입출력예시
// 번호를 선택해 주세요.(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)
// 0
// 도서명을 입력해 주세요.
// 퓨처셀프
// 도서 위치를 입력해 주세요.
// 3,1
// 등록이 완료되었습니다. 퓨처셀프(3,1)

// 번호를 선택해 주세요.(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)
// 1
// 도서 명 또는 도서 번호를 입력해 주세요.
// 퓨처셀프
// 퓨처셀프는 3,1에 있습니다.

// 번호를 선택해 주세요.(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)
// 2
// 회원등록 페이지 입니다. 회원이름을 입력해 주세요.
// 신태욱
// 비밀번호를 입력해 주세요.
// 1234
// 회원등록이 완료되었습니다.

// 번호를 선택해 주세요.(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)
// 3
// 대출예약을 위한 회원명과 도서명을 입력해 주세요.
// 신태욱,퓨처셀프
// 예약되었습니다.

Dictionary<string, string> bookList = new Dictionary<string, string>();
Dictionary<string, string> memberList = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("번호를 선택해 주세요.(0: 도서등록, 1: 도서검색, 2: 회원등록, 3: 대출예약)");
    string status = Console.ReadLine();
    switch(status)
    {
        case "0":
            RegisterBook();
            break;
        case "1":
            SearchBook();
            break;
        case "2":
            RegisterMember();
            break;
        case "3":
            MakeReservation();
            break;
        default:
            Console.WriteLine("잘못 입력하였습니다. 다시 입력해 주세요.");
            break;
    }
}

void MakeReservation()
{
}

void RegisterMember()
{
}

void SearchBook()
{
}

void RegisterBook()
{
}