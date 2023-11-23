using UnityEngine;

public class DynamicLODAdjuster : MonoBehaviour
{
    private LODDistanceManager lodDistanceManager;
    private VolumeCategoryManager volumeCategoryManager;

    // Assume these are set or calculated based on performance metrics
    public float performanceFactor = 1.0f; 

    private void Start()
    {
        lodDistanceManager = FindObjectOfType<LODDistanceManager>();
        volumeCategoryManager = FindObjectOfType<VolumeCategoryManager>();
    }

    public float GetAdjustedLODDistance(float volume)
    {
        var category = volumeCategoryManager.GetVolumeCategory(volume);
        float baseDistance = lodDistanceManager.GetLODDistance(category);
        return baseDistance * performanceFactor; // Adjust based on performance
    }
}