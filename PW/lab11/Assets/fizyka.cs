using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fizyka : MonoBehaviour
{
    Rigidbody fiz;
    public float speed;
    float inputX, inputZ;
    bool skok = false;
    bool strzal = false;
    public GameObject kulka;
    public Transform pozycjakulki;
    public Transform pozycjakulki2;
    public Transform pozycjakulki3;
    public Transform pozycjakulki4;
    void Awake()
    {
        fiz = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        if(Input.GetButtonDown("Jump"))
        {
            skok = true;
        }
        if(Input.GetButtonDown("Fire1"))
        {
            strzal = true;
        }
    }

    void FixedUpdate()
    {
        fiz.velocity = new Vector3(inputX*speed, fiz.velocity.y, inputZ*speed);
        if(skok==true)
        {
            Skok();
            skok = false;
        }
        if(strzal==true)
        {
            Strzal();
            strzal = false;
        }
    }

    void Skok()
    {
        fiz.AddForce(0, 400, 0);
    }

    void Strzal()
    {
        GameObject nowaKulka = Instantiate(kulka, pozycjakulki.position, Quaternion.identity);
        GameObject nowaKulka2 = Instantiate(kulka, pozycjakulki2.position, Quaternion.identity);
        GameObject nowaKulka3 = Instantiate(kulka, pozycjakulki3.position, Quaternion.identity);
        GameObject nowaKulka4 = Instantiate(kulka, pozycjakulki4.position, Quaternion.identity);
        nowaKulka.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 20);
        nowaKulka2.GetComponent<Rigidbody>().velocity = new Vector3(20, 0, 0);
        nowaKulka3.GetComponent<Rigidbody>().velocity = new Vector3(-20, 0, 0);
        nowaKulka4.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -20);
    }
}
