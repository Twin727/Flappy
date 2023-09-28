using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float force;
    Rigidbody2D _playerRigid;

    public GameObject _restartButton;

    void Start()
    {
        Time.timeScale = 1; // чтобы остановить игру после сталкновения с врагом
        _playerRigid = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _playerRigid.velocity = Vector2.up * force;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
            gameObject.SetActive(false);
            //Destroy(gameObject);
        Time.timeScale = 0; // игра останавливается
        _restartButton.SetActive(true);
    }
}
