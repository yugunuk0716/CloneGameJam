using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONArchor : CONCharacter
// public class CONArchor : MonoBehaviour
{
    [SerializeField] private float arrowSpeed = 1.0f;

    // public GameObject target;
    public GameObject arrow;

    // public float lf = 0.0f;
    // public float del = 2.0f;

    public override void OnAttack()
    // public void Update()
    {
        // if(Time.time < lf + del) return;
        // lf = Time.time;
        GameObject target = MGActiveEnemy.Instance.GetEnemy(MGActiveEnemy.SearchType.FRONT);


        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.transform.position + (target.transform.position - this.transform.position) * 0.5f;
                p2.y += 3.0f;
        Vector2 p3 = target.transform.position;

        Instantiate(arrow).GetComponent<Arrow>().Init(this.gameObject, target, arrowSpeed);
    }
}
