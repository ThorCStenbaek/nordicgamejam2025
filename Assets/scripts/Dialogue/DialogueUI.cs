using UnityEngine;
using TMPro;
using System.Collections;

public class DialogueUI : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public float displayDuration = 3f;

    private Coroutine dialogueRoutine;

    void Awake()
    {
        if (dialogueText != null)
        {
          
        }
    }

    public void ShowDialogue(string message)
    {
        dialogueText.gameObject.SetActive(true);
        if (dialogueRoutine != null)
            StopCoroutine(dialogueRoutine);

        dialogueRoutine = StartCoroutine(ShowDialogueRoutine(message));
    }

    private IEnumerator ShowDialogueRoutine(string message)
    {
        dialogueText.text = message;
        dialogueText.gameObject.SetActive(true);

        yield return new WaitForSeconds(displayDuration);

         dialogueText.text="";
        dialogueRoutine = null;
    }
}
