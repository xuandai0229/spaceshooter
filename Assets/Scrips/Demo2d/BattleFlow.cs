using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI; // Giao diện Game Over
    public GameObject gameWinUI; // Giao diện Game Win
    public PlayerHeath playerHeath; // Tham chiếu đến PlayerHeath
    public GameObject audio; // Tham chiếu đến Audio

    private void Start()
    {
        gameOverUI.SetActive(false); // Ẩn giao diện Game Over lúc bắt đầu
        gameWinUI.SetActive(false); // Ẩn giao diện Game Win lúc bắt đầu
        playerHeath.onDead += OnGameOver; // Đăng ký sự kiện khi người chơi chết
    }

    private void Update()
    {
        if(EnemyHeath.livingEnemyCount <= 0)
        {
                       OnGameWin();
        }
    }

    void OnGameOver()
    {
        gameOverUI.SetActive(true); // Hiển thị giao diện Game Over
        audio.SetActive(false); // Tắt âm thanh
    }

    void OnGameWin()
    {
        gameWinUI.SetActive(true); // Hiển thị giao diện Game Win
        audio.SetActive(false); // Tắt âm thanh
        playerHeath.gameObject.SetActive(false); // Ẩn nhân vật người chơi
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
