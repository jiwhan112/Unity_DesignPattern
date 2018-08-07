using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCharactor : MonoBehaviour { // 게임캐릭터
    
    //접근점
    IWeapon weapon; //  무기 인터페이스에서 동일한 인터페이스를 활용한 클래스를 상속받아 해당 함수를 실행하면 똑같이 바꿔 사용할 수 있다.


    // 교환 가능한 인터페이스
    void SetWeapon(IWeapon iw)
    {
        weapon = iw;
    }

    private void Start()
    {
        Attack();
        Knife knife = new Knife();
        AX ax = new AX();
        SetWeapon(knife);
        Attack();
        SetWeapon(ax);
        Attack();

    }

    void Attack()
    {
        // 델리게이트
        if (weapon == null)
        {
            Debug.Log("맨손공격");
        }
        else
            weapon.Attack();
    }
}
