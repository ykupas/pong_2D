using UnityEngine;

public class paddle : MonoBehaviour
{
    // Protected variable can be accessed from child classes
    protected Rigidbody2D _rigidbody;

    // Awake is called one time, for initialization
    private void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
