using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONHeroMan : CONHero
{
    public int skillDamage = 10;

    // 히어로 개별 유닛이 가지는 특성 구현

    public void Skill()
    {
        MGActiveEnemy.Instance.ControlAllEnemy((e) => {
            e.GetComponent<CONEnemy>().OnDamaged(skillDamage);
        });
    }
}
