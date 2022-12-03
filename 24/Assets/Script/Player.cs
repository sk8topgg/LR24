
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 jumpForce;
    Vector2 currentVelocity;
    Rigidbody2D rgbd;
    GameManager gameManager;
    ScoreUI scoreUi;
    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        rgbd.gravityScale = 0;
        gameManager = FindObjectOfType<GameManager>();
        scoreUi = FindObjectOfType<ScoreUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameOver) { rgbd.bodyType = RigidbodyType2D.Static;return; }
        if (Input.GetMouseButtonDown(0))
        {   
            if (rgbd.gravityScale != 0.5f) { rgbd.gravityScale = 0.5f; }
            rgbd.AddForce(jumpForce);
            SpeedController();
            scoreUi.IncrementScore(1);
        }
    }
    void SpeedController()
    {   
        currentVelocity = rgbd.velocity;
        currentVelocity.x = Mathf.Clamp(currentVelocity.x, 2, 2);
        currentVelocity.y = Mathf.Clamp(currentVelocity.y, 0, 2);
        rgbd.velocity = currentVelocity;
    }
}
