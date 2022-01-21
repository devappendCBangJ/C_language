#include <stdio.h>

int main() {
	// 입력
	int N, listN[101], M, listM[201]; // listM에 N의 원소들을 넣을거니까 크기가 M의 원소들만 고려한 101이 아닌 N의 원소들도 고려한 201이 되어야한다 ♣
	scanf_s("%d", &N);
	for (int i = 0; i < N; i++) {
		scanf_s("%d", &listN[i]);
	}
	scanf_s("%d", &M);
	for (int i = 0; i < M; i++) {
		scanf_s("%d", &listM[i]);
	}

	// 연산
	int last = 1, cnt = 0, tmp = 0;
	for (int i = 0; i < N; i++) {
		for (int j = tmp; j < M + cnt; j++) {
			if (listM[j] > listN[i]) {
				for (int k = M + cnt - 1; k >= j; k--) { // 여기도 배열의 총 크기를 M + cnt로 해줘야함. 정렬문제가 아니라서 한칸씩 밀리니까 M + cnt - 2가 아닌 M + cnt - 1로 설정 ♣
					listM[k + 1] = listM[k];
				}
				listM[j] = listN[i];
				last = 0;
				tmp = j;
				break;
			}
		}
		if (last == 1) {
			listM[M - 1 + cnt + 1] = listN[i];
			tmp = M - 1 + cnt + 1;
		}
		last = 1;
		cnt++;
		// 확인용 코드
		for (int i = 0; i < M + cnt; i++) {
			printf("(%d)", listM[i]);
		}
		printf("\n");
	}

	// 출력
	for (int i = 0; i < M + cnt; i++) {
		printf("%d ", listM[i]);
	}
}