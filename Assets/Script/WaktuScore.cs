using UnityEngine;
using TMPro;

public class WaktuScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public float timer = 300f; // Waktu awal dalam detik (misalnya 5 menit)
    public int score = 0;

    void Start()
    {
        UpdateScoreText();
        UpdateTimerText();
    }

    void Update()
    {
        // Update waktu mundur
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            // Waktu habis, tambahkan tindakan apa yang diinginkan di sini
            Debug.Log("Waktu habis!");
        }
    }

    // Fungsi untuk menambah skor
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Fungsi untuk memperbarui teks skor
    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    // Fungsi untuk memperbarui teks waktu mundur
    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
