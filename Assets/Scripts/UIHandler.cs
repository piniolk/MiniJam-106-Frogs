using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour {
    int num = 0;
    TMP_Text text;
    void Start() {
        text = GetComponent<TextMeshProUGUI>();
        text.text = num.ToString();
    }

    public void UpdateText() {
        num++;
        text.text = num.ToString();
    }

    public void SubtractText() {
        num--;
        text.text = num.ToString();
    }
}
