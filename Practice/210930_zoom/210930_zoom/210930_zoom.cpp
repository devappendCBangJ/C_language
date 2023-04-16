#include <stdio.h>
#include <math.h>

// �ִ밪, �ּҰ� ���� �迭 + �Լ� ����
int findMin(int s[], int n, int *idx); // int *idx ��
int findMax(int s[], int n, int *idx);

// �Ȱ��� ��� ��Ʈ1
// int findMin(int s[], int n, int* idx, int* min);
// int findMax(int s[], int n, int* idx, int* max);

// �ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

// ���Ұ� �Լ��� �迭 - ���� �迭 �Լ�
double add(double a, double b) { return a + b; }
double sub(double a, double b) { return a - b; }
double mul(double a, double b) { return a * b; }
double div(double a, double b) { return a / b; }
double (*f[4])(double, double) = { add, sub, mul, div }; // ���Ұ� �Լ��� �迭 ���� //*f[4]??? // �� �������� ; �Ⱥٿ����� ���⼭�� ; ����? = ������ �ϴϱ� ��

// �ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

// �ڸ��� ���� �Լ�
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

// �ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

// ¦���� 2�� ����, Ȧ���� 3���ؼ� 1����. �ݺ� >> 1�� �����ϴ� �Լ�
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

// �ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

int main() {
	// �ִ밪, �ּҰ� ���� �迭 + �Լ�
	printf("�ѤѤ��ִ밪, �ּҰ� ���ϴ� �迭 + �Լ��ѤѤ�\n");
	int d1[7] = { 33, 12, 23, 45, 67, 11, 25 };
	int min, max, idx_min, idx_max;
	min = findMin(d1, 7, &idx_min); // &���� : �ش� �ּҿ� ���� ������ ������ ����
	max = findMax(d1, 7, &idx_max); // &���� : �ش� �ּҿ� ���� ������ ������ ����
	printf("min: d[%d]=%d, max d[%d]=%d\n", idx_min, min, idx_max, max);

	// �Լ��� �迭 - ���� �迭
	printf("�ѤѤ��Լ��� �迭 - ���� �迭�ѤѤ�\n");
	double x = 17, y = 13;
	char op[4] = { '+', '-', '*', '/' };
	for (int i = 0; i < 4; i++)
		printf("%.2f %c %.2f = %.2f\n", x, op[i], y, f[i](x, y)); // ���Ұ� �Լ��� �迭 ȣ�� ��

	// ���� �ڸ��� ��ȯ
	printf("�ѤѤ����� �ڸ��� ��ȯ�ѤѤ�\n");
	int n = 123456;
	int d2[20]; // ���Ƿ� 20�� ���� ���� �迭 ����
	printf("%d --> %d\n", n, findDigits(n));
	int m = getDigits(n, d2); // �迭�� ����Ҷ�, []�̰� ���� �ʰ� �׳� �迭 �̸��� �ᵵ �� ���ּҴ� �˾Ƽ� �ҷ�����
							  // �迭�� �Լ��� �μ��� ���� ���纻�� �ƴ� ������ ����
	for (int i = 0; i < m; i++) {
		printf("%d��° �ڸ��� : %d\n", i + 1, d2[i]);
	}

	// abcd = a^4 + b^4 + c^4 + d^4
	printf("�ѤѤ�abcd = a^4 + b^4 + c^4 + d^4�ѤѤ�\n");
	int q[20] = { 0 };
	for (int x = 0; x < 10000; x++) {
		getDigits(x, q);
		int tot = 0;
		for (int i = 0; i < 4; i++)
			tot += pow(q[i], 4);
		if (x == tot)
			printf("%d^4+%d^4+%d^4+%d^4=%d\n", q[0], q[1], q[2], q[3], x);
	}

	// ¦���� 2�� ����, Ȧ���� 3���ؼ� 1����. �ݺ� >> 1�� �����ϴ� �Լ�
	printf("�ѤѤ�¦���� 2�� ����. Ȧ���� 3���ؼ� 1����. �ݺ� >> 1�� �����ϴ� �Լ��ѤѤ�\n");
	int n2 = 13;
	int s2[20] = { 0 };
	int m2 = sequence(n2, s2);
	for (int i = 0; i <= m2; i++) {
		printf("%d\n", s2[i]);
	}
}

// �ѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤѤ�

// �ִ밪, �ּҰ� ���� �迭 + �Լ�
int findMin(int s[], int n, int* idx) { // int* : �ڷ����� int�� �ڷ��� �ּҸ� �ҷ��� / �Լ����� return���� 1���� �ټ� �����Ƿ� �ٸ� ���� �ҷ����� ���� �ּ� ����
	int min = s[0];
	for (int i = 1; i < n; i++) {
		if (s[i] < min) {
			min = s[i];
			*idx = i;
		}
	}
	return min;
}

int findMax(int s[], int n, int* idx) { // int* : �ڷ����� int�� �ڷ��� �ּҸ� �ҷ��� / �Լ����� return���� 1���� �ټ� �����Ƿ� �ٸ� ���� �ҷ����� ���� �ּ� ����
	int max = s[0];
	for (int i = 1; i < n; i++) {
		if (s[i] > max) {
			max = s[i];
			*idx = i;
		}
	}
	return max;
}
// �Լ��� �̸��� �����Ϳ� ����� ����

// �Ȱ��� ��� ��Ʈ1
//void findMin(int s[], int n, int* idx, int* min) { // int* : �ڷ����� int�� �ڷ��� �ּҸ� �ҷ��� / �Լ����� return���� 1���� �ټ� �����Ƿ� �ٸ� ���� �ҷ����� ���� �ּ� ����
//	int min = s[0];
//	for (int i = 1; i < n; i++) {
//		if (s[i] < min) {
//			min = s[i];
//			*idx = i;
//		}
//	}
//}