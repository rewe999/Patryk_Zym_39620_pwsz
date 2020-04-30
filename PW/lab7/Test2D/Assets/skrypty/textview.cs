using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textview : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text txt = GameObject.Find("Canvas/Text").GetComponent<Text>();
        txt.text = "asdasdasd";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
