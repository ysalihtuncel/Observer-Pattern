using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public Observer<int> Health = new Observer<int>(100);
    public static event Action<int> OnAnyCollected;

    // Start is called before the first frame update
    void Start()
    {
        Health.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Health.Value += 10;
        }
    }

    public void UpdateScore(int points)
    {
        OnAnyCollected?.Invoke(points);
    }
}
