using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baitap : MonoBehaviour
{

    [SerializeField] private float TongDiem = 0;
    [SerializeField] private float DiemToan;
    [SerializeField] private float DiemVan;
    [SerializeField] private float DiemAnh;
    [SerializeField] private string[] nguoichoi = { "chó", "mèo", "lợn", "gà", "vịt" };
    // Start is called before the first frame update
    void Start()
    {
        TongDiem = (DiemAnh + DiemToan + DiemVan) / 3;

        Debug.Log("Tong Diem: " + TongDiem);

        if (TongDiem == 10)
        {
            Debug.Log("bạn giỏi vl =))");
        }
        else if (TongDiem < 10 && TongDiem >= 8)
        {
            Debug.Log("học sinh giỏi");
        }
        else if (TongDiem < 8 && TongDiem >= 5)
        {
            Debug.Log("học sinh khá");
        }
        else
        {
            Debug.Log("học sinh yếu");
        }


        int i = 0;
        while (i < nguoichoi.Length)
        {
            Debug.Log("Người chơi: " + nguoichoi[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
