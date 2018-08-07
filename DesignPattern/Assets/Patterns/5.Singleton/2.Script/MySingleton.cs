using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton  {

    static private MySingleton I;
    public int Data;
    private MySingleton()
    {
        Data = 0;
    }
    public void PlusData()
    {
        Data++;
    }
    public void MinData()
    {
        Data--;
        if (Data < 0) Data = 0;
    }
    public static MySingleton GetInstance()
    {
        if (I == null)
        {
            I = new MySingleton();
            return I;
        }
        else
            return I;

    }
}
