using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private HashSet<GameObject> portalObjects = new HashSet<GameObject>();
    [SerializeField] private Transform destination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (portalObjects.Contains(collision.gameObject))

        {
            return;
        }
        if (destination.TryGetComponent(out Portal destinationPortal))
        {
            destinationPortal.portalObjects.Add(collision.gameObject);
        }
        collision.transform.position = destination.position;
    }
           private void OnTriggerEnter(Collider collision)
    {
        portalObjects.Remove(collision.gameObject);
    }
}
    
