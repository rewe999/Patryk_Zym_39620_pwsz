using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{

    GameObject[] delSphere;
    // Start is called before the first frame update
    void Start()
    {
        delSphere = GameObject.FindGameObjectsWithTag("kula");
        foreach (GameObject del in delSphere) Destroy(del);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
