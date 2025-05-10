using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameController : MonoBehaviour
{
    // Member Variables
    private static GameController _instance;
    public static GameController Instance { get { return _instance; } }

    private float _monthDuration = 10f;
    private float _currTime = 0;
    
    
    // Awake
    private void Awake()
    {
        // Singleton
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        
        // Initialization
        _instance = this;
    }

    // Update
    private void Update()
    {
        
    }
}
