using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class NetworkInfo
{
    public string ipAddress;
    public string ipBroadcast;
    public string hostPertama;
    public string hostTerakhir;
}
public class Subnetting : MonoBehaviour
{
    public Sprite newImage;
    public GameObject[] PanelJawaban;
    public string subnetmask;
    public NetworkInfo[] arrayNetworkInfo;
    public GameObject papanScore;
    private Dictionary<NetworkInfo, bool> nilaiBooleanDictionary = new Dictionary<NetworkInfo, bool>();
    private WaktuScore scorecomponent;
    void Awake()
    {
        foreach (NetworkInfo nf in arrayNetworkInfo)
        {
            nilaiBooleanDictionary[nf] = false;
        }
    }

    void Start()
    {
        scorecomponent = papanScore.GetComponent<WaktuScore>();
    }
    public void AnswerCheck()
    {
        for (int pj = 0; pj < PanelJawaban.Length; pj++)
        {
            if (PanelJawaban[pj].activeSelf)
            {
                Transform[] transformArray = new Transform[4];
                transformArray[0] = PanelJawaban[pj].transform.Find("ipaddress");
                transformArray[1] = PanelJawaban[pj].transform.Find("ipbroadcast");
                transformArray[2] = PanelJawaban[pj].transform.Find("hostpertama");
                transformArray[3] = PanelJawaban[pj].transform.Find("hostterakhir");
                foreach (NetworkInfo nf in arrayNetworkInfo)
                {
                    if (!nilaiBooleanDictionary[nf])
                    {
                        string[] nfInfo = new string[4];
                        nfInfo[0] = nf.ipAddress;
                        nfInfo[1] = nf.ipBroadcast;
                        nfInfo[2] = nf.hostPertama;
                        nfInfo[3] = nf.hostTerakhir;
                        int isTrue = 0;

                        for (int i = 0; i < 4; i++)
                        {
                            if (transformArray[i] != null)
                            {
                                Transform inputobject = transformArray[i].Find("InputField (TMP)");
                                TMP_InputField input = inputobject.GetComponent<TMP_InputField>();
                                if (input != null)
                                {
                                    string nilaiTeks = input.text;
                                }
                                else
                                {
                                    Debug.LogWarning("Child 'inputfield' tidak memiliki komponen TMP_InputField.");
                                }

                                if (input.text == nfInfo[i])
                                {
                                    isTrue++;
                                }
                            }
                        }

                        if (isTrue == 4)
                        {
                            nilaiBooleanDictionary[nf] = true;
                            PanelJawaban[pj].SetActive(false);
                            if (PanelJawaban[pj + 1] != null)
                            {
                                PanelJawaban[pj + 1].SetActive(true);
                            }
                            Transform parentpanel = PanelJawaban[pj].transform.parent;
                            Image parentimage = parentpanel.GetComponent<Image>();
                            parentimage.sprite = newImage;
                            scorecomponent.AddScore(100);
                        }
                        else
                        {
                            scorecomponent.AddScore(isTrue * 10);
                        }

                    }
                }
            }
        }
    }
}
