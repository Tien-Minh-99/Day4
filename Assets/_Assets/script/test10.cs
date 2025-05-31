using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test10 : MonoBehaviour
{
    [SerializeField] private int i = 0;

    // Start is called before the first frame update
    void Start()
    {

        do
        {
            Debug.Log("i: " + i);
            i++;
        } while (i < 5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
