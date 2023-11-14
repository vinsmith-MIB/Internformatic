using UnityEngine;

public class KontrolAnimasi : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float gerakanHorizontal = Input.GetAxis("Horizontal");
        float gerakanVertikal = Input.GetAxis("Vertical");


        // Mengatur animasi berdasarkan arah karakter
        if (gerakanHorizontal > 0)
        {
            // Karakter bergerak ke kanan
            anim.SetBool("BergerakKanan", true);
            anim.SetBool("BergerakKiri", false);
        }
        else if (gerakanHorizontal < 0)
        {
            // Karakter bergerak ke kiri
            anim.SetBool("BergerakKiri", true);
            anim.SetBool("BergerakKanan", false);
        }
        else
        {
            // Karakter berhenti horizontal
            anim.SetBool("BergerakKanan", false);
            anim.SetBool("BergerakKiri", false);
        }

        if (gerakanVertikal > 0)
        {
            // Karakter bergerak ke atas
            anim.SetBool("BergerakAtas", true);
            anim.SetBool("BergerakBawah", false);
        }
        else if (gerakanVertikal < 0)
        {
            // Karakter bergerak ke bawah
            anim.SetBool("BergerakBawah", true);
            anim.SetBool("BergerakAtas", false);
        }
        else
        {
            // Karakter berhenti vertikal
            anim.SetBool("BergerakAtas", false);
            anim.SetBool("BergerakBawah", false);
        }
    }
}
