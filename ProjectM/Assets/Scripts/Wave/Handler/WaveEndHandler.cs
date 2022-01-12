using UnityEngine;

public class WaveEndHandler : MonoBehaviour
{
    private void Start()
    {
        WaveManager.Instance.OnWaveCompleted += () => {
            ++GameManager.Instance.Money;
            Debug.Log(GameManager.Instance.Money);
        };
    }
}