using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour
{
    public float restartDelay = 1f;

    public void EndGame() {
        Invoke("Restart", restartDelay);
    }

    void Restart() {
        SceneManager.LoadScene("MazeBallGame");
    }
}
