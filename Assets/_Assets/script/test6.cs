using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test6 : MonoBehaviour
{

    [SerializeField] private int score = 85;

    // Start is called before the first frame update
    void Start()
    {
        if (score>=90)
        {
            Debug.Log("Grade: A");
        }
        else if (score >= 80)
        {
            Debug.Log("Grade: B");
        }
        else
        {
            Debug.Log("Grade: C");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
