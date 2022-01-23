#include <stdio.h>

int main() {
	// 입력
	int total = 0, N, M, list[1001];
	scanf_s("%d %d", &N, &M);
	for (int i = 0; i < N; i++) {
		scanf_s("%d", &list[i]);
		total += list[i];
	}
	int j = total / M;
	// printf("((%d))\n", j); // 확인용 코드
	int tmp = 0, i = 0, cnt = 1;
	while (i <= N){
		if (j >= tmp) {
			tmp += list[i++];
		}
		else {
			tmp = 0, cnt++;
			if (cnt == M + 1 || (list[i - 1]) > j) {
				j++;
				i = 0;
				cnt = 1;
			}
			else {
				tmp += list[i - 1];
			}
		}
		// printf("(%d)\n", tmp); // 확인용 코드
	}

	// 출력
	printf("%d", j);
}