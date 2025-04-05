using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour
{
    [Header("Lights to Control")]
    public Light[] lights;

    [Header("Flicker Settings")]
    public bool flickerOnStart = false;
    public float minFlickerInterval = 0.05f;
    public float maxFlickerInterval = 0.3f;

    [Header("Initial State")]
    public bool startOn = true;

    private Coroutine flickerRoutine;
    private bool isFlickering = false;

    void Start()
    {
        SetLights(startOn);

        if (flickerOnStart)
        {
            StartFlickering();
        }
    }

    // Turn lights on or off
    public void SetLights(bool on)
    {
        foreach (var light in lights)
        {
            light.enabled = on;
        }
    }

    // Toggle lights
    public void ToggleLights()
    {
        bool currentlyOn = lights.Length > 0 && lights[0].enabled;
        SetLights(!currentlyOn);
    }

    // Flicker control
    public void StartFlickering()
    {
        if (flickerRoutine == null)
        {
            flickerRoutine = StartCoroutine(Flicker());
            isFlickering = true;
        }
    }

    public void StopFlickering()
    {
        if (flickerRoutine != null)
        {
            StopCoroutine(flickerRoutine);
            flickerRoutine = null;
        }

        isFlickering = false;
        SetLights(true); // Leave lights on after flicker stops
    }

    public void ToggleFlicker()
    {
        if (isFlickering)
        {
            StopFlickering();
        }
        else
        {
            StartFlickering();
        }
    }

    // 🆕 Toggle between fully off and flickering on
    public void ToggleOnOffAndFlicker()
    {
        if (isFlickering || (lights.Length > 0 && lights[0].enabled))
        {
            // Turn off and stop flickering
            StopFlickering();
            SetLights(false);
        }
        else
        {
            // Turn on and start flickering
            StartFlickering();
        }
    }

    // The flickering logic
    private IEnumerator Flicker()
    {
        while (true)
        {
            bool newState = Random.value > 0.5f;
            SetLights(newState);
            float waitTime = Random.Range(minFlickerInterval, maxFlickerInterval);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
