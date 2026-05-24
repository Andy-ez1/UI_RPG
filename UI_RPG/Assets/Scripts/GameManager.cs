using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy currentEnemy;

    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyHealth;
    [SerializeField] private Image enemyPreview;
    [SerializeField] private Enemy[] allEnemies;

    [Header("Weapon Selection")]
    [SerializeField] private Weapon[] playerWeapons;
    [SerializeField] private Button[] weaponButtons;
    [SerializeField] private TMP_Text selectedWeaponText;

    [Header("Game Over")]
    [SerializeField] private GameObject gameOverPanel;

    private bool gameOver = false;

    public void Start()
    {
        gameOverPanel.SetActive(false);
        SetCurrentEnemy();
        SetupWeaponButtons();
        selectedWeaponText.text = "Weapon: " + playerWeapons[0].name;
        RefreshUI();
    }

    private void SetupWeaponButtons()
    {
        for (int i = 0; i < weaponButtons.Length && i < playerWeapons.Length; i++)
        {
            int index = i;
            weaponButtons[i].GetComponentInChildren<TMP_Text>().text = playerWeapons[i].name;
            weaponButtons[i].onClick.AddListener(() => SelectWeapon(index));
        }
    }

    public void SelectWeapon(int index)
    {
        player.SetWeapon(playerWeapons[index]);
        selectedWeaponText.text = "Weapon: " + playerWeapons[index].name;
    }

    public void Fight()
    {
        if (gameOver) return;

        player.Attack(currentEnemy);

        if (!currentEnemy.IsAlive)
        {
            SetCurrentEnemy(); 
        }
        else
        {
            currentEnemy.Attack(player);
            if (!player.IsAlive)
            {
                GameOver();
                RefreshUI();
                return;
            }
        }
        RefreshUI();
    }

    private void SetCurrentEnemy()
    {
        int enemyIndex = Random.Range(0, allEnemies.Length);
        currentEnemy = allEnemies[enemyIndex];
        currentEnemy.Reset();
    }

    public void RefreshUI()
    {
        playerName.text = player.CharName;
        playerHealth.text = "HP: " + player.Health.ToString("F1");
        enemyName.text = currentEnemy.CharName;
        enemyHealth.text = "HP: " + currentEnemy.Health.ToString("F1");
        enemyPreview.sprite = currentEnemy.enemyImage;
    }

    private void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        Debug.Log("GAME OVER!");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}