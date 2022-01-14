#include <stdio.h>

int reverse(int x) {
	int tot = 0;
	while (x != 0) {
		tot += (x % 10);
		tot *= 10; // rev * 10이 아니라 rev *= 10임. 실수 주의 ♣
		x /= 10; // num[i] / 10가 아니라 num[i] /= 10임. 실수 주의 ♣
		// printf("(%d)\n", num[i]); // 확인용 코드
	}
	tot /= 10; // rev / 10이 아니라 rev /= 10임. 실수 주의 ♣
	return tot;
}

bool isPrime(int x) { // 하나의 함수에서 return을 여러개 하면 안된다 ♣
	bool de_flag = 1;
	if (x == 1) {
		de_flag = 0; // 1은 소수가 아니다(약수가 자기 자신을 포함해서 2개가 되지 않으므로) ♣
	}
	for (int j = 2; j <= (x / 2); j++) {
		if (x % j == 0) {
			de_flag = 0;
			break;
		}
	}
	return de_flag;
}

int main() {
	// 입력
	int N;
	scanf_s("%d", &N);
	int num[101]; // 배열의 선언에서 인덱스는 변수로 설정할 수 없다. 상수로 설정해야한다 ♣
	for (int i = 0; i < N; i++) {
		scanf_s("%d", &num[i]);
	}

	// 연산
	int rev = 0;
	bool deci_flag = 1;
	for (int i = 0; i < N; i++) {
		rev = reverse(num[i]);
		// printf("(%d)\n", rev); // 확인용 코드
		deci_flag = isPrime(rev);
		// printf("(%d)\n", deci_flag); // 확인용 코드
		if (deci_flag == 1) {
			printf("%d ", rev); // rev 초기화 안하면 값 누적됨 ♣
		}
		deci_flag = 1;
		rev = 0;
	}
}