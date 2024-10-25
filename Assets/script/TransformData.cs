using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformData : MonoBehaviour
{
    [SerializeField]TransformDataController TDC;

    public Vector3 GetPositionDirection()
    {
        return TDC.Direction;
    }

}
