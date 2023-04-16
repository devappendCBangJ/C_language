#include<stdio.h>
#define M 3
#define N 4

// ��� ����, ��(�ڱ� �ڽ� ����) ��� �Լ�
int getDivisor(int n, int d[]);
// ���׼�(�ڽ��� ������ ��� ����� �� > �ڽ�)(200���ϸ�) ��� �Լ�
int sumArray(int d[], int m);
// ��� ��� �Լ�
void printMat(int a[M][N], const char t[]);
// ��� ��� �Լ�2
void printMat2(int a[M][M], const char t[]);
// ��� ���� �Լ�
void addMat(int a[M][N], int b[M][N], int c[M][N]);
// ��� ���� �Լ�
void mulMat(int a[M][N], int b[N][M], int c[M][M]);
// ���ڿ� ���� ��� �Լ�
int strLen(char t[]);
// �޴� ���� �Լ�
int selectMenu();
const char menu[][20] = { // �� ��� 20�� = 20���� ���尡���� �迭
"(1) ��",
"(2) ������",
"(3) ġŸ",
"(4) ������",
"(5) Ÿ��",
"(6) �׸��ϱ�"
}; // ���⵵ ; �ʿ��� ��

int main() {
	// ��� ����, ��(�ڱ� �ڽ� ����) ���
	printf("�ѤѤѾ�� ����, �� ��¤ѤѤ�\n");
	int n; // ���� ���� n
	scanf_s("%d", &n);
	int s[100] = { 0 };
	int m = getDivisor(n, s);
	printf("n = %d�� ���\n", n);
	for (int i = 0; i <= m; i++)
		printf("%d\n", s[i]);

	// ���׼�(�ڽ��� ������ ��� ����� �� > �ڽ�)(200���ϸ�) ���
	printf("�ѤѤ�200 ������ ���׼�(�ڽ��� ������ ��� ����� �� > �ڽ��� ����) ��¤ѤѤ�\n");
	for (int n = 2; n <= 200; n++) { // ���� ���� n // n
		m = getDivisor(n, s);
		int p = sumArray(s, m + 1); // ��� ���� ���ϴ� �Լ����� �ڱ� �ڽ��� ������ ��� ������ m�� �̹Ƿ� �����ϸ� m+1�� ��
		if (p > n) {
			printf("n=%d, p=%d\n", n, p);
		}
	}

	// ��� ���
	printf("�ѤѤ���� ��� �Լ��ѤѤ�\n");
	int a[M][N] = { {1, 2, 3, 4}, {1, 0, 1, 0}, {4, 3, 2, 1} };
	int b[M][N] = { {1, 0, 1, 0}, {1, 2, 3, 4}, {4, -3, 2, -1} };
	int c[M][N] = { 0 }; // ����� ��� ��
	int d[N][M] = { {1, 0, 1}, {0, 1, 2}, {3, 4, 4}, {-3, -2, -1} };
	int e[M][M] = { 0 }; // ����� ��� ��
	printMat(a, "a[]");
	printMat(b, "b[]");

	// ��� ����
	printf("�ѤѤ���� ���� �Լ��ѤѤ�\n");
	addMat(a, b, c);
	printMat(c, "c[]=a[]+b[]");

	// ��� ����
	printf("�ѤѤ���� ���� �Լ��ѤѤ�\n");
	mulMat(a, d, e);
	printMat2(e, "e[]=a[]xd[]");

	// ���ڿ� ���� ���
	printf("�ѤѤѹ��ڿ� ���� ��¤ѤѤ�\n");
	char s2[] = "apple"; // ���ڿ��� �迭�� ����
	printf("%s ���� : %d\n", s2, strLen(s2));

	// �޴� ����
	printf("�ѤѤѸ޴� ���äѤѤ�\n");
	int sel = selectMenu();
	printf("����� �ᱹ %s��(��) ������ϴ�\n", menu[sel - 1] + 4);
	
	return 0;
}

// �ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

// ��� ����, ��(�ڱ� �ڽ� ����) ��� �Լ�
int getDivisor(int n, int d[]) {
	int count = 0;
	d[0] = 1; // ��
	for (int i = 2; i <= n / 2; i++) { // 1,n�� ������ ����ϱ� �Ϻη� ���� ����
		if (n % i == 0) {
			count++; // ��
			d[count] = i; // ��
		}
	}
	return count;
}

// ���׼�(�ڽ��� ������ ��� ����� �� > �ڽ��� ����)(200���ϸ�) ��� �Լ�
int sumArray(int d[], int m) {
	int sum = 0;
	for (int i = 0; i < m; i++) {
		sum += d[i];
	}
	return sum;
}

// ��� ��� �Լ�
void printMat(int a[M][N], const char t[]) { // a[][N] �̷��� �ص� �ȴ� // const char t[] ����� �ܾ� �ϳ��ϳ��� ���ڿ� ����
	printf("============== %s =============\n", t);
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			printf("%5d\t", a[i][j]); // \t : tab
		}
		printf("\n");
	}
}

// ��� ��� �Լ�2
void printMat2(int a[M][M], const char t[]) { // a[][N] �̷��� �ص� �ȴ�
	printf("============== %s =============\n", t);
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < M; j++) {
			printf("%5d\t", a[i][j]); // \t : tab
		}
		printf("\n");
	}
}

// ��� ���� �Լ�
void addMat(int a[M][N], int b[M][N], int c[M][N]) {
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			c[i][j] = a[i][j] + b[i][j];
		}
	}
}

// ��� ���� �Լ�
void mulMat(int a[M][N], int b[N][M], int c[M][M]) {
	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			c[i][j] = 0;
			for (int k = 0; k < N; k++) { // ��
				c[i][j] += a[i][k] * b[k][j]; // ��
			}
		}
	}
}

// ���ڿ� ���� ��� �Լ� ��
int strLen(char t[]) {
	int cnt = 0;
	while (t[cnt] != NULL) { //NULL = 0
		cnt++;
	}
	return cnt;
}

// �޴� ���� �Լ�
int selectMenu() {
	int sel = 0;
	int prev_sel = 0;
	do {
		for (int i = 0; i < 6; i++)
			printf("\t%s\n", menu[i]);
		printf("�����ϴ� ������ ��ȣ�� �Է��Ͻÿ� : ");
		scanf_s("%d", &sel);
		if (sel > 0 && sel < 6) {
			printf("����� %d�� %s��(��) ������ϴ�\n", sel, menu[sel - 1] + 4); // �迭�� 0���� ����, �Է��� 1���� �ϹǷ� sel-1�� ���������� ��
																			 //(1)�� ���� 1����Ʈ���̹Ƿ� ���� ���ڸ� ����ϱ� ���� �ּ� 3 ���� ��
			prev_sel = sel;
		}
	} while (sel != 6);
	return prev_sel;
}