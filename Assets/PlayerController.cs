using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    private float jumpHeight = 2f;

    // Start is called before the first frame update
    void Start()
    {
        if (IsInTheAir(1f))
        {
            Debug.Log("whatever");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0f,jumpHeight,0f);   
        }
    }

    private bool IsInTheAir(float minHeight)
    {
        return transform.position.y > minHeight;
    }
}
