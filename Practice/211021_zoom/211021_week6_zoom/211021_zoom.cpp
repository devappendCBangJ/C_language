#include <stdio.h>
#include <math.h>
#include <Windows.h>

// ����ü - ���Ҽ�
struct COMPLEX {
	double real;
	double img;
}; // ����ü ���� �� �����ݷ� �ʼ� ��

// ����ü - print �Լ� ���� �� ����
void printComp(const char s[], COMPLEX a) {
	if(a.img >= 0)
		printf("%s %.3f + %.3fi\n", s, a.real, a.img); // �迭�� �̸��� ���ι�ȣ�ϱ� s�� ���� ��
	else
		printf("%s %.3f %.3fi\n", s, a.real, a.img);
}

// ����ü - ���ϱ� �Լ� ���� �� ����
COMPLEX addComp(COMPLEX a, COMPLEX b) {
	COMPLEX c = { a.real + b.real, a.img + b.img };
	return c;
}

// ����ü - ũ�� �Լ� ���� �� ����
double magComp(COMPLEX a) {
	double mag = sqrt(a.real * a.real + a.img * a.img); // ��
	return mag;
}

// ����ü - ���ϱ� �Լ� ���� �� ����
COMPLEX mulComp(COMPLEX a, COMPLEX b) { // (a+bi)(c+di)
	COMPLEX c;
	c.real = a.real * b.real - a.img * b.img; // ��
	c.img = a.real * b.img + a.img * b.real; // ��
	return c;
}

// ����ü - ��
struct POINT1 { double x; double y; };

// ����ü - �� (�� 2��)
struct LINE { POINT1 st; POINT1 end; };

// ����ü - �ﰢ�� (�� 3��)
struct TRIANGLE { POINT1 p1; POINT1 p2; POINT1 p3; };

// ���� �Լ�
LINE setLine(POINT1 a, POINT1 b) {
	LINE L = { a,b };
	return L;
}

// ����ü - �� �� ���� �Ÿ�
double distLine(LINE l) {
	return sqrt((l.end.x - l.st.x) * (l.end.x - l.st.x) + (l.end.y - l.st.y) * (l.end.y - l.st.y));
}

// �ﰢ�� �Լ�
TRIANGLE setTri_p(POINT1 p1, POINT1 p2, POINT1 p3) {
	TRIANGLE t = { p1, p2, p3 };
	return t;
}

// �ﰢ�� �Լ�2
TRIANGLE setTri_a(POINT1 p[]) {
	TRIANGLE t = { p[0], p[1], p[2]};
	return t;
}

// �ﰢ�� ���� �Լ� ��
double areaTri(TRIANGLE t) {
	LINE a = setLine(t.p1, t.p2), b = setLine(t.p2, t.p3), c = setLine(t.p3, t.p1);
	double la = distLine(a), lb = distLine(b), lc = distLine(c);
	double s = (la + lb + lc) / 2;
	return sqrt(s * (s - la) * (s - lb) * (s - lc)); // �ﰢ���� ���� ����
}

// ����ü - ����Ʈ ũ��
union TWOBYTES {
	unsigned short sh;
	unsigned char c[2];
};

// ����ü - ����Ʈ ũ��
union FOURBYTES {
	unsigned int in;
	unsigned char c[4];
};

// ������ - ��Ź�� �ùķ��̼�
enum WASHER {IDLE, LOAD, WASH, LINSE, DRAIN, FINISH};

int main() {
	// ����ü - ���Ҽ� ���
	printf("�ѤѤѱ���ü - ���Ҽ� ���ѤѤ� \n");
	COMPLEX a = { 3.7, -1.2 }, b = {0.1, 2.3};
	printf("a�� real = %f\n", a.real);
	printComp("a = ", a); // "a = "�� ����ϱ� �Լ������� ���� �� char s[]�� �ƴ� const char s[]�� ����
	printComp("b = ", b);
	printComp("c = ", addComp(a, b));
	printf("lal = %.7f\n", magComp(a));
	printComp("a*b = ", mulComp(a, b));

	// ����ü - �ﰢ�� ���
	printf("�ѤѤѱ���ü - �ﰢ�� ���ѤѤ� \n");
	POINT1 a_2 = { 0, 0 }, b_2 = { 1, 1 }, c_2 = { 1, 0 };
	LINE p = { a_2, b_2 };
	printf("lLl = %.3f\n", distLine(p));
	TRIANGLE t = setTri_p(a_2, b_2, c_2);
	printf("area = %.3f\n", areaTri(t));

	// ����ü - ����Ʈ ���
	printf("�ѤѤѰ���ü - ����Ʈ ���ѤѤ� \n");
	TWOBYTES a_3 = { 1255 }; // ��� ���� ���� �Ƹ���ϳ� ��
	printf("sh = %d\n", a_3.sh); // ��
	printf("sh = %x\n", a_3.sh);
	for (int i = 0; i < 2; i++) {
		printf("c[%d]=%d\n", i, a_3.c[i]);
		printf("c[%d]=%x\n", i, a_3.c[i]);
	}

	FOURBYTES a_4 = { 12551000 };
	printf("sh = %d\n", a_4.in);
	printf("sh = %x\n", a_4.in);
	for (int i = 0; i < 4; i++) {
		printf("c[%d]=%d\n", i, a_4.c[i]);
		printf("c[%d]=%x\n", i, a_4.c[i]);
	}

	// ������ - ��Ź�� �ùķ��̼�
	printf("�ѤѤѿ����� - ��Ź�� �ùķ��̼ǤѤѤ� \n");
	WASHER mode = IDLE;
	int cnt = 0;
	while (1) {
		printf("while�� ������ ��!\n");
		switch (mode) {
		case IDLE:
			// printf("idle mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = LOAD;
				cnt = 0;
				printf("load mode...\n");
			}
			break;
		case LOAD:
			// printf("load mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = WASH;
				cnt = 0;
				printf("wash mode...\n");
			}
			break;
		case WASH:
			// printf("wash mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = LINSE;
				cnt = 0;
				printf("linse mode...\n");
			}
			break;
		case LINSE:
			// printf("linse mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = DRAIN;
				cnt = 0;
				printf("drain mode...\n");
			}
			break;
		case DRAIN:
			// printf("drain mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = FINISH;
				cnt = 0;
				printf("finish mode...\n");
			}
			break;
		case FINISH:
			// printf("finish mode...\n");
			cnt++;
			if (cnt > 100) {
				mode = IDLE;
				cnt = 0;
				printf("idle mode...\n");
			}
			break;
		}
		Sleep(1);
	}
}