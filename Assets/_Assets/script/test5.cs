using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test5 : MonoBehaviour
{

    [SerializeField] private int sum;
    [SerializeField] private int difference;
    [SerializeField] private int product;
    [SerializeField] private int quotient;
    [SerializeField] private int remainder;

    [SerializeField] private bool isEqual;
    [SerializeField] private bool isNotEqual;

    [SerializeField] private bool andResult;
    [SerializeField] private bool orResult;
    [SerializeField] private bool notResult;
    // Start is called before the first frame update
    [SerializeField]
    private void Start()
    {
        sum = 10 + 5;
        difference = 10 - 5;
        product = 10 * 5;
        quotient = 10 / 5;
        remainder = 10 % 5;

        Debug.Log("sum: " + sum);
        Debug.Log("difference: " + difference);
        Debug.Log("prodouct: " + product);
        Debug.Log("quotient: " + quotient);
        Debug.Log("remainder: " + remainder);


        isEqual = (10 == 10);//true
        isNotEqual=(10 != 5);//true

        Debug.Log("Is Equal: " + isEqual);
        Debug.Log("Is Not Equal: " + isNotEqual);


        andResult = (true && false);
        orResult = (true || false);
        notResult = !true;

        Debug.Log("AND Result: " + andResult);
        Debug.Log("OR Result: " + orResult);
        Debug.Log("NOT Result: " + notResult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
