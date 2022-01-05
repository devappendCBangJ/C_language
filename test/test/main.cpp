#include <stdio.h>

extern void f1();
extern void f2();
int main(void) {
	// f1(); // 이렇게는 불가능
	f2();

	char a[11] = "안녕하세요";
	for (int i = 0; i <= 10; i++) {
		printf("%d", a[i]);
	}

	return 0;
}