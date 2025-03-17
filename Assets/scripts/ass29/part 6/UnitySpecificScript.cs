using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    void Start()
    {
        print("GameObject Started!");

    }

    // Update is called once per frame
    void Update()
    {
        GameObject targetObj = GameObject.Find("Joker");
        while (Input.GetKey(KeyCode.D))
        {

            if (targetObj != null)
            {
                targetObj.SetActive(false);
                print("TargetObject deactivated!");
            }
        }
        if (targetObj == null)
        {
            print("No TargetObject found.");
        }
        else if (targetObj != null)
        {
            print("Found object by name: " + targetObj.name);
        }

        GameObject targetObjbytag = GameObject.FindGameObjectWithTag("Joker");
        if (targetObjbytag == null)
        {
            print("No TargetObject found.");
        }
        else if (targetObjbytag != null)
        {
            print("Found object by tag: " + targetObjbytag.name);
        }
        Light light = GameObject.FindObjectOfType<Light>();
        if (light != null)
        {
            print("Found Light object: " + light.name);
        }
        else
        {
            print("No Light object found.");
        }

    }
    void OnEnable()
    {
        print("GameObject Enabled");
    }
    void OnDisable()
    {
        print("GameObject Disabled");
    }
}
