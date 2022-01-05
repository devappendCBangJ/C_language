#include<stdio.h>
#define M 3
#define N 4

// 약수 개수, 값(자기 자신 제외) 출력 함수
int getDivisor(int n, int d[]);
// 과잉수(자신을 제외한 모든 약수의 합 > 자신)(200이하만) 출력 함수
int sumArray(int d[], int m);
// 행렬 출력 함수
void printMat(int a[M][N], const char t[]);
// 행렬 출력 함수2
void printMat2(int a[M][M], const char t[]);
// 행렬 덧셈 함수
void addMat(int a[M][N], int b[M][N], int c[M][N]);
// 행렬 곱셈 함수
void mulMat(int a[M][N], int b[N][M], int c[M][M]);
// 문자열 길이 출력 함수
int strLen(char t[]);
// 메뉴 선택 함수
int selectMenu();
const char menu[][20] = { // 한 행당 20열 = 20글자 저장가능한 배열
"(1) 뱀",
"(2) 원숭이",
"(3) 치타",
"(4) 몽구스",
"(5) 타조",
"(6) 그만하기"
}; // 여기도 ; 필요함 ♣

int main() {
	// 약수 개수, 값(자기 자신 제외) 출력
	printf("ㅡㅡㅡ약수 개수, 값 출력ㅡㅡㅡ\n");
	int n; // 전역 변수 n
	scanf_s("%d", &n);
	int s[100] = { 0 };
	int m = getDivisor(n, s);
	printf("n = %d의 약수\n", n);
	for (int i = 0; i <= m; i++)
		printf("%d\n", s[i]);

	// 과잉수(자신을 제외한 모든 약수의 합 > 자신)(200이하만) 출력
	printf("ㅡㅡㅡ200 이하의 과잉수(자신을 제외한 모든 약수의 합 > 자신인 정수) 출력ㅡㅡㅡ\n");
	for (int n = 2; n <= 200; n++) { // 지역 변수 n // n
		m = getDivisor(n, s);
		int p = sumArray(s, m + 1); // 약수 개수 구하는 함수에서 자기 자신을 제외한 약수 개수가 m개 이므로 포함하면 m+1개 ♣
		if (p > n) {
			printf("n=%d, p=%d\n", n, p);
		}
	}

	// 행렬 출력
	printf("ㅡㅡㅡ행렬 출력 함수ㅡㅡㅡ\n");
	int a[M][N] = { {1, 2, 3, 4}, {1, 0, 1, 0}, {4, 3, 2, 1} };
	int b[M][N] = { {1, 0, 1, 0}, {1, 2, 3, 4}, {4, -3, 2, -1} };
	int c[M][N] = { 0 }; // 결과를 담는 통
	int d[N][M] = { {1, 0, 1}, {0, 1, 2}, {3, 4, 4}, {-3, -2, -1} };
	int e[M][M] = { 0 }; // 결과를 담는 통
	printMat(a, "a[]");
	printMat(b, "b[]");

	// 행렬 덧셈
	printf("ㅡㅡㅡ행렬 덧셈 함수ㅡㅡㅡ\n");
	addMat(a, b, c);
	printMat(c, "c[]=a[]+b[]");

	// 행렬 곱셈
	printf("ㅡㅡㅡ행렬 곱셈 함수ㅡㅡㅡ\n");
	mulMat(a, d, e);
	printMat2(e, "e[]=a[]xd[]");

	// 문자열 길이 출력
	printf("ㅡㅡㅡ문자열 길이 출력ㅡㅡㅡ\n");
	char s2[] = "apple"; // 문자열을 배열에 담음
	printf("%s 길이 : %d\n", s2, strLen(s2));

	// 메뉴 선택
	printf("ㅡㅡㅡ메뉴 선택ㅡㅡㅡ\n");
	int sel = selectMenu();
	printf("당신은 결국 %s을(를) 골랐습니다\n", menu[sel - 1] + 4);
	
	return 0;
}

// ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

// 약수 개수, 값(자기 자신 제외) 출력 함수
int getDivisor(int n, int d[]) {
	int count = 0;
	d[0] = 1; // ♣
	for (int i = 2; i <= n / 2; i++) { // 1,n은 무조건 약수니까 일부러 포함 안함
		if (n % i == 0) {
			count++; // ♣
			d[count] = i; // ♣
		}
	}
	return count;
}

// 과잉수(자신을 제외한 모든 약수의 합 > 자신인 정수)(200이하만) 출력 함수
int sumArray(int d[], int m) {
	int sum = 0;
	for (int i = 0; i < m; i++) {
		sum += d[i];
	}
	return sum;
}

// 행렬 출력 함수
void printMat(int a[M][N], const char t[]) { // a[][N] 이렇게 해도 된다 // const char t[] 행렬은 단어 하나하나를 상자에 담음
	printf("============== %s =============\n", t);
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			printf("%5d\t", a[i][j]); // \t : tab
		}
		printf("\n");
	}
}

// 행렬 출력 함수2
void printMat2(int a[M][M], const char t[]) { // a[][N] 이렇게 해도 된다
	printf("============== %s =============\n", t);
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < M; j++) {
			printf("%5d\t", a[i][j]); // \t : tab
		}
		printf("\n");
	}
}

// 행렬 덧셈 함수
void addMat(int a[M][N], int b[M][N], int c[M][N]) {
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			c[i][j] = a[i][j] + b[i][j];
		}
	}
}

// 행렬 곱셈 함수
void mulMat(int a[M][N], int b[N][M], int c[M][M]) {
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			c[i][j] = 0;
			for (int k = 0; k < N; k++) { // ♣
				c[i][j] += a[i][k] * b[k][j]; // ♣
			}
		}
	}
}

// 문자열 길이 출력 함수 ♣
int strLen(char t[]) {
	int cnt = 0;
	while (t[cnt] != NULL) { //NULL = 0
		cnt++;
	}
	return cnt;
}

// 메뉴 선택 함수
int selectMenu() {
	int sel = 0;
	int prev_sel = 0;
	do {
		for (int i = 0; i < 6; i++)
			printf("\t%s\n", menu[i]);
		printf("좋아하는 동물의 번호를 입력하시오 : ");
		scanf_s("%d", &sel);
		if (sel > 0 && sel < 6) {
			printf("당신은 %d번 %s을(를) 골랐습니다\n", sel, menu[sel - 1] + 4); // 배열은 0부터 저장, 입력은 1부터 하므로 sel-1로 대응시켜줌 ♣
																			 //(1)은 각각 1바이트씩이므로 이후 글자만 출력하기 위해 주소 3 증가 ♣
			prev_sel = sel;
		}
	} while (sel != 6);
	return prev_sel;
}