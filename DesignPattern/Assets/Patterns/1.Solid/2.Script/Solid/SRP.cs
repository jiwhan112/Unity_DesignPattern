using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 단일 책임의 원칙
// 클래스는 하나의 기능만 가지며 클래스가 제공하는 모든 서비스는 그 하나의 책임을 수행하는 데 집중되어 있어야 한다는 원칙입니다.
// 클래스당 하나의 책임이 목적


    // 기타 객체를 구현할 때 SRP를 적용 안했을떄의 모습
public enum GuitarType { A, B, C };
//public  class Guitar
//{
//    string name;
//    string model;
//    int number;
//    float price;
//    float Length;
//    string user;
//    GuitarType type;

//    public Guitar(string name, string model, int number, float price, float length, string user, GuitarType type)
//    {
//        this.name = name;
//        this.model = model;
//        this.number = number;
//        this.price = price;
//        Length = length;
//        this.user = user;
//        this.type = type;
//    }

//    // 문제점 너무 많은 정보를 한번에 관리함 
//    // 관련있는 정보를 한곳에서 관리 할 필요가 있음
//}

public class Guitar
{  
    int number;
    string user;
    Guitar_Spec spec;

    public Guitar(int number, string user, Guitar_Spec spec)
    {
        this.number = number;
        this.user = user;
        this.spec = spec;
    }
    // SRP를 적용하여 관련있는 데이터는 따로 클래스를 만들어 빼놓음
}

public class Guitar_Spec
{
    string name;
    float price;
    float Length;
    GuitarType type;

    public Guitar_Spec(string name, float price, float length, GuitarType type)
    {
        this.name = name;
        this.price = price;
        Length = length;
        this.type = type;
    }
}




