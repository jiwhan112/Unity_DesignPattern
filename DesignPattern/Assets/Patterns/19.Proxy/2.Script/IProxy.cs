using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public interface ISubjectByProxy
{
    void Action1(); // 1번일
    void Action2(); // 2번일

}
public class Proxy : ISubjectByProxy
{
    ISubjectByProxy real;
    public Proxy(ISubjectByProxy real)
    {
        this.real = real;
    }
    public void Action1()
    {
        Debug.Log("간단한 일 by proxy");
    }

    public void Action2()
    {
        real.Action2();
    }
}

internal class RealSubject : ISubjectByProxy
{
    public void Action1()
    {
        Debug.Log("간단한 일 by Real");
    }

    public void Action2()
    {
        Debug.Log("복잡한 일 by Real");
    }
}