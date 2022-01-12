using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGMana : MonoSingleton<MGMana>
{
    public event System.Action<int> OnManaChanged;

    [SerializeField] private float mamaIncreasementTime = 2.0f;
    private float lastManaIncreaseMent;

    private int _mana;
    public int Mana {
        get { return _mana; }
        set {
            _mana = Mathf.Clamp(_mana + value, 0, 10);
        }
    }

    private void Awake()
    {
        OnManaChanged += (e) => { };
    }

    private void Update()
    {
        if(Time.time >= mamaIncreasementTime + lastManaIncreaseMent) {
            AddMana(1);
        }
    }

    public bool CanUseMana(int amount)
    {
        return (Mana - amount < 0);
    }

    public void UseMana(int amount)
    {
        if(!CanUseMana(amount)) return;
        Mana -= amount;

        OnManaChanged(Mana);
    }

    public void AddMana(int amount)
    {
        Mana += amount;
        OnManaChanged(Mana);
    }
}
