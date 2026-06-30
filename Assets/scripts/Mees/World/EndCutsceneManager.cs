using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndCutsceneManager : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    [SerializeField] private GameObject Cover;
    [SerializeField] private Image Image;
    [SerializeField] private TMP_Text dialogueText;

    [SerializeField] private Sprite[] CutsceneImage;
    [SerializeField][TextArea] private string[] dialogueWords;
    private int step;

    private void Start()
    {
        Canvas.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (step >= CutsceneImage.Length)
            {
                step = 0;
            }
            else
            {
                Cover.SetActive(false);
                Canvas.SetActive(true);
                Image.sprite = CutsceneImage[step];
                dialogueText.text = dialogueWords[step];
                step++;
            }
        }
    }
}
