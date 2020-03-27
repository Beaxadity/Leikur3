using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    // Gerir tímann fyrir biðin fyrir restartið
    public float restartDelay = 0.2f;

    public GameObject completeLevelUI;

    public GameObject failedLevelUI;

    public void CompleteLevel()
    {
        // Athugar hvort þú komst að endanum
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            // Setur bið á restartið
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        // Byrjar aftur sceneið
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}