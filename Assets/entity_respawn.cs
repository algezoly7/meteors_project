﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entity_respawn : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Prefab;
    void OnTriggerEnter()
    {
        Instantiate(Prefab, SpawnPoint.position, SpawnPoint.rotation);
    }
}
