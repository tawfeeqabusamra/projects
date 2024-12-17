using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PopupBook : MonoBehaviour
{
    public Transform floor1;
    public Transform booklid1;
    public Transform bookLid2;
    public Transform popupObject;
    public Transform bookLid; 
        public float popupScaleSpeed = 2f;
    public Transform[] popupElements; 
                                      // public Vector3[] targetPositions; 
    // public Vector3 finalScale = Vector3.one;   
      bool isOpen = false; 
    float bookProgress = 0f;     float popupProgress = 0f;
    void Start()
    {
        bookLid.position = floor1.position;

        foreach (var element in popupElements)
        {
            element.localScale = Vector3.zero; 
        }


    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !isOpen)
        {
            OpenBook();
        }
    }

    void OpenBook()
    {
        // if (booklid1.eulerAngles.x <= 0f)
        // {
        //     booklid1.Rotate(-50 * Time.deltaTime, 0, 0);


        // }
        if (bookProgress < 1f)
        {
            bookProgress += Time.deltaTime * 0.5f;
            booklid1.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 0), Quaternion.Euler(180f, 0, 0), bookProgress);
            // booklid1.rotation = Quaternion.Lerp(Quaternion.Euler(0, 0, 0), Quaternion.Euler(180f, 0, 0), bookProgress);
        }

        // foreach (var element in popupElements)
        // {
        //     element.localScale = Vector3.zero; 
        // }
        // for (int i = 0; i < popupElements.Length; i++)
        //     {
        //         Transform element = popupElements[i];

        //         
        //         element.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, openProgress);

        //         
        //         element.position = Vector3.Lerp(bookLid.position, targetPositions[i], openProgress);
        //     }
        // if (popupProgress < 1f)
        // {
        //     popupProgress += Time.deltaTime * 60f;
        //     for (int i = 0; i < popupElements.Length; i++)
        //     {
        //         Transform element = popupElements[i];

        //         
        //         // element.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, openProgress);

        //       
        //         // element.position = Vector3.Lerp(bookLid.position, targetPositions[i], openProgress);
        //     }
        //     // popupObject.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, popupProgress);
        // }
        foreach (var element in popupElements)
        {
            popupProgress += Time.deltaTime * 6f;
            element.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, popupProgress);
        }
        // if (booklid1.eulerAngles.x == -179f)
        // {
        //     isOpen = true;

        // }

        // 
        // float currentRotation = bookLid.localRotation.eulerAngles.x;
        // if (currentRotation < 90f)
        // {
        //     bookLid.Rotate(Vector3.right * 50f * Time.deltaTime);

        //    
        //     float openProgress = Mathf.Clamp01(currentRotation / 90f);

        //   
        //     for (int i = 0; i < popupElements.Length; i++)
        //     {
        //         Transform element = popupElements[i];

        // 
        //         element.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, openProgress);

        //
        //         element.position = Vector3.Lerp(bookLid.position, targetPositions[i], openProgress);
        //     }
        // }
        // else
        // {
        //     isOpen = true; // عند الفتح الكامل
        // }
    }
}

