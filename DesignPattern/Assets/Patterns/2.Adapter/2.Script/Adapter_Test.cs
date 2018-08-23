using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  다른 라이브러리 함수를 어뎁터라는 클래스에 넣고 사용가능하게 해줌
public class Adapter_Float :IAdapter_Math_Float {
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

   
	
}

public class Adapter_Int : IAdapter_Math_Int
{
    // 인터페이스부분
    public int HalfOf(float f)
    {
        Debug.Log(f + "를 절반으로"); // 본래기능에 디버그를 해주는 부분 추가
        return (int)MyMath.HalfOf((double)f);
    }

    public List<int> ListSorting(List<int> list)
    {
        //여러가지 처리
        // 후에 리턴 
        // 알고리즘이 많이 바껴서 사용할때는 이렇게 사용 한다.
        return MyMath.Sorting(list);
    }

    public int TwiceOf(float f)
    {
        return (int)MyMath.TwiceOf((double)f);
    }



}
