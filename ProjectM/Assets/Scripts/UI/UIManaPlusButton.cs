using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManaPlusButton : MonoBehaviour
{
    [SerializeField] private int mamaIncreasementAmount = 1;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => {
            MGMana.Instance.AddMana(mamaIncreasementAmount);
            Destroy(gameObject);
        });
    }
}
