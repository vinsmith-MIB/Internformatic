using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public GameObject dialog; // GameObject dialog yang ingin diaktifkan
    private CanvasGroup canvasGroup; // Komponen CanvasGroup untuk mengatur alpha

    private void Start()
    {
        // Pastikan GameObject dialog tidak aktif saat game dimulai
        dialog.SetActive(false);

        // Dapatkan komponen CanvasGroup
        canvasGroup = dialog.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            // Jika CanvasGroup tidak ada, tambahkan komponen baru
            canvasGroup = dialog.AddComponent<CanvasGroup>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Aktifkan GameObject dialog
            dialog.SetActive(true);

            // Set alpha CanvasGroup menjadi 1
            canvasGroup.alpha = 1f;
        }
    }
}

