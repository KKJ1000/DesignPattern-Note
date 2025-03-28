# 디자인 패턴 기초, SOLID원칙

#### Gang of Four = GOF

SOLID 원칙
* **단일 책임 원칙** (Single Responsibility)
* **개방-폐쇄 원칙** (Open-Closed)
* **리스코프 치환 원칙** (Liskov Substitution)
* **인터페이스 분리 원칙** (Interface Segregation)
* **의존 역전 원칙** (Dependency Inversion)

### 1. 단일 책임 원칙
---
* 모든 클래스는 하나의 책임만 가진다. 
* 클래스는 그 책임을 완전히 캡슐화해야한다.
* 클래스가 제공하는 모든 기능은 이 책임과 부합

예시) Player 클래스에 입력, 움직임, 오디오를 구현하는 것이 아닌

Input, Movement, Audio 클래스로 나누어 구현.

가독성, 확장성, 재사용성이 뛰어나다.

### 2. 개방폐쇄 원칙
---
* 확장에 대해서 열려있어야 한다

  - 모듈이 동작을 확장할 수 있다는 것을 의미.
  - 요구사항이 변경될 때, 새로운 동작을 추가해 모듈을 확장.

* 수정에 대해서는 닫혀 있어야 한다.
  - 코드를 수정하지 않아도 모듈의 기능을 확장하거나 변경 가능.
  - 모듈의 라이브러리 (ex.DLL)의 수정이 필요 없음.

### 3. 리스코프 치환 원칙
---
* 파생클래스는 기본 클래스를 대체 할수 있어야함.
* 하위클래스를 강력하고 유연하게 만드는 원칙.
* OOP의 상속을 사용하면 하위 클래스를 통해 기능을 추가 할 수 있음.
  - 그러나, 주의하지 않으면 불필요한 복잡성이 발생.

* 서브클래싱 할 때 기능을 제거하는 경우 원칙이 위배된다.
* 추상화를 단순하게 유지.
* 하위 클래스에는 기본클래스의 퍼블릭 멤버 존재.
* 상속보다는 구성.
* 클래스 계층 구조를 설정하기 전에 클래스 API를 고려.
  - 현실의 분류가 항상 클래스 계층구조로 변환되는 것은 아님.
  - EX : Car와 Train이 별도의 상위 클래스에서 상속받는 것이 합리적.

### 4. 인터페이스 분리 원칙
---
* 클라이언트가 자신이 이용하지않는 메서드에 의존하지 않아야 한다는 원칙.
* 큰 덩어리의 인터페이스들을 구체적이고 작은 단위들로 분리.
  - 클라이언트들이 꼭 필요한 메서드들만 이용 할 수 있게함.
* 시스템의 내부 의존성을 약화하고 유연성을 강화.

### 5. 의존 역전 원칙
---
* 소프트웨어 모듈들을 분리하는 특정 형식
* 상위 모듈은 하위 모듈의 것을 직접 가져오면 안된다.
  - 둘다 추상화에 의존해야함.
* 추상화는 세부사항에 의존해서는 안됨.
  - 세부사항이 추상화에 의존해야함.
* 클래스가 다른 클래스와 관계가 있으면 안됨
  - 클래스가 다른 클래스의 작동 방식을 많이 알고있으면 안됨
  - 종속성 또는 결합 발생
  - 종속성은 어느 잠재적인 위험

  
|Abstract Class|Interface|
|:--|:--|
|메서드를 완전히 또는 일부 구현|메서드를 선언만 가능, 구현은 불가|
|변수 및 필드 선언/사용|메서드와 프로퍼티 선언만 가능 (필드는 제외)|
|스태틱 멤버 가능|스태틱 멤버 불가|
|생성자 사용 가능|생성자 사용 불가|
|모든 액세스 한정자 가능 protected, private, etc.| 모든 멤버는 public으로 취급|     