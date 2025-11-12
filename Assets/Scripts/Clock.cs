using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Update()
    {
        var now = DateTime.Now;
        var time = now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(0, 0, hourDegrees(time.TotalHours));
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minuteDegrees(time.TotalMinutes));
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondDegrees(now.Second));
    }

    static float hourDegrees(double hour)
    {
        return -30 * (float)hour;
    }

    static float minuteDegrees(double minute)
    {
        return -6 * (float)minute;
    }

    static float secondDegrees(double second)
    {
        return -6 * (float)second;
    }
}
