using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MyMath클래스
public class MyMath {
    public static double TwiceOf(double t)
    {
        return t * 2;
    }
    public static double HalfOf(double t)
    {
        return t / 2;
    }
    public static List<int> Sorting(List<int> t)
    {
        t.Sort();
        return t;
    }
}
