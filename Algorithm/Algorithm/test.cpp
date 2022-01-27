#include <stdio.h>
#include <vector>
#include <algorithm>

int main() {
	// 입력 + 정렬
	std::vector<int> listN;
	int sum = 0, min = 2000000000, max = -2000000000, N, C;
	scanf_s("%d %d", &N, &C);
	for (int i = 0; i < N; i++) {
		scanf_s("%d", &listN[i]);
		if (min > listN[i]) {
			min = listN[i];
		}
		else if(max < listN[i]) {
			max = listN[i];
		}
		printf("listN[i] : %d\n", listN[i]); // 확인용 코드
		printf("min : %d\n", min); // 확인용 코드
		printf("max : %d\n", max); // 확인용 코드
	}
	printf("\n"); // 확인용 코드
	for (int i = 0; i < N; i++) { // 확인용 코드
		printf("listN[i] : %d\n", listN[i]);
	}
	sort(listN.begin(), listN.end());
	printf("\n"); // 확인용 코드
	for (int i = 0; i < N; i++) { // 확인용 코드
		printf("listN[i] : %d\n", listN[i]);
	}
	printf("\n"); // 확인용 코드

	// 연산
	int middle, cnt, res = min;
	while (min <= max) {
		middle = (min + max) / 2, cnt = 1;
		for (int i=1; i<N; i++){
			if (middle <= listN[i] - listN[i - 1]) {
				cnt++;
			}
			printf("((%d))\n", cnt); // 확인용 코드
		}
		printf("(%d)\n", middle); // 확인용 코드
		if (cnt < C) {
			max = middle - 1;
		}
		else if(cnt >= C) {
			if (middle > res) {
				res = middle;
			}
			min = middle + 1;
		}
	}

	// 출력
	printf("%d", res);
}