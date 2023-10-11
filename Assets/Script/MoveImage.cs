using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MoveImage : MonoBehaviour, IPointerEnterHandler
{
    public GameObject imageToMove;
    public Button moveButton;
    public float NewPosition = 18.318f;

    private RectTransform imageRectTransform;

    private void Start()
    {
        // Dapatkan komponen RectTransform dari gambar
        imageRectTransform = imageToMove.GetComponent<RectTransform>();

        // Tambahkan event listener ke tombol
        moveButton.onClick.AddListener(MoveImageToNewPosition);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Buat vektor posisi baru dengan anchor Y 18.318 (sesuai permintaan Anda)
        Vector2 newPosition = new Vector2(imageRectTransform.anchoredPosition.x, NewPosition);

        // Atur posisi anchor gambar ke posisi baru
        imageRectTransform.anchoredPosition = newPosition;
    }

    private void MoveImageToNewPosition()
    {
        // Buat vektor posisi baru dengan anchor Y 18.318 (sesuai permintaan Anda)
        Vector2 newPosition = new Vector2(imageRectTransform.anchoredPosition.x, NewPosition);

        // Atur posisi anchor gambar ke posisi baru
        imageRectTransform.anchoredPosition = newPosition;
    }
}
