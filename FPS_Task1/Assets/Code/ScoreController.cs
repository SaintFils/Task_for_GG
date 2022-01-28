using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextFormatter scoreText;
    private int _counter = 0;

    private void Start()
    {
        scoreText.Format(_counter);
    }

    private void RefreshScore()
    {
        _counter += 10; //i'm so sorry for magic numbers like that. 
        scoreText.Format(_counter);
    }
    private void OnEnable()
    {
        Target.onTargetHit += RefreshScore;
    }

    private void OnDisable()
    {
        Target.onTargetHit -= RefreshScore;
    }
}
