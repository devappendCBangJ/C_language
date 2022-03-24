//scanf_s("%d%c%d", &x, &op, 1, &y); : 캐릭터 자료형 입력 시 뒤에는 바이트 표시 필수

#include <stdio.h> // 기본 입출력 라이브러리
#include <math.h> // 수학 라이브러리
#include <Windows.h> // sleep 라이브러리
# include "solution.h"

void week2() {
	//2차 방정식 계수 a b c 입력 받은 후 해 출력
	printf("ㅡㅡㅡ2차 방정식 계수 a b c 입력 받은 후 해 출력ㅡㅡㅡ \n");
	float a, b, c;
	scanf_s("%f, %f, %f", &a, &b, &c);
	if (a == 0) { // a가 0인 경우
		if (b == 0) { // b가 0인 경우
			printf("No solution");
		}
		else { // b가 0이 아닌 경우
			printf("s= %f\n", c / b); // 해가 무한대 아닌가??? ♣
		}
	}
	else { // a가 0이 아닌 경우
		float D = b * b - 4 * a * c;
		if (D >= 0) { // D가 0보다 크거나 같은 경우
			float x1 = -b / (2 * a) - sqrt(D) / (2 * a);
			float x2 = -b / (2 * a) + sqrt(D) / (2 * a);

			printf("x=%f, %f\n", x1, x2);
		}
		else { // D가 0보다 작은 경우
			float im = sqrt(-D) / (2 * a);

			printf("x=%f-%fi, %f + %fi\n", -b / (2 * a), im, -b / (2 * a), im);
		}
	}

	// 거스름돈 계산(5만원, 1만원, 5천원, 1천원
	printf("ㅡㅡㅡ거스름돈 계산(5만원, 1만원, 5천원, 1천원ㅡㅡㅡ \n");
	int amount = 3000, pay = 100000;
	int rem = pay - amount;
	int n50000 = rem / 50000;
	int n10000 = (rem % 50000) / 10000;
	int n5000 = ((rem % 50000) % 10000) / 5000;
	int n1000 = (((rem % 50000) % 10000) % 5000) / 1000;

	printf("n50000=%d장\n", n50000);
	printf("n10000=%d장\n", n10000);
	printf("n5000=%d장\n", n5000);
	printf("n1000=%d장\n", n1000);

	// 간단한 계산기(+-*/%)
	printf("ㅡㅡㅡ간단한 계산기(+-*/%)ㅡㅡㅡ \n");
	int x, y, res;
	char op, ch;
	while (1) {
		scanf_s("%d%c%d", &x, &op, 1, &y); // 캐릭터 뒤에는 바이트 표시 필수
		switch (op) {
		case '+':
			res = x + y;
			break;
		case '-':
			res = x - y;
			break;
		case '*':
			res = x * y;
			break;
		case '/':
			res = x / y;
			break;
		case '%':
			res = x % y;
			break;
		default:
			printf("Wrong operator\n");
			break;
		}
		printf("%d %c %d = %d\n", x, op, y, res);

		scanf_s("%c", &ch, 1); // 캐릭터 뒤에는 바이트 표시 필수 ♣
							   // scanf에서 입력받도록 지정한 자료형이 아닌 값을 입력했을 때, 그냥 건너띔 ♣
							   // scanf에서 %c를 받도록했는데 여러 문자를 입력했을 때, scanf_s가 여러번 실행됨 ♣
		if (ch == 'n' || ch == 'N') { // ''는 문자, ""는 문자열
			printf("계산기를 종료합니다");
			break;
		}
	}

	// 복리 계산(100만원 10년이면 얼마?)
	printf("ㅡㅡㅡ복리 계산(100만원 10년이면 얼마?)ㅡㅡㅡ \n");
	float total = 1000000, r = 0.045;

	for (int y = 1; y <= 10; y++) {
		total *= (1 + r);
		printf("total[%d 년]=%f\n", y, total);
	}

	// 복리 계산(100만원이 1억원으로 언제?)
	printf("ㅡㅡㅡ복리 계산(100만원 1억으로 언제?)ㅡㅡㅡ \n");
	total = 1000000, r = 0.045;
	int y_count = 0;

	while (total < 100000000) {
		total *= (1 + r);
		y_count++;
	}
	printf("total[%d 년]=%f\n", y_count, total);

	// 간단한 애니메이션(물방울 터뜨리기)
	printf("ㅡㅡㅡ간단한 애니메이션(물방울 터뜨리기)ㅡㅡㅡ \n");
	for (int i = 0; i < 3; i++) { // int 대신 size_t 사용 가능
		printf(".");
		Sleep(500);
		printf("\b");

		printf("o");
		Sleep(500);
		printf("\b");

		printf("O");
		Sleep(500);
		printf("\b");

		printf("*");
		Sleep(500);
		printf("\b");

		printf(" ");
		Sleep(500);
		printf("\b");
	}

	// AB^2+CD^2 = ABCD인 경우 찾기
	printf("ㅡㅡㅡAB^2+CD^2 = ABCD인 경우 찾기ㅡㅡㅡ \n");
	int A, B, C, D;
	for (A = 0; A < 10; A++) {
		for (B = 0; B < 10; B++) {
			for (C = 0; C < 10; C++) {
				for (D = 0; D < 10; D++) {
					if ((A * 10 + B) * (A * 10 + B) + (C * 10 + D) * (C * 10 + D) == A * 1000 + B * 100 + C * 10 + D) {
						printf("조건을 만족하는 ABCD = %d\n", A * 1000 + B * 100 + C * 10 + D);
					}
				}
			}
		}
	}
	int ABCD = 0;
	for (ABCD = 0; ABCD < 10000; ABCD++) {
		int AB = ABCD / 100; // 이 선언이 for문 안에서 계속해서 이뤄져야함 ♣
		int CD = ABCD % 100;
		if (AB * AB + CD * CD == ABCD) {
			printf("조건을 만족하는 ABCD = %d\n", ABCD);
		}
	}
}