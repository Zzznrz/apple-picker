using UnityEngine;

public class RorateApple : MonoBehaviour
{
    public float rorateSpeed = 40f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10f * Time.deltaTime, 40f * Time.deltaTime, 0);
    }
}
