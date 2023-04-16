// <���� �Լ�>
// 0. ���� ������� �ҷ����� : #include <stdlib.h>
// 0. �ð� ������� �ҷ����� : #include <time.h>
// 1. ���� �õ� ���� : srand(time(NULL)
	// - �ʴ��� �ð� ��ȯ(1970�� 1�� 1�� ~ ����) : time(NULL)
// 2. ���� ���� : rand()

// Ư�� ���� ����Ʈ ���Ұ� ���� : ����[����Ʈ ����] = {���Ұ�}

// �ڷ����� ũ�� ��� : sizeof(��� or ���� �̸� or �ڷ���)

#include <stdio.h> // �⺻ ����� ���̺귯��
#include <stdlib.h> // ���� ���̺귯��
#include <time.h> // �ð� ���̺귯��
#include <math.h> // ���� ���̺귯��
#include "solution.h"

void week1() {
	// ���� ���� 10��
	printf("�ѤѤѷ��� ���� 10���ѤѤ� \n");
	for (int i = 0; i < 10; i++)
		printf("%d\n", rand());

	// ���� �ֻ��� 10ȸ
	printf("�ѤѤѷ��� �ֻ����ѤѤ� \n");
	srand(time(NULL));
	for (int i = 0; i < 10; i++)
		printf("%d\n", rand() % 6 + 1);

	// ���� �ֻ��� 6���� �� 5�� �� �� ���Դ���?
	printf("�ѤѤѷ��� �ֻ��� 6���� �� 5�� �� �� ���Դ���?�ѤѤ� \n");
	srand(time(NULL));
	int count_num_5 = 0;

	for (int i = 0; i < 60000; i++) {
		int temp = rand() % 6 + 1;

		if (temp == 5)
			count_num_5++;
	}
	printf("count of 5 = %d \n", count_num_5);

	// �ֻ��� Ȯ��
	printf("�ѤѤ��ֻ��� Ȯ���ѤѤ� \n");
	srand(time(NULL));

	int count_dice[7] = { 0 };
	for (int i = 0; i < 60000; i++) {
		int temp_2 = rand() % 6 + 1;

		count_dice[temp_2]++;
	}

	for (int i = 1; i <= 6; i++) {
		printf("count of %d = %d \n", i, count_dice[i]);
	}

	// A^3 + B^3 + C^3 = ABC �� ABC ã��
	printf("�ѤѤ�A^3 + B^3 + C^3 = ABC �� ABC ã��ѤѤ� \n");
	int ABC = 0;
	for (ABC = 0; ABC < 1000; ABC++) {
		int A, B, C;
		A = ABC / 100;
		B = (ABC % 100) / 10;
		C = ABC % 10;

		if (A * A * A + B * B * B + C * C * C == ABC) {
			printf("%d^3+%d^3+%d^3 = %d \n", A, B, C, ABC);
		}
	}

	// 1~100 ���� �� �Ҽ��� ���� ã��
	printf("�ѤѤ�1~100 ���� �� �Ҽ��� ���� ã��ѤѤ� \n");
	for (int n = 2; n <= 100; n++) {
		int isPrime = 1; //Prime �ʱ�ȭ

		for (int m = 2; m < n; m++) {
			if (n % m == 0) {
				isPrime = 0; //Prime ����
				break; // break�ϸ� �ݺ��� �ٷ� �Ʒ��� �̵� ��
			}
		}
		if (isPrime) { //isPrime == true, isPrime == 1 or ��Ÿ 0�� ������ ������ ���� ��
			printf("%d is prime! \n", n);
		}
	}
			// n = 2, m = 2�϶�, 2��° for������ m < n �������� �ʱ⶧���� �ٷ� �������ͼ� isPrime = 1 �״����
			// �׷��� �ܼ�â�� 2 is Prime!�� ǥ�õǴ� ��!

	printf("�ѤѤ�1~100 ���� �� a^2 + b^2 = c^2 �� a, b, c ã��ѤѤ� \n");
	// 1~100 ���� �� a^2 + b^2 = c^2 �� a, b, c ã��
	int a, b, c;
	for (a = 1; a <= 100; a++) {
		for (b = 1; b <= 100; b++) {
			for (c = 1; c <= 100; c++) {
				if (a * a + b * b == c * c) {
					if (a <= b) { // ��
						printf("%5d, %5d, %5d \n", a, b, c);
					}
				}
			}
		}
	}

	//	printf("�ѤѤѤѤѤѤѤѤѤѤѤѤѤ� \n");
	//	// �ڷ����� ũ�� ��� : sizeof(��� or ���� �̸� or �ڷ���)
	//	short wow;
	//	wow = 515;
	//	printf("short ��� : % d", wow);
	//	printf("size of long double : %d\n", sizeof(long double));
	//
	//	printf("�ѤѤѤѤѤѤѤѤѤѤѤѤѤ� \n");
}