using UnityEngine;
using System.Collections;

public class entity_destroy : MonoBehaviour
{
    public GameObject the_entity;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("wait");
        Destroy(the_entity);
    }
}
