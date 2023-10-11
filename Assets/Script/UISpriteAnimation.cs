using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISpriteAnimation : MonoBehaviour
{
    public Image m_Image;
    public Sprite[] m_SpriteArray;
    public float m_Speed = 0.02f;

    private int m_IndexSprite;
    private Coroutine m_CorotineAnim;
    private bool IsDone = false;

    private void Start()
    {
        // Memulai animasi saat permainan dimulai
        StartAnimation();
    }

    private void StartAnimation()
    {
        // Memastikan animasi tidak sedang berjalan sebelum memulai
        StopAnimation();

        // Memulai animasi
        IsDone = false;
        m_CorotineAnim = StartCoroutine(Func_PlayAnimUI());
    }

    public void StopAnimation()
    {
        // Menghentikan animasi
        IsDone = true;
        if (m_CorotineAnim != null)
        {
            StopCoroutine(m_CorotineAnim);
        }
    }

    IEnumerator Func_PlayAnimUI()
    {
        while (!IsDone)
        {
            yield return new WaitForSeconds(m_Speed);
            
            // Mengganti sprite
            m_Image.sprite = m_SpriteArray[m_IndexSprite];
            m_IndexSprite = (m_IndexSprite + 1) % m_SpriteArray.Length;
        }
    }
}
