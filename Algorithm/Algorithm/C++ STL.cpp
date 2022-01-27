// ● C++ STL : C++ 표준 라이브러리(Standard Template Library)
	// C++ STL 공부 사이트 : https://coding-factory.tistory.com/596
	// 1. Vector
		// 1) 개념 : 동적 배열
			// (1) 벡터 구조
				// front() : 첫번째 원소
				// back() : 마지막 원소
				// begin() : 첫번째 위치
				// end() : 마지막의 다음 위치
				// size() : 원소 개수
				// capacity() : 할당 공간 크기
		// 2) 특징
			// - 동적 원소 추가
			// - 속도 : 배열 > Vector
			// - 메모리 효율 : 배열 < Vector
		// 3) 사용 순서
			// (1) 헤더파일 불러오기
				// #include <vector>
			// (2) 벡터 생성
				// 동적 1차원 벡터 : vector<int> v;
				// 동적 2차원 벡터 : vector<vector<int>> v;
				// n개 정적 벡터 : vector<int> v[n];

				// n개 정적 벡터 + 0으로 초기화 : vector<int> v(n);
				// n개 정적 벡터 + m으로 초기화 : vector<int> v(n, m);
				// 동적 벡터 + 초기화 : vector<int> v = {1, 2, 3};
				// 열만 정적 벡터 + 초기화 : vector<int> v[] = {{1, 2}, {3, 4}};
			// (3) 벡터 복사
				// 벡터v 복사하여 벡터v2 생성 : vector<int> v2(v);
			// (3) 벡터값 추가
				// 마지막 위치에 벡터값 추가 : v.push_back(value);
				// index 위치에 벡터값 추가 : v.begin() = v.insert(v.begin()+index, value);
				// index 위치에 벡터값 n번 추가 : v.begin() = v.insert(v.begin()+index, n, value);

				// - 중간값 추가시 인덱스가 뒤로 밀리면서 자동정렬
			// (3) 벡터값 삭제
				// 마지막 위치 벡터값 삭제 : v.pop_back();
				// index 위치 벡터값 삭제 : v.erase(v.begin()+index);
				// index 범위 벡터값 삭제 : v.erase(v.begin(), v.begin()+index);
				// 모든 위치 벡터값 삭제 : v.clear();

				// - 중간값 삭제시 인덱스가 앞으로 당겨지면서 자동정렬
			// (4) 벡터 크기 출력
				// 벡터 원소 개수 : v.size();
				// 벡터 할당공간 크기 : v.capacity();
			// (4) 벡터값 출력
				// 모든 벡터값 출력
				// for (int i = 0; i < v.size(); i++)
					// cout << v[i] << " ";
				// index값 출력 : cout << v[index] << endl;
				// 처음값 출력 : cout << v.front() << endl;
				// 마지막값 출력 : cout << v.back() << endl;
	// 2. Sort
		// 1) 개념 : 퀵정렬(힙 정렬 + 삽입 정렬)
			// (1) 벡터 구조
				// front() : 첫번째 원소
				// back() : 마지막 원소
				// begin() : 첫번째 위치
				// end() : 마지막의 다음 위치
				// size() : 원소 개수
				// capacity() : 할당 공간 크기
		// 2) 특징
			// - 퀵정렬 시간복잡도 : nlogn
			// - 버블정렬, 선택정렬, 삽입정렬 시간복잡도 : n^2
		// 3) 사용 순서
			// (1) 헤더파일 불러오기
				// #include <algorithm>
			// (2) 벡터 or 배열 생성
			// (3) index범위 오름차순 정렬
				// 배열 오름차순 정렬 : sort(v+index1, v+index2);
				// vector 오름차순 정렬 : sort(v.begin(), v.end());
				// vector 내림차순 정렬
					// bool desc(int a, int b) {
						// return a > b;
					// }
					// sort(v+index1, v+index2, desc);
	// 3. Stack
		// 1) 개념 : 후입선출(Last In First Out)
		// 2) 특징
			// - 개념 : 후입선출(LIFO)
			// - 활용 : 인터럽트처리, 수식 계산, 서브루틴의 복귀 번지 저장 등
				// 그래프 깊이 우선 탐색(DFS), 재귀적(Recursion)함수 호출 등
		// 3) 사용 순서
			// (1) 헤더파일 불러오기
				// #include <stack>
			// (2) 스택 생성
				// int형 스택 : stack<int> s;
				// char형 스택 : stack<char> s;
			// (3) 스택 스왑
				// 스택s1과 스택s2 스왑 : s1.swap(s2);
			// (3) 스택값 추가
				// 마지막 위치에 스택값 추가 : s.push(value);
			// (3) 스택값 삭제
				// 마지막 위치 스택값 삭제 : s.pop();
			// (4) 스택 크기 출력
				// 스택 원소 개수 : s.size();
				// 스택 원소유무 : s.empty();
			// (4) 벡터값 출력
				// 마지막값 출력 : s.top();
	// 4. Queue
		// 1) 개념 : 선입선출(First In First Out) 배열
			// (1) Queue 구조
				// Enqueue : 큐 맨 뒤 데이터 추가
				// Dequeue : 큐 맨 앞 데이터 삭제
		// 2) 특징
			// - 개념 : 선입선출(FIFO)
			// - 프론트(front) : 큐 한쪽 끝에서 삭제 연산 수행
			// - 리어(rear) : 큐 다른 한쪽 끝에서 삽입 연산 수행
			// - 활용 : 그래프 넓이 우선 탐색(BFS), 컴퓨터 버퍼
		// 3) 사용 순서
			// (1) 헤더파일 불러오기
				// #include <queue>
			// (2) 큐 생성
				// int형 스택 : queue<int> s;
				// char형 스택 : queue<char> s;
			// (3) 큐값 추가
				// Enqueue : q.push(value);
			// (3) 큐값 삭제
				// Dequeue : q.pop();
			// (4) 큐 크기 출력
				// 큐 원소 개수 : q.size();
				// 큐 원소유무 : q.empty();
			// (4) 큐값 출력
				// 처음값 출력 : q.front()
				// 마지막값 출력 : q.back();
// 동적할당 delete 공부해보기
