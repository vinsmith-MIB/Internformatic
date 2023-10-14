using UnityEngine;
using UnityEngine.UI;

public class PanelReplacement : MonoBehaviour
{
    public GameObject panelToReplace; // Panel yang akan diganti
    public GameObject replacementPanel; // Panel pengganti

    private bool isReplaced = false;

    private void Start()
    {
        // Pastikan panel pengganti tidak aktif saat permainan dimulai
        replacementPanel.SetActive(false);
    }

    public void ReplacePanel()
    {
        if (!isReplaced)
        {
            // Salin posisi dan rotasi dari panel yang akan diganti
            Vector3 position = panelToReplace.transform.position;
            Quaternion rotation = panelToReplace.transform.rotation;

            // Nonaktifkan panel yang akan diganti
            panelToReplace.SetActive(false);

            // Aktifkan panel pengganti dengan posisi dan rotasi yang sama
            replacementPanel.transform.position = position;
            replacementPanel.transform.rotation = rotation;
            replacementPanel.SetActive(true);

            isReplaced = true;
        }
    }
}
