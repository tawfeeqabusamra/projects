using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class movement : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {
        float newX = Mathf.PingPong(Time.time * 20, 50) - 25;
      
        transform.position = new Vector3(newX, 0, 0);

    }
}