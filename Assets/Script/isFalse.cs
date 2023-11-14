using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class isFalse : MonoBehaviour
{
    public GameObject[] isfalseDialog;

    private void Awake()
    {
        // Menonaktifkan semua elemen dalam array
        for (int i = 0; i < isfalseDialog.Length; i++)
        {
            isfalseDialog[i].SetActive(false);
        }
    }

    public void Onclickfalse() {
        for (int i = 0; i < isfalseDialog.Length; i++)
        {
            isfalseDialog[i].SetActive(false);
        }
    }
}
