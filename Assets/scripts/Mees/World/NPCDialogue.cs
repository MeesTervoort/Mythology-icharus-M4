using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    //UI References
    [SerializeField] private GameObject Canvas;
    [SerializeField] private GameObject InteractArrow;
    [SerializeField] private TMP_Text speakerText;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private Image portaitImage;

    //Dialogue content
    [SerializeField] private string[] speaker;
    [SerializeField][TextArea] private string[] dialogueWords;
    [SerializeField] private Sprite[] portait;

    private bool dialogueActive;
    private int step;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && dialogueActive)
        {
            if(step >= dialogueWords.Length)
            {
                Canvas.SetActive(false);
                step = 0;
            }
            else
            {
                Canvas.SetActive(true);
                speakerText.text = speaker[step];
                dialogueText.text = dialogueWords[step];
                portaitImage.sprite = portait[step];
                step++;
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InteractArrow.SetActive(true);
            dialogueActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dialogueActive = false;
            InteractArrow.SetActive(false);
            Canvas.SetActive(false);
        }
    }
}