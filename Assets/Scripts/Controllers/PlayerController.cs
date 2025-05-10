using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Member Variables
    private static PlayerController _instance;
    public static PlayerController Instance { get { return _instance; } }

    private float _fund; // Total player fund
    private float _monthlyRevenue; // Player monthly revenue
    private int _fanNum; // Number of player's total fan
    private float _fundRaisingRate; // Player fund raising success rate
    private float _discoverMusicianRate; // Player discover musician success rate

    private int _chanceBooster = 1;
    
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
        _fund = DataController.Instance.INITIAL_FUND;
        _fundRaisingRate = DataController.Instance.INITIAL_FUND_RAISING_RATE;
        _discoverMusicianRate = DataController.Instance.INITIAL_DISCOVER_MUSICIAN_RATE;
    }
    
    // Start
    private void Start()
    {
        // Update every UI info
        UIController.Instance.UpdateCompanyInfo(_fund, _monthlyRevenue, _fanNum);
    }

    /// <summary>
    /// Check to raise fund with 
    /// </summary>
    public void RaiseFund()
    {
        // Check whether successfully raise fund
        float check = UnityEngine.Random.Range(0f, 1f) * _chanceBooster;
        
        if (check > (1 - _fundRaisingRate)) // Success in fund raising action
        {
            _fund += UnityEngine.Random.Range(DataController.Instance.MIN_FUND_RAISED, DataController.Instance.MAX_FUND_RAISED);
            UIController.Instance.UpdateCompanyInfo(_fund, _monthlyRevenue, _fanNum);
        }
    }

    /// <summary>
    /// Check to discover musicians
    /// </summary>
    public void DiscoverMusician()
    {
        // Check whether successfully discover musician
        float check = UnityEngine.Random.Range(0f, 1f) * _chanceBooster;
        Debug.Log(check.ToString("F2"));

        if (check > (1 - _discoverMusicianRate)) // Success in discovering new musician
        {
            Debug.Log("Discovered musician");
        }
    }
}






















