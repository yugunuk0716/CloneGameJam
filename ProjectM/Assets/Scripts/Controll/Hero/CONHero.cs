using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONHero : CONCharacter
{
    // 히어로 고유의 스킬 구현 등
    public int damge;


    public override void OnAttack()
    {
        base.OnAttack();
        MGGame.Instance.enemyConList[Random.Range(0, MGGame.Instance.enemyConList.Count / 2)].OnDamaged(damge);

    }
}
