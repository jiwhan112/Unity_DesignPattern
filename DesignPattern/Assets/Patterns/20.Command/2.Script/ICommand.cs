using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

// 명령의 객체화
// 명령을 객체화해서 우선순위나 여러가지 형태로 만들 수 있음
// 대기명령 / 명령에서 명령으로 넘김 / 순서대로 명령 실행 등등


public interface ICommand : IComparable<ICommand>
{
    void Excute();
}

public class StringPrintCommand : ICommand // 우선순위에따라 명령 실행
{
    public string CommandString;
    public StringPrintCommand(string str)
    {
        CommandString = str;
    }
    public int CompareTo(ICommand other)
    {
       return  CommandString.Length - ((StringPrintCommand)other).CommandString.Length;
    }

    public void Excute()
    {
        Debug.Log(CommandString);
    }
}
