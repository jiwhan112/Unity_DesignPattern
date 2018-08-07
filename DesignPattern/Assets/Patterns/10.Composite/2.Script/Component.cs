using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component // 하위탐색이 가능한 하나의 객체
{

    string name;
    public Component(string name) { this.name = name; }
    public string GetName()
    {
        return name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }

}

public class Folder : Component
{
    public Folder(string s) : base(s) { }
    List<Component> children = new List<Component>();
    

    public bool AddComponent(Component com)
    {
        children.Add(com);
        return true;
    }
    public bool RemoveComponent(Component com)
    {
        return children.Remove(com);
    }
    public List<Component>  GetChildren()
    {
        return children;
    }


}