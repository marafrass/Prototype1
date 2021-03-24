using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuResetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CheckPointData.checkpointNumber = 0;
        Debug.Log("set checkpoint number to" + CheckPointData.checkpointNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
