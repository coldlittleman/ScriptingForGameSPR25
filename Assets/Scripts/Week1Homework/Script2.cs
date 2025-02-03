using UnityEngine;

public class Script2 : MonoBehaviour
{

    public float bagel;

    public float pleistocene;

    public float laminitis;

    public float galileo;

    float total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        total = pleistocene / laminitis - galileo * bagel;

        Debug.Log("The total for pleistocene / laminitis - galileo + bagel is" + " " + total);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
