using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    // Member Variables
    private static UIController _instance;
    public static UIController Instance { get { return _instance; } }

    [SerializeField] private TextMeshProUGUI _playerFundText;
    [SerializeField] private TextMeshProUGUI _playerRevenueText;
    [SerializeField] private TextMeshProUGUI _playerFanNumText;
    
    
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
    /// Update Company UI Info
    /// </summary>
    public void UpdateCompanyInfo(float fund, float revenue, int fanNum)
    {
        _playerFundText.text = fund.ToString("F2");
        _playerRevenueText.text = revenue.ToString("F2");
        _playerFanNumText.text = fanNum.ToString("F2");
    }
}
