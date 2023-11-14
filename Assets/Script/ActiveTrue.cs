using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTrue : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameobj;
    public bool isTrue;

    public void isActive() {
        if(isTrue)
        gameobj.SetActive(true);
        else
        gameobj.SetActive(false);
    }
}
