using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
    public AudioSource splashMusicAudioSource; // Tarik objek Audio Source dari scene splash ke sini

    private void Start()
    {
        // Memulai pemutaran musik di scene main menu
        splashMusicAudioSource.Play();
    }
}