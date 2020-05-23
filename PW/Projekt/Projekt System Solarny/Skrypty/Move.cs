using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    GameObject slonce;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        slonce = GameObject.Find("Slonce").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(slonce.transform);
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    
}
