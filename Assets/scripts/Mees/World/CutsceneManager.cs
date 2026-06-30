using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    [SerializeField] private Image Image;
    [SerializeField] private TMP_Text dialogueText;

    [SerializeField] private Sprite[] CutsceneImage;
    [SerializeField][TextArea] private string[] dialogueWords;
    private int step;


    private void Start()
    {
        Canvas.SetActive(true);
        step = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (step >= CutsceneImage.Length)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("main");
                step = 0;
            }
            else
            {
                Canvas.SetActive(true);
                Image.sprite = CutsceneImage[step];
                dialogueText.text = dialogueWords[step];
                step++;
            }
        }
    }
}
