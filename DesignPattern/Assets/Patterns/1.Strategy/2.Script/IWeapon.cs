using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IWeapon
{
    string WeaponName();
    void Attack();
    float Damage();
    float AttackSpeed();
    
}

public class Knife : IWeapon
{
    public void Attack()
    {
        Debug.Log(WeaponName() + "이 " + Damage().ToString() + "공격력으로 공격합니다." + "공격속도는" + AttackSpeed() + "입니다.");
    }

    public float AttackSpeed()
    {
        return 1.0f;
    }

    public float Damage()
    {
        return 10.0f;
    }

    public string WeaponName()
    {
        return "Knife";
    }
}
public class AX : IWeapon
{
    public void Attack()
    {
        Debug.Log(WeaponName() + "이 " + Damage().ToString() + "공격력으로 공격합니다." + "공격속도는" + AttackSpeed() + "입니다.");
    }

    public float AttackSpeed()
    {
        return 2.0f;
    }

    public float Damage()
    {
        return 20;
    }

    public string WeaponName()
    {
        return "AX";
    }
}
