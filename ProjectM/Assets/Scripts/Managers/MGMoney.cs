using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGMoney : MonoSingleton<MGMoney>
{
    /// <summary>
    /// 돈 변경 시 호출됨. (int = addedAmount)
    /// </summary>
    public event Action<int> OnMoneyChanged;

    private int _money = 0;
    public int Money { get { return _money; } }

    private void Awake()
    {
        OnMoneyChanged += (e) => { };
    }

    private void AddMoney(int amount)
    {
        _money += amount;

        OnMoneyChanged(amount);
    }
}
