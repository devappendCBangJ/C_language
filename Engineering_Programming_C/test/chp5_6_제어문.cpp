// ● 제어문 : 문장 실행 순서에 영향
	// 0. 프로그램 흐름 제어
		// 0) 순차 구조
		// 1) 선택 구조
		// 2) 반복 구조

	// 1. 조건문 : 조건에 따른 수행
		// 1) if문
			// if(조건)
				// 문장; ... 이건 실행
				// 문장; ... 이건 실행x
			// else if(조건)
				// 문장; ... 이건 실행
				// 문장; ... 이건 실행x
			// else
				// 문장;
			
			// - 특징 : 
				// else절은 가장 가까운 if절과 매칭 ♣

		// 2) switch문
			// switch(조건) {
			// case c1:
				// 문장;
				// break;
			// case c2:
				// 문장;
				// break;
			// default:
				// 문장;
				// break;
			// }

			// - 특징 : 
				// case 뒤는 조건식의 경우 값을 기입
				// default는 else와 같은 역할
				// break 나올때까지 순차적으로 계속 실행함
					// 이 특성을 이용해서 의도적으로 break를 안쓸 수도 있음 ♣

		// 3) 중첩 조건문

	// 2. goto문 : 해당 레이블로 위치 점프 수행... 반복문의 원리
		// 1) goto문
			// while(1){
			// 레이블1:
				// goto 레이블2
			// }
			// 레이블2:
				// goto 레이블1

	// 3. 반복문 : 
		// 1) while문
			// while(조건)
				// 문장; ... 이건 실행
				// 문장; ... 이건 실행x

		// 2) do_while문 : 반복 조건을 루프 끝에서 검사(문장 1번 실행 >> 조건문 실행)
			// do
				// 문장;
			// while(조건)

		// 3) for문
			// for (초기화; 조건식; 증감식)
				// 문장; ... 이건 실행
				// 문장; ... 이건 실행x

			// - 특징
				// 초기화 부분에는 아무거나 써도되고, 안 써도 됨 ♣
				// 증감 부분에는 뺄셈, 곱셈, 어떤 수식이든 가능 ♣
		
		// 4) 중첩 반복문

		// 5) break문 : 반복루프 빠져나옴
		
		// 6) continue문 : 현재 반복루프 빠져나옴 + 바로 다음 반복루프 실행

		// 7) 센티널 : 입력되는 데이터의 끝을 알리는 특수한 값
			// 예시 : while(y > 50) 이면 y가 45인 경우, while문 빠져나옴

	// 4. 복합문 = 블록 : 중괄호 이용 문장 그룹핑
		// {문장; 문장; 문장; ...}