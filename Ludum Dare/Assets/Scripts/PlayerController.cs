using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D  playerRigidbody;
    public int          forceJump;
    public Animator     Anime;

    public bool         slide;

    public Transform    GroundCheck;
    public bool         grounded;
    public LayerMask    whatIsGround;

    public float        slideTemp;
    public float        timeTemp;

    public Transform    player;
    public Transform    colisor;
    private bool        comeBack;

    public AudioSource audio;
    public AudioClip   soundJump;
    public AudioClip   soundSlide;
    public AudioClip   soundCoin;

    public UnityEngine.UI.Text scoreTxt;
    public static int  score;

	// Use this for initialization
	void Start () {
        score = 0;
        PlayerPrefs.SetInt("score", score);

        colisor.position = new Vector3(colisor.position.x, player.position.y-0.04f, colisor.position.z);
    }
	
	// Update is called once per frame
	void Update () {

        scoreTxt.text = score.ToString();

        if (Input.GetMouseButtonDown(0) && grounded)
        {
            playerRigidbody.AddForce(new Vector2(0, forceJump));

            audio.PlayOneShot(soundJump);
            audio.volume = 1;

            colisor.position = new Vector3(colisor.position.x, player.position.y-0.04f, colisor.position.z);
        }

        if (!grounded)
        {
            comeBack = true;
        }

        if (grounded && comeBack)
        {
            colisor.position = new Vector3(colisor.position.x, player.position.y+0.04f, colisor.position.z);
            comeBack = false;
        }

        grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, whatIsGround);

        Anime.SetBool("jump", !grounded);
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerPrefs.SetInt("score", score);
        if (score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        if (other.gameObject.name == "Platform(Clone)" || other.gameObject.name == "Floor")
        {

        } else if (other.gameObject.name != "Seed(Clone)")
        {
            Application.LoadLevel("gameover");
            //Debug.Log("GAME OVER: " + other.name);
        } else {
            Destroy(other.gameObject);
            score++;
            audio.PlayOneShot(soundCoin);
            audio.volume = 1;
        }
    }
}
