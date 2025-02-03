using UnityEngine;

public class Script3 : MonoBehaviour
{
    string fullSentence;

    public string intro;

    public string middle;

    public string outro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fullSentence = intro + " " + middle + " " + outro;

        Debug.Log(fullSentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
