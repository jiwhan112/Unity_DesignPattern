using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Light의 On Off 상태를 인터페이스로 구현
// 각 상태는 메모리 낭비를 최소화 하기 위해 객체를 새로 생성하지 않고 싱글턴으로 운용함

public interface ILightState
{
    void Enter();
    void Update();
    void EXit();
}
public class Light
{
    ILightState CurrentState;

    public void Update()
    {
        CurrentState.Update();
    }
    public void SetStateOn() //켜지는 메소드 함수
    {
        if (CurrentState != null)
            CurrentState.EXit();
        CurrentState = LightState_ON.GetInstance();
        CurrentState.Enter();
    }
    public void SetStateOff() // 꺼지는 메소드 함수
    {
        if (CurrentState != null)
            CurrentState.EXit();
        CurrentState = LightState_OFF.GetInstance();
        CurrentState.Enter();
    }

   

}
public class LightState_ON : ILightState
{
  
    private LightState_ON()
    {
    }
    public void Enter()
    {
        Debug.Log("켜짐상태");
    }

    public void EXit()
    {
    }

    public void Update()
    {

        Debug.Log("켜짐");
    }


    static private LightState_ON I;
    public static LightState_ON GetInstance()
    {
        if (I == null)
        {
            I = new LightState_ON();
            return I;
        }
        else
            return I;

    }
}
public class LightState_OFF : ILightState
{
    public void Enter()
    {
        Debug.Log("꺼짐상태");
    }

    public void EXit()
    {
    }

    public void Update()
    {
        Debug.Log("꺼짐");
    }

    static private LightState_OFF I;
    public static LightState_OFF GetInstance()
    {
        if (I == null)
        {
            I = new LightState_OFF();
            return I;
        }
        else
            return I;

    }
}


