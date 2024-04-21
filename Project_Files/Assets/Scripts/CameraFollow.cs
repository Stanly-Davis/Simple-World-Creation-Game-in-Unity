
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object to follow. Drag and drop this object to camera settings

    private void Update()
    {
        // Update the camera's position to be behind the player
        transform.position = target.position - new Vector3(0,-3,3);

        // Update the camera's rotation to 30 degree
        transform.rotation = Quaternion.Euler(30f, 0f, 0f);
    }
}
