using UnityEngine;

public class Script4 : MonoBehaviour
{
    public Vector3 startingPosition;

    public Vector3 moveDirection;

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDirection * speed * Time.deltaTime;

        Debug.Log("heRE WE GOOOOOOOOOOOOOO!!!");
    }
}
