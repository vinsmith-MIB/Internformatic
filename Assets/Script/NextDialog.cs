using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject firstPanel;  // Panel pertama yang akan digantikan
    public GameObject secondPanel; // Panel kedua yang akan ditampilkan

    private bool isSecondPanelActive = false; // Menandai apakah panel kedua sedang aktif

    void Start()
    {
        // Inisialisasi, aktifkan panel pertama dan nonaktifkan panel kedua
        firstPanel.SetActive(true);
        secondPanel.SetActive(false);
    }

    void Update()
    {
        // Cek jika panel pertama diklik
        if (Input.GetMouseButtonDown(0)) // Anda bisa mengganti dengan event klik yang sesuai dengan kebutuhan Anda
        {
            // Ganti panel yang aktif berdasarkan status saat ini
            if (isSecondPanelActive)
            {
                firstPanel.SetActive(true);
                secondPanel.SetActive(false);
            }
            else
            {
                firstPanel.SetActive(false);
                secondPanel.SetActive(true);
            }

            // Ubah status aktif panel
            isSecondPanelActive = !isSecondPanelActive;
        }
    }
}
