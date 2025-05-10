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

    private int _totalMonthNum;
    private float _monthDuration;
    private int _currMonthNum;
    private float _currTime;
    
    
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
        _monthDuration = DataController.Instance.MONTH_DURATION;
        _totalMonthNum = DataController.Instance.TOTAL_MONTH_NUM;
        _currTime = _monthDuration;
        _currMonthNum = 1;
        Debug.Log(DataController.Instance.MONTH_DURATION);
        Debug.Log(_monthDuration);
    }
    
    // Start
    private void Start()
    {
        // Update time UI info
        UIController.Instance.UpdateTimeLeft(_currTime);
        UIController.Instance.UpdateMonthInfo(_currMonthNum, _totalMonthNum);
    }

    // Update
    private void Update()
    {
        // Update current time
        _currTime -= Time.deltaTime;
        UIController.Instance.UpdateTimeLeft(_currTime);
        
        // Check whether current month ends
        if (_currTime <= 0) // Month ends
        {
            _currTime = _monthDuration;
            _currMonthNum += 1;
            
            // Check whether game ends
            if (_currMonthNum > _totalMonthNum) // Game ends
            {
                Debug.Log("Game End !!!");
            }
            else // Game doesn't end
            {
                UIController.Instance.UpdateTimeLeft(_currTime);
                UIController.Instance.UpdateMonthInfo(_currMonthNum, _totalMonthNum);
            }
        }
    }
}
