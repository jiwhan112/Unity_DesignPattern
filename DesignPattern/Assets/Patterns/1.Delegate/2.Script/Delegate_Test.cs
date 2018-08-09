using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Delegate_Test : MonoBehaviour {

    // 함수포인터 메서드를 호출시 Delegate로 선언한 타입이 매서드를 가리키기때문에 
    // 메서드를 직접호출하는 것 대신에 delegate로 매서드 호출 가능
    // 콜백 메서드 구현시 효과적

    public delegate T Cal<T>(T x,T y);
    public delegate void CallMessage();
    public static T Calcuator<T>(T x, T y, Cal<T> a)
    {
       return a(x,y);
    }

    int Plus(int x, int y) { return x + y; }
    float Plus(float x, float y) { return x + y; }
    double Plus(double x, double y) { return x + y; }

    void Message_1() { Debug.Log("1111"); }
    void Message_2() { Debug.Log("2222"); }
    void Message_3() { Debug.Log("3333"); }
    void Message_4() { Debug.Log("4444"); }

    private void Start()
    {
        // 일반화
        Cal<int> pluse_int = new Cal<int>(Plus);
        Cal<float> pluse_float = new Cal<float>(Plus);
        Cal<double> pluse_double = new Cal<double>(Plus);

        Debug.Log(Calcuator(1,2, pluse_int));
        Debug.Log(Calcuator(1.0f, 2.0f, pluse_float));

        //체인
        CallMessage dele = new CallMessage(Message_1);
        dele += Message_2;
        dele += Message_3;
        dele += Message_4;
        dele();
        dele -= Message_2;
        dele -= Message_3;
        dele += Message_4;
        dele();
    }

}
