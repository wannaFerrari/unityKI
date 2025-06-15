using UnityEngine;

public class TimeScaleTest : MonoBehaviour
{
    [Range(0.001f,100f)]
    public float timeScale;


    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScale;
    }
}
