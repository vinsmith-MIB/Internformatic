using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInEffect : MonoBehaviour
{
    public GameObject container;  // Container berisi elemen UI
    [SerializeField]
    public float fadeInDuration = 0.02f;  // Durasi efek fade in dalam detik
    private float currentTime = 0.0f;

    private void Start()
    {
        // Set alpha elemen-elemen UI dalam container menjadi 0 (transparan) di awal
        Image[] images = container.GetComponentsInChildren<Image>();
        Text[] texts = container.GetComponentsInChildren<Text>();
        Button[] buttons = container.GetComponentsInChildren<Button>();

        foreach (var image in images)
        {
            Color startColor = image.color;
            startColor.a = 0.0f;
            image.color = startColor;
        }

        foreach (var text in texts)
        {
            Color startColor = text.color;
            startColor.a = 0.0f;
            text.color = startColor;
        }

        foreach (var button in buttons)
        {
            Color startColor = button.image.color;
            startColor.a = 0.0f;
            button.image.color = startColor;
        }
    }

    private void Update()
    {
        // Perbarui waktu saat ini
        currentTime += Time.deltaTime;

        // Hitung nilai alpha berdasarkan waktu saat ini dan durasi fade in
        float alpha = Mathf.Clamp01(currentTime / fadeInDuration);

        // Terapkan alpha ke elemen-elemen UI dalam container
        Image[] images = container.GetComponentsInChildren<Image>();
        Text[] texts = container.GetComponentsInChildren<Text>();
        Button[] buttons = container.GetComponentsInChildren<Button>();

        foreach (var image in images)
        {
            Color currentColor = image.color;
            currentColor.a = alpha;
            image.color = currentColor;
        }

        foreach (var text in texts)
        {
            Color currentColor = text.color;
            currentColor.a = alpha;
            text.color = currentColor;
        }

        foreach (var button in buttons)
        {
            Color currentColor = button.image.color;
            currentColor.a = alpha;
            button.image.color = currentColor;
        }

        // Hentikan pemrosesan setelah efek fade in selesai
        if (alpha >= 1.0f)
        {
            enabled = false;  // Nonaktifkan skrip ini
        }
    }
}
