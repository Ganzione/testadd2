using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.03f, 0, 0); //왼쪽 버튼 누른만큼 움직
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.03f, 0, 0); //오른쪽 버튼 누른만큼 움직
        }
    }
}
