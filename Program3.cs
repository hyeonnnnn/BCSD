using UnityEngine;
using System;

public class Exercise03 : MonoBehaviour
{
    [SerializeField] // 유니티 에디터 Inspector View에서 해당 클래스 멤버 변수 값을 설정 가능
    private int x = 10;
    private void Awake()
    {
        int[][] array = new int[3][];

        array[0] = new int[3] { 1, 2, 3 };
        array[1] = new int[] { 10, 20, 30, 40 };
        array[2] = new int[] { 100, 200, 300, 400, 500 };

        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = 0; j < array[i].Length; ++j)
            {
                Debug.Log($"[{i}][{j}] = {array[i][j]}");
            }
        }

        // 배열
        int[] enemys = new int[5];

        Debug.Log($"배열의 타입 : {enemys.GetType()}");
        Debug.Log($"배열의 기본 타입 : {enemys.GetType().BaseType}");

        Debug.Log("== 정렬 전 ==");
        for (int index = 0; index < enemys.Length; ++index)
        {
            // using System과 UnityEngine 둘 다 Random 클래스가 있기 때문에
            // UnityEngine 이름공간을 붙여줄 것
            enemys[index] = UnityEngine.Random.Range(0, 100);

            Debug.Log(enemys[index]);
        }

        Array.Sort(enemys); // 매개변수로 사용한 enemys를 정렬

        Debug.Log("== 정렬 후 ==");
        for (int index = 0; index < enemys.Length; ++index)
        {
            Debug.Log(enemys[index]);
        }
        Debug.Log($"Dimensions : {enemys.Rank}");

        // 반복문 while
        int result = 0;
        int index = 1;

        while (index <= 100)
        {
            result += index;
            index++;
        }

        Debug.Log($"1부터 100까지의 합 {result}");

        // 반복문 for
        // index 변수는 지역 변수로 취급
        for (int index = 0; index < 10; ++index)
        {
            Debug.Log(index);
        }

        // 중첩 반복문
        for (int x = 1; x < 10; ++x)
        {
            for (int y = 1; y < 10; ++y)
            {
                Debug.Log($" {x} × {y} = {x * y}");
            }
        }

        // switch, case
        x /= 10;

        switch (x)
        {
            case 10:
                Debug.Log("학점 : A+");
                break;
            case 9:
                Debug.Log("학점 : A+");
                break;
            case 8:
                Debug.Log("학점 : B+");
                break;
            case 7:
                Debug.Log("학점 : C+");
                break;
            case 6:
                Debug.Log("학점 : D");
                break;
            default:
                Debug.Log("학점 : F");
                break;
        }

        // if, else if, else
        if (x >= 90)
        {
            Debug.Log("학점 : A+");
        }
        else if (x >= 80)
        {
            Debug.Log("학점 : B+");
        }
        else if (x >= 70)
        {
            Debug.Log("학점 : C+");
        }
        else if (x >= 60)
        {
            Debug.Log("학점 : D");
        }
        else
        {
            Debug.Log("학점 : F");
        }

        // 조건문 if
        if (x % 2 == 0)
        {
            Debug.Log("x는 짝수다");
        }
        else
        {
            Debug.Log("x는 홀수다");
        }

        // 여러 개의 조건식을 동시에 만족하도록 설정
        if (x > 5 && x < 10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }

        // 위의 if문과 같은 결과를 출력할 것
        if (x > 5)
        {
            if (x < 10)
            {
                Debug.Log("x는 5보다 크고 10보다 작다");
            }
        }
        Debug.Log($"x의 값음 {x}");
    }
}