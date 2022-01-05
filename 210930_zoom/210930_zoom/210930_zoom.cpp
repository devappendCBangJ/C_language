#include <stdio.h>
#include <math.h>

// 최대값, 최소값 추출 배열 + 함수 선언
int findMin(int s[], int n, int *idx); // int *idx ♣
int findMax(int s[], int n, int *idx);

// 똑같은 결과 세트1
// int findMin(int s[], int n, int* idx, int* min);
// int findMax(int s[], int n, int* idx, int* max);

// ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

// 원소가 함수인 배열 - 계산기 배열 함수
double add(double a, double b) { return a + b; }
double sub(double a, double b) { return a - b; }
double mul(double a, double b) { return a * b; }
double div(double a, double b) { return a / b; }
double (*f[4])(double, double) = { add, sub, mul, div }; // 원소가 함수인 배열 생성 //*f[4]??? // 왜 위에서는 ; 안붙여놓고 여기서는 ; 붙임? = 연산을 하니까 ♣

// ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

// 자릿수 추출 함수
int findDigits(int n) {
	int dig = 0;
	while (n > 0) {
		n /= 10;
		dig++;
	}
	return dig;
}

int getDigits(int n, int digits[]) {
	int m = findDigits(n);
	for (int i = 0; i < m; i++) {
		digits[i] = n % 10;
		n /= 10;
	}
	return m;
}

// ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

// 짝수면 2로 나눔, 홀수면 3곱해서 1더함. 반복 >> 1로 수렴하는 함수
int sequence(int n, int s[]) {
	int m = 0;
	s[m] = n;
	while (n > 1) {
		if (n % 2 == 0) {
			n /= 2;
		}
		else {
			n = 3 * n + 1;
		}
		m++;
		s[m] = n;
	}
	return m;
}

// ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

int main() {
	// 최대값, 최소값 추출 배열 + 함수
	printf("ㅡㅡㅡ최대값, 최소값 구하는 배열 + 함수ㅡㅡㅡ\n");
	int d1[7] = { 33, 12, 23, 45, 67, 11, 25 };
	int min, max, idx_min, idx_max;
	min = findMin(d1, 7, &idx_min); // &변수 : 해당 주소에 대한 정보를 변수에 담음
	max = findMax(d1, 7, &idx_max); // &변수 : 해당 주소에 대한 정보를 변수에 담음
	printf("min: d[%d]=%d, max d[%d]=%d\n", idx_min, min, idx_max, max);

	// 함수의 배열 - 계산기 배열
	printf("ㅡㅡㅡ함수의 배열 - 계산기 배열ㅡㅡㅡ\n");
	double x = 17, y = 13;
	char op[4] = { '+', '-', '*', '/' };
	for (int i = 0; i < 4; i++)
		printf("%.2f %c %.2f = %.2f\n", x, op[i], y, f[i](x, y)); // 원소가 함수인 배열 호출 ♣

	// 정수 자리수 반환
	printf("ㅡㅡㅡ정수 자리수 반환ㅡㅡㅡ\n");
	int n = 123456;
	int d2[20]; // 임의로 20개 원소 갖는 배열 설정
	printf("%d --> %d\n", n, findDigits(n));
	int m = getDigits(n, d2); // 배열을 사용할때, []이거 쓰지 않고 그냥 배열 이름만 써도 그 뒷주소는 알아서 불러와짐
							  // 배열은 함수의 인수로 사용시 복사본이 아닌 원본이 전달
	for (int i = 0; i < m; i++) {
		printf("%d번째 자리수 : %d\n", i + 1, d2[i]);
	}

	// abcd = a^4 + b^4 + c^4 + d^4
	printf("ㅡㅡㅡabcd = a^4 + b^4 + c^4 + d^4ㅡㅡㅡ\n");
	int q[20] = { 0 };
	for (int x = 0; x < 10000; x++) {
		getDigits(x, q);
		int tot = 0;
		for (int i = 0; i < 4; i++)
			tot += pow(q[i], 4);
		if (x == tot)
			printf("%d^4+%d^4+%d^4+%d^4=%d\n", q[0], q[1], q[2], q[3], x);
	}

	// 짝수면 2로 나눔, 홀수면 3곱해서 1더함. 반복 >> 1로 수렴하는 함수
	printf("ㅡㅡㅡ짝수면 2로 나눔. 홀수면 3곱해서 1더함. 반복 >> 1로 수렴하는 함수ㅡㅡㅡ\n");
	int n2 = 13;
	int s2[20] = { 0 };
	int m2 = sequence(n2, s2);
	for (int i = 0; i <= m2; i++) {
		printf("%d\n", s2[i]);
	}
}

// ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

// 최대값, 최소값 추출 배열 + 함수
int findMin(int s[], int n, int* idx) { // int* : 자료형이 int인 자료의 주소를 불러옴 / 함수에서 return값은 1개만 줄수 있으므로 다른 값도 불러오기 위해 주소 지정
	int min = s[0];
	for (int i = 1; i < n; i++) {
		if (s[i] < min) {
			min = s[i];
			*idx = i;
		}
	}
	return min;
}

int findMax(int s[], int n, int* idx) { // int* : 자료형이 int인 자료의 주소를 불러옴 / 함수에서 return값은 1개만 줄수 있으므로 다른 값도 불러오기 위해 주소 지정
	int max = s[0];
	for (int i = 1; i < n; i++) {
		if (s[i] > max) {
			max = s[i];
			*idx = i;
		}
	}
	return max;
}
// 함수의 이름도 포인터와 비슷한 개념

// 똑같은 결과 세트1
//void findMin(int s[], int n, int* idx, int* min) { // int* : 자료형이 int인 자료의 주소를 불러옴 / 함수에서 return값은 1개만 줄수 있으므로 다른 값도 불러오기 위해 주소 지정
//	int min = s[0];
//	for (int i = 1; i < n; i++) {
//		if (s[i] < min) {
//			min = s[i];
//			*idx = i;
//		}
//	}
//}