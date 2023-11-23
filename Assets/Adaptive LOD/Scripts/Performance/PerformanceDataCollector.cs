using UnityEngine;
using System;

public class PerformanceDataCollector : MonoBehaviour
{
    public float currentFPS;
    public float memoryUsage;
    public Action<float> OnFPSUpdate;

    private void Update()
    {
        currentFPS = 1.0f / Time.deltaTime;
        memoryUsage = System.GC.GetTotalMemory(false) / 1024f / 1024f;

        OnFPSUpdate?.Invoke(currentFPS);
    }
}