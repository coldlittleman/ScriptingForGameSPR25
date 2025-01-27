using UnityEngine;

public class MovementTest : MonoBehaviour
{

    public Vector3 startingPosition;

    public Vector3 moveDirection;

    public float speed;

   // this is a comment. this is not code
   // comment comment comment
    // Start is called when this object first exists in the scene, and the game is loaded.
    void Start()
    {
        Debug.Log("Good morning gamers.");

        //in reference to the object this script is on, get reference to its transform component
        // get reference to the transform's position, and set it = Vector3.zero, which means (0,0,0)
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //move direction is (1,0,1)
        this.transform.position += moveDirection * speed * Time.deltaTime; //multiplying by time.deltatime means per second, rather than per frame
        Debug.Log("I like coffee.");
    }
}
