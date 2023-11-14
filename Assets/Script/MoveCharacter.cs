using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanKarakter : MonoBehaviour
{
    public float kecepatan = 5f; // Kecepatan pergerakan karakter

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float gerakanHorizontal = Input.GetAxis("Horizontal");
        float gerakanVertikal = Input.GetAxis("Vertical");

        Vector2 gerakan = new Vector2(gerakanHorizontal, gerakanVertikal);
        rb.freezeRotation = true;
        rb.velocity = gerakan * kecepatan;
    }
}
