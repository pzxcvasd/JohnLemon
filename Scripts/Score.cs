using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI text;
    public static int cntItem;

    void Start() {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update() {

        text.text = cntItem.ToString();
    }
}
