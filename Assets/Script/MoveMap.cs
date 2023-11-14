using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMap : MonoBehaviour
{
    public string arah;
    private Rigidbody2D rb;
    private Collider2D cd;
    private GameObject map;
    private bool lewatBatas = false;



    void Start()
    {
        map = GameObject.FindWithTag("Map");
        rb = map.GetComponent<Rigidbody2D>();
        cd = GetComponent<Collider2D>();

    }


    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && lewatBatas == false)
        {
            float gerakanHorizontal = (arah == "kiri" || arah == "kanan")
                ? -Input.GetAxis("Horizontal") : 0;
            float gerakanVertikal = (arah == "atas" || arah == "bawah")
                ? -Input.GetAxis("Vertical") : 0;

            Vector2 gerakan = new Vector2(gerakanHorizontal, gerakanVertikal);
            rb.velocity = gerakan * 150;
        }
        if (other.gameObject.CompareTag("BatasCanvas"))
        {
            lewatBatas = true;
            cd.isTrigger = true;
            Vector2 gerakan = new Vector2(0, 0);
            rb.velocity = gerakan * 150;
        }


    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector2 gerakan = new Vector2(0, 0);
            rb.velocity = gerakan * 150;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            Vector2 gerakan = new Vector2(0, 0);
            rb.velocity = gerakan * 150;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BatasCanvas"))
        {
            lewatBatas = false;
            cd.isTrigger = false;
        }
    }
}
