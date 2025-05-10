using System.Runtime.CompilerServices;
using UnityEngine;

public class singleton : MonoBehaviour
{
    private static singleton instance;

    public static singleton Instance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindAnyObjectByType<singleton>();
                if (obj != null)
                {
                    instance = obj;
                }
                else
                {
                    var newObj = new GameObject().AddComponent<singleton>();
                    instance = newObj;
                }
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Debug.Log("중복된 개체가 탐색되어 삭제했습니다.");
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

