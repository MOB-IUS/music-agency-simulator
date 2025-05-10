using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    // Member Variables
    private static UIController _instance;
    public static UIController Instance { get { return _instance; } }

    [SerializeField] private TextMeshProUGUI _playerFundText; // Company UI texts
    [SerializeField] private TextMeshProUGUI _playerRevenueText;
    [SerializeField] private TextMeshProUGUI _playerFanNumText;

    [SerializeField] private TextMeshProUGUI _timeLeftText; // Time UI texts
    [SerializeField] private TextMeshProUGUI _currMonthText;
    [SerializeField] private TextMeshProUGUI _monthLeftNumText;
    
    
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
        
    /// <summary>
    /// Update time left in the current month
    /// </summary>
    /// <param name="time"></param>
    public void UpdateTimeLeft(float time)
    {
        _timeLeftText.text = time.ToString("F1");
    }

    /// <summary>
    /// Update current month number and month left number
    /// </summary>
    public void UpdateMonthInfo(int currMonth, int totalMonthsNum)
    {
        _currMonthText.text = currMonth.ToString();
        _monthLeftNumText.text = (totalMonthsNum - currMonth).ToString();
    }
    
    /// <summary>
    /// Update Company UI Info
    /// </summary>
    public void UpdateCompanyInfo(float fund, float revenue, int fanNum)
    {
        _playerFundText.text = fund.ToString("F1");
        _playerRevenueText.text = revenue.ToString("F1");
        _playerFanNumText.text = fanNum.ToString();
    }
}
