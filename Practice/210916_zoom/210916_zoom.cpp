//scanf_s("%d%c%d", &x, &op, 1, &y); : ĳ���� �ڷ��� �Է� �� �ڿ��� ����Ʈ ǥ�� �ʼ�

#include <stdio.h> // �⺻ ����� ���̺귯��
#include <math.h> // ���� ���̺귯��
#include <Windows.h> // sleep ���̺귯��
# include "solution.h"

void week2() {
	//2�� ������ ��� a b c �Է� ���� �� �� ���
	printf("�ѤѤ�2�� ������ ��� a b c �Է� ���� �� �� ��¤ѤѤ� \n");
	float a, b, c;
	scanf_s("%f, %f, %f", &a, &b, &c);
	if (a == 0) { // a�� 0�� ���
		if (b == 0) { // b�� 0�� ���
			printf("No solution");
		}
		else { // b�� 0�� �ƴ� ���
			printf("s= %f\n", c / b); // �ذ� ���Ѵ� �ƴѰ�??? ��
		}
	}
	else { // a�� 0�� �ƴ� ���
		float D = b * b - 4 * a * c;
		if (D >= 0) { // D�� 0���� ũ�ų� ���� ���
			float x1 = -b / (2 * a) - sqrt(D) / (2 * a);
			float x2 = -b / (2 * a) + sqrt(D) / (2 * a);

			printf("x=%f, %f\n", x1, x2);
		}
		else { // D�� 0���� ���� ���
			float im = sqrt(-D) / (2 * a);

			printf("x=%f-%fi, %f + %fi\n", -b / (2 * a), im, -b / (2 * a), im);
		}
	}

	// �Ž����� ���(5����, 1����, 5õ��, 1õ��
	printf("�ѤѤѰŽ����� ���(5����, 1����, 5õ��, 1õ���ѤѤ� \n");
	int amount = 3000, pay = 100000;
	int rem = pay - amount;
	int n50000 = rem / 50000;
	int n10000 = (rem % 50000) / 10000;
	int n5000 = ((rem % 50000) % 10000) / 5000;
	int n1000 = (((rem % 50000) % 10000) % 5000) / 1000;

	printf("n50000=%d��\n", n50000);
	printf("n10000=%d��\n", n10000);
	printf("n5000=%d��\n", n5000);
	printf("n1000=%d��\n", n1000);

	// ������ ����(+-*/%)
	printf("�ѤѤѰ����� ����(+-*/%)�ѤѤ� \n");
	int x, y, res;
	char op, ch;
	while (1) {
		scanf_s("%d%c%d", &x, &op, 1, &y); // ĳ���� �ڿ��� ����Ʈ ǥ�� �ʼ�
		switch (op) {
		case '+':
			res = x + y;
			break;
		case '-':
			res = x - y;
			break;
		case '*':
			res = x * y;
			break;
		case '/':
			res = x / y;
			break;
		case '%':
			res = x % y;
			break;
		default:
			printf("Wrong operator\n");
			break;
		}
		printf("%d %c %d = %d\n", x, op, y, res);

		scanf_s("%c", &ch, 1); // ĳ���� �ڿ��� ����Ʈ ǥ�� �ʼ� ��
							   // scanf���� �Է¹޵��� ������ �ڷ����� �ƴ� ���� �Է����� ��, �׳� �ǳʶ� ��
							   // scanf���� %c�� �޵����ߴµ� ���� ���ڸ� �Է����� ��, scanf_s�� ������ ����� ��
		if (ch == 'n' || ch == 'N') { // ''�� ����, ""�� ���ڿ�
			printf("���⸦ �����մϴ�");
			break;
		}
	}

	// ���� ���(100���� 10���̸� ��?)
	printf("�ѤѤѺ��� ���(100���� 10���̸� ��?)�ѤѤ� \n");
	float total = 1000000, r = 0.045;

	for (int y = 1; y <= 10; y++) {
		total *= (1 + r);
		printf("total[%d ��]=%f\n", y, total);
	}

	// ���� ���(100������ 1������� ����?)
	printf("�ѤѤѺ��� ���(100���� 1������ ����?)�ѤѤ� \n");
	total = 1000000, r = 0.045;
	int y_count = 0;

	while (total < 100000000) {
		total *= (1 + r);
		y_count++;
	}
	printf("total[%d ��]=%f\n", y_count, total);

	// ������ �ִϸ��̼�(����� �Ͷ߸���)
	printf("�ѤѤѰ����� �ִϸ��̼�(����� �Ͷ߸���)�ѤѤ� \n");
	for (int i = 0; i < 3; i++) { // int ��� size_t ��� ����
		printf(".");
		Sleep(500);
		printf("\b");

		printf("o");
		Sleep(500);
		printf("\b");

		printf("O");
		Sleep(500);
		printf("\b");

		printf("*");
		Sleep(500);
		printf("\b");

		printf(" ");
		Sleep(500);
		printf("\b");
	}

	// AB^2+CD^2 = ABCD�� ��� ã��
	printf("�ѤѤ�AB^2+CD^2 = ABCD�� ��� ã��ѤѤ� \n");
	int A, B, C, D;
	for (A = 0; A < 10; A++) {
		for (B = 0; B < 10; B++) {
			for (C = 0; C < 10; C++) {
				for (D = 0; D < 10; D++) {
					if ((A * 10 + B) * (A * 10 + B) + (C * 10 + D) * (C * 10 + D) == A * 1000 + B * 100 + C * 10 + D) {
						printf("������ �����ϴ� ABCD = %d\n", A * 1000 + B * 100 + C * 10 + D);
					}
				}
			}
		}
	}
	int ABCD = 0;
	for (ABCD = 0; ABCD < 10000; ABCD++) {
		int AB = ABCD / 100; // �� ������ for�� �ȿ��� ����ؼ� �̷������� ��
		int CD = ABCD % 100;
		if (AB * AB + CD * CD == ABCD) {
			printf("������ �����ϴ� ABCD = %d\n", ABCD);
		}
	}
}