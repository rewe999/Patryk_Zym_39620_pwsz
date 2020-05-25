using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class strzalka : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed;
    public GameObject kula;
    public Material[] kolory;
	
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		
		transform.Translate(x,y,0);
        
		if(Input.GetMouseButtonDown(0)){
            Vector3 pozycja = Input.mousePosition;
            pozycja.z = 10f;
            RandomCircle();
            pozycja = Camera.main.ScreenToWorldPoint(pozycja);
            Instantiate(kula, pozycja,Quaternion.identity);
		}
    }

    void RandomCircle()
    {        
        int rand = Random.Range(0, kolory.Length);
        kula.transform.GetComponent<Renderer>().material = kolory[rand];
    }
}
