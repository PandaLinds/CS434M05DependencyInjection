using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeslaEngine : IEngine
{
    // Start is called before the first frame update
    public void StartEngine()
    {
        PushToStart();
        Debug.Log("Engine started");
    }

    private void PushToStart()
    {
        Debug.Log("Start button has been pushed");
    }
}
