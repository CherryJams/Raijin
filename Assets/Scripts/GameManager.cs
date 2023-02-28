using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool IsLevelStarted = false;
    private bool IsOptionMenuActive;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject levelUI;
    [SerializeField] private GameObject optionsMenu;

    private void Start()
    {
        Pause();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsLevelStarted)
            {
                ResumeLevel();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsOptionMenuActive)
            {
                HideOptionMenu();
            }
            else
            {
                ShowOptionsMenu();
            }
        }
    }

    private void HideOptionMenu()
    {
        IsOptionMenuActive = false;
        optionsMenu.SetActive(false);
        if (IsLevelStarted)
        {
            levelUI.SetActive(true);
            Time.timeScale = 1f;
        }
        else
        {
            pauseMenu.SetActive(true);
        }
    }

    public void ResumeLevel()
    {
        levelUI.SetActive(true);
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        Time.timeScale = 1f;
        IsLevelStarted = true;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        levelUI.SetActive(false);
        optionsMenu.SetActive(false);
        Time.timeScale = 0f;
    }

    void ShowOptionsMenu()
    {
        if (IsLevelStarted)
        {
            IsOptionMenuActive = true;
            optionsMenu.SetActive(true);
            levelUI.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            IsOptionMenuActive = true;
            pauseMenu.SetActive(false);
            optionsMenu.SetActive(true);
        }
    }

    public void Resume()
    {
        Debug.Log("pressed resume");
        if (IsLevelStarted)
        {
            ResumeLevel();
        }
        else
        {
            Pause();
        }
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}