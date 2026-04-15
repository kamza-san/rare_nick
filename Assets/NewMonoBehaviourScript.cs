using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int hp = 3;
    private bool isAlive = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("게임 시작");
        Debug.Log("초기 HP: " + hp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isAlive)
        {
            hp -= 1;
            Debug.Log("현재 HP: " + hp);
            transform.position = trasform.Translate(0f,3f,0f);
            if (hp <= 0)
            {
                isAlive = false;
                Debug.Log("게임 오버");
            }
        }
    }
}
