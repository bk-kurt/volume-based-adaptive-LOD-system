using UnityEngine;

public class PerformanceBasedLODAdjuster : MonoBehaviour
{
    public DynamicLODAdjuster dynamicLODAdjuster;
    public PerformanceDataCollector dataCollector;

    private void Start()
    {
        dataCollector.OnFPSUpdate += AdjustLODBasedOnFPS;
    }

    private void AdjustLODBasedOnFPS(float fps)
    {
        if (fps < 30)
        {
            dynamicLODAdjuster.performanceFactor = 0.5f; // Lower LOD quality to improve performance
        }
        else
        {
            dynamicLODAdjuster.performanceFactor = 1f; // Restore LOD quality
        }
    }

    private void OnDestroy()
    {
        dataCollector.OnFPSUpdate -= AdjustLODBasedOnFPS;
    }
}