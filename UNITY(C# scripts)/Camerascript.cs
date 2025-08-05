using UnityEngine;

public class Camerascript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform playertrans;
    public float offSet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camerapos = transform.position;
        camerapos.z = playertrans.position.z + offSet;
        transform.position = camerapos;

    }
}
