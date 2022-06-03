/*
// C# 공부 : https://076923.github.io/posts/C-27/

디자인타임
런타임

0. 단축키
	Ctrl + L : 한줄 지우기
	Ctrl + K + C : 전체 주석
	Ctrl + K + U : 전체 주석 해제
	메소드에 커서 가져다 대기 : 오버로딩 확인
	F1 : 함수 설명
	F9 : 디버깅 break point 생성 // 빨간 지점에 도달하면 break
	F10 : 디버깅 다음줄 진행
	F11 : 

0. 학습 목표
	1) 객체 지향 프로그래밍
	2) C# 프로그래밍
	3) 자동화 제어 ♣
		(1) windows UI
		(2) 시리얼 통신, TCP 통신 (응용 프로그래밍)
		(3) windows 프로그래밍

1. C#
	1) 특징
		(1) 객체 지향 프로그래밍(완전한 Class 기반)
			- 은닉
			- 상속
			- 다형성
		(2) windows 인프라 사용 가능 ♣
			1] windows API 사용
			2] .NET 제공 클래스 사용
			ex. 이미지로드, 시리얼 통신, TCP 통신
		(2) 높은 대중성 : 많은 라이브러리 ♣
		(3) 포인터 사용x / 동적 메모리 사용o ♣
			1] 용도별 사용성
				[1] windows 프로그래밍 : good ♣
				[2] system 프로그래밍 : bad
			2] 메모리 관리 실수에 따른 오류 봉쇄
			3] 느린 속도. 커스터마이징 어려움 ♣
		(3) 중간 코드 형태 존재 ♣♣♣
			1] .NET 반드시 설치해야 실행 가능
			2] C, C++에 비해 1/3 느린 속도
			3] OS 호환성 증가
				C# 어플 | VB.NET 어플 | C++ 어플
				ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
				CLR(Common Language Runtime)
				ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
				.NET Framework
				ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
				운영체제(Windows, Linux, Mac OS)
		(4) Java와 비슷한 문법

2. .NET Framework Basic
	1) Project add : 파일 - 새로만들기 - 프로젝트 - C# Windows Forms 앱(.NET Framework)
	2) Icon add : 좌측 도구상자 - 다양한 아이콘
	3) Icon attribute : 아이콘 오른쪽 마우스 - 속성 - 속성
		- text font
		- text size
		- text color
		- ...
	3) Icon event : 아이콘 오른쪽 마우스 - 속성 - 이벤트
	4) Code : 아이콘 오른쪽 마우스 - 코드 수정
		1] 형변환
			[1] int형 변환 : Convert.ToInt32(data)
			[1] string형 변환 : Convert.ToString(data)
			[1] double형 변환 : Convert.ToDouble(data)
			[1] float형 변환 : Convert.ToSingle(data)

		2] 출력
			[1] 텍스트 출력 : Console.WriteLine(변수명)
			[1] 메시지 박스 출력 : MessageBox.Show("~~~") ♣

		3] 창 ♣
			[1] 현재 창 너비 : this.ClientSize.Width
			[1] 현재 창 높이 : this.ClientSize.Height

		3] 박스
			[1] 활성화 : attribute_name.Enabled = true
			[1] 비활성화 : attribute_name.Enabled = false
			[2] 텍스트 수정 : attribute_name.Text = "~~~"
			[2] 텍스트 색 수정 : attribute_name.Forecolor = Color.Red
			[2] Box 색 수정 : attribute_name.Backcolor = Color.Red
			[3] x좌표 : attribute_name.Left = 좌표
			[3] y좌표 : attribute_name.Top = 좌표
			[4] x너비 : attribute_name.Width
			[4] y너비 : attribute_name.Height

		3] 체크 박스 ♣
			[1] 체크박스 체크 : 변수명.Checked = true
			[1] 체크박스 체크 해제 : 변수명.Checked = false

		3] 픽쳐 박스 ♣
			[1] 상태 받기(픽쳐 박스를 하나로 묶은 경우)
				PictureBox 변수명 = sender as PictureBox;
				if (변수명.Name == "picturebox_name") ~~ 코드 ~~
			[2] 이미지 설정
				attribute_name.Image = Properties.Resources.그림_파일명

		3] Graphics ♣
			[1] 그래픽 객체 생성 : Graphics 변수명 = attribute_name.CreateGraphics()
			[2] 타원 그리기 : 변수명.DrawEllipse(new pen(Color.Red), x좌표, y좌표, 타원 너비, 타원 높이)
			[2] line 그리기 : 변수명.DrawLine(new pen(Color.Red), x1좌표, y1좌표, x2좌표, y2좌표)
				- 펜 생성 : Pen 펜_변수명 = new pen(Color.Red)
			[3] Clear : 변수명.Clear(Color.White);

		3] 마우스 ♣
			[1] 마우스 x좌표 : e.X
			[1] 마우스 y좌표 : e.Y
			[2] 마우스 왼쪽 클릭 : e.Button == MouseButtons.Left
			[2] 마우스 오른쪽 클릭 : e.Button == MouseButtons.Right

		4] 색 ♣
			Color 변수명 = Color.Red
		
		4] 시간 ♣
			[1] 현재 시간 초로 표시 : DateTime 변수명 = DateTime.Now;

		4] 랜덤 ♣
			[1] 랜덤 변수 생성 : Random 변수명 = new Random();
			[2] 랜덤 변수 값 범위 지정 : 변수명 = 변수명.Next(n1, n2);

		4] 배열 ♣
			[1] 1차원 배열 생성
				- string 배열 : string[] 변수명 = new string[원소개수] { "원소1", "원소2", ... };
				- bool 배열 : bool[] 변수명 = new bool[원소개수] { bool형, bool형, ... };
			[1] 1차원 배열 수정 : 변수명[인덱스] = 원소
			[2] 2차원 배열 생성
				- 2차원 배열 : double[,] 변수명 = new double[행 개수, 열 개수];
			[2] 2차원 배열 수정
				- 2차원 배열 : 변수명[행 인덱스, 열 인덱스] = 원소

			- 배열 인덱스 0부터 시작

		5] string ♣
			[1] 생성 : string 변수명 = String값;
			[2] 길이
				1]] 앞뒤 공백 제외 길이 : 변수명.Trim().Length;
				2]] 앞뒤 공백 포함 길이 : 변수명.Length;
			[3] 일부 추출
				1]] a번째부터 b개의 문자 : 변수명.Substring(a, b);
			[4] 대문자화 / 소문자화
				1]] 대문자화 : 변수명.ToUpper();
				2]] 소문자화 : 변수명.ToLower();
			[5] 비교 ♣♣
				1]] string끼리 비교 : 변수명1 == 변수명2
					- string은 참조형 변수기 때문에, 변수명1==변수명2 이것은 주소를 비교하는 것인데
						C#에서는 변수값을 비교하는 것으로 인식해버림. 권장되지 않는 방법
				2]] string끼리 비교 : 변수명1.CompareTo(변수명2);
					- 같은 경우 : 0
					- 다른 경우 : 1
			[6] 인덱스 추출 ♣
				1]] 변수명1에서 변수명2의 인덱스 추출 : 변수명1.IndexOf(변수명2);
			[7] 공백삽입
				1]] 총 문자 개수가 value개 되도록 왼쪽에 공백 삽입 : 변수명.PadLeft(value);
				2]] 총 문자 개수가 value개 되도록 오른쪽에 공백 삽입 : 변수명.PadRight(value);
			[8] 단어 자르기 ♣
				char[] 기준_배열명 = new char[] { '기준1', '기준2', ... };
				string [] 새로운_배열명 = 변수명.Split(기준_배열명);
			[9] 단어 대체 : 변수명.Replace('대체할 단어', '대체 후 단어'); ♣
			[10] 형식 지정 : string.Format("{index:0000.0000}", 변수명, ...); ♣
				index : index가 0부터 시작해서 뒤에 있는 변수중에서 사용할 변수 지정
				0000.0000 : 정수, 소수점 자리수 지정

		+a)
			1) 참조형 변수 종류
				(1) 클래스
				(2) 배열
				(3) 스트링

			2) 나눗셈
				(1) int 나눗셈 : 몫만 추출하는 나눗셈 실시
					int / int
				(2) double 나눗셈 : 소숫점 나눗셈 실시
					int / double
					double / int
					double / double
			
		5] 마스크 연산
			(num & 0x01) != 0;
			(num & 0x02) != 0;
			(num & 0x04) != 0;
			(num & 0x08) != 0;
			(num & 0x10) != 0;
			(num & 0x20) != 0;
			(num & 0x40) != 0;
			(num & 0x80) != 0;

		6] 함수
			[1] 함수 생성
				private 리턴_자료형 함수명(입력_자료형 입력_변수명, ...)
				{
					~~ 코드 ~~
					return 리턴값
				} // 여기에 ; 사용x
			[2] 함수 사용
				함수명(입력_변수값, ...);

		7] 자원 추가 ♣
			1way : 프로젝트 폴더 -> resources
			2way : 상단 프로젝트 -> 프로젝트 속성 -> 리소스 -> 리소스 추가

		7] 파일 열기 ♣
			[1] 파일 열기 팝업
				DialogResult rtn = openFileDialog.ShowDialog();
				if (rtn != DialogResult.OK) return;
			[2] 파일명 + 파일위치 받기 : string fname = openFileDialog.FileName;

		7] 파일 읽기 ♣
			[1] 파일 읽기
				StreamReader sr = new StreamReader(fname, Encoding.Default);
			[2] 한줄 읽기
				st = sr.ReadLine();
			[3] 파일 닫기
				sr.Close();

		8] 프로그램 종료 : Application.Exit()

3. 자료형
	1) 자료형 종류
		(1) 기본 데이터 형식 : int, double, decimal... ♣
		(2) 복합 데이터 형식 : string, Socket, Image... ♣

		- 대부분 프로그래밍 언어 : type에 엄격(오류 감소 but 편리성 감소) ♣
		- python : type에 관대(오류 증가 but 편리성 증가) ♣

		(1) 값 형식 : 변수에 데이터의 값 담음 ♣
		(2) 참조 형식 : 변수에 데이터의 위치 담음 ♣

	2) 자료형 사용
		(1) Basic
			1] 데이터 선언 : 데이터형식 변수명;
				int x;
				int x, int y;
				int x = 30, int y = 30;

				- 여러개 변수 동시 선언 가능

				- C, C++ : 초기화 선언 안하면, 초기화 X(효율성을 위해)
				- C# : 초기화 선언 안하면, 0으로 초기화 ♣
			2] 데이터 할당 : 변수명 = 데이터;
				x = 100;
			3] 블록 ♣
				- 블록 안에서 선언된 변수 : 블록 안에서만 생존, 블록 밖에서는 사망

		(2) 값 변수 / 참조 변수
			1] 값 변수 : 변수에 데이터 값 담음
				{
				int a = 100;
				int b = 200;
				int c = 300;
				}

				- 값 변수(= 자동 변수 = stack 변수) : stack에 값 할당, 블록 벗어나면 stack 순서대로 해제 ♣♣♣
			2] 참조 변수 : 변수에 데이터의 위치 담음
				{
				object a = 10;
				object b = 20;
				}

				- 참조 변수 : stack에 주소 할당 + heap에 데이터 값 저장 + stack이 heap을 가리킴, 블록 벗어나면 stack 순서대로 해제 + garbage collector가 heap 해제 ♣♣♣
					garbage collector : 프로그램 무거워짐 but error 적음

				- C, C++ : 메모리 주소 출력 가능
				- C# : 메모리 주소 출력 불가(error를 없애기 위해) ♣

				- stack : cache memory(cpu에 존재)에 저장 / 적은 용량 / 임시 사용 메모리 공간 ♣
				- heap : memory에 저장 / 주소 지정능력만큼 용량 / 장기 사용 메모리 공간 ♣

		(3) 기본 데이터 형식 / 복합 데이터 형식
			1] 기본 데이터 형식
				[1] 정수 형식 ♣♣♣
					1]] sbyte : signed byte 정수 /1byte / -128 ~ 127 ♣
					1]] byte : unsigned short / 1byte / 0 ~ 255 ♣
					2]] short : signed short 정수 / 2byte / -32,768 ~ 32,767
					2]] ushort : unsigned short 정수 / 2byte / 0 ~ 66535
					3]] int : signed int 정수 / 4byte / -21억 ~ 21억
					3]] uint : unsigned int 정수 / 4byte / 0 ~ 42억
					4]] long : signed long 정수 / 8byte
					4]] ulong : unsigned long 정수 / 8byte
					5]] char : 유니코드문자 / 2byte

				[2] 부동 소수점 형식 ♣
					1]] float : 단일 정밀도 부동 소수점 / 4byte / e38 / 유효숫자 : 7 or 8자리(부정확한 계산. 속도 증가)
						- 1비트 : 부호
						- 8비트 : 지수부(유효숫자)
						- 23비트 : 가수부(데이터 크기)
					2]] double : 복수 정밀도 부동 소수점 / 8byte / e308 / 유효숫자 : 15자리(정확한 계산. 속도 저하 but 요즘 시대에는 상관 없다)

				[3] 문자열 형식
					1]] char : 문자
						- 사용 : 문자를 작은 따옴표로 감싸줌
							char a = '가';
					2]] string : 문자열 ♣
						- 사용 : 문자를 큰 따옴표로 감싸줌
							string a = "안녕하세요";

				[4] 논리 형식
					1]] bool : 논리 형식 / 1byte / true, false ♣

					- C, C++ : 논리 형식 없는 언어. 0은 거짓, 0이 아닌수는 참으로 판단
					- C# : 논리 형식 있는 언어. 별도 논리 형식 도입(코드 읽을 때, 거짓을 의미하는지 숫자 0을 의미하는지 구분 위함) ♣

				- data overflow : 데이터 형식이 자료형 크기 초과시, 최저값으로 돌아가 다시 count ♣

				[5] object 형식 : 일단 건너띈다

			2] 형변환
				[1] 명시적 casting : 큰 자료형 -> 작은 자료형인 경우 ♣♣♣
					1]] 정수 <-> 정수
						int x = 128;
						sbyte y = (sbyte)x; // 결과 : -128 ♣

						- 원본 변수 자료형 > 변환 변수 자료형 : 오버플로우 주의 ♣
					2]] 부동 소수점 <-> 부동 소수점
						float a = 69.6875;
						double b = (double)a;

						- 부동 소수점 : 오버플로우 존재x ♣
						- 소수점 정밀성 손상 주의 ♣
					3]] 부호 존재 <-> 부호 존재x
						int a = -30;
						uint b = (uint)a; // 결과 : 4294967266

						- 오버 플로우 주의 ♣
					4]] 부동 소수점 <-> 정수

						- 소수점 버림
					4]] 문자열 <-> 숫자
						Convert.ToString(변수명)
						Convert.Int32(변수명)
				[2] 묵시적 casting : 작은 자료형 -> 큰 자료형인 경우 ♣
					sbyte x = 128;
					int y = x;
			3] 상수와 열거 형식
				-

4. 연산자
	- 수식 : 피연산자(변수, 상수), 연산자 등으로 구성된 식
	1) 기능에 따른 연산자 분류
		(1) 대입 연산 = 배정 연산 = 할당 연산 : = ♣
			- 항상, 왼쪽 변수 = 오른쪽 수식

			- 복합 대입 연산자 ♣
				x+=y : x = x + y
				x-=y : x = x - y
				x*=y : x = x * y
				x/=y : x = x / y
				x%=y : x = x % y
				x&=y : x = x & y
				x|=y : x = x | y
				x^=y : x = x ^ y
				x>>=y : x = x >> y
				x<<=y : x = x << y
		(2) 산술 연산 : + - * / % ♣♣♣ 모든 수치데이터 형식
			- 나눗셈 연산자에서 정수끼리 나눗셈 >> 결과 : 정수형 생성(나머지값은 버림) ♣
			- 나눗셈 연산자에서 부동소수점끼리 나눗셈 >> 결과 : 부동소수점 생성 ♣

			double x = 15.3/3.0 >> x = 5.1
			int x = 15.3/3.0 >> error
			int x = (int)(15.3/3.0) >> x = 5

			int a = 8/3 >> a = 2
			double a = 8/3 >> a = 2.0
		(3) 부호 : + -
		(4) 증감 : ++ -- ♣♣♣ 모든 수치데이터 형식 + 열거 형식
			++변수 : 증가 후 대입
			--변수 : 감소 후 대입
			변수++ : 대입 후 증가
			변수-- : 대입 후 감소
		(5) 관계 : == != > < >= <=
			- 사용 : bool = (5 == 5) + (6 != 2) = 2
			- 결과 : 참(true) or 거짓(false)
				출력 시 ♣
					false : 거짓
					true : 참
				입력 시 ♣
					false : 거짓
					true : 참
		(6) 논리 : && || !
			x && y : and 연산 (x, y가 모두 참일 때만 참)
				▶주의!!◀ ♣
					&& 연산자 단축 계산 : 첫 번째 피연산자가 거짓이면, 다른 피연산자들 실행x
			x || y : or 연산 (x, y 둘중 하나만 참이면 참)
				▶주의!!◀ ♣
					|| 연산자 단축 계산 : 첫 번째 피연산자가 참이면, 다른 피연산자들 실행x
			!x : not 연산 (x가 참이면 거짓, x가 거짓이면 참)

			- 결과 : 참(true) or 거짓(false)
				출력 시
					false : 거짓
					true : 참
				입력 시
					false : 거짓
					true : 참
		(7) 조건 : ? ♣
			x ? y : z

			- 결과 :
				x가 참인 경우 : y
				x가 거짓인 경우 : z
		(8) 콤마 : , ♣
			- 결과 : 순차적 계산
		(9) 비트 단위 연산자 : & | ^ ~ << >> ♣
			& : 비트단위 and (모두 1일때만 1)
				0110 & 1100 -> 0100
			| : 비트단위 or (적어도 하나가 1이면 1)
				0110 | 1100 -> 1110
			^ : 비트단위 xor (같은 숫자면 0, 다른 숫자면 1) ♣
				0110 ^ 1100 -> 1010
			~ : 비트단위 not (1이면 0, 0이면 1) ♣
				~0110 -> 1001
			<< : 왼쪽으로 n비트 이동 (2의 n승 배) ♣
				1001<<2 -> 0100
			>> : 오른쪽으로 n비트 이동 (2의 -n승 배) ♣
				1001>>2 -> 0010
		(10) sizeof 연산자 : sizeof
		(11) 형변환 : (type)변수 or 상수 ♣
			① 자동적 형변환
				ⓐ 대입 연산 시 형변환
					- 지정한 형식대로 올림 or 내림 변환
						- 올림 변환 : double f = 10; >> f = 10.0
						- 내림 변환 : int i = 3.141592; >> i = 3 // 반올림이 아닌 무조건 내림 변환 ♣
				ⓑ 정수 연산 시 형변환
					- int형 변환
						- 내림 변환 : char형 or short형 >> int형 변환♣
				ⓒ 수식 연산 시 형변환
					- 항상 올림 변환
						- 올림 변환 : int + double >> double
			② 명시적 형변환
				(자료형)변수 or 상수
		(12) 포인터 연산자 : * & []
		(13) 구조체 연산자 : . ->

	2) 연산자 우선순위
		단항 > 산술 > 관계 > 논리 > 대입 > 콤마 ♣
			(1) 단항 연산자
				1. () []
				2. sizeof &(주소) ++ -- ~ ! + - 형변환
			(2) 이항 연산자
				산술
					1. * / %
					2. + -
				관계
					3. << >>
					4. < <= > >=
					5. == !=
					6. &
					7. ^
					8. |
			(3) 삼항 연산자
				논리
					1. &&
					2. ||
					3. ?
				대입
					4. = += *= /= %= &= ^= |= <<= >>=
				콤마
					5. ,

	- 피연산자 수에 따른 연산자 분류 ♣
		단항 연산자 : 피연산자 수 1개 ex) ++x; --y;
		이항 연산자 : 피연산자 수 2개 ex) x+y; x-y;
		삼항 연산자 : 연산자 수 3개 ex) x ? y : z;

5. 제어문
	1) 분기문 : 프로그램 흐름 제어 by 조건
		- C# 조건식 : 숫자형x. bool형o
		// C언어와 같다
		(1) if : 배타적 구조 ♣
		(2) switch ♣

	2) 반복문 
		// C언어와 같다
		(1) while
		(2) do while	: 반드시 1회 실행 while
		(3) for
		(4) foreach : 배열을 순회하여 각 데이터요소 차례 접근
			foreach(데이터형식 변수명 in 배열 or 컬렉션)
				~~ 코드 ~~
		(5) 무한루프
			1] while 구현
				while(true)
				{
					~~ 코드 ~~
				}
			2] for 구현
				for( ; ; )
				{
					~~ 코드 ~~
				}
		(5) try ~ catch

	3) 점프문
		(1) break
		(2) continue : 반복문을 깨지 않고, 해당 반복문의 다음 반복 실행
		(3) goto : 지정된 레이블로 실행 이동
			- 스파게티 코드 가능성 증가
			- 이득을 볼 수 있는 경우가 있다 ♣
			- 이론적으로 없어도 모든 경우에서 프로그래밍 가능 ♣
			1] 레이블로 이동
				goto 레이블명;
			2] 레이블 선언
				레이블명:
					~~ 코드 ~~

6. Method
	1) 정의 : 일련의 코드를 하나로 묶음
	2) 특징
		(1) 호칭
			- C# : 메소드
			- C / C++ : 함수
			- 파스칼 : 프로시저 ♣
		(2) 선언
			- C# : Class 내에만 attribute, method 선언 가능 / Class 내에 Class 선언 가능
			- C / C++ : Class 밖에도 attribute, method 선언 가능

			- 변수 : attribute
			- 함수 : method
		(3) 호출 : 메소드명 호출
	3) 사용
		(1) 순서
			1] 상위 함수(Caller) 정지
			2] 매개변수 복사
			3] Class의 메소드 실행
			4] 다 마치면, 불러온 함수의 메모리 삭제
			5] 상위 함수(Caller) 복귀
		(2) 구조 : Stack ♣
			메소드의 변수 = 새로운 문맥 ♣
			ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
			상위함수 부분 변수 = 문맥
		(3) 사용
			class 클래스명
			{
				한정자 반환_형식 메소드명(자료형1 매개변수1, 자료형2 매개변수2, ...)
				{
					~~ 코드 ~~
				}
				return 메소드 결과
				}
			}
	4) 구성 요소
		(1) return
			- 점프문
			- 메소드 종결 후 코드 흐름을 Caller에게 돌려줌
			- 함수 반환형과 return 자료형 일치 필수 ♣
			- 함수 반환형이 void여도 return; 으로 return 사용 가능 ♣
		(2) 매개변수
			1] 일반 매개변수 전달(Call by value) : 복사본 전달
				// 메소드 정의
					한정자 static 반환형 메소드명(자료형1 매개변수1, 자료형2 매개변수2, ...)
					{
						~~ 코드 ~~
					}
				// main문
					인수 선언 + 초기화 필수 ♣
					메소드명(인수1, 인수2, ...);
			2] 참조에 의한 매개변수 전달(Call by reference) : 보이지 않는 주소 전달
				- ref를 메소드 정의, main문에서 메소드 호출하는 부분 전부 써야 오류 없음. 프로그래머에게 call by reference라는 것을 인지시키기 위함
				- 입력값 사용o, 출력값 사용o
				- 변수 초기화하지 않고 매개변수로 넣으면 오류

				// 메소드 정의
					한정자 static 반환형 메소드명(ref 자료형1 매개변수1, ref 자료형2 매개변수2, ...)
					{
						~~ 코드 ~~
					}
				// main문
					인수 선언 + 초기화 필수 ♣
					메소드명(ref 인수1, ref 인수2, ...);
			3] 선택적 매개변수 : 매개변수 기본값 할당
				- 생략 불가능한 변수를 생략 가능한 매개변수보다 앞에 선언 ♣
				// 메소드 정의
					한정자 static 반환형 메소드명(자료형1 매개변수1 = 초기값1, 자료형2 매개변수2 = 초기값2, ...)
					{
						~~ 코드 ~~
					}
				// main문
					인수 넣을 시 선언 + 초기화 필수 ♣
					인수 생략 없음 : 메소드명(인수1, 인수2);
					인수2 생략 : 메소드명(인수1);
					인수1, 2 생략 : 메소드명();
			4] 가변길이 매개변수 : 개수가 유연하게 변하는 매개변수
				// 메소드 정의
					한정자 static 반환형 메소드명(params 배열_자료형 [] 배열명) ♣
					{
						for(int i = 0; i < 배열명.Length; i++)
						{
							~~ 배열명[i]에 대한 연산 ~~
						}
						~~ 기타 배열에 대한 연산 ~~
					}
				// main문
					인수 선언 + 초기화 필수 ♣
					메소드명(원하는 개수의 인수를 ,로 구분하여 넣음); ♣
			5] 명명된 매개변수 : 매개변수 이름 명시하여 순서 고려x
				// 메소드 정의
					한정자 static 반환형 메소드명(자료형1 매개변수1명, 자료형2 매개변수2명, ...)
					{
						~~ 코드 ~~
					}
				// main문
					인수 선언 + 초기화 필수 ♣
					메소드명(매개변수1명 : 인수1, 매개변수2명 : 인수2); ♣
			6] 출력 전용 매개변수 전달
				- out을 메소드 정의, main문에서 메소드 호출하는 부분 전부 써야 오류 없음. 프로그래머에게 인지시키기 위함
				- 입력값 사용x, 출력값 사용o
				- 변수 초기화하지 않고 매개변수로 넣어도 괜찮다
				// 메소드 정의
					한정자 static 반환형 메소드명(out 자료형1 매개변수1, out 자료형2 매개변수2, ...) ♣
					{
						~~ 코드 ~~
					}
				// main문
					인수 선언 필수 + 초기화 필요없음 ♣
					메소드명(out 인수1, out 인수2, ...);
	5) 예시
		(1) 메소드 선언
			class Calculator
			{
				public static int Plus(int a, int b)
				{
					Console.WriteLine("Input : {0}, {1}", a, b);
					int result = a + b;
					return result;
				}
			}
		(2) 메소드 호출 in 상위함수(Caller)
			class MainApp
			{
				public static void Main()
				{
					int x = Calculator.Plus(3,4);
					int y = Calculator.Plus(5,6);
					int z = Calculator.Plus(7,8);
				}
			}
	+a) 
		1) 한정자
			(1) public : Class 외부 / Class 내부에서 호출 가능
				public static 반환형 메소드명(자료형1 매개변수1, 자료형2 매개변수2, ...)
				{
					~~ 코드 ~~
				}
			(2) private : Class 외부에선 호출 불가능 / Class 내부에선 호출 가능
				private static 반환형 메소드명(자료형1 매개변수1, 자료형2 매개변수2, ...)
				{
					~~ 코드 ~~
				}
				static 반환_형식 메소드명(자료형1 매개변수1, 자료형2 매개변수2, ...)
				{
					~~ 코드 ~~
				}
		2) static
			- 멤버변수 or 메소드에 붙음
			(1) non-static : 객체마다 1개씩 각기 다르게 사용
			(2) static : 클래스 전체에 1개만 유일
		3) 점프문
			(1) break
			(2) continue
			(3) goto
			(4) return
		4) 매개변수 전달
			(1) C++
				Call by value : 값 복사 전달
				Call by reference : 보이지 않는 주소 복사 전달
				Call by address : 보이는 주소 복사 전달
			(2) C#
				Call by value : 값 복사 전달
				Call by reference : 보이지 않는 주소 복사 전달
		5] 메소드 오버로딩 : 하나의 메소드 이름에 여러 형태 구현
			// 메소드 정의
			int Plus(int a, int b)
			{
				return a + b;
			}
			double Plus(double a, double b)
			{
				return a + b;
			}
			// main문
			int result1 = Plus(1,2);
			double result2 = Plus(3.1, 2.4);
	6) 

7. Class
	0) 역사
		(1) 기계어
		(2) 어셈블리어
		(3) 고급 언어
			1] goto문 : 스파게티 코드
			2] 구조적 프로그래밍 : 순서대로 코드 진행
			3] OOP
				- readability
				- maintainence
				- reusable
	1) 정의
		(1) 객체지향프로그래밍(OOP)
			1] 개념
				- 코드 내 모든 것을 객체(Object)로 표현 ♣
				- 복합 데이터 형식 ♣
			2] 용어
				[1] Class : 청사진
				[2] 객체(object = instance) : 청사진의 실체
				[3] 속성(property = member) : 변수 ♣
				[4] 메소드(method = member 함수) :함수
				[5] 객체.속성 or 객체.메소드에서 . : member 접근 연산자 ♣
	2) 비교
		(1) class
			1] C언어 : class X
			2] C++ : class 사용 가능. 기능 많음
			3] C#, java : 완전한 class
				- 모든 것이 class 내에 존재
			4] Python : class 사용 가능. 라이브러리 많음(ex. opencv, tensorflow...)
		(2) 참조 변수 선언 ♣
			1] C, C++ : 배열을 값으로 선언
				int a[100];
			2] C# : 배열을 참조 변수로만 선언
				int [] a = new int [100];
					- int [] a : stack(참조)
					- new int [100] : heap(실제값)
				Man a = new Man; // class를 참조변수로 선언
			
	3) 사용
		(1) 선언
			class 클래스명
			{
				~~ property & method ~~
			}

			- 관례 : class명 첫자는 대문자 
		(2) 생성자 & 소멸자
			1] 생성자(Constructor) : class 생성
				[1] 특징
					1]] 프로그래머가 선언하지 않아도, 매개변수 받지 않는 default 생성자 생성
					1]] 생성자 1개라도 선언시, default 생성자 제공x
				[2] 사용
					class 클래스명 ♣
					{
						한정자 클래스명(자료형1 매개변수1, 자료형2 매개변수2, ...) // 생성자 ♣♣♣
						{
							~~ property & method ~~
						}
						~~ property && method ~~
					}
			2] 소멸자(Destructor) : class 소멸
				[1] 특징
					1]] 프로그래머가 선언하지 않아도, default 소멸자 제공
					1]] 생성자 1개라도 선언시, default 생성자 제공x
					2]] 소멸자를 직접 구현하는 것이 좋지 않은 이유
						- garbage collector의 사용으로 소멸자 호출시점 예측 불가
						- garbage collector의 신뢰도 높음
				[2] 비교
					1]] C, C++ : 프로그래머가 class 나가기 전, delete 객체명;으로 처리. delete하는 순간 제거 ♣♣♣
					2]] C# : class 벗어나면, 지역변수의 범위를 넘어간 heap의 객체를 garbage collector가 처리. garbage collector가 제거하므로 바로 제거x
				[3] 사용
					class 클래스명
					{
						~클래스명() // 소멸자 ♣♣♣
						{
							~~ 코드 ~~
						}
						~~ property && method
					}
		(3) 얕은 복사 & 깊은 복사
			1] 얕은 복사
				[1] 개념 : 힙의 주소 복사 ♣♣♣
				[2] 사용
					클래스명 새로운_객체명 = 기존_객체명; ♣♣♣
			2] 깊은 복사
				[1] 개념 : 값을 복사 ♣♣♣
				[2] 사용
					class 클래스명
					{
						한정자 반환형(=클래스명을 사용하면된다) 메소드명0()
						{
							클래스명 임시_객체명 =  new 클래스명(); ♣♣♣
							임시_객체명.속성명1 = this.속성명1 ♣♣♣
							임시_객체명.속성명2 = this.속성명2 ♣♣♣
							...
							return 임시_객체명 ♣♣♣
						}
						~~ property && method ~~
					}
					클래스명 새로운_객체명 = 기존객체명.메소드명0(); ♣♣♣♣♣
		(4) 은닉(Encapsulation)
			1] 개념 : 필요한 기능만 노출. 내부는 감춤
				- default : private
			2] 종류
				1] public : Base Class 내/외부, 파생 Class 모두에서 접근 가능
					- 수정 범위 : 프로그램 전체 ♣
				2] protected : Base Class 내부, 파생 Class만 접근 가능
					- 수정 범위 : Base Class 내부 + 파생 Class ♣
				3] private : Base Class 내부만 접근 가능
					- 수정 범위 : Base Class 내부 ♣
			ex]
				// Class 생성
				class Circle2D
				{
					pulbic Circle2D(double x, double y, double r)
					{
						xc = x; yc = y; radius = r;
					}
					private double xc, yc, radius;
					public double area()
					{
						return 3.141592654 * radius * radius
					}
				}

				// Class 사용
				Circle2D c = new Circle2D(10, 20, 5);
				double r = c.radius; // 이건 불가능
				double a = c.area(); // 이건 가능
		(5) 상속(Inheritance)
			1] 개념 : 부모 Class(기반 Class)가 자식 Class(파생 Class)에게 필드, 메소드, 프로퍼티 상속
				- private를 제외한 부모 Class의 모든 것 상속 ♣
			2] 용어
				[1] 부모 class = 기반 class
				[2] 자식 class = 파생 class
			3] 사용
				class 기반클래스명
				{
					~~ property && method ~~
				}
				class 파생클래스명:기반클래스명 ♣♣♣
				{
					~~ property && method ~~ 
			4] 형식 변환 종류
				- 기본적으로 형식과 내용물 중, 형식에 맞춰 class 호출이 발생한다 ♣♣♣♣♣
				[1] is
					1]] 개념 : 객체 형식 검사. 내용물의 형식을 확인한다 ♣♣♣♣♣
						- 결과 : bool로 반환 ♣
					2]] 사용
						if(객체명 is 클래스명){~~ 코드 ~~} ♣♣♣
				[2] as
					1]] 개념 : 형식 변환 연산자 역할
						- 형변환 연산자
							형변환 실패 : 예외 던짐
							형변환 성공 : 형식 변환
						- as 연산자
							형변환 실패 : 객체 참조를 null로 만듦 ♣♣♣♣♣
							형변환 성공 : 형식 변환
					2]] 사용
						- 형변환 연산자 ♣♣♣
							클래스명1 클래스1_객체명 = (클래스명1)클래스2_객체명;
							클래스1_객체명.클래스1_메소드();

							((클래스명1)클래스2_객체명).클래스1_메소드();

							클래스명1 클래스1_객체명 = new 클래스명1();
							클래스1_객체명.클래스1_메소드();
						- as 연산자 ♣♣♣
							클래스명1 클래스1_객체명 = 클래스2_객체명 as 클래스명1;
		(6) 다형성(Polymorphism)
			1] 개념 : 여러 형태의 객체 구현
				- 파생 클래스의 메소드 오버라이딩
			2] 오버라이딩
				[1] 개념 : 부모 Class의 메소드를 자식 Class에서 재정의
					- 형식이 baseclass 형태여도, 내용물이 derivedclass 형태면, 내용물에 맞춰서 오버라이딩하여 호출 ♣♣♣♣♣
				[2] 사용
					- 부모 Class : virtual 한정자로 미리 선언 ♣♣♣
					- 자식 Class : 부모 Class에서 virtual 한정자로 선언된 메소드를 override 한정자로 재선언 ♣♣♣

					class 기반클래스명
					{
						한정자 virtual 반환형 메소드명1()
						{
							~~ 코드 ~~
						}
					}

					class 파생클래스명:기반클래스명
					{
						한정자 override 반환형 메소드명1()
						{
							base.메소드명1(); ♣♣♣
							~~ 코드 ~~
						}
					}

					♣♣♣
					- 호출 시 형식 : baseclass 형태
					- 내용물 : baseclass 형태
					>> 결과 : baseclass의 메소드 사용

					- 호출 시 형식 : baseclass 형태
					- 내용물 :derivedclass 형태
					>> 결과 : derivedclass 메소드 사용

					- 호출 시 형식 : derivedclass 형태
					- 내용물 : derivedclass 형태
					>> 결과 : derivedclass 형태 사용
			2] 오버라이딩 봉인
				[1] 개념 : 부모 Class의 메소드를 파생 Class에서 오버라이딩 불가
				[2] 사용

					class 기반클래스명
						{
							한정자 virtual 반환형 메소드명1()
							{
								~~ 코드 ~~
							}
						}

					class 파생클래스명:기반클래스명
					{
						한정자 sealed 반환형 메소드명1() ♣♣♣
						{
							base.메소드명1(); ♣♣♣
							~~ 코드 ~~
						}
					}
			3] 메소드 숨기기
				[1] 개념 : 부모 Class의 메소드를 자식 Class에서 재정의x. 새로 선언하여 덮음o
					- 형식이 baseclass형태이고, 내용물이 derivedclass 형태면, 형식에 맞춰서 호출 ♣♣♣♣♣
				[2] 사용
					- new 한정자(객체 할당 시 new 연산자와 다름) ♣♣♣
					- 부모 Class : virtual 한정자로 미리 선언x ♣♣♣
					- 자식 Class : 부모 Class와 같은 이름의 메소드를 new 한정자로 선언 ♣♣♣
				
					class 기반클래스명
					{
						한정자 반환형 메소드명1()
						{
						`	~~ 코드 ~~
						}
					}

					class 파생클래스명:기반클래스명
					{
						한정자 new 반환형 메소드명1()
						{
							~~ 코드 ~~
						}
					}
		(7) 중첩 Class
			1] 개념 : 클래스 내에 클래스 선언
			2] 사용
				class 클래스명1
				{
					~~ property && method ~~
					class 클래스명2
					{
						~~ property && method ~~
					}
				}
		(8) 분할 Class
			1] 개념 : 분할하여 class 구현. 서로 다른 파일에 구현 가능
			2] 사용
				// 파일1
				partial class 클래스명1 ♣♣♣
				{
					~~ property && method ~~
				}

				// 파일2
				partial class 클래스명1 ♣♣♣
				{
					~~ property && method ~~
				}
		(9) 확장 Method ♣♣♣
			1] 개념 : 기존 Class 기능 확장 but 상속과는 다르다
			2] 사용
				namespace 네임스페이스명
				{
					한정자 static class 클래스명
					{
						한정자 static 반환형 메소드명(this 대상_자료형 식별자, 자료형1 매개변수1, 자료형2 매개변수2, ...)
						{
							~~ 코드 ~~
						}
					}
				}
		(10) 구조체 ♣♣♣
			1] 비교
				[1] 클래스 ♣♣♣
					키워드 : class
					형식 : 참조 형식
					복사 : 얕은 복사
					인스턴스 생성 : new연산자, 생성자 필요
					생성자 : 매개변수 없는 생성자 선언도 가능
					상속 : 가능
				[2] 구조체 ♣♣♣
					키워드 : struct
					형식 : 값 형식
					복사 : 깊은 복사
					인스턴스 생성 : 선언만으로도 생성
					생성자 : 매개변수 없는 생성자 선언 불가능
					상속 : 모든 구조체는 System.Object형식을 상속하는 System.ValueType으로부터 직접 상속받음

					- C언어의 struct와 유사 ♣♣♣
					- struct와 class는 유사 ♣♣♣

					struct MyStruct // 키워드 : struct
					{
						public int MyField1
						public int MyField2

						public void MyMethod()
						{
							~~ property && method ~~
						}
					}

					MyStruct s; // 형식 : 값형식, 인스턴스 : 선언만으로도 생성
					s.MyField1 = 1;
					s.MyField2 = 2;

					MyStruct t;
					t = s; // 복사 : 깊은 복사
					s.Myfield = 3;
	+a)
		1) 참조 변수로만 선언가능한 자료형 ♣♣♣
			(1) 배열
			(2) 스트링
			(3) Class
		2) this 키워드
			(1) 개념 : 객체가 스스로를 가리키는 키워드(Class 내에서 아직 만들어지지 않은 Class의 인스턴스 지칭)
		3) base 키워드
			(1) 개념 : 부모 Class 지칭 ♣
			(2) 사용
				class 기반클래스명
				{
					public 반환형 기반클래스의_메소드명(자료형1 매개변수1, 자료형2 매개변수2, ...)
					{
						~~ 코드 ~~
					}
				}

				class 파생클래스명:기반클래스명
				{
					public 반환형 파생클래스의_메소드명(자료형1 매개변수1, 자료형2 매개변수2, ...)
					{
						base.기반클래스의_메소드명();
					}
				}
		4) static(정적) ♣♣♣
			(1) 정적 member : class 내에 1개만 존재하는 member
				class Bread
				{
					public double weight;
					public static int cnt;
					public int n;
				}

				Bread a = new Bread();
				Bread b = new Bread();
				Bread c = new Bread();

				♣♣♣
				a.n = 100; // 가능
				a.cnt = 100; // 불가능
				Bread.cnt = 100; // 가능
				Bread.n = 100; // 불가능
			(2) 정적 class : 정적 member만을 가질 수 있는 class ♣♣♣
				Convert.ToInt32("123") // Convert : .NET에 있는 정적 class명이므로, Convert형 객체를 만들 수 없다 ♣♣♣

				namespace 네임스페이스명 ♣♣♣
				{
					한정자 static class 클래스명 ♣♣♣
					{
						한정자 static 반환형 메소드명(this 대상_자료형 식별자, 자료형1 매개변수1, 자료형2 매개변수2, ...) ♣♣♣
						{
							~~ 코드 ~~
						}
					}
				}

				namespace MyExtension
				{
					public static class IntegerExtension
					{
						public static int Power(this int myInt, int exponent)
						{
							int result = myInt;
							for(int i = 1; i < exponent; i++)
								result = result * myInt;

							return result;
						}
					}
				}
*/