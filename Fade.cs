using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public GameObject targetObject;
    public string sceneToLoad = "NextScene";
    public Image fadeImage;
    public float fadeDuration = 1f;
    public Image[] sequenceImages;
    public float imageDisplayTime = 1f;
    private bool fade = false;

    void Update()
    {
        if (!targetObject.activeSelf && !fade)
        {
            StartCoroutine(FadeOutAndShowSequence());
        }
    }

    System.Collections.IEnumerator FadeOutAndShowSequence()
    {
        fade = true;

        float timer = 0f;
        Color color = fadeImage.color;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Clamp01(timer / fadeDuration);
            fadeImage.color = new Color(color.r, color.g, color.b, alpha);
            yield return null;
        }

        foreach (Image img in sequenceImages)
        {
            img.gameObject.SetActive(true);
            yield return new WaitForSeconds(imageDisplayTime);
            img.gameObject.SetActive(false);
        }

        SceneManager.LoadScene(sceneToLoad);
    }
}