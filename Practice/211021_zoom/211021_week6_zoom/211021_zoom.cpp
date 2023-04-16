#include <stdio.h>
#include <math.h>
#include <Windows.h>

// 구조체 - 복소수
struct COMPLEX {
	double real;
	double img;
}; // 구조체 생성 시 세미콜론 필수 ♣

// 구조체 - print 함수 정의 및 선언
void printComp(const char s[], COMPLEX a) {
	if(a.img >= 0)
		printf("%s %.3f + %.3fi\n", s, a.real, a.img); // 배열의 이름이 선두번호니까 s만 쓰면 됨
	else
		printf("%s %.3f %.3fi\n", s, a.real, a.img);
}

// 구조체 - 더하기 함수 정의 및 선언
COMPLEX addComp(COMPLEX a, COMPLEX b) {
	COMPLEX c = { a.real + b.real, a.img + b.img };
	return c;
}

// 구조체 - 크기 함수 정의 및 선언
double magComp(COMPLEX a) {
	double mag = sqrt(a.real * a.real + a.img * a.img); // ♣
	return mag;
}

// 구조체 - 곱하기 함수 정의 및 선언
COMPLEX mulComp(COMPLEX a, COMPLEX b) { // (a+bi)(c+di)
	COMPLEX c;
	c.real = a.real * b.real - a.img * b.img; // ♣
	c.img = a.real * b.img + a.img * b.real; // ♣
	return c;
}

// 구조체 - 점
struct POINT1 { double x; double y; };

// 구조체 - 선 (점 2개)
struct LINE { POINT1 st; POINT1 end; };

// 구조체 - 삼각형 (점 3개)
struct TRIANGLE { POINT1 p1; POINT1 p2; POINT1 p3; };

// 직선 함수
LINE setLine(POINT1 a, POINT1 b) {
	LINE L = { a,b };
	return L;
}

// 구조체 - 두 점 사이 거리
double distLine(LINE l) {
	return sqrt((l.end.x - l.st.x) * (l.end.x - l.st.x) + (l.end.y - l.st.y) * (l.end.y - l.st.y));
}

// 삼각형 함수
TRIANGLE setTri_p(POINT1 p1, POINT1 p2, POINT1 p3) {
	TRIANGLE t = { p1, p2, p3 };
	return t;
}

// 삼각형 함수2
TRIANGLE setTri_a(POINT1 p[]) {
	TRIANGLE t = { p[0], p[1], p[2]};
	return t;
}

// 삼각형 면적 함수 ♣
double areaTri(TRIANGLE t) {
	LINE a = setLine(t.p1, t.p2), b = setLine(t.p2, t.p3), c = setLine(t.p3, t.p1);
	double la = distLine(a), lb = distLine(b), lc = distLine(c);
	double s = (la + lb + lc) / 2;
	return sqrt(s * (s - la) * (s - lb) * (s - lc)); // 삼각형의 면적 공식
}

// 공용체 - 바이트 크기
union TWOBYTES {
	unsigned short sh;
	unsigned char c[2];
};

// 공용체 - 바이트 크기
union FOURBYTES {
	unsigned int in;
	unsigned char c[4];
};

// 열거형 - 세탁기 시뮬레이션
enum WASHER {IDLE, LOAD, WASH, LINSE, DRAIN, FINISH};

int main() {
	// 구조체 - 복소수 계산
	printf("ㅡㅡㅡ구조체 - 복소수 계산ㅡㅡㅡ \n");
	COMPLEX a = { 3.7, -1.2 }, b = {0.1, 2.3};
	printf("a의 real = %f\n", a.real);
	printComp("a = ", a); // "a = "는 상수니까 함수값으로 받을 때 char s[]가 아닌 const char s[]로 정의
	printComp("b = ", b);
	printComp("c = ", addComp(a, b));
	printf("lal = %.7f\n", magComp(a));
	printComp("a*b = ", mulComp(a, b));

	// 구조체 - 삼각형 계산
	printf("ㅡㅡㅡ구조체 - 삼각형 계산ㅡㅡㅡ \n");
	POINT1 a_2 = { 0, 0 }, b_2 = { 1, 1 }, c_2 = { 1, 0 };
	LINE p = { a_2, b_2 };
	printf("lLl = %.3f\n", distLine(p));
	TRIANGLE t = setTri_p(a_2, b_2, c_2);
	printf("area = %.3f\n", areaTri(t));

	// 공용체 - 바이트 계산
	printf("ㅡㅡㅡ공용체 - 바이트 계산ㅡㅡㅡ \n");
	TWOBYTES a_3 = { 1255 }; // 출력 값이 뭔가 아리까리하네 ♣
	printf("sh = %d\n", a_3.sh); // ♣
	printf("sh = %x\n", a_3.sh);
	for (int i = 0; i < 2; i++) {
		printf("c[%d]=%d\n", i, a_3.c[i]);
		printf("c[%d]=%x\n", i, a_3.c[i]);
	}

	FOURBYTES a_4 = { 12551000 };
	printf("sh = %d\n", a_4.in);
	printf("sh = %x\n", a_4.in);
	for (int i = 0; i < 4; i++) {
		printf("c[%d]=%d\n", i, a_4.c[i]);
		printf("c[%d]=%x\n", i, a_4.c[i]);
	}

	// 열거형 - 세탁기 시뮬레이션
	printf("ㅡㅡㅡ열거형 - 세탁기 시뮬레이션ㅡㅡㅡ \n");
	WASHER mode = IDLE;
	int cnt = 0;
	while (1) {
		printf("while문 돌리는 중!\n");
		switch (mode) {
		case IDLE:
			// printf("idle mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = LOAD;
				cnt = 0;
				printf("load mode...\n");
			}
			break;
		case LOAD:
			// printf("load mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = WASH;
				cnt = 0;
				printf("wash mode...\n");
			}
			break;
		case WASH:
			// printf("wash mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = LINSE;
				cnt = 0;
				printf("linse mode...\n");
			}
			break;
		case LINSE:
			// printf("linse mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = DRAIN;
				cnt = 0;
				printf("drain mode...\n");
			}
			break;
		case DRAIN:
			// printf("drain mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = FINISH;
				cnt = 0;
				printf("finish mode...\n");
			}
			break;
		case FINISH:
			// printf("finish mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = IDLE;
				cnt = 0;
				printf("idle mode...\n");
			}
			break;
		}
		Sleep(1);
	}
}