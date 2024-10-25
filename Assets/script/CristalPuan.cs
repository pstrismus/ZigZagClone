using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalPuan : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ChangeScore.instance.PathColorChangeControl();
        ChangeScore.instance.ChangeScor(2);
        Destroy(gameObject);
    }
}
