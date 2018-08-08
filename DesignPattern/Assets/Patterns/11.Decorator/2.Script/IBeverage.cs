using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBeverage
{
    int GetTotalPrice(); // 가격을 물음

}

public class Base_Obj : IBeverage // 오브젝트 베이스에 이렇게 상속해 놓는다
{
    public virtual int GetTotalPrice()
    {
        return 0;
    }
}
public class Adding_Obj : Base_Obj //추가되는 오브젝트설계
{
    IBeverage Ibase;
    public Adding_Obj(IBeverage Ibase)
    {
       
        this.Ibase = Ibase;
    }
     public override int GetTotalPrice()
    {
        return Ibase.GetTotalPrice();
    }
 
}
public class Milk : Adding_Obj
{
    public Milk(IBeverage Ibase) : base(Ibase)
    {

    }
    public override int GetTotalPrice() //추가부분 단순구현
    {
        return base.GetTotalPrice()+50;
    }
}

public class Espresso : Adding_Obj
{
    static int espressoCount = 0;
    public Espresso(IBeverage Ibase) : base(Ibase)
    {
    }
    public override int GetTotalPrice() // 추가부분 확장 구현
    {
        return base.GetTotalPrice()+GetAddPrice();
    }
    public static int GetAddPrice() 
    {
        espressoCount++;
        int price = 100;
        if (espressoCount > 1)
            price = 70;
        return price;

    }

}
