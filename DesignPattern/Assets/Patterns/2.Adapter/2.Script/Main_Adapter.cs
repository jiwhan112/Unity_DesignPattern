using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Adapter : MonoBehaviour {

    // 호출하는 MAIN부분이라 가정
    void Start()
    {
        Adapter_Float floatAdapter = new Adapter_Float();
        Adapter_Int intAdapter = new Adapter_Int();

        Debug.Log(floatAdapter.HalfOf(25.0f));
        Debug.Log(intAdapter.HalfOf(25.0f));
    }

}
