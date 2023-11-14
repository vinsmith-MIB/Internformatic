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

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex > 1) {
            Destroy(gameObject);
        }
    }
}



