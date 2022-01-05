// int main함수 : 프로그램 시작 시 진입점이기 때문에 프로젝트 당 1개만 정의

# include <stdio.h> // 기본 입출력 라이브러리
# include <stdlib.h> // 난수 라이브러리
# include <time.h> // 시간 라이브러리
# include <math.h> // 수학 라이브러리

#define Num_Of_Balls 45
#define Ball_to_Pick 7

#define Num_Of_Cards 52
#define Card_to_Pick 7

#define pi atan(1.)*4 // (파이/4)*4

// 피타고라스 정리 함수 초기 선언
float distance(float x1, float y1, float x2, float y2);

// 테일러 급수 함수 초기 선언
int factorial(int n);
float exp_t(float x, int n);

// 사제 arctan2 초기 선언
float atan3(float y, float x);

int main() {
	// 45개 숫자 중에서 중복되지 않는 7개 숫자 뽑기
	printf("ㅡㅡㅡ45개 숫자 중에서 중복되지 않는 7개 숫자 뽑기ㅡㅡㅡ\n");

	// 중복되지 않도록 공 뽑기 >> 공 대입 : 7회 반복
	srand(time(NULL));

	int ball_box[Ball_to_Pick] = { 0 }, flag_1, ball_num;
	for (int i = 0; i < Ball_to_Pick; i++) {
		do {
			ball_num = rand() % Num_Of_Balls + 1; // ♣
			flag_1 = 1; // ♣
			for (int j = 0; j < i; j++) {
				if (ball_num == ball_box[j]) {
					flag_1 = 0; // ♣
					printf("중복 공 발생! 다시 돌리기!\n");
					break;
				}
			}
		} while (flag_1 == 0); // ♣
		ball_box[i] = ball_num;
	}
	// 공 출력
	for (int i = 0; i < Ball_to_Pick; i++) {
		printf("%d\n", ball_box[i]);
		// 전체 공 출력을 가장 마지막에 한꺼번에 하므로 중복되는 공 발생! printf문이 가장 먼저 출력됨
	}

	// 52개 트럼프 카드 중에서 중복되지 않는 7개 카드 뽑기
	printf("ㅡㅡㅡ52개 트럼프 카드 중에서 중복되지 않는 7개 카드 뽑기ㅡㅡㅡ\n");

	// 중복되지 않도록 카드 뽑기 >> 카드 대입 : 7회 반복
	srand(time(NULL));

	int card_box[Card_to_Pick] = { 0 }, flag_2, card;
	for (int i = 0; i < Card_to_Pick; i++) {
		do {
			card = rand() % Num_Of_Cards + 1; // ♣
			flag_2 = 1; // ♣
			for (int j = 0; j < i; j++) {
				if (card == card_box[j]) {
					flag_2 = 0; // ♣
					printf("중복 카드 발생! 다시 돌리기!\n");
					break;
				}
			}
		} while (flag_2 == 0); // ♣
		card_box[i] = card;
	}

	// 카드 출력 1번째 방법 ♣
	printf("ㅡㅡㅡ1wayㅡㅡㅡ\n");
	const char suit[][3] = { "♠","◆","♥","♣" }; // 기호 상수 // suit[][3] 여기서 3은 배열에서 차지하는 바이트를 의미한다 ♣
	const char num[][3] = { "A","2","3","4","5","6","7","8","9","10","J","Q","K" }; // 기호 상수
	for (int i = 0; i < Card_to_Pick; i++) { // ♣
		printf("%s", suit[card_box[i] / 13]);
		printf("%s\n", num[card_box[i] % 13]);
	}

	// 카드 출력 2번째 방법
	printf("ㅡㅡㅡ2wayㅡㅡㅡ\n");
	for (int i = 0; i < Card_to_Pick; i++) { // ♣
		switch (card_box[i] / 13) {
		case 0:
			printf("♠");
			break;
		case 1:
			printf("◆");
			break;
		case 2:
			printf("♥");
			break;
		case 3:
			printf("♣");
			break;
		}
		switch (card_box[i] % 13 + 1) {
		case 1:
			printf("A\n");
			break;
		case 11:
			printf("J\n");
			break;
		case 12:
			printf("Q\n");
			break;
		case 13:
			printf("K\n");
			break;
		default:
			printf("%d\n", card_box[i] % 13 + 1);
			break;
		}
	}

	// 피타고라스 정리
	printf("ㅡㅡㅡ피타고라스 정리ㅡㅡㅡ\n");
	printf("dist = %f\n", distance(0, 0, 3, 4));

	// 테일러 급수
	printf("ㅡㅡㅡ테일러 급수ㅡㅡㅡ\n");
	printf("exp(0.3) = %f, exp_t(0.3, 5) = %f\n", exp(0.3), exp_t(0.3, 5));
	printf("Error = %f [%%]\n", (exp(0.3) - exp_t(0.3, 5)) / exp(0.3) * 100);

	// 사제 arctan2
	printf("ㅡㅡㅡ사제 arctan2ㅡㅡㅡ\n");

	for (float ang = 0; ang < 360; ang += 10) {
		float x = cos(ang / 360 * (2*pi)); // 왜 pi냐??? 2pi아님??? ♣
		float y = sin(ang / 360 * (2*pi)); // ang을 arctan으로 계산해야되는거아니냐??? arctan이 y/x를 각도로 바꾸는 건데 왜 y랑 x를 각도로 환산하지??? ♣
		printf("atan2(%f) = %f, atan3(%f) = %f\n", y / x, atan2(y, x), y / x, atan3(y, x)); // y가 앞쪽, x가 뒤쪽 // arctan에 각도를 왜넣어??? y/x를 넣어야지??? ♣
	}
}

// 피타고라스 정리 함수
float distance(float x1, float y1, float x2, float y2) {
	float sol = sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	return sol;
}
// 메인문에 함수 정의하면 왜 안되지??? ♣
// c언어는 함수 안에 함수 중첩 정의가 불가능 ♣

// 테일러 급수 함수 - 팩토리얼
int factorial(int n) {
	int v = 1;
	for (int i = 1; i <= n; i++) {
		v *= i;
	}
	return v;
}

// 테일러 급수 함수 - e^x 결과값
float exp_t(float x, int n) {
	float v = 0;
	for (int i = 0; i <= n; i++) {
		v += pow(x, i) / factorial(i); // 테일러 급수 식 ♣
	}
	return v;
}

// 사제 arctan2 함수
float atan3(float y, float x) {
	float ang;
	if (x > 0) {
		ang = atan(y / x);
	}
	else if (x < 0) {
		if (y > 0) {
			ang = pi - atan(y / (-x));
		}
		else {
			ang = -pi + atan(y / x);
		}
	}
	else {
		if (y > 0) {
			ang = pi / 2;
		}
		else if (y < 0) {
			ang = -pi / 2;
		}
		else {
			ang = 0; // ♣
		}
	}
	return ang;
}