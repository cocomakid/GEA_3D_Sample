using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject gameOverPanel;
    public string titleSceneName = "Title";

    public GameObject clearPanel;


    void Awake() { Instance = this; }     // 시작할 때 자기 자신을 넣음

    public void GameClear()
    {
        clearPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Retry()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
    }

    public void GoTitle()
    {
        SceneManager.LoadScene(titleSceneName);
    }
    
}
