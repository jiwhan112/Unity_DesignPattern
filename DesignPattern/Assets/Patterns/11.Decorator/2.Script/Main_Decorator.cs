using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Decorator : MonoBehaviour {


    private void Start()
    {
        // 가격을 각기 다른 방식으로 추가하고있음
        IBeverage price = new Base_Obj(); 

        Debug.Log(price.GetTotalPrice());
        price = new Milk(price);
        Debug.Log(price.GetTotalPrice());
        price = new Espresso(price);
        Debug.Log(price.GetTotalPrice());
        price = new Espresso(price);
        Debug.Log(price.GetTotalPrice());

    }
}
