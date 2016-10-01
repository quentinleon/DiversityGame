using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

    public bool dead;
	public Rigidbody2D rb2d;

    float speed = 10f;
	public Text deathMessage;
	public BGFade bgFade;

	public AudioClip gameMusic;
	public AudioClip deathMusic;
	public AudioSource src;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
        GetComponent<Animator>().SetBool("dead", false);
        dead = false;
		src.clip = gameMusic;
		src.loop = true;
		src.Play ();
	}
	
	// Update is called once per frame
	void Update () {
        if (!dead) {
			int vx = (int)Input.GetAxisRaw ("Horizontal");
			int vy = (int)Input.GetAxisRaw ("Vertical");
			rb2d.velocity = new Vector2 (vx, vy) * speed;
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -3, 3), Mathf.Clamp(transform.position.y, -5, 5));
		}
    }

    void OnTriggerEnter2D(Collider2D coll) {
        dead = true;
		rb2d.isKinematic = false;
        GetComponent<Animator>().SetBool("dead", true);
		rb2d.velocity = new Vector2(5, 7);
		StartCoroutine ("DeathRoutine");
		Obstacle obs = coll.GetComponent<Obstacle> ();
		deathMessage.text = "Knocked down by " + obs.obstacleName + ":\n" + obs.deathMessage;
		src.clip = deathMusic;
		src.Play ();
    }

	public IEnumerator DeathRoutine()
	{
		yield return new WaitForSeconds (2.0f);
		bgFade.StartFade ();
	}
}
