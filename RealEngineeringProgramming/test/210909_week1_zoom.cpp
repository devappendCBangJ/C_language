// <난수 함수>
// 0. 난수 헤더파일 불러오기 : #include <stdlib.h>
// 0. 시간 헤더파일 불러오기 : #include <time.h>
// 1. 난수 시드 지정 : srand(time(NULL)
	// - 초단위 시간 반환(1970년 1월 1일 ~ 현재) : time(NULL)
// 2. 난수 실행 : rand()

// 특정 변수 리스트 원소값 지정 : 변수[리스트 개수] = {원소값}

// 자료형의 크기 출력 : sizeof(상수 or 변수 이름 or 자료형)

#include <stdio.h> // 기본 입출력 라이브러리
#include <stdlib.h> // 난수 라이브러리
#include <time.h> // 시간 라이브러리
#include <math.h> // 수학 라이브러리
#include "solution.h"

void week1() {
	// 랜덤 숫자 10개
	printf("ㅡㅡㅡ랜덤 숫자 10개ㅡㅡㅡ \n");
	for (int i = 0; i < 10; i++)
		printf("%d\n", rand());

	// 랜덤 주사위 10회
	printf("ㅡㅡㅡ랜덤 주사위ㅡㅡㅡ \n");
	srand(time(NULL));
	for (int i = 0; i < 10; i++)
		printf("%d\n", rand() % 6 + 1);

	// 랜덤 주사위 6만번 중 5가 몇 번 나왔는지?
	printf("ㅡㅡㅡ랜덤 주사위 6만번 중 5가 몇 번 나왔는지?ㅡㅡㅡ \n");
	srand(time(NULL));
	int count_num_5 = 0;

	for (int i = 0; i < 60000; i++) {
		int temp = rand() % 6 + 1;

		if (temp == 5)
			count_num_5++;
	}
	printf("count of 5 = %d \n", count_num_5);

	// 주사위 확률
	printf("ㅡㅡㅡ주사위 확률ㅡㅡㅡ \n");
	srand(time(NULL));

	int count_dice[7] = { 0 };
	for (int i = 0; i < 60000; i++) {
		int temp_2 = rand() % 6 + 1;

		count_dice[temp_2]++;
	}

	for (int i = 1; i <= 6; i++) {
		printf("count of %d = %d \n", i, count_dice[i]);
	}

	// A^3 + B^3 + C^3 = ABC 인 ABC 찾기
	printf("ㅡㅡㅡA^3 + B^3 + C^3 = ABC 인 ABC 찾기ㅡㅡㅡ \n");
	int ABC = 0;
	for (ABC = 0; ABC < 1000; ABC++) {
		int A, B, C;
		A = ABC / 100;
		B = (ABC % 100) / 10;
		C = ABC % 10;

		if (A * A * A + B * B * B + C * C * C == ABC) {
			printf("%d^3+%d^3+%d^3 = %d \n", A, B, C, ABC);
		}
	}

	// 1~100 숫자 중 소수인 정수 찾기
	printf("ㅡㅡㅡ1~100 숫자 중 소수인 정수 찾기ㅡㅡㅡ \n");
	for (int n = 2; n <= 100; n++) {
		int isPrime = 1; //Prime 초기화

		for (int m = 2; m < n; m++) {
			if (n % m == 0) {
				isPrime = 0; //Prime 실패
				break; // break하면 반복문 바로 아래로 이동 ♣
			}
		}
		if (isPrime) { //isPrime == true, isPrime == 1 or 기타 0을 제외한 정수와 같음 ♣
			printf("%d is prime! \n", n);
		}
	}
			// n = 2, m = 2일때, 2번째 for문에서 m < n 충족하지 않기때문에 바로 빠져나와서 isPrime = 1 그대로임
			// 그래서 콘솔창에 2 is Prime!도 표시되는 것!

	printf("ㅡㅡㅡ1~100 숫자 중 a^2 + b^2 = c^2 인 a, b, c 찾기ㅡㅡㅡ \n");
	// 1~100 숫자 중 a^2 + b^2 = c^2 인 a, b, c 찾기
	int a, b, c;
	for (a = 1; a <= 100; a++) {
		for (b = 1; b <= 100; b++) {
			for (c = 1; c <= 100; c++) {
				if (a * a + b * b == c * c) {
					if (a <= b) { // ♣
						printf("%5d, %5d, %5d \n", a, b, c);
					}
				}
			}
		}
	}

	//	printf("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ \n");
	//	// 자료형의 크기 출력 : sizeof(상수 or 변수 이름 or 자료형)
	//	short wow;
	//	wow = 515;
	//	printf("short 출력 : % d", wow);
	//	printf("size of long double : %d\n", sizeof(long double));
	//
	//	printf("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ \n");
}