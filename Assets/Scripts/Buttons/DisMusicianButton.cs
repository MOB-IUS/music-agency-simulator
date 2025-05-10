using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisMusicianButton : MonoBehaviour
{
    // Button click function to perform player discover musician action
    public void OnClick()
    {
        PlayerController.Instance.DiscoverMusician();
    }
}
