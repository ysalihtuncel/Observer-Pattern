using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] int points = 10;

    //public delegate void Notify(int points);
    //public static event Notify OnAnyCollected;
    public static event Action<int> OnAnyCollected;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnAnyCollected?.Invoke(points);
            gameObject.SetActive(false);
        }
    }
    
}
