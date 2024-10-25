using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePath : MonoBehaviour
{
    [SerializeField]GameObject PathCube;
    [SerializeField]Transform NewCube;

    public static CreatePath instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

}
    private void Start()
    {
        for (int i = 0; i < 35; i++)
        {
            CreatePathCube();
        }
    }
    public void CreatePathCube()
    {
        int randomNumber = Random.Range(0,2);
       
        if (randomNumber == 0)
        {
            Vector3 konum = new Vector3(NewCube.position.x, NewCube.position.y, NewCube.position.z + 1.397484f);
            NewCube = Instantiate(PathCube, konum,Quaternion.identity).transform;
        }
        else
        {
            Vector3 konum = new Vector3(NewCube.position.x + -1.397484f, NewCube.position.y, NewCube.position.z);
            NewCube = Instantiate(PathCube, konum, Quaternion.identity).transform;
        }
    }
}
