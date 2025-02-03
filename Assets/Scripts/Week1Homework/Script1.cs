using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    int ivy;

    int kayenne;

    int balsamCandle;

    int total;

    void Start()
    {
        kayenne = 19;

        balsamCandle = 71;

        ivy = 2;

        ivy = kayenne / 4 + 2 * balsamCandle - kayenne;

        total = kayenne + ivy / 5 * ivy; 

        Debug.Log("Balsam candle's value is" + " " + balsamCandle);

        Debug.Log("Kayenne's value is" + " " + kayenne);

        Debug.Log("Ivy's value is" + " " + ivy);

        Debug.Log("Hi Anthony! The total value is" + " " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
