#include <stdio.h>

bool is_prime_number(int num)						// num이 소수인가?
{
	bool isprime = true;
	for (int i = 2; i < num; i++)
	{
		if (num % i == 0)
		{
			isprime = false;
			break;
		}
	}
	return isprime;
}

void FindNumberOfPrimeNumber(int nMax, int* nprime)	// nMax까지 소수 개수?
{
	*nprime = 0;
	for (int i = 2; i <= nMax; i++)
	{
		bool isprime = is_prime_number(i);
		if (isprime) (*nprime)++; // ♣
	}
}