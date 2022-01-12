using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGTimeScale :  MonoSingleton<MGTimeScale>
{

    private float _timeScale = 1.0f;
    public float TimeScale
    { 
        get { return _timeScale; }
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
    }
}
