using UnityEngine;

public class OnOffButton : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool IsTrue;
    public GameObject button2;

    private GameObject button1;
    void Awake()
    {
        button1 = this.gameObject;
        if(!IsTrue){
            button1.SetActive(false);
        }

    }

    // Update is called once per frame
    public void OnOff() {
        button1.SetActive(false);
        button2.SetActive(true);
    }
}
