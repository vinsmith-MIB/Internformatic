using UnityEngine;
using UnityEngine.UI;

public class isFalse : MonoBehaviour
{
    public GameObject[] isfalseDialog;

    private void Start()
    {
        // Menonaktifkan semua elemen dalam array
        for (int i = 0; i < isfalseDialog.Length; i++)
        {
            isfalseDialog[i].SetActive(false);
        }
    }
}
