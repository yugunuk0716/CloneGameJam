using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimeScale : MonoBehaviour
{
    private Button btn;
    private Text text;

    private bool isPressed = false;

    const float  NORMAL      = 1.0f;
    const string NORMAL_TEXT = ">";
    const float  DOUBLE      = 2.0f;
    const string DOUBLE_TEXT = ">>";

    private void Start()
    {
        btn = GetComponent<Button>();
        text = GetComponentInChildren<Text>();

        btn.onClick.AddListener(() => {
            MGTimeScale.Instance.SetTimeScale(isPressed ? NORMAL : DOUBLE);
            text.text = isPressed ? NORMAL_TEXT : DOUBLE_TEXT;
            isPressed = !isPressed;
        });
    }
}
