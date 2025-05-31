using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test7 : MonoBehaviour
{
    [SerializeField] private int day = 3;
    // Start is called before the first frame update
    void Start()
    {

        switch (day)
        {
            case 1: Debug.Log("Monday"); break;
            case 2: Debug.Log("TueDay"); break;
            case 3: Debug.Log("WednesDay"); break;
            default: Debug.Log("Other Day"); break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
