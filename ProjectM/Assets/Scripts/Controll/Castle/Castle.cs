using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    /// <summary>
    /// 성 사망 시 호출
    /// </summary>
    public event System.Action OnCastleDead;

    /// <summary>
    /// 성 공격 시 호출 (int = damage)
    /// </summary>
    public event System.Action<int> OnCastleDamaged;

    [SerializeField] private int defaultHP = 100;
    public int HP { get; private set; }

    private void Awake()
    {
        OnCastleDead    += ()  => { };
        OnCastleDamaged += (d) => { };
        HP = defaultHP;
    }

    public void DecreaseHP(int damage)
    {
        OnCastleDamaged(damage);

        HP -= damage;

        if(HP <= 0) {
            OnCastleDead();
        }
    }
}
