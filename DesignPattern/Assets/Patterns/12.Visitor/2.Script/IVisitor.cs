using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 방문하는 객체와 
// 방문을 허락하는 객체

public interface IVisitor // 기능상속
{
    void Vistor(IVisitable visitable);
}
public interface IVisitable //객체상속
{
    void Appect(IVisitor visit);
}
public class VisitorA : IVisitor //기능분리 age를 더해줌
{
    public int ageSum = 0;
    public VisitorA()
    {
         ageSum = 0;
    }
    public void Vistor(IVisitable visitable)
    {
        if(visitable is VisitorableA) // A 메소드가 방문하면 해주는 일
        {
            ageSum+=((VisitorableA)visitable).Age; // 방문하면 더함
        }
    }
}
public class VisitorB : IVisitor //기능분리 age를 더해줌
{
    public int totalEXP = 0;
    public VisitorB()
    {
        totalEXP = 0;
    }
    public void Vistor(IVisitable visitable)
    {
        if (visitable is VisitorableA) // A 메소드가 방문하면 해주는 일
        {
            totalEXP += ((VisitorableA)visitable).EXP1; // 방문하면 더함
        }
    }
}


public class VisitorableA : IVisitable
{
    int age;
    int EXP;
    public VisitorableA(int age,int exp)
    {
        Age = age;
        EXP = exp;
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }

    public int EXP1
    {
        get
        {
            return EXP;
        }

        set
        {
            EXP = value;
        }
    }

    public void Appect(IVisitor visit) // 자기자신을 연결해줌 조건은 따로 추가시킬 수 있음
    {
        visit.Vistor(this);
    }
    
}