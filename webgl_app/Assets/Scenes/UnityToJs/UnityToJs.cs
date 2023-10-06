using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnityToJs : MonoBehaviour
{

#if UNITY_WEBGL && !UNITY_EDITOR
    [System.Runtime.InteropServices.DllImport("__Internal")]
    private static extern void HelloJs(string str);
#endif
    
    public void Hello()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        HelloJs(GameObject.Find("InputField (TMP)").GetComponent<TMP_InputField>().text);
#endif
    }
    
}
