#include <stdio.h>

int main() {
	// 입력
	int N;
	int score[101];
	scanf_s("%d", &N);
	for (int i = 0; i < N; i++) {
		scanf_s("%d", &score[i]);
	}

	// 연산
	int min, j, tmp, idx;
	for (int i = 0; i < N - 1; i++) {
		min = score[i];
		idx = i;
		for (j = i+1; j < N; j++){
			if (score[j] < min) {
				min = score[j];
				idx = j;
			}
		}
		tmp = score[i];
		score[idx] = tmp;
		score[i] = min;
		// 확인용 코드
		// for (int i = 0; i <= N-1; i++) {
			// printf("(%d)", score[i]);
		// }
		// printf("\n");
	}
	// 확인용 코드
	// for (int i = 0; i < N; i++) {
		// printf("(%d)\n", score[i]);
	// }

	int cnt = 1, res;
	for (int i = N - 1; i > 0; i--) {
		if (score[i] > score[i - 1]) {
			cnt++;
		}
		if (cnt == 3) {
			res = score[i-1];
			break;
		}
	}
	printf("%d", res);
}