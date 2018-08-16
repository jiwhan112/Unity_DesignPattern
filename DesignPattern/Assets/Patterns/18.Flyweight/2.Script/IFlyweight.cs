using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyweight  {
    string Data;

    public Flyweight(string Data)
    {
        this.Data = Data;
    }
    public string GetData()
    {
        return Data;
    }
	
}

public class FlyweightFactory
{
    Dictionary<string, Flyweight> pool;
    public FlyweightFactory()
    {
        pool = new Dictionary<string, Flyweight>();
    }
    public Flyweight GetFlyweight(string Key)
    {
        Flyweight f = null;
        pool.TryGetValue(Key,out f);
        if (f == null)
        {
            Debug.Log("새로 생성");
            f = new Flyweight(Key);
            pool.Add(Key, f);
        }
        else
            Debug.Log("제사용");

        return f;
    }

}
