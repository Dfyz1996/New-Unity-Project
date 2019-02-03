using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }
}
