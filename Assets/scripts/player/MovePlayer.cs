using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour
{
    private GameObject player;
    private ScreenFader screenFader;

    public float fadeDelay = 0.1f; // Optional delay after fade before moving

    void Awake()
    {
        player = GameObject.FindWithTag("Player");

        GameObject faderObject = GameObject.FindWithTag("ScreenFader");
        if (faderObject != null)
        {
            screenFader = faderObject.GetComponent<ScreenFader>();
        }

        if (player == null)
        {
            Debug.LogWarning("No GameObject tagged 'Player' found in the scene.");
        }

        if (screenFader == null)
        {
            Debug.LogWarning("No GameObject tagged 'ScreenFader' or missing ScreenFader component.");
        }
    }

    public void MoveWithFade()
    {
        if (player != null && screenFader != null)
        {
            StartCoroutine(FadeAndMove());
        }
    }

    private IEnumerator FadeAndMove()
    {
        screenFader.FadeToBlack();

        yield return new WaitForSeconds(screenFader.fadeDuration + fadeDelay);

        player.transform.position = transform.position;
        player.transform.rotation = transform.rotation;

        screenFader.FadeFromBlack();
    }


    public void Move()
    {
        if (player != null)
        {
            player.transform.position = transform.position;
            player.transform.rotation = transform.rotation; // Optional: match rotation
        }
    }

}
