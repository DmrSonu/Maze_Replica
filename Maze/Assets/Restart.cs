using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        Time.timeScale = 0.1f;
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
