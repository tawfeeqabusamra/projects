using UnityEngine;

public class PageFlipping : MonoBehaviour
{
    public GameObject[] papers;
    private float targetRotationAngle = -180f;
    private float rotationSpeed = 180f;
    private bool[] isFlipping;
    private float[] currentRotation;

    void Start()
    {
        isFlipping = new bool[papers.Length];
        currentRotation = new float[papers.Length];

        for (int i = 0; i < papers.Length; i++)
        {
            isFlipping[i] = false;
            currentRotation[i] = 0f;
        }
    }

    void Update()
    {
        if (papers == null || papers.Length == 0)
        {
            Debug.LogError("No papers assigned to the array.");
            return;
        }

        for (int i = 0; i < papers.Length; i++)
        {
            papers[i].transform.position = new Vector3(-1.569f, 0f, papers[i].transform.position.z);

            if (Input.GetKeyDown(KeyCode.RightArrow) && !isFlipping[i])
            {
                targetRotationAngle = -180f;
                isFlipping[i] = true;
                currentRotation[i] = 0f;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) && !isFlipping[i])
            {
                targetRotationAngle = 0f;
                isFlipping[i] = true;
                currentRotation[i] = -180f;
            }

            if (isFlipping[i])
            {
                currentRotation[i] = Mathf.MoveTowards(currentRotation[i], targetRotationAngle, rotationSpeed * Time.deltaTime);
                papers[i].transform.rotation = Quaternion.Euler(0f, 0f, currentRotation[i]);

                if (Mathf.Approximately(currentRotation[i], targetRotationAngle))
                {
                    isFlipping[i] = false;
                }
            }
        }
    }
}