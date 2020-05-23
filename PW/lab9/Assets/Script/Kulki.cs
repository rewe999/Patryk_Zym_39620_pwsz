using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulki : MonoBehaviour
{

    public GameObject[] obiekty;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            CancelInvoke("Generate");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Generate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            genObj(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            genObj(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            genObj(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            genObj(3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            genObj(4);
        }

    }

    void Generate()
    {
        int rand = Random.Range(0, obiekty.Length);
        Instantiate(obiekty[rand], transform.position, Quaternion.identity);
    }

    void genObj(int n)
    {
        Instantiate(obiekty[n], transform.position, Quaternion.identity);
    }
}
