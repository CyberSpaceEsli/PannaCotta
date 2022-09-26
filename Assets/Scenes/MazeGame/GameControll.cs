using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour
{
    public void EndGame() {
        Restart();
    }

    void Restart() {
        SceneManager.LoadScene("MazeBallGame");
    }
}
