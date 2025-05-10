using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DataController : MonoBehaviour
{
    // Member Variables
    private static DataController _instance;
    public static DataController Instance { get { return _instance; } }

    public float INITIAL_FUND = 1000; // Initial player fund
    public float INITIAL_FUND_RAISING_RATE = 0.1f; // Initial fund raising success rate
    public float INITIAL_DISCOVER_MUSICIAN_RATE = 0.05f; // Initial discover musician success rate

    public float minFundRaised = 200f; // Range of possible fund raising
    public float maxFundRaised = 1200f;
    
    
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
