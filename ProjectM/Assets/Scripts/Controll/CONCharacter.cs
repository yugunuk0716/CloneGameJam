using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONCharacter : CONEntity
{
    // 캐릭터가 가지고 있는 고유 스탯 선언
    // FSM, Detect 기능 등
    // 고유 캐릭터 스탯 데이터
    // 애니메이션 정보

    public float attackDelay;
    public float timer;


    public override void Awake()
    {
        base.Awake();
    }

    public override void OnEnable()
    {
        base.OnEnable();
    }

    public override void OnDisable()
    {
        base.OnDisable();
    }

    protected override void cleanUpOnDisable()
    {

    }

    protected override void firstUpdate()
    {
        base.firstUpdate();
    }

    public override void Update()
    {
        base.Update();
        

        Attack();


    }

    public override void Attack()
    {
        
        if(MGGame.Instance != null)
        {
            if (MGGame.Instance.enemyConList.Count > 0 && timer > attackDelay)
            {
                timer = 0;
                OnAttack();
            }
            else
            {
                timer += Time.deltaTime * MGTimeScale.Instance.TimeScale;
            }
            base.Attack();
        }
    }

    /// <summary>
    /// 공격 시 호출됨
    /// </summary>
    public virtual void OnAttack() { print("공격!"); }
}
