using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    [SerializeField]private TransformData TD;

    public  static float BallMoveSpeed = 7;

    private void Awake()
    {
        TD = GetComponent<TransformData>();
    }

    private void Update()
    {
        SettransformDirection();
    }

    private void SettransformDirection()
    {
        transform.position += TD.GetPositionDirection() * BallMoveSpeed * Time.deltaTime;
    }
}
