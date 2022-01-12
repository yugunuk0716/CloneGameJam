using UnityEngine;

public class Arrow : MonoBehaviour
{
    float t;
    float speed;

    Vector2 p1;
    Vector2 p2;
    Vector2 p3;

    Vector2 l1; // p1 ~ p2
    Vector2 l2; // p2 ~ p3
    Vector2 l3; // l1 ~ l2 == Arrow position

    GameObject shooter;
    GameObject target;

    bool calculate = false;

    private void Start()
    {
        print("»ý¼º");
    }

    public void Init(GameObject shooter, GameObject target, float speed)
    {
        this.shooter = shooter;
        this.target  = target;

        p1 = shooter.transform.position;

        this.speed = speed;
        this.t = 0.0f;

        calculate = true;
    }

    private void Update()
    {
        if(!calculate) return;

        p2 = shooter.transform.position + (target.transform.position - shooter.transform.position) * 0.5f;
        p2.y += 3.0f;
        p3 = target.transform.position;

        l1 = Vector2.Lerp(p1, p2, t);
        l2 = Vector2.Lerp(p2, p3, t);
        l3 = Vector2.Lerp(l1, l2, t);

        this.transform.position = l3;

        t += Time.deltaTime * speed;

        if(t >= 1.0f) {
            gameObject.SetActive(false);
        }
    }
}