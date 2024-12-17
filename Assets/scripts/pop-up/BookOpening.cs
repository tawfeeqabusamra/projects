using UnityEngine;

public class BookOpenClose : MonoBehaviour
{
    public Transform leftPage1;
    public Transform rightPage1;

    public Transform leftPage;       
    public Transform rightPage;      
    public Transform[] objectsToMove; 
        public Vector3[] objectStartPositions; 
    public Vector3 objectFinalScale = Vector3.one; 

    public float openingSpeed = 90.0f; 
    public float movementSpeed = 1.0f; 
    public float scalingSpeed = 1.0f;  

    private bool isOpening = false;   
    private float currentAngle = 0.0f;
    private float maxAngle = 90.0f; 

    void Start()
    {
        objectStartPositions = new Vector3[objectsToMove.Length];
        for (int i = 0; i < objectsToMove.Length; i++)
        {
            objectStartPositions[i] = objectsToMove[i].localPosition;
        }

       
        leftPage.localRotation = Quaternion.Euler(-90, 0, 0); 
        rightPage.localRotation = Quaternion.Euler(90, 0, 0);

        foreach (var obj in objectsToMove)
        {
            obj.localScale = Vector3.zero;
            obj.localPosition = Vector3.zero; 
        }
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            isOpening = true;
        }

        if (isOpening)
        {
            OpenBookAndRestoreObjects();
        }
    }

    void OpenBookAndRestoreObjects()
    {
        
        if (currentAngle < maxAngle)
        {
            float step = openingSpeed * Time.deltaTime;
            currentAngle += step;

            leftPage.Rotate(Vector3.right, step);
            rightPage.Rotate(Vector3.left, step);

            
            float progress = currentAngle / maxAngle;
            for (int i = 0; i < objectsToMove.Length; i++)
            {
                
                objectsToMove[i].localPosition = Vector3.Lerp(Vector3.zero, objectStartPositions[i], progress);

               
                objectsToMove[i].localScale = Vector3.Lerp(Vector3.zero, objectFinalScale, progress);
            }
        }
        else
        {
            isOpening = false; 
        }
    }
}