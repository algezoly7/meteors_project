using UnityEngine;

public class meteor_disappear : MonoBehaviour
{
    public GameObject the_meteor;
    void OnTriggerEnter()
    {
        Destroy(the_meteor);
    }
}
