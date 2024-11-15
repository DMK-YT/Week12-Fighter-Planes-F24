using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject player;
    public GameObject enemy;
    public GameObject enemyTwo;
    public GameObject cloud;
    private int score;
    public GameObject coin;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 1f, 3f); 
        InvokeRepeating("CreateEnemyTwo", 4f, 8f);
        CreateSky();
        InvokeRepeating("CreateCoin", 5f, 10f);
        score = 0;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.identity);
    }
    void CreateEnemyTwo()
    {
        Instantiate(enemyTwo, new Vector3(Random.Range(-5f, 5f), 8f, 0), Quaternion.identity);
    }

    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }
    }

    public void EarnScore(int howMuch)
    {
        score = score + howMuch;
        scoreText.text = "Score: " + score;
    }
    public void SetLivesCount(int lives)
    {
        livesText.text = "Lives: " + lives;
    }

    void CreateCoin()
    {
        Instantiate(coin, new Vector3(Random.Range(-7f, 7f), 7.5F, 0), Quaternion.identity);

    }
}
