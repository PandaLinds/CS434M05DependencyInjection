using UnityEngine;

public class OrganicFryOilEngine : IEngine
{
    public void StartEngine()
    {
        FillWithRestrauntOil();
        Debug.Log("Engine started");
    }

    private void FillWithRestrauntOil()
    {
        Debug.Log("The engine is filled with used frying oil");
    }
}