using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인터페이스 분리 원칙

// 적용법
// 한클래스는 자신이 사용하지 않는 인터페이스는 구현하지 말아야한다는 원리
// 다른클래스에 종속 시 최소한의 인터페이스를 사용하도록한다.
// 어려개의 구체적인 인터페이스가 낫다.
// 인터페이스의 단일책임


// 동물을 만든다고 가정
//interface IAnimal // 동물에 필요한 인터페이스
//{
//    void EAT();
//    void BUY();
//    void FLY(); // 특정 객체 구현에 필요없음
//    void MOVE(); 
//}
interface IAnimal // 동물에 필요한 인터페이스
{
    void EAT();
    void MOVE();
}
interface IBird // 특정 동물에 필요
{
    void FLY(); 
}
interface ICry // 특정 동물에 필요
{
    void CRY(); //
}

// ISP의 개념부분만 구현 이름이나 세부구현은 하지 않았음
public class Dog : ICry, IAnimal
{
    public void CRY()
    {
        Debug.Log("멍멍");
    }

    public void EAT()
    {
        Debug.Log("먹음");
    }

    public void MOVE()
    {
        Debug.Log("이동");

    }
}
public class Bird : ICry, IBird, IAnimal
{
    public void CRY()
    {
        Debug.Log("삐약");

    }

    public void EAT()
    {
        Debug.Log("먹음");

    }

    public void FLY()
    {
        Debug.Log("날다");
    }

    public void MOVE()
    {
        Debug.Log("이동");
    }
}