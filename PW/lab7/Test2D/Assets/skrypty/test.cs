using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int ilosc = 5;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < ilosc; i++)
        {
            print("Patryk " + (i+1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
