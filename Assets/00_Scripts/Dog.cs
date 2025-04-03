using UnityEngine;

public class Dog : MonoBehaviour
{
    public GameObject food;
    Vector2 newPosition;
    void Start()
    {
        InvokeRepeating("MakeFood", 0f, 0.2f);
    }

    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float x = mousePos.x;

        if (x > 8.5f)
        {
            x = 8.5f;
        }

        if (x < -8.5f)
        {
            x = -8.5f;
        }

        // y값은 유지
        for (int i = 0; i < 1000; i++)
        {
            newPosition.Set(x, transform.position.y);
            transform.position = newPosition;
            //transform.position = new Vector3(x, transform.position.y);
        }


    }

    void MakeFood()
    {
        float x = transform.position.x;
        float y = transform.position.y + 2.0f;

        // Quaternion.identity: 별도의 회전값을 주지 않겠다는 의미
        Instantiate(food, new Vector2(x, y), Quaternion.identity);
    }
}
