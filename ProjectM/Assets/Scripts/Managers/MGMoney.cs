using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGMoney : MonoSingleton<MGMoney>
{
    private int _money = 0;
    public int Money { get { return _money; } }

    private void AddMoney(int amount)
    {
        _money += amount;
    }
}
