using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usermovement : MonoBehaviour
{

    void Start()
    {

    }
    float y = 0;
    float moveSpeed = 5f;
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        bool a = Input.GetMouseButton(0);
        bool b = Input.GetMouseButton(1);



        if (a == true)
        {

            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
        if (b == true)
        {

            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }


        transform.position += new Vector3(x, 0, z);

    }
}
