using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CONEnemy : CONCharacter, IMoveManagement
{
    public int curHp;

    public int maxHp;

    public int CurrentDestIdx => throw new System.NotImplementedException();

    public float DefaultSpeed => throw new System.NotImplementedException();

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
        if(curHp <= 0)
        {
            MGActiveEnemy.Instance.Remove(this.gameObject);
        }
    }

    public float HpPercent()
    {
        return (float)curHp  / (float)maxHp;
    }

    public float GetRemainDistance()
    {
        return Vector2.Distance(this.transform.position, MGScene.Instance.towerTrm.position);
    }

    public void SetSpeed(float multipy, float duration)
    {
        throw new System.NotImplementedException();
    }
}
