using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [Header("Sound Settings")]
    public AudioClip clip;           // Drag your audio file here
    [Range(0f, 1f)] public float volume = 1f;

    private AudioSource audioSource;

    void Awake()
    {
        // Get or add an AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // Call this to play the assigned sound
    public void Play()
    {
        if (clip == null)
        {
            Debug.LogWarning("PlaySound: No AudioClip assigned!");
            return;
        }

        audioSource.clip = clip;
        audioSource.volume = volume;
        audioSource.Play();
    }

    // Optional: Play a different clip on demand
    public void PlayOneShot(AudioClip customClip, float customVolume = 1f)
    {
        if (customClip == null)
        {
            Debug.LogWarning("PlaySound: No custom AudioClip provided!");
            return;
        }

        audioSource.PlayOneShot(customClip, customVolume);
    }
}
