using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody body;
    public float Force = 150f;
    public float LRspeed = 5f;
    public float clampminX = -4.18f;
    public float clampmaxX = 4.18f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 clamppos = transform.position;
        // this is one method for clamp
        //if (clamppos.x<clampminX)
        //{
        //    clamppos.x = clampminX;
        //}
        //if (clamppos.x > clampmaxX)
        //{
        //    clamppos.x = clampmaxX;
        //}
        //transform.position = clamppos;
        
        //in built untiy method for clamp
        clamppos.x = Mathf.Clamp(clamppos.x, clampminX, clampmaxX);
        transform.position = clamppos;

        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(LRspeed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-LRspeed * Time.deltaTime, 0, 0);

        }
    }
    private void FixedUpdate() {
      

            body.AddForce(0, 0, Force * Time.deltaTime);
        }
    
}
