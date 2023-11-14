using UnityEngine;

public class PauseaudioSrc : MonoBehaviour
{
    private AudioSource musicSource;

    void Start()
    {
        musicSource = GameObject.FindGameObjectWithTag("BacksoundMainMenu").GetComponent<AudioSource>();
    }

    public void IsPause()
    {
        musicSource.Pause();
    }

    public void isPlay() 
    {
        musicSource.Play();
    }
}
