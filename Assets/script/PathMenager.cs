using UnityEngine;
using System.Collections;
public class PathMenager : MonoBehaviour
{
    [SerializeField]GameObject CristalPoint;
    [SerializeField] float time;
    [System.Obsolete]
    private void OnEnable()
    {
        if (CristalPoint!=null)
        {
            int RandomCreate = Random.RandomRange(0, 11);
            if (RandomCreate == 0)
            {
                Vector3 konum = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
                GameObject Kristal = Instantiate(CristalPoint, konum, Quaternion.identity);
                Kristal.transform.parent = gameObject.transform;


            }
        }
       
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CreatePath.instance.CreatePathCube();

            StartCoroutine(destroyer(time));            

        }
    }

    private IEnumerator destroyer(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Rigidbody>().isKinematic = false;

        Destroy(gameObject,2.5f);
    }
}
