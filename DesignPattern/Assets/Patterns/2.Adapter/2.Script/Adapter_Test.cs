using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adapter_Test : MonoBehaviour , IAdapter_Math {
    // 인터페이스부분
    public float HalfOf(float f)
    {
        Debug.Log(f+"를 절반으로"); // 본래기능에 디버그를 해주는 부분 추가
        return (float)MyMath.HalfOf((double)f);
    }

    public List<int> ListSorting(List<int> list)
    {
        //여러가지 처리
        // 후에 리턴 
        // 알고리즘이 많이 바껴서 사용할때는 이렇게 사용 한다.
        return MyMath.Sorting(list);
    }

    public float TwiceOf(float f)
    {
       return (float)MyMath.TwiceOf((double)f);
    }

    // Adapter_Test 호출하는 MAIN부분이라 가정
    void Start () {
        Debug.Log(HalfOf(100.0f));
        Debug.Log(TwiceOf(100.0f));

    }
	
}
