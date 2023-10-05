using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityToJs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

#if UNITY_WEBGL && !UNITY_EDITOR
    [System.Runtime.InteropServices.DllImport("__Internal")]
    private static extern void HelloJs(string str);
#endif
    
    public void Hello()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        HelloJs("Hello from Unity");
#endif
    }

}
