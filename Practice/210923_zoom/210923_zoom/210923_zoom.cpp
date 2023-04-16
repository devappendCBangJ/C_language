// int main�Լ� : ���α׷� ���� �� �������̱� ������ ������Ʈ �� 1���� ����

# include <stdio.h> // �⺻ ����� ���̺귯��
# include <stdlib.h> // ���� ���̺귯��
# include <time.h> // �ð� ���̺귯��
# include <math.h> // ���� ���̺귯��

#define Num_Of_Balls 45
#define Ball_to_Pick 7

#define Num_Of_Cards 52
#define Card_to_Pick 7

#define pi atan(1.)*4 // (����/4)*4

// ��Ÿ��� ���� �Լ� �ʱ� ����
float distance(float x1, float y1, float x2, float y2);

// ���Ϸ� �޼� �Լ� �ʱ� ����
int factorial(int n);
float exp_t(float x, int n);

// ���� arctan2 �ʱ� ����
float atan3(float y, float x);

int main() {
	// 45�� ���� �߿��� �ߺ����� �ʴ� 7�� ���� �̱�
	printf("�ѤѤ�45�� ���� �߿��� �ߺ����� �ʴ� 7�� ���� �̱�ѤѤ�\n");

	// �ߺ����� �ʵ��� �� �̱� >> �� ���� : 7ȸ �ݺ�
	srand(time(NULL));

	int ball_box[Ball_to_Pick] = { 0 }, flag_1, ball_num;
	for (int i = 0; i < Ball_to_Pick; i++) {
		do {
			ball_num = rand() % Num_Of_Balls + 1; // ��
			flag_1 = 1; // ��
			for (int j = 0; j < i; j++) {
				if (ball_num == ball_box[j]) {
					flag_1 = 0; // ��
					printf("�ߺ� �� �߻�! �ٽ� ������!\n");
					break;
				}
			}
		} while (flag_1 == 0); // ��
		ball_box[i] = ball_num;
	}
	// �� ���
	for (int i = 0; i < Ball_to_Pick; i++) {
		printf("%d\n", ball_box[i]);
		// ��ü �� ����� ���� �������� �Ѳ����� �ϹǷ� �ߺ��Ǵ� �� �߻�! printf���� ���� ���� ��µ�
	}

	// 52�� Ʈ���� ī�� �߿��� �ߺ����� �ʴ� 7�� ī�� �̱�
	printf("�ѤѤ�52�� Ʈ���� ī�� �߿��� �ߺ����� �ʴ� 7�� ī�� �̱�ѤѤ�\n");

	// �ߺ����� �ʵ��� ī�� �̱� >> ī�� ���� : 7ȸ �ݺ�
	srand(time(NULL));

	int card_box[Card_to_Pick] = { 0 }, flag_2, card;
	for (int i = 0; i < Card_to_Pick; i++) {
		do {
			card = rand() % Num_Of_Cards + 1; // ��
			flag_2 = 1; // ��
			for (int j = 0; j < i; j++) {
				if (card == card_box[j]) {
					flag_2 = 0; // ��
					printf("�ߺ� ī�� �߻�! �ٽ� ������!\n");
					break;
				}
			}
		} while (flag_2 == 0); // ��
		card_box[i] = card;
	}

	// ī�� ��� 1��° ��� ��
	printf("�ѤѤ�1way�ѤѤ�\n");
	const char suit[][3] = { "��","��","��","��" }; // ��ȣ ��� // suit[][3] ���⼭ 3�� �迭���� �����ϴ� ����Ʈ�� �ǹ��Ѵ� ��
	const char num[][3] = { "A","2","3","4","5","6","7","8","9","10","J","Q","K" }; // ��ȣ ���
	for (int i = 0; i < Card_to_Pick; i++) { // ��
		printf("%s", suit[card_box[i] / 13]);
		printf("%s\n", num[card_box[i] % 13]);
	}

	// ī�� ��� 2��° ���
	printf("�ѤѤ�2way�ѤѤ�\n");
	for (int i = 0; i < Card_to_Pick; i++) { // ��
		switch (card_box[i] / 13) {
		case 0:
			printf("��");
			break;
		case 1:
			printf("��");
			break;
		case 2:
			printf("��");
			break;
		case 3:
			printf("��");
			break;
		}
		switch (card_box[i] % 13 + 1) {
		case 1:
			printf("A\n");
			break;
		case 11:
			printf("J\n");
			break;
		case 12:
			printf("Q\n");
			break;
		case 13:
			printf("K\n");
			break;
		default:
			printf("%d\n", card_box[i] % 13 + 1);
			break;
		}
	}

	// ��Ÿ��� ����
	printf("�ѤѤ���Ÿ��� �����ѤѤ�\n");
	printf("dist = %f\n", distance(0, 0, 3, 4));

	// ���Ϸ� �޼�
	printf("�ѤѤ����Ϸ� �޼��ѤѤ�\n");
	printf("exp(0.3) = %f, exp_t(0.3, 5) = %f\n", exp(0.3), exp_t(0.3, 5));
	printf("Error = %f [%%]\n", (exp(0.3) - exp_t(0.3, 5)) / exp(0.3) * 100);

	// ���� arctan2
	printf("�ѤѤѻ��� arctan2�ѤѤ�\n");

	for (float ang = 0; ang < 360; ang += 10) {
		float x = cos(ang / 360 * (2*pi)); // �� pi��??? 2pi�ƴ�??? ��
		float y = sin(ang / 360 * (2*pi)); // ang�� arctan���� ����ؾߵǴ°žƴϳ�??? arctan�� y/x�� ������ �ٲٴ� �ǵ� �� y�� x�� ������ ȯ������??? ��
		printf("atan2(%f) = %f, atan3(%f) = %f\n", y / x, atan2(y, x), y / x, atan3(y, x)); // y�� ����, x�� ���� // arctan�� ������ �ֳ־�??? y/x�� �־����??? ��
	}
}

// ��Ÿ��� ���� �Լ�
float distance(float x1, float y1, float x2, float y2) {
	float sol = sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	return sol;
}
// ���ι��� �Լ� �����ϸ� �� �ȵ���??? ��
// c���� �Լ� �ȿ� �Լ� ��ø ���ǰ� �Ұ��� ��

// ���Ϸ� �޼� �Լ� - ���丮��
int factorial(int n) {
	int v = 1;
	for (int i = 1; i <= n; i++) {
		v *= i;
	}
	return v;
}

// ���Ϸ� �޼� �Լ� - e^x �����
float exp_t(float x, int n) {
	float v = 0;
	for (int i = 0; i <= n; i++) {
		v += pow(x, i) / factorial(i); // ���Ϸ� �޼� �� ��
	}
	return v;
}

// ���� arctan2 �Լ�
float atan3(float y, float x) {
	float ang;
	if (x > 0) {
		ang = atan(y / x);
	}
	else if (x < 0) {
		if (y > 0) {
			ang = pi - atan(y / (-x));
		}
		else {
			ang = -pi + atan(y / x);
		}
	}
	else {
		if (y > 0) {
			ang = pi / 2;
		}
		else if (y < 0) {
			ang = -pi / 2;
		}
		else {
			ang = 0; // ��
		}
	}
	return ang;
}