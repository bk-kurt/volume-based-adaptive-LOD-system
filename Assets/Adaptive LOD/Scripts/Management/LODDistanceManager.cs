using UnityEngine;
using System.Collections.Generic;

public class LODDistanceManager : MonoBehaviour
{
    [System.Serializable]
    public class LODDistanceSettings
    {
        public VolumeCategoryManager.VolumeCategory category;
        public float baseLODDistance;
    }

    public List<LODDistanceSettings> lodDistanceSettings;

    public float GetLODDistance(VolumeCategoryManager.VolumeCategory category)
    {
        foreach (var setting in lodDistanceSettings)
        {
            if (setting.category == category)
                return setting.baseLODDistance;
        }
        return 0f;
    }
}