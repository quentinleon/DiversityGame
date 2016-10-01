using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BGFade : MonoBehaviour {

	public SpriteRenderer sr;
	public Text message;

	void Awake()
	{
		sr = GetComponent<SpriteRenderer> ();
	}

	public void StartFade()
	{
		StartCoroutine ("FadeIn");
	}

	public IEnumerator FadeIn()
	{
		while (sr.color.a < 1)
		{
			sr.color = new Color (0, 0, 0, sr.color.a + 0.005f);
			yield return null;
		}
		while (message.color.a < 1)
		{
			message.color = new Color (1, 1, 1, message.color.a + 0.01f);
			yield return null;
		}
		yield return new WaitForSeconds (5.0f);
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
