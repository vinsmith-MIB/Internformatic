using UnityEngine;
using UnityEngine.UI;

public class TextTypewriter : MonoBehaviour
{
    public float typingSpeed = 0.05f; // Kecepatan animasi ketik (sec per karakter)
    public string fullText; // Teks lengkap yang akan ditampilkan

    private Text textComponent;
    private string currentText = "";
    private float timer;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        fullText = textComponent.text;
        textComponent.text = "";
    }

    private void Update()
    {
        if (currentText != fullText)
        {
            timer += Time.deltaTime;
            if (timer >= typingSpeed)
            {
                currentText = fullText.Substring(0, currentText.Length + 1);
                textComponent.text = currentText;
                timer = 0f;
            }
        }
    }
}
