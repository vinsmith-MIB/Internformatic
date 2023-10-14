using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string fullText;
    public float typingSpeed = 0.1f;

    private string currentText = "";
    private int textIndex = 0;

    private void Start()
    {
        StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        while (textIndex < fullText.Length)
        {
            currentText += fullText[textIndex];
            textMeshPro.text = currentText;
            textIndex++;

            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
