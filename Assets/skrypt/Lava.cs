using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    [SerializeField] float growthSpeed = 0.8f;
    Vector3 startScale, startPosition;
    // Odniesienie do skryptu PlayerRespawn
    PlayerRespawn respawn;
    bool isRising = false;
    void Start()
    {
        startScale = transform.localScale;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
