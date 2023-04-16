// ● 문자와 문자열
	// 1. 표현 방법
		// 1) 문자 표현 방법
			// 1) 아스키 코드 : 8비트 (0~127)
			// 2) 유니코드 : 16비트 (0~65536)
				// - 전 세계 모든 문자 표현

		// 2) 문자열 표현 방법 (문자열 : 문자들 여러 개 모임)
			// 1) 문자열 상수 : 아스키코드 문자로 저장 ♣
			// 2) 문자열 변수 : char형 배열 + 마지막 NULL(아스키코드 0번)
				// - NULL = 아스키 코드 0
				// - 숫자 0 = 아스키 코드 42

				// char형 %c출력 >> 실제 문자 출력 ♣
				// char형 %d출력 >> 아스키코드 출력 ♣

	// 2. 문자 배열의 초기화
		// char str[6] = {'H','e','l','l','o','\0'}; >> NULL을 위한 방 하나 더 생성 ♣
		// char str[6] = "Hello";
		// char str[] = "C Bible";

	// 3. 문자열의 배열 ♣
		// 2차원 배열 : char s[3][6] = {"init", "open", "close"}; >> 6글자 3개 단어
		// 3차원 배열 : char dic[3][2][30] = {{"book", "책"}, {"boy", "소년"}, {"computer", "컴퓨터"}} >> 30글자 2개 묶음 3개 단어
		// s[i] : 문자열의 선두 주소

		// - 배열의 가장 마지막 부분인 \0를 아니까 배열의 선두 주소만 알면 됨 ♣
	
	// 4. 라이브러리
		// 1) 문자 입출력 라이브러리
			// #include <stdio.h>
				// scanf_s("%c", &c) : 하나 문자 읽고 변수 c에 저장
				// printf("%c", c) : 변수 c에 저장된 문자 출력

				// int getchar(void) : 하나 문자 읽고 반환 >> 엔터 필요o, 에코o
				// void putchar(int c) : 변수 c에 저장된 문자 출력 >> 엔터 필요o, 에코o

			// #include <conio.h> ♣
				// int getch(void) : 하나 문자 읽고 반환(버퍼 사용x) >> 엔터 필요x, 에코x
				// void putch(int c) : 변수 c에 저장된 문자 출력(버퍼 사용x) >> 엔터 필요x, 에코x
				// int getche(void) : 하나 문자 읽고 반환(버퍼 사용x) >> 엔터 필요x, 에코o

		// 2) 문자열 입출력 라이브러리
			// #include <stdio.h>
				// scanf_s("%s", s) : 문자열 읽고 배열 s[]에 저장 >> 배열 자체가 포인터이므로 & 붙이지 않는다 / 문자열을 수치로 반환 ♣
				// printf("%s", s) : 배열 s[]에 저장된 문자열 출력

				// *gets(char *s) : 한 줄 문자열 읽고 배열 s[]에 저장 >> 엔터 필요o / 얘는 scanf_s처럼 괄호 안에 받을 상자 입력
				// int puts(const char *s) : 배열 s[]에 저장된 한 줄 문자열 출력

				// - scanf_s, getchar, getche, gets : Enter 클릭 >> \n 대신 \0을 추가 ♣

		// 3) 문자 처리 라이브러리
			// #include <ctype.h> ♣
				// isalpha(c) : c가 영문자?
				// isupper(c) : c가 대문자?
				// islower(c) : c가 소문자?
				// isalnum(c) : c가 영문자 or 10진수 숫자?
				// isdigit(c) : c가 10진수 숫자?
				// isxdigit(c) : c가 16진수 숫자?
				// isspace(c) : c가 공백(' ', '\n', '\t', '\v', '\r') 문자?
				// ispunct(c) : c가 구두점(, . ;) 문자?
				// isprint(c) : c가 출력 가능 문자? ♣
				// iscntrl(c) : c가 제어 문자? ♣
				// isascii(c) : c가 아스키 코드? ♣
				// >> 결과값 : true(1) / false(0)

				// toupper(c) : c를 대문자로 변환
				// tolower(c) : c를 소문자로 변환
				// toascii(c) : c를 아스키 코드로 변환 ♣

		// 4) 문자열 처리 라이브러리
			// #include <string.h> ♣
				// strlen(s) : 문자열 s의 길이
				// strcpy(s1, s2) : s2를 s1에 복사
				// strcat(s1, s2) : s2를 s1 끝에 붙여넣기
				// strcmp(s1, s2) : s2를 s1과 비교
					// 반환값 : s1 - s2
						// - 반환값 < 0 : 아스키 코드 s1이 s2보다 작다
						// - 반환값 = 0 : 아스키 코드 s1이 s2과 같다
						// - 반환값 > 0 : 아스키 코드 s1이 s2보다 크다
				// strncpy(s1, s2, n) : s2 n개의 문자를 s1에 복사 ♣
				// strncat(s1, s2, n) : s2 n개의 문자를 s1 끝에 붙여넣기
				// strncmp(s1, s2, n) : 최대 n개 문자 s2를 s1과 비교
				// strchr(s, c) : 문자열 s 안에서 문자 c 찾기 >> 절대 주소 반환 ♣
				// strstr(s1, s2) : 문자열 s1 안에서 문자열 s2 찾기 >> 절대 주소 반환 ♣

		// 5) 문자열을 수치로 변환 라이브러리
			// #include <stdlib.h> ♣
				// int atoi(const char *str) : str 배열을 int형으로 변환
				// long atoi(const char *str) : str 배열을 long형으로 변환
				// double atof(const char *str) : str 배열을 double형으로 변환 

		// 6) 수치 추출 라이브러리
			// #include <stdio.h> ♣
				// sscanf(s,...) : 배열 s에서, 지정된 형식으로 수치 읽은 후, 변수에 저장(문자 >> 수) ♣
				// sprintf(s,...) : 변수 값을, 지정된 형식으로 수치 읽은 후, 배열 s에 저장(수 >> 문자) ♣