using UnityEngine;
using UnityEngine.UI;

public class PerformanceFeedbackUI : MonoBehaviour
{
    public PerformanceDataCollector dataCollector;
    public Text fpsText;
    public Text memoryText;

    private void Update()
    {
        fpsText.text = "FPS: " + dataCollector.currentFPS.ToString("F2");
        memoryText.text = "Memory: " + dataCollector.memoryUsage.ToString("F2") + " MB";
    }
}