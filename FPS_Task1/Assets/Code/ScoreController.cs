using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextFormatter scoreText;
    [SerializeField] private TextFormatter triesText;
    [SerializeField] private int tries = 3;
    private int _counter = 0;
    

    private void Start()
    {
        scoreText.Format(_counter);
        triesText.Format(tries);
    }

    private void RefreshScore()
    {
        _counter += 10; //i'm so sorry for magic numbers like this. 
        scoreText.Format(_counter);
    }

    private void RefreshTries()
    {
        tries--;
        if (tries <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);   
        }
        triesText.Format(tries);
    }
    private void OnEnable()
    {
        Target.OnTargetHit += RefreshScore;
        FailZone.OnFailZoneEnter += RefreshTries;
    }

    private void OnDisable()
    {
        Target.OnTargetHit -= RefreshScore;
        FailZone.OnFailZoneEnter -= RefreshTries;

    }
}
