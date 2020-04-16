using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityLifeTime : MonoBehaviour
{
    public float lifeTime = 1.0f;
    public GameObject entity;
    void Awake()
    {
        Destroy(entity, lifeTime);
        Debug.Log("iam here");
    }
}
