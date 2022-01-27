#include <stdio.h>
#include <vector>
#include <algorithm>

int main() {
	// 입력
	int N;
	scanf_s("%d", &N);
	int cnt[2001] = { 0 }, listN[2001] = { 0 }, K;
	for (int i = 1; i <= N; i++) {
		scanf_s("%d", &listN[i]);
		cnt[listN[i]]++;
		// printf("cnt[listN[%d]] : %d\n", listN[i], cnt[listN[i]]); // 확인용 코드
	}
	scanf_s("%d", &K);

	// 연산
	int res = -1;
	if (K < N) {
		res = K + 1;
	}
	else {
		int sum = N, i = 2, total = N;	// 이미 한바퀴 돈 상태니까 i=1이 아니라 sum=N, total=N, i=2 ♣
		while (total < K) {
			sum -= cnt[i];
			total += sum;
			i++;
		}
		printf("total : %d\n", total);	// 확인용 코드
		if (total == K) {
			for (int j = 1; j <= N; j++) {	// 변수 j랑 i랑 헷갈려서 선언은 j로 하고 ++은 i로 해버림 ♣
				if (listN[j] >= i) {
					res = j;
					break;
				}
			}
			// printf("total == K\n");	// 확인용 코드
		}
		else {
			i--;	// 되돌리려면 역순으로 해야한다 ♣
			total -= sum;
			sum += cnt[i];
			// printf("total : %d\n", total);	// 확인용 코드

			for (int j = 1; j <= N; j++) {
				if (listN[j] >= i) {
					total++;
					// printf("i : %d\n", i);	// 확인용 코드
					// printf("listN[j] : %d\n", listN[j]);	// 확인용 코드
					if (total == K + 1) {
						res = j;
						break;
					}
				}
			}
		}
	}

	// 출력
	printf("%d", res);
}