#include <stdio.h>

int main() {
// 변수
	int total = 0;
	int k = 0;
	int i = 1;
	int l = 1;
	int food_times[100] = { 1 }; // 이렇게 해도 되나??? // 인덱스 0번은 쓸모 없으니까 아무값이나 넣음
	int food_index[100];
	int food_size;
	bool food_count = 1;
	int food_result;
// 입력
	scanf_s("%d", &k);
	while (food_times[i-1] > 0) {
		scanf_s("%d", &food_times[i]);
		i++;
	}
	food_times[i-1] = '\0';
	// printf("%d\n", food_times[i]); // 확인용 코드
// 연산
	// 음식의 인덱스 기억
	// food_size = sizeof(food_times) / sizeof(food_times[0]) - 1; // 이건 초기에 지정한 배열 크기가 대입됨
	food_size = i-2; // 이렇게 해야됨
	// printf("%d", food_size); // 확인용 코드
	for(int j = 1; j <= food_size; j++){
		food_index[j] = j;
		// printf("%d\n", food_index[j]); // 확인용 코드
	}
	// 반복문 돌기
	while (1) {
		// printf("여깄다"); // 확인용 코드
		// 현재 원소가 비어있지 않다면 현재 원소--, total++
		if (food_count == 1 && food_times[l] != 0) {
			food_times[l]--;
			total++;
		}
		// 현재 원소가 비어있든 아니든 l++
		l++;
		// 반복문 회전 시키는 코드
		if (l > food_size) {
			l = 1;
		}
		// total과 l이 같아지면 멈춤
		if (k == total) {
			food_count == 0;
			if (food_times[l] != 0) {
				food_result = food_index[l];
				break;
			}
		}
	}
	// 출력
	printf("%d", food_result);
}