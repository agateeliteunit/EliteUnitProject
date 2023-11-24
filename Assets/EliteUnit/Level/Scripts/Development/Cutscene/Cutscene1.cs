using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Cutscene1 : MonoBehaviour
{
    public VideoPlayer videoCutscene;
    public string sceneName; 

    void Start()
    {
        videoCutscene.Play();
        StartCoroutine(cekCutscene());
    }

    void Update()
    {
        if (videoCutscene.isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                gameplayScene();
            }
        }
    }

    IEnumerator cekCutscene()
    {
        yield return new WaitForSeconds(4f);

        while (videoCutscene.isPlaying)
        {
            yield return null;
        }

        gameplayScene();
    }

    void gameplayScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}