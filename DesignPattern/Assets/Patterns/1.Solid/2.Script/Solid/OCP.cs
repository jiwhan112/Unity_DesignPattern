using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 개방 폐쇄이 원칙
// 확장에는 열려있고 변경에는 닫혀있어야한다.
// 재사용성이 용이해야함 추상화 개념이 중요하다.

// 적용법
// 확장될 것과 그렇지 않을 것을 구분
// 이 두 모듈이 만나는 지점에 인터페이스를 정의한다.
// 구현에 의존하기보다 정의한 인터페이스에 의존하도록 코드를 작성한다.

 
// 주의사항 인터페이스는 가능하면 변경 X
// 인터페이스를 정의할 때 여러 경우의 수에 대한 예측이 필요
// 추상화 중시 행위에 대한 본질적인 정의를 통해 인터페이스를 식별

public abstract class Beverage
{
    protected string sName;
    protected int iNumber;
    protected Beverage_Spec spec;

    protected Beverage(int iNumber)
    {
        SetsName();
        SetBeverage_Spec();
        this.iNumber = iNumber;
    }
    protected abstract void SetsName();
    protected abstract void SetBeverage_Spec();

    public override string ToString()
    {
        string s1 = "Name:" + sName + "\n";
        string s2 = "Number:" + iNumber + "\n";
        return s1 + s2 + spec.ToString();
    }

    //출력


}
public abstract class Beverage_Spec
{
    protected float fSugar;
    protected float fWater;
    protected float fPSrice;
    protected string DebugString;

    protected Beverage_Spec()
    {
        SetfSugar();
        SetsWater();
        SetsPrice();
    }
    protected abstract Beverage_Spec SetfSugar();
    protected abstract Beverage_Spec SetsWater();
    protected abstract Beverage_Spec SetsPrice();

    //출력
    public override string ToString()
    {
        string s1 = "Sugar:" + fSugar;
        string s2 = "Water:" + fWater;
        string s3 = "Price:" + fPSrice;
        DebugString = s1 + "\n" + s2 + "\n" + s3 + "\n";
        return DebugString;
    }
}


public class Water : Beverage
{
    public Water(int iNumber) : base(iNumber)
    {
    }

    protected override void SetBeverage_Spec()
    {
        spec = new Water_Spec();
    }

    protected override void SetsName()
    {
        sName = "Water";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
public class Coffee : Beverage
{
    public Coffee(int iNumber) : base(iNumber)
    {
    }

    protected override void SetBeverage_Spec()
    {
        spec = new Coffee_Spec();
    }

    protected override void SetsName()
    {
        sName = "Coffee";
    }

    public override string ToString()
    {

        return base.ToString();
    }
}

public class Water_Spec : Beverage_Spec
{
    public Water_Spec()
    {
    }

    // 추가적으로 들어가는 것이 없음

    protected override Beverage_Spec SetfSugar()
    {
        fSugar = 0;
        return this;
    }

    protected override Beverage_Spec SetsPrice()
    {
        fPSrice = 500;
        return this;

    }

    protected override Beverage_Spec SetsWater()
    {
        fWater = 100;
        return this;


    }
}

//확장
public class Coffee_Spec : Beverage_Spec
{

    // 프림을 추가 구현
    protected float fPrim;

    public Coffee_Spec()
    {
        SetPrim();
    }

    protected override Beverage_Spec SetfSugar()
    {
        fSugar = 50;
        return this;
    }

    protected override Beverage_Spec SetsPrice()
    {
        fPSrice = 1000;
        return this;

    }

    protected override Beverage_Spec SetsWater()
    {
        fWater = 70;
        return this;
    }

    protected virtual Beverage_Spec SetPrim()
    {
        fPrim = 50;
        return this;
    }

    public override string ToString()
    {

        string s1 = "Prim:" + fPrim;
        DebugString = base.ToString();
        DebugString += s1;
        return DebugString;
    }
}


