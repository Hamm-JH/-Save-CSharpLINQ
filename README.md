# CSharpLINQ
> ####  LINQ reference code 
>
> ####  .NET은 특정 형식에 없던 기능을 추가하는 개념으로 확장 메서드(extension method)를 제공한다. C# LINQ에서 제공하는 확장 메서드를 사용해보자.



### 확장 메서드 사용하기

> #### .NET에서 확장 메서드를 사용하려면 System.Linq 네임스페이스를 선언해야 한다.
>
> #### 다음의 확장 메서드를 사용하여 숫자 배열 또는 컬렉션에서 원하는 값을 구할수 있다.

- #### Sum()	: 숫자 배열 또는 컬렉션의 합

- #### Count() : 숫자 배열 또는 컬렉션의 건수

- #### Average() : 숫자 배열 또는 컬렉션의 평균

- #### Max() : 최대값

- #### Min() : 최소값



### Sum() 메서드로 배열의 합 구하기

> #### 정수 배열 또는 컬렉션에 들어 있는 데이터의 전체 합을 LINQ.Sum() 메서드를 사용해 구한다.

- #### Sum()

![Sum](mdFiles/Images/Sum/SumCode.PNG)

![SumImg](mdFiles/Images/Sum/SumImg.PNG)



### Count() 메서드로 배열의 개수 구하기

> #### Count() 확장 메서드로 정수 배열의 개수를 구한다.

- #### Count()

![Count](mdFiles/Images/Count/CountCode.PNG)

![Img](mdFiles/Images/Count/CountImg.PNG)



### 