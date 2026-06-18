using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UIElements;

public class NPCDialogue : MonoBehaviour
{
    //UI References
    [SerializeField] private GameObject InteractArrow;
    [SerializeField] private TMP_Text speakerText;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private Image portaitImage;

    //Dialogue content
    [SerializeField] private string[] speaker;
    [SerializeField] private string[] dialogueWords;
    [SerializeField] private Sprite portait;


    private bool dialogueActive;
    private int step;

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

    private void OnTriggerEnter(Collider other)
    {

    }

    void Update()

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







    //public List<string> DialogueLines = new List<string>();

    //private GameObject DialogueBox;
    //private TextMeshProUGUI DialogueText;



    //private int currentline = 0;
    //private bool playerInRange = false;
    //private bool talking = false;

    //void Start()
    //{
    //    DialogueBox = GameObject.FindWithTag("DialogueBox");
    //    DialogueText = GameObject.FindWithTag("DialogueText").GetComponent<TextMeshProUGUI>();

    //    DialogueBox.SetActive(false);
    //}

    //void Update()
    //{

    //    if (!playerInRange)
    //    {
    //        InteractArrow.SetActive(false);
    //        EndDialogue();
    //    }
    //    else
    //    {
    //        InteractArrow.SetActive(true);
    //    }

    //    if (playerInRange && Input.GetKeyDown(KeyCode.E))
    //    {
    //        if (!talking)
    //        {
    //            StartDialogue();
    //        }
    //        else
    //        {
    //            NextLine();
    //        }
    //    }
    //}

    //void StartDialogue()
    //{
    //    talking = true;
    //    currentline = 0;

    //    DialogueBox.SetActive(true);
    //    DialogueText.text = DialogueLines[currentline];
    //}

    //void NextLine()
    //{
    //    currentline++;

    //    if (currentline >= DialogueLines.Count)
    //    {
    //        EndDialogue();
    //    }
    //    else
    //    {
    //        DialogueText.text = DialogueLines[currentline];
    //    }

    //}
    //void EndDialogue()
    //{ 
    //   talking = false;
    //   DialogueBox.SetActive(false);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        playerInRange = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        playerInRange = false;
    //    } 
    //}
=======
        if (!playerInRange)
        {
            InteractArrow.SetActive(false);
            EndDialogue();
        }
        else
        {
            InteractArrow.SetActive(true);
        }

        if (playerInRange && Input.GetKeyDown(KeyCode.E))
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
>>>>>>> parent of b716d37 (Merge branch 'Mees' into Pascal)
=======
        if (!playerInRange)
        {
            InteractArrow.SetActive(false);
            EndDialogue();
        }
        else
        {
            InteractArrow.SetActive(true);
        }

        if (playerInRange && Input.GetKeyDown(KeyCode.E))
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
>>>>>>> parent of b716d37 (Merge branch 'Mees' into Pascal)
=======
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

        if (playerInRange && Input.GetKeyDown(KeyCode.E))
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
>>>>>>> parent of b716d37 (Merge branch 'Mees' into Pascal)
