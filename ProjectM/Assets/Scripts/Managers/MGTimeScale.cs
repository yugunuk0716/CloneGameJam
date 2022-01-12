using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGTimeScale :  MonoSingleton<MGTimeScale>
{
    /// <summary>
    /// TimeScale 변경 시 호출됨 (float = TimeScale)
    /// </summary>
    public event System.Action<float> OnTimeScaleUpdated;


    private float _timeScale = 1.0f;
    public float TimeScale
    { 
        get { return _timeScale; }
    }

    private void Awake()
    {
        OnTimeScaleUpdated += (a) => { };
    }


    /// <summary>
    /// 시간 배속을 설정합니다,
    /// </summary>
    /// <param name="scale">배속 (0 ~ n)</param>
    public void SetTimeScale(float scale)
    {
        if(scale < 0.0f) {
            return;
        }

        _timeScale = scale;

        OnTimeScaleUpdated(TimeScale);
    }
}
