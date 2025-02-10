using UnityEngine;

public class CameraMovment : MonoBehaviour 
{ 
    public float sensitivity = 2.0f; 
    public float moveSpeed = 5.0f; 
    public float verticalSpeed = 2.0f; 
    public float smoothTime = 0.1f; 
 
    private float rotationX = 0f; 
    private float rotationY = 0f; 
    private float smoothVelocityX; 
    private float smoothVelocityY; 
 
    void Update() 
    { 
        if (Input.GetMouseButton(0)) 
        { 
            MouseLook(); 
        } 
 
        MoveCamera(); 
    } 
 
    void MouseLook() 
    { 
        float mouseX = Input.GetAxis("Mouse X") * sensitivity; 
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity; 
 
        rotationY += mouseX; 
        rotationX -= mouseY; 
 
        rotationX = Mathf.Clamp(rotationX, -80f, 80f); 
 
        float smoothedX = Mathf.SmoothDampAngle(transform.eulerAngles.x, rotationX, ref smoothVelocityX, smoothTime); 
        float smoothedY = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotationY, ref smoothVelocityY, smoothTime); 
 
        transform.rotation = Quaternion.Euler(smoothedX, smoothedY, 0); 
    } 
 
    void MoveCamera() 
    { 
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; 
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; 
 
        float upDown = 0; 
        if (Input.GetKey(KeyCode.Q)) upDown = -verticalSpeed * Time.deltaTime; 
        if (Input.GetKey(KeyCode.E)) upDown = verticalSpeed * Time.deltaTime; 
 
        transform.Translate(horizontal, upDown, vertical); 
    } 
}