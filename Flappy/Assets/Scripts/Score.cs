using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public short _score;
    public Text _scoreText;
 
    void Start()
    {
        _score = 0;
    }

    void Update()
    {
        _scoreText.text = _score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
            _score++;
    }
}
