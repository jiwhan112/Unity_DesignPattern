using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 메멘토 패턴은 특정 상태였다가 되돌리는 기능을 가진 패턴
 * 기능 취소 롤백 기능
 */
/// 예제) 버프상태였다가 되돌리기
/// 

public struct BufType
{
    public float STR;
    public float INT;
    public float LUCK;
}
public class Monster
{
    string Name;
    float Damage;
    BufType Buf;
    public Monster Monster_(string name)
    {
        this.Name = name;
        return this;
    }
    public Monster Monster_(float STR, float INT, float LUCK)
    {
        this.Buf.STR = STR;
        this.Buf.INT = INT;
        this.Buf.LUCK = LUCK;
        return this;
    }
   
    public float ReturnDamage()
    {
        return (Buf.STR + Buf.INT) * Buf.LUCK;
    }


    public Memento CreateMemento()
    {
        Memento m = new Memento();
        m.SetState(Buf);
        return m;
    }
    public void SetMemento(Memento m)
    {
        Buf = m.GetState();
    }
    public void BufUp(float per)
    {
        float Val;
        Val = Buf.STR * per*0.01f;
        Buf.STR += Val;
        Val = Buf.INT * per * 0.01f; ;
        Buf.INT += Val;
        Val = Buf.LUCK * per * 0.01f; ;
        Buf.LUCK += Val;
    }
}

public class Memento
{
    BufType buf;
    public BufType GetState()
    {
        return buf;
    }
    public void SetState(BufType b)
    {
        this.buf = b;
    }

}


