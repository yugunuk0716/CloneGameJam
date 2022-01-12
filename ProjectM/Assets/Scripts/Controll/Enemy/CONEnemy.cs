using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CONEnemy : CONCharacter
{
    public int curHp;

    public int maxHp;


    public override void Awake()
    {
        base.Awake();
    }

    public override void Start()
    {
        base.Start();
    }

    public override void OnEnable()
    {
        base.OnEnable();
        curHp = maxHp;
    }

    public override void OnDisable()
    {
        base.OnDisable();
    }


    public override void LateUpdate()
    {
        base.LateUpdate();
    }

    public void OnDamaged(int damage)
    {
        curHp -= damage;
    }

    public float HpPercent()
    {
        return (float)curHp  / (float)maxHp;
    }
}
