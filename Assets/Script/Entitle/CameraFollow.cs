using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Target;

    private Transform thisTransform;
    private Transform targetTransform;

    void Start()
    {
        thisTransform = transform;
        targetTransform = Target.transform;
    }

    void Update()
    {
        Vector3 targetPosition = new Vector3(targetTransform.position.x, targetTransform.position.y, thisTransform.position.z);
        thisTransform.position = targetPosition;
    }
}
