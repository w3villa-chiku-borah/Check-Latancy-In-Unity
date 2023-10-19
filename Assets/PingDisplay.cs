using UnityEngine;
using System.Collections;
using TMPro;
public class LatencyMeasurement : MonoBehaviour
{
    public TextMeshProUGUI latencyText;
    public string serverAddress = "example.com"; 

    private void Start()
    {
        StartCoroutine(MeasureLatency());
    }

    private IEnumerator MeasureLatency()
    {
        while (true)
        {
            Ping ping = new Ping(serverAddress);
            yield return new WaitForSeconds(1f);

            if (ping.isDone)
            {
               
                latencyText.text = "Latency: " + ping.time + " ms";
            }
            else
            {
                latencyText.text = "not responding";
            }
        }
    }
}



