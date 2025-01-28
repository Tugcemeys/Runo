using UnityEngine;

public class NotaMovement : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        transform.Translate(Vector3.back*speed*Time.fixedDeltaTime);
    }
}