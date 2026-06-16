using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    [SerializeField] private Image Image;

    [SerializeField] private Sprite[] CutsceneImage;
    private int step;

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
                step++;
            }
        }
    }
}
