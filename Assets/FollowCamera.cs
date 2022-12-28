using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject thingToFollow;
    [SerializeField] private Vector3 cameraOffset = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + cameraOffset;
    }
}
