using UnityEngine;
using UnityEngine.UI;

public class MoveImages : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public float speed = 1.0f; // Kecepatan perpindahan

    private RectTransform image1RectTransform;
    private RectTransform image2RectTransform;
    private RectTransform canvasRectTransform;
    private float imageWidth;

    private void Start()
    {
        // Mendapatkan komponen RectTransform dari kedua gambar
        image1RectTransform = image1.GetComponent<RectTransform>();
        image2RectTransform = image2.GetComponent<RectTransform>();

        // Mendapatkan RectTransform dari Canvas
        canvasRectTransform = GetComponentInParent<Canvas>().GetComponent<RectTransform>();

        // Mendapatkan lebar gambar
        imageWidth = image1RectTransform.rect.width;

        // Memulai pergerakan gambar
        StartMoving();
    }

    private void Update()
    {
        // Menggerakkan kedua gambar ke kiri dengan kecepatan yang ditentukan
        float newX1 = image1RectTransform.anchoredPosition.x - (speed * Time.deltaTime);
        float newX2 = image2RectTransform.anchoredPosition.x - (speed * Time.deltaTime);
        image1RectTransform.anchoredPosition = new Vector2(newX1, image1RectTransform.anchoredPosition.y);
        image2RectTransform.anchoredPosition = new Vector2(newX2, image2RectTransform.anchoredPosition.y);

        // Memeriksa apakah gambar 1 telah mencapai batas kiri canvas
        if (image1RectTransform.anchoredPosition.x <= -imageWidth)
        {
            // Memindahkan gambar 1 ke belakang gambar 2
            image1RectTransform.anchoredPosition = new Vector2(image2RectTransform.anchoredPosition.x - 1 + imageWidth, image1RectTransform.anchoredPosition.y);
        }

        // Memeriksa apakah gambar 2 telah mencapai batas kiri canvas
        if (image2RectTransform.anchoredPosition.x <= -imageWidth)
        {
            // Memindahkan gambar 2 ke belakang gambar 1
            image2RectTransform.anchoredPosition = new Vector2(image1RectTransform.anchoredPosition.x-1 + imageWidth, image2RectTransform.anchoredPosition.y);
        }
    }

    private void StartMoving()
    {
        // Memulai pergerakan
        enabled = true;
    }

    private void StopMoving()
    {
        // Memberhentikan pergerakan
        enabled = false;
    }
}
