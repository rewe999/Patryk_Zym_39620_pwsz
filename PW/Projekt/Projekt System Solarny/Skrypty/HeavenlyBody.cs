using UnityEngine;
using System.Collections;
using UnityEngine;


public class HeavenlyBody : MonoBehaviour {
    GameObject[] planety;
    public int  min,max;

    private void Start()
    {
        planety = GameObject.FindGameObjectsWithTag("planety");
        for (int i = 0; i < planety.Length; i++)
        {
            int spped = setRandomSpeed(min, max);
            planety[i].GetComponent<Move>().speed = spped;
        }
    }
  
    int setRandomSpeed(int min, int max)
    {
        return Random.Range(min,max);
    }
}

