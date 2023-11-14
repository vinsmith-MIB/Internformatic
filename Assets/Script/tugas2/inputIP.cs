using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputIP : MonoBehaviour
{
    private TMP_InputField input;

    void Start()
    {
        input = gameObject.GetComponent<TMP_InputField>();
    }



    void LateUpdate()
    {
        // Pindahkan caret ke paling akhir dalam LateUpdate
        input.caretPosition = input.text.Length;
    }
}
