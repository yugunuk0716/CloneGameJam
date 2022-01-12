using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWaveText : MonoBehaviour
{
    void Start()
    {
        GetComponent<RectTransform>().localPosition = new Vector2(600, 300);
    }

    // Update is called once per frame
    void Update()
    {
        (int a, int b) = MGWave.Instance.GetWaveData();
        MGScene.Instance.waveObj.GetComponent<UnityEngine.UI.Text>().text = $"{a} / {b}";
    }
}
