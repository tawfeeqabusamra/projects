using UnityEngine;

public class PopupBook : MonoBehaviour
{
    public Transform rightPage;
    public Transform leftPage; 
    public Transform[] popUpObjects;
    public float openSpeed = 2f;
    public float scaleSpeed = 2f;
    bool isOpening = false;
    bool isClosing = false;
    bool isScaling = false;
    Vector3[] initialScales;
    Quaternion closedRotation;
    Quaternion openRotation;

    void Start()
    {

        openRotation = Quaternion.Euler(0, 0, 0);
        closedRotation = Quaternion.Euler(180, 0, 0); 
        rightPage.rotation = closedRotation; 

        initialScales = new Vector3[popUpObjects.Length];
        for (int i = 0; i < popUpObjects.Length; i++)
        {
            initialScales[i] = popUpObjects[i].localScale;
            popUpObjects[i].localScale = Vector3.zero;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isOpening && !isClosing)
            {
                isOpening = true;
            }
            else if (!isClosing)
            {
                isClosing = true;
            }
        }

        if (isOpening)
        {
            OpenBook();
            ScaleObjects(Vector3.one);
        }

        if (isClosing)
        {
            CloseBook();
        }
    }

    void OpenBook()
    {
        rightPage.rotation = Quaternion.Lerp(rightPage.rotation, openRotation, Time.deltaTime * openSpeed);
        if (Quaternion.Angle(rightPage.rotation, openRotation) < 1f)
        {
            isOpening = false;
            isScaling = true;
        }
    }

    void CloseBook()
    {
        rightPage.rotation = Quaternion.Lerp(rightPage.rotation, closedRotation, Time.deltaTime * openSpeed);
        ScaleObjects(Vector3.zero);
        if (Quaternion.Angle(rightPage.rotation, closedRotation) < 1f)
        {
            isClosing = false;
            isScaling = false;
        }
    }

    void ScaleObjects(Vector3 targetScale)
    {
        for (int i = 0; i < popUpObjects.Length; i++)
        {
            popUpObjects[i].localScale = Vector3.Lerp(popUpObjects[i].localScale, targetScale, Time.deltaTime * scaleSpeed);
        }
    }
}