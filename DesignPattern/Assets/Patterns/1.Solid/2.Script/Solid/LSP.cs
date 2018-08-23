using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//리스코브 치환의 원칙
// 서브타입은 언제나 기반타입과 호환될수 있어야 한다.

// 적용 방법
// 두개 이상의 객체가 같은 일을 한다면 둘을 하나의 클래스로 표현하고 이들을 구분할 수 있는 필드를 둔다.
// 똑같은 연산을 제공하지만 이들을 약간씩 다르게 사용하고자 한다면 공통의 인터페이스를 만들고 이를 구현해야한다. 인터페이스 상속
// 공통 연산이 없을 경우 별개의 클래스 두개를 만든다.
// 만약 두 개체가 하는 일에 추가적으로 무언가를 더 한다면 구현 상속을 사용합니다.


// 적용 이슈
// 상속 구조가 필요하다면 Extract Subclass, Push Down Field, Push Down Method 등의 리펙토링 기법을 활용해 LSP를 준수하는 구조를 구성한다.
// 키워드는 공통된 연산(기능)을 묶는 것이다.
// Design by Contract(“서브 클래스에서는 기반 클래스의 사전 조건과 같거나 더 약한 수준에서 사전 조건을 대체할 수 있고, 기반 클래스의 사후 조건과 같거나 
// 더 강한 수준에서 사후 조건을 대체할 수 있다.”)적용: 기반 클래스를 서브 클래스로 치환 가능하게 하려면 받아들이는 선 조건에서 서브 클래스의 제약사항이 기반 클래스의 제약 사항보다 느슨하거나 같아야 합니다. 
// 만약 제약조건이 더 강하다면 기반 클래스에서 실행되던 것이 서브 클래스의 강 조건으로 인해 실행되지 않을 수도 있기 때문입니다. 반면 서브 클래스의 후 조건은 같거나 더 강해야 하는데, 
// 약하다면 기반 클래스의 후 조건이 통과시키지 않는 상태를 통과시킬 수도 있기 때문입니다.

public interface IEntity
{
    void ATTACK();
    void SHILD();
    void MOVE();
}

public class Entity_Charactor : IEntity
{
    public void ATTACK()
    {
        Debug.Log("캐릭터 공격");
    }

    public void MOVE()
    {
        Debug.Log("캐릭터 이동");
    }

    public void SHILD()
    {
        Debug.Log("캐릭터 실드");
    }
}

public class Entity_MyMonster : IEntity
{
    public void ATTACK()
    {
        Debug.Log("몬스터 공격");
    }

    public void MOVE()
    {
        Debug.Log("몬스터 이동");
    }

    public void SHILD()
    {
        Debug.Log("몬스터 실드");
    }
}

public abstract class Entity
{
    protected IEntity entity;
    public Entity()
    {
        SetEntity();
    }
    protected abstract void SetEntity();

    public void Attack()
    {
        entity.ATTACK();
    }
    public void MOVE()
    {
        entity.MOVE();
    }
    public void SHILD()
    {
        entity.SHILD();
    }


}
public class Charactor : Entity
{
    protected override void SetEntity()
    {
        entity = new Entity_Charactor();
    }
}

public class MyMonster: Entity
{
    protected override void SetEntity()
    {
        entity = new Entity_MyMonster();

    }
}

