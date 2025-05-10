using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseFundButton : MonoBehaviour
{
    // Button click function to perform player raise fund action
    public void OnClick()
    {
        PlayerController.Instance.RaiseFund();
    }
}
