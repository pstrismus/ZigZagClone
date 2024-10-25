using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDataController : MonoBehaviour
{

    public Vector3 Direction;

    private void Start()
    {
        Direction = Vector3.forward;
    }

    private void Update()
    {
       if (Input.GetMouseButtonDown(0) && ChangeScore.instance != null)
       {
            TransformController.BallMoveSpeed += 0.005f;
            ChangeScore.instance.PathColorChangeControl();
            SetDataDirection();
            ChangeScore.instance.ChangeScor(1);
       }
    }

    private void SetDataDirection()
    {
        if (Direction.x == -1)
        {
            Direction = Vector3.forward;
        }
        else
        {
            Direction = Vector3.left;
        }
    }

}
