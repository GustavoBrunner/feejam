using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Light))]
public class FlickLight : MonoBehaviour
{
    private Light lightToFlick;
    [SerializeField, Range(0.0f, 3.0f)] private float minIntensity = 0.5f;
    [SerializeField, Range(0.0f, 3.0f)] private float maxIntensity = 1.2f;
    [SerializeField, Min(0f)] private float timeBetweenIntensity = 0.1f;

    private float currentTimer;

    private void Awake()
    {
        if (lightToFlick == null)
        {
            lightToFlick = GetComponent<Light>();
        }

        ValidateIntensityBounds();
    }

    private void Update()
    {
        currentTimer += Time.deltaTime;
        if (!(currentTimer > timeBetweenIntensity)) return;
        lightToFlick.intensity = Random.Range(minIntensity, maxIntensity);
        currentTimer = 0;
    }

    private void ValidateIntensityBounds()
    {
        if (!(minIntensity > maxIntensity))
            return;
    }
}
