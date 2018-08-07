using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 복사할 클래스 구현
public class Object_Cube : MonoBehaviour, IProtoType
{
    public int x;
    public int y;
    public string ObjName;
    GameObject parentobj; // 동적할당이 필요한 메모리는 재할당해서 다시 할당 해줘야한다.
    public void Init(int x, int y, string ObjName , GameObject parent)
    {
        this.x = x;
        this.y = y;
        this.ObjName = ObjName;
        name = ObjName +"_"+ GetHashCode();
        SetParentObj(parent);
    }
    public void SetParentObj(GameObject parent)
    {
        parentobj = parent;
        transform.SetParent(parentobj.transform);
    }

    public Object CopyInterface()
    {
        GameObject gg = new GameObject();
        Object_Cube script = gg.AddComponent<Object_Cube>(); // 깊은/얕은복사 차이점
        script.Init(x,y,ObjName, parentobj);
        return gg;
    }
}
