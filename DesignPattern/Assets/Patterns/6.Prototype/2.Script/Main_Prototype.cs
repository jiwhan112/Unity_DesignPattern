using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Prototype : MonoBehaviour
{
    private void Start()
    {
        GameObject ss = new GameObject();
        ss.AddComponent<Object_Cube>();
        ss.GetComponent<Object_Cube>().Init(1, 1, "ss", gameObject);
        ss.GetComponent<Object_Cube>().CopyInterface();
        ss.GetComponent<Object_Cube>().CopyInterface();
        ss.GetComponent<Object_Cube>().CopyInterface();

    }
}
