using UnityEngine;

public class DatatypePractice : MonoBehaviour
{
    //ints are numbers without decimals
    int santaClaus;

    //floats are decimal numbers
    float total;
    public float mario;
    public float yoshi = 4.8f;

    //chars are only allowed to be 1 letter or character. 
    char bee = 'B';

    //string means string of numbers, so a word or a whole paragraph
    string fullSentence;
    string intro = "Best of luck.";

    string outro = "Farewell, traveler.";

    public string chestName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;

        //math uses *, +, -, or /
        santaClaus = (santaClaus + 5) * 2 / (3 - 7);

        Debug.Log(santaClaus);

        Debug.Log(yoshi);

        //Subtracts 2 from the current value of yoshi
        yoshi = yoshi - 2;

        Debug.Log("Yoshi's value is " + yoshi);

        Debug.Log(bee);

        Debug.Log(intro);

        total = mario + 7 + yoshi;

        Debug.Log(total);

        fullSentence = intro + " " + outro;

        Debug.Log(fullSentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
