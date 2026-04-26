using System.Collections;
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEngine;


public class PlayerRespawn : MonoBehaviour
{
    private Vector3 currentCheckpoint;
    [SerializeField] float fallPoint = -20f;
    public Lava lava;
    private void Start()
    {
        currentCheckpoint = transform.position;
    }

    private void Update()
    {
        if (transform.position.y <= fallPoint)
        {
            Respawn();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            currentCheckpoint = other.transform.position;
        }
    }
    public void Respawn()
    {
        transform.position = currentCheckpoint;
        lava.StopLava();
    }
}
