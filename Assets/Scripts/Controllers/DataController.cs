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

    public float MIN_FUND_RAISED = 200f; // Range of possible fund raising
    public float MAX_FUND_RAISED = 1200f;

    public int TOTAL_MONTH_NUM = 24; // Total number of month for a gameplay round
    public float MONTH_DURATION = 3f; // Totoal number of seconds for each month
    
    
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
