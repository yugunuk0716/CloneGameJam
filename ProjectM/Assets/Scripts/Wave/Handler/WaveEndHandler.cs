using UnityEngine;

public class WaveEndHandler : MonoBehaviour
{
    private void Start()
    {
        MGWave.Instance.OnWaveCompleted += () => {
            // ++GameManager.Instance.Money;
            // Debug.Log(GameManager.Instance.Money);
        };
    }
}