using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = $"Score: {score}";
    }
}
