using UnityEngine;
using System.Collections.Generic;

public class VolumeCategoryManager : MonoBehaviour
{
    public enum VolumeCategory { Small, Medium, Large }

    [System.Serializable]
    public class VolumeThreshold
    {
        public VolumeCategory category;
        public float minVolume;
    }

    public List<VolumeThreshold> volumeThresholds;

    public VolumeCategory GetVolumeCategory(float volume)
    {
        foreach (var threshold in volumeThresholds)
        {
            if (volume >= threshold.minVolume)
                return threshold.category;
        }
        return VolumeCategory.Small;
    }
}