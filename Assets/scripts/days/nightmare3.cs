using UnityEngine;

public class nightmare3 : MonoBehaviour
{
    public QuestMaker questMaker;
    public AudioClip startOfDayClip; // Assign this in Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Play audio
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null && startOfDayClip != null)
        {
            audioSource.clip = startOfDayClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Missing AudioSource or AudioClip on afternoon1");
        }

        // Start quest logic
        if (questMaker != null)
        {
            questMaker.Nightmare3();
        }
        else
        {
            Debug.LogWarning("QuestMaker not assigned to afternoon1 script.");
        }
    }
}
