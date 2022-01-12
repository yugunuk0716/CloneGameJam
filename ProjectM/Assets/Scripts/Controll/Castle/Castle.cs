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

    public RectTransform hpBarTrm;

    [SerializeField] private int defaultHP = 100;
    public int HP { get; private set; }

    private void Awake()
    {
        OnCastleDead    += ()  => { };
        OnCastleDamaged += (d) => { };
        HP = defaultHP;
    }

    private void Start()
    {
        hpBarTrm.gameObject.SetActive(false);
    }

    public void DecreaseHP(int damage)
    {
        hpBarTrm.transform.SetParent(MGScene.Instance.towerTrm);
        hpBarTrm.gameObject.SetActive(true);
        OnCastleDamaged(damage);

        HP -= damage;

        if(HP <= 0) {
            OnCastleDead();
        }

        hpBarTrm.localScale = new Vector3((float)HP / (float)defaultHP, 1, 1);
    }



}
