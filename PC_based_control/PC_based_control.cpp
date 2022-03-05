/*
// C# 공부 : https://076923.github.io/posts/C-27/

디자인타임
런타임

0. 학습 목표
	1) 객체 지향 프로그래밍
	2) C# 프로그래밍
	3) 자동화 제어
		(1) windows UI
		(2) 시리얼 통신, TCP 통신 (응용 프로그래밍)
		(3) windows 프로그래밍

1. C#
	1) 특징
		(1) 객체 지향 프로그래밍(완전한 클래스 기반)
			- 은닉
			- 상속
			- 다형성
		(2) windows 인프라 사용 가능
			1] windows API 사용
			2] .NET 제공 클래스 사용
			ex. 이미지로드, 시리얼 통신, TCP 통신
		(2) 높은 대중성 : 많은 라이브러리
		(3) 포인터 사용x / 동적 메모리 사용o
			1] 용도별 사용성
				[1] windows 프로그래밍 : good
				[2] system 프로그래밍 : bad
			2] 메모리 관리 실수에 따른 오류 봉쇄
			3] 느린 속도. 커스터마이징 어려움 
		(3) 중간 코드 형태 존재
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
			[1] int형 변환 : Convert.ToInt32(string_data)
			[1] string형 변환 : Convert.ToString(int_data)

		2] 출력
			[1] 텍스트 출력 : Console.WriteLine(변수명)
			[1] 메시지 박스 출력 : MessageBox.Show("~~~")

		3] 창
			[1] 현재 창 너비 : this.ClientSize.Width
			[1] 현재 창 높이 : this.ClientSize.Height

		3] 박스
			[1] 활성화 : attribute_name.Enabled = true
			[1] 비활성화 : attribute_name.Enabled = false
			[2] 텍스트 수정 : attribute_name.Text = "~~~"
			[2] 텍스트 색 수정 : attribute_name.Forecolor = Color.Red
			[3] x좌표 : attribute_name.Left = 좌표
			[3] y좌표 : attribute_name.Top = 좌표
			[4] x너비 : attribute_name.Width
			[4] y너비 : attribute_name.Height

		3] Graphics
			[1] 그래픽 객체 생성 : Graphics 변수명 = attribute_name.CreateGraphics()
			[2] 타원 그리기 : 변수명.DrawEllipse(new pen(Color.Red), x좌표, y좌표, 타원 너비, 타원 높이)
			[2] line 그리기 : 변수명.DrawLine(new pen(Color.Red), x1좌표, y1좌표, x2좌표, y2좌표)
				- 펜 생성 : new pen(Color.Red)

		3] 마우스
			[1] 마우스 x좌표 : e.X
			[1] 마우스 y좌표 : e.Y
			[2] 마우스 왼쪽 클릭 : e.Button == MouseButtons.Left
			[2] 마우스 오른쪽 클릭 : e.Button == MouseButtons.Right

		4] 색 변수
			Color 변수명 = Color.Red

		4] 랜덤
			[1] 랜덤 변수 생성 : Random 변수명 = new Random();
			[2] 랜덤 변수 값 범위 지정 : 변수명 = 변수명.Next(n1, n2);

		5] 프로그램 종료 : Application.Exit()

3. 자료형
	1) 자료형 종류
		(1) 기본 데이터 형식 : int, double, decimal...
		(2) 복합 데이터 형식 : string, Socket, Image...

		- 대부분 프로그래밍 언어 : type에 엄격(오류 감소 but 편리성 감소)
		- python : type에 관대(오류 증가 but 편리성 증가)

		(1) 값 형식 : 변수에 데이터의 값 담음
		(2) 참조 형식 : 변수에 데이터의 위치 담음

	2) 자료형 사용
		(1) Basic
			1] 데이터 선언 : 데이터형식 변수명;
				int x;
				int x, int y;
				int x = 30, int y = 30;

				- 여러개 변수 동시 선언 가능

				- C, C++ : 초기화 선언 안하면, 초기화 X(효율성을 위해)
				- C# : 초기화 선언 안하면, 0으로 초기화
			2] 데이터 할당 : 변수명 = 데이터;
				x = 100;
			3] 블록
				- 블록 안에서 선언된 변수 : 블록 안에서만 생존, 블록 밖에서는 사망

		(2) 값 변수 / 참조 변수
			1] 값 변수 : 변수에 데이터 값 담음
				{
				int a = 100;
				int b = 200;
				int c = 300;
				}

				- 값 변수(= 자동 변수 = stack 변수) : stack에 값 할당, 블록 벗어나면 stack 순서대로 해제
			2] 참조 변수 : 변수에 데이터의 위치 담음
				{
				object a = 10;
				object b = 20;
				}

				- 참조 변수 : stack에 주소 할당 + heap에 데이터 값 저장 + stack이 heap을 가리킴, 블록 벗어나면 stack 순서대로 해제 + garbage collector가 heap 해제

				- C, C++ : 메모리 주소 출력 가능
				- C# : 메모리 주소 출력 불가(error를 없애기 위해)

				- stack : cache memory(cpu에 존재)에 저장 / 적은 용량 / 임시 사용 메모리 공간
				- heap : memory에 저장 / 주소 지정능력만큼   용량 / 장기 사용 메모리 공간

		(3) 기본 데이터 형식 / 복합 데이터 형식
			1] 기본 데이터 형식
				[1] 정수 형식
					1]] sbyte : signed byte 정수 /1byte / -128 ~ 127
					1]] byte : unsigned short / 1byte / 0 ~ 255
					2]] short : signed short 정수 / 2byte / -32,768 ~ 32,767
					2]] ushort : unsigned short 정수 / 2byte / 0 ~ 66535
					3]] int : signed int 정수 / 4byte / -21억 ~ 21억
					3]] uint : unsigned int 정수 / 4byte / 0 ~ 42억
					4]] long : signed long 정수 / 8byte
					4]] ulong : unsigned long 정수 / 8byte
					5]] char : 유니코드문자 / 2byte

				[2] 부동 소수점 형식
					1]] float : 단일 정밀도 부동 소수점 / 4byte / e38 / 유효숫자 : 7 or 8자리(부정확한 계산. 속도 증가)
						- 1비트 : 부호
						- 8비트 : 지수부(소수점 유효숫자)
						- 23비트 : 가수부(데이터 크기)
					2]] double : 복수 정밀도 부동 소수점 / 8byte / e308 / 유효숫자 : 15자리(정확한 계산. 속도 저하 but 요즘 시대에는 상관 없다)

				[3] 문자열 형식
					1]] char : 문자
						char a = '가';
					2]] string : 문자열
						string a = "안녕하세요";

				[4] 논리 형식
					1]] bool : 논리 형식 / 1byte / true, false

					- C, C++ : 논리 형식 없는 언어. 0은 거짓, 0이 아닌수는 참으로 판단
					- C# : 논리 형식 있는 언어. 별도 논리 형식 도입(코드 읽을 때, 거짓을 의미하는지 숫자 0을 의미하는지 구분 위함)

				- data overflow : 데이터 형식이 자료형 크기 초과시, 최저값으로 돌아가 다시 count

				[5] object 형식 : 일단 건너띈다

			2] 형변환
				[1] 명시적 casting : 큰 자료형 >> 작은 자료형인 경우
					1]] 정수 <-> 정수
						int x = 128;
						sbyte y = (sbyte)x;

						- 원본 변수 자료형 > 변환 변수 자료형 : 오버플로우 주의
					2]] 부동 소수점 <-> 부동 소수점
						float a = 69.6875;
						double b = (double)a;

						- 부동 소수점 : 오버플로우 존재x
						- 소수점 정밀성 손상 주의
					3]] 부호 존재 <-> 부호 존재x
						int a = 500;
						uint b = (uint)b;

						- 오버 플로우 주의
					4]] 부동 소수점 <-> 정수

						- 소수점 버림
					4]] 문자열 <-> 숫자
						Convert.ToString(변수명)
						Convert.Int32(변수명)
				[2] 묵시적 casting : 작은 자료형 >> 큰 자료형인 경우
					sbyte x = 128;
					int y = x;
			3] 상수와 열거 형식
				
				-
*/