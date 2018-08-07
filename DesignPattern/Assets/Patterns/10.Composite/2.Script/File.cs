using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class File : Component{ // 하나의 객체 하위탐색은 불가능

    Object data;

    public File(string s) : base(s)
    {

    }


    Object GetData()
    {
        return data;
    }
    void SetData(Object obj)
    {
        data = obj;
    }

}
