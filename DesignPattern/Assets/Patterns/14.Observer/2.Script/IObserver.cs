using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  옵저버를 연결해 두었다가 특정 행동을 하면 호출되게 하는 패턴
///  
/// </summary>
public interface IOnclickListener
{
    void Add(IOberver o); // 추가
    void Remove(IOberver o ); //삭제
    void Notice(); // 알리기
}
public interface IOberver
{
    void Call();
}


public class Subject : IOnclickListener // 옵저버들을 관리해줌
{
    List<IOberver> obList;
   public Subject()
    {
        obList = new List<IOberver>();
    }
    public void Add(IOberver o)
    {
        Debug.Log("추가");
        obList.Add(o);
        // 추가됨
        Notice();
    }

    public void Notice() // 변화가 있으면 호출
    {
        for (int i = 0; i < obList.Count; i++)
        {
            obList[i].Call();
        }
    }

    public void Remove(IOberver o)
    {
        Debug.Log("삭제");
        obList.Remove(o);
        Notice();
    }
}

public class Oberver : IOberver // 각각의 옵저버객체
{
    string Name;
    public Oberver()
    {
        Name = GetHashCode().ToString();
    }
    public void Call()
    {
        Debug.Log("Oberver");
    }
}
public class Oberver2 : IOberver // 각각의 옵저버객체
{
    string Name;
    int age;
    float height;
    public Oberver2(int age, float height)
    {
        Name = GetHashCode().ToString();
        this.age = age;
        this.height = height;
    }
    public void Call()
    {
        Debug.Log("Oberver2 나이키" + age +"/"+ height );
    }
}
