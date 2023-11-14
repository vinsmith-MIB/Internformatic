using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{

    public Transform masukanLoadingbar;

    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan = 0.0f;


    // Update is called once per frame
    void Update()
    {
        if (nilaiSekarang < 639)
        {
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        }
        masukanLoadingbar.GetComponent<Image>().fillAmount = nilaiSekarang / 1000;

    }
}