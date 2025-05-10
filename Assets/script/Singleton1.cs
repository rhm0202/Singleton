using UnityEngine;

public class Singleton1 : MonoBehaviour
{
    private static Singleton1 instance;

    public static Singleton1 Instance
    {
        get
        {
            if (instance == null)
                SetupInstance();
            return instance;
        }
    }

    private static void SetupInstance()
    {
        instance = FindFirstObjectByType<Singleton1>();
        if (instance == null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = "Singleton";
            instance = gameObj.AddComponent<Singleton1>();
            DontDestroyOnLoad(gameObj);
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
