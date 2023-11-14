using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.SceneManagement;
public class DoubleClickHandler : MonoBehaviour, IPointerClickHandler
{
    public float doubleClickTimeThreshold = 0.2f; // Waktu antara dua klik agar dianggap sebagai double click
    public string sceneTujuan;
    public GameObject buttonTujuan;
    private float lastClickTime = 0;
    
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Time.time - lastClickTime < doubleClickTimeThreshold)
        {
            SceneManager.LoadScene(sceneTujuan);
        }
        else
        {
            buttonTujuan.GetComponent<PindahScene>().namaScene = sceneTujuan;
        }

        lastClickTime = Time.time;
    }
}
