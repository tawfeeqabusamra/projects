using UnityEngine;

public class PopUpEffect : MonoBehaviour
{
    public GameObject[] scenes;
    public float scaleSpeed = 1.0f;
    public Vector3 targetScale = new Vector3(1f, 1f, 1f);

    private int currentSceneIndex = -1;
    private bool isScalingUp = false;
    private bool isScalingDown = false;
    private Vector3 originalScale;
    private bool goingForward = true; // Determines the direction (true = forward, false = backward)

    void Start()
    {
        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i].transform.localScale = Vector3.zero;
            scenes[i].SetActive(false);
        }
    }

    void Update()
    {
        if (scenes == null || scenes.Length == 0)
        {
            Debug.LogError("No scenes assigned to the array.");
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentSceneIndex == -1)
            {
                currentSceneIndex = 0;
                scenes[currentSceneIndex].SetActive(true);
                isScalingUp = true;
                originalScale = scenes[currentSceneIndex].transform.localScale;
            }
            else if (currentSceneIndex < scenes.Length - 1)
            {
                isScalingDown = true;
                goingForward = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentSceneIndex > 0)
            {
                isScalingDown = true;
                goingForward = false;
            }
        }

        if (isScalingUp)
        {
            scenes[currentSceneIndex].transform.localScale = Vector3.Lerp(scenes[currentSceneIndex].transform.localScale, targetScale, scaleSpeed * Time.deltaTime);

            if (Vector3.Distance(scenes[currentSceneIndex].transform.localScale, targetScale) < 0.01f)
            {
                scenes[currentSceneIndex].transform.localScale = targetScale;
                isScalingUp = false;
            }
        }

        if (isScalingDown)
        {
            scenes[currentSceneIndex].transform.localScale = Vector3.Lerp(scenes[currentSceneIndex].transform.localScale, Vector3.zero, scaleSpeed * Time.deltaTime);

            if (Vector3.Distance(scenes[currentSceneIndex].transform.localScale, Vector3.zero) < 0.01f)
            {
                scenes[currentSceneIndex].transform.localScale = Vector3.zero;
                scenes[currentSceneIndex].SetActive(false);

                if (goingForward && currentSceneIndex < scenes.Length - 1)
                {
                    currentSceneIndex++;
                }
                else if (!goingForward && currentSceneIndex > 0)
                {
                    currentSceneIndex--;
                }

                scenes[currentSceneIndex].SetActive(true);
                isScalingUp = true;
                isScalingDown = false;
                originalScale = scenes[currentSceneIndex].transform.localScale;
            }
        }
    }
}