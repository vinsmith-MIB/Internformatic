using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource; // Referensi ke Audio Source di Scene 1

    private void Awake()
    {
        // Pastikan skrip ini tidak akan dihancurkan ketika berpindah scene
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        // Memulai pemutaran musik di Scene 1
        musicSource.Play();
    }

    // Fungsi ini akan dipanggil ketika berpindah scene
    private void OnLevelWasLoaded(int level)
    {
        // Cek jika sudah berada di Scene 2
        if (level == 2) // Ubah angka ini sesuai dengan indeks Scene 2 di build settings
        {
            // Temukan Audio Source di Scene 2 dan lanjutkan pemutaran musik
            AudioSource scene2MusicSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
            scene2MusicSource.Play();
        }
    }
}


