using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class AB_Weapon
{
    string StrName;
    float fDamage;
    public float fRange;

    protected AB_Weapon(string strName, float fDamage, float fRange)
    {
        StrName = strName;
        this.fDamage = fDamage;
        this.fRange = fRange;
    }
    abstract public void Attack();
    abstract public void SHILD();

    public string NAME()
    {
        return StrName;
    }

}
interface IATTACKWAY
{
    void ATTACKWAY(float s);

}


public class Knife : AB_Weapon
{
    IATTACKWAY way;
    public Knife() : base("Knife", 20, 10)
    {
        way = new MELEEATTACK();
    }

    public override void Attack()
    {
        way.ATTACKWAY(fRange);
    }
    public override void SHILD()
    {
        Debug.Log(NAME() + "방어");
    }

 
}
public class AX : AB_Weapon
{
    IATTACKWAY way;
    public AX() : base("AX", 20, 10)
    {
        way = new DISATTACK();
    }

    public override void Attack()
    {
        way.ATTACKWAY(fRange);
    }
    public override void SHILD()
    {
        Debug.Log(NAME() + "방어");
    }


}

public class ARROW : AB_Weapon
{

    public ARROW() : base("ARROW", 20, 10)
    { }

    public override void Attack()
    {
        Debug.Log(NAME() + "원거리공격");
    }
    public override void SHILD()
    {
        Debug.Log(NAME() + "방어");
    }


}

public class MELEEATTACK : IATTACKWAY
{
    public void ATTACKWAY(float s)
    {
        // 무기의 범위를 알고싶음
        Debug.Log(s.ToString() + "근접공격");
    }
}
public class DISATTACK : IATTACKWAY
{
    public void ATTACKWAY(float s)
    {
        // 무기의 범위를 알고싶음
        Debug.Log(s.ToString() + "원거리공격");
    }
}



//interface IWeapon
//{
//    string WeaponName();
//    void Attack();
//    float Damage();
//    float AttackSpeed();    
//}

//public class Knife : IWeapon
//{
//    public void Attack()
//    {
//        Debug.Log(WeaponName() + "이 " + Damage().ToString() + "공격력으로 공격합니다." + "공격속도는" + AttackSpeed() + "입니다.");
//    }

//    public float AttackSpeed()
//    {
//        return 1.0f;
//    }

//    public float Damage()
//    {
//        return 10.0f;
//    }

//    public string WeaponName()
//    {
//        return "Knife";
//    }
//}
//public class AX : IWeapon
//{
//    public void Attack()
//    {
//        Debug.Log(WeaponName() + "이 " + Damage().ToString() + "공격력으로 공격합니다." + "공격속도는" + AttackSpeed() + "입니다.");
//    }

//    public float AttackSpeed()
//    {
//        return 2.0f;
//    }

//    public float Damage()
//    {
//        return 20;
//    }

//    public string WeaponName()
//    {
//        return "AX";
//    }
//}
