using UnityEngine;

public class SingletonClass
{
    private SingletonClass() { }                      // 생성자를 private으로: 외부에서 new 못하게

    private static SingletonClass instance;           // 인스턴스를 저장할 static 변수

    public static SingletonClass Instance             // 전역 접근 지점 (속성)
    {
        get
        {
            if (instance == null)                     // 아직 인스턴스가 없으면
            {
                instance = new SingletonClass();      // 인스턴스 생성
            }
            return instance;                          // 인스턴스 반환
        }
    }
}