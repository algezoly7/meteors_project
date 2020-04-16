using UnityEngine;
using System.Collections;

public class explosion_disappear : MonoBehaviour
{
    public GameObject the_explosion;

    IEnumerator OnTriggerEnter()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("wait");
        Destroy(the_explosion);
    }

}
