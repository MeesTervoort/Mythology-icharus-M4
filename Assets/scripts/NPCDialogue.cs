using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public List<string> DialogueLines = new List<string>();

    private GameObject DialogueBox;
    private TextMeshProUGUI DialogueText;
    public GameObject InteractArrow;

    private int currentline = 0;
    private bool playerInRange = false;
    private bool talking = false;
    void Start()
    {
        DialogueBox = GameObject.FindWithTag("DialogueBox");
        DialogueText = GameObject.FindWithTag("DialogueText").GetComponent<TextMeshProUGUI>();

        DialogueBox.SetActive(false);
    }

    void Update()
    {

        if (!playerInRange)
        {
            InteractArrow.SetActive(false);
            EndDialogue();
        }
        else
        {
            InteractArrow.SetActive(true);
        }

        if (playerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            if (!talking)
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

        DialogueBox.SetActive(true);
        DialogueText.text = DialogueLines[currentline];
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
            DialogueText.text = DialogueLines[currentline];
        }

    }
    void EndDialogue()
    { 
       talking = false;
       DialogueBox.SetActive(false);
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
