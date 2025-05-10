using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    // Member Variables
    private static EventController _instance;
    public static EventController Instance { get { return _instance; } }

    // Delegates
    public delegate void EmptyDelegate();
    
    // Events
    public event EmptyDelegate TryRaiseFund;
    public event EmptyDelegate TryDiscoverMusician;
    
    // Events Invokers
    public void InvokeTryRaiseFund() { TryRaiseFund?.Invoke(); }
    public void InvokeTryDiscoverMusician() { TryDiscoverMusician?.Invoke(); }
    
    
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
}
