using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public List<string> DialogueLines = new List<string>();

    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;

    private int currentline = 0;
    private bool playerInRange = false;
    private bool talking = false;
    void Start()
    {
        dialogueBox = GameObject.FindWithTag("dialogueBox");
        dialogueText = GameObject.FindWithTag("dialogueText").GetComponent<TextMeshProUGUI>();

        dialogueBox.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            if (talking)
            {
                StartDialogue();
            }
            else
            {
                NextLine();
            }
        }

    }

    void StartDialogue()
    {
        talking = true;
        currentline = 0;

        dialogueBox.SetActive(true);
        dialogueText.text = DialogueLines[currentline];
    }

    void NextLine()
    {
        currentline++;

        if (currentline >= DialogueLines.Count)
        {
            EndDialogue();
        }
        else
        {
            dialogueText.text = DialogueLines[currentline];
        }

        void EndDialogue()
        {
            talking = false;
            dialogueBox.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
