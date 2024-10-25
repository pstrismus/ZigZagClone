using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform Target;

    Vector3 offset;

    Vector3 NewPosition;

    [SerializeField]float lerpValue;
    void Start()
    {
        offset = transform.position - Target.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        Vector3 newTransform = Vector3.Lerp(transform.position, Target.position + offset, lerpValue * Time.deltaTime);
        transform.position = newTransform;

    }
}
