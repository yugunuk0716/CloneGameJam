using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONHeroMan : CONHero
{
    public int skillDamage = 10;
    public float stunBaseTime = 0.75f;
    public float stunRandomAmount = 0.25f;

    // 히어로 개별 유닛이 가지는 특성 구현

    public void Skill()
    {
        MGActiveEnemy.Instance.ControlAllEnemy((e) => {
            CONEnemy enemy = e.GetComponent<CONEnemy>();
            float originalXVelocity = enemy.myVelocity.x;

            enemy.OnDamaged(skillDamage);
            enemy.myVelocity.x = 0.0f;

            StartCoroutine(ResetEnemyVelocity(enemy, originalXVelocity, Random.Range(stunBaseTime - stunRandomAmount, stunBaseTime + stunRandomAmount)));
        });
    }

    IEnumerator ResetEnemyVelocity(CONEnemy enemy, float originalXVelocity, float time)
    {
        yield return new WaitForSeconds(time);
        enemy.myVelocity.x = originalXVelocity;
    }

    
}
