using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public GameObject[] PanelJawaban;
    public string subnetmask;
    public NetworkInfo[] arrayNetworkInfo;
    private Dictionary<NetworkInfo, bool> nilaiBooleanDictionary = new Dictionary<NetworkInfo, bool>();

    void Awake()
    {
        foreach (NetworkInfo nf in arrayNetworkInfo)
        {
            nilaiBooleanDictionary[nf] = false;
        }
    }
    public void AnswerCheck()
    {
        foreach (GameObject obj in PanelJawaban)
        {
            if (obj.activeSelf)
            {
                Transform child = obj.transform.GetChild(0);
                Transform[] transformArray = new Transform[4];
                transformArray[0] = child.transform.Find("ipaddress");
                transformArray[1] = child.transform.Find("ipbroadcast");
                transformArray[2] = child.transform.Find("hostpertama");
                transformArray[3] = child.transform.Find("hostterakhir");
                foreach (Transform t in transformArray)
                    Debug.Log(t);

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
                                    // Ambil nilai teks dari TMP_InputField
                                    string nilaiTeks = input.text;
                                    Debug.Log("Nilai teks dari TMP_InputField: " + nilaiTeks);
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
                            nilaiBooleanDictionar[nf] = true;
                        }

                    }
                }
            }
        }
    }
}
