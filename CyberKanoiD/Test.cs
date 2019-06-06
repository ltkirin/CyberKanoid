using UnityEngine;

public class Test : MonoBehaviour {
    [SerializeField] private float min;
    [SerializeField] private float max;

    private float f;

    private void Awake()
    {
        f = 0;
    }

    private void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Up();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Down();
        }
	}

    private void Up()
    {
        f = Mathf.Lerp(f, max, Time.deltaTime);
    }

    private void Down()
    {
        f = Mathf.Lerp(f, min, Time.deltaTime);
    }
}
