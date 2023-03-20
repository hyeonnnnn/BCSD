using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    // enum PlayerState { Idle, Move, Attack }
    private void Awake()
    {
        // Nullable
        int? intValue;

        intValue = null; //null이기 때문에 출력하면 에러
        Debug.Log(intValue.HasValue);
        // Debug.Log(intValue.Value); // guswo intValue가 null이기 때문에 값을 출력히면 에러 발생

        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        // var
        var valueInt = 33;
        var valueFloat = 33.4567f;
        var valuestring = "문자열";

        Debug.Log("5/4 : " + valueInt);
        Debug.Log(" 실수 : " + valueFloat);
        Debug.Log("문자열 : " + valuestring);

        // 열거형을 이용한 플레이어 상태 관리
        PlayerState playerState = PlayerState.Idle;

        switch (playerState)
        {
            case PlayerState.Idle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }

        // 상수를 이용한 플레이어 상태 관리
        const int PlayerIdle = 0;
        const int PlayerMove = 1;
        const int PlayerAttack = 2;

        int PlayerState = PlayerAttack;

        switch (playerState)
        {
            case PlayerState.Idle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }

        // 숫자를 문자열로 형 변환 - ToString()
        string stringValue = "초기화";
        int intValue = 33;
        float floatValue = 12.3456f;

        Debug.Log("stringValue : " + stringValue);

        // 정수를 문자열로 형 변환
        stringValue = intValue.ToString();
        Debug.Log("stringValue : " + stringValue);

        // 실수를 문자열로 형 변환
        stringValue = floatValue.ToString();
        Debug.Log("stringValue : " + stringValue);

        // 문자열을 숫자로 형 변환 II - TryPalse()
        string stringValue = "숫자가 아닙니다.";
        int intValue = 10;

        bool isconversion = int.TryParse(stringValue, out intValue);
        if (isconversion == true)
        {
            Debug.Log("stringValue : " + stringValue);
            Debug.Log("intValue : " + intValue);
        }
        else
        {
            Debug.Log("stringValue 변수에 있어있는 내용이 숫자가 아니어서 형 변황에 실패했습니다.");
        }

        // 문자열을 숫자로 형 변환 I - Palse()
        // 문자열(sring)에 숫자가 아닌 데이터가 들어있을 경우 숫자로 형 변환을 시도하면 에러 발생
        int intValue = 10;
        float floatValue = 12.3456f;
        string stringValue = "33";

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);

        // 실수(33.4567)를 정수(int)로 형 변환하려고 하면 에러 발생
        intValue = int.Parse(stringValue);
        stringValue = "33.4567";
        floatValue = float.Palse(stringValue);

        Debug.Log("intValue : " + intValue);
        Debug.Log("floatValue : " + floatValue);
        Debug.Log("stringValue : " + stringValue);

        // 부동 소수점과 정수 사이의 형 변환
        float floatValue = 0.9f;
        int intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        floatValue = 1.1f;
        intValue = (int)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("intValue : " + intValue);

        // 크기가 서로 다른 부동 소수점 사이의 형 변환
        float floatValue = 69.6875f;
        double doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        floatValue = 0.1f;
        doubleValue = (double)floatValue;

        Debug.Log("floatValue : " + floatValue);
        Debug.Log("doubleValue : " + doubleValue);

        // 부호 없는 정수와 있는 정수(byte, sbyte) 사이의 형 변환
        sbyte sbyteValue = 31;
        byte byteValue = (byte)sbyteValue;


        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        // 부호 있는 정수(sbyte)가 음수일 때
        sbyteValue = -31;
        byteValue = (byte)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        // 부호 없는 정수(byte)가 부호 있는 정수(sbyte)의 최댓값보다 클 때
        byteValue = 200;
        sbyteValue = (sbyte)byteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("byteValue : " + byteValue);

        // 크기가 서로 다른 정수(int, sbyte) 사이의 형 변환
        sbyte sbyteValue = 10;
        int intValue = (int)sbyteValue;

        Debug.Log("sbyteValue : " + sbyteValue);
        Debug.Log("intValue : " + intValue);

        // sbyte의 최대 범위인 127보다 큰 130을 전달하기 때문에 오버플로우 발생
        intValue = 130;                     // int : -128 ~ 127
        sbyteValue = (sbyte)intValue;       // sbyte : -2147483648 ~ -2147483647

        object valueInt = 31;                           // 박싱 (데이터 저장)
        object valueFloat = 3.14159265358979f;          // 박싱
        object valueString = "객체지향 프로그래밍";     // 박싱
        object valueBlool = false;                      // 박싱

        Debug.Log("정수 : " + valueInt);                // 언박싱 (데이터 사용)
        Debug.Log("실수 : " + valueFloat);              // 언박싱
        Debug.Log("문자열 : " + valueString);           // 언박싱
        Debug.Log("논리 : " + valueBlool);              // 언박싱

        float floatValue01 = 3.141592653589793238462643383279f;     // 7자리 표현
        float floatValue02 = 31.141592653589793238462643383279f;    // 7자리 표현
        double doubleValue = 3.141592653589793238462643383279;      // 15자리 표현
        decimal decimalValue = 3.141592653589793238462643383279m;   // 15자리 표현

        Debug.Log("float Data : " + floatValue01);
        Debug.Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug.Log("decimal Data : " + decimalValue);

        sbyte byteValue = -129;                     // -128 ~ 127
        byte ubyteValue = 255;                      // 0 - 255
        short shortValue = -32768;                  // -32768 ~ 32767
        ushort ushortValue = 65535;                 // 0 ~ 65535
        int intValue = -2147483648;                 // -2147483648 ~ -2147483647 
        uint uintValue = 4294967295;                // 0 ~ 4294967295
        long longValue = -922337283685477588;       // -922337283685477588 ~ -922337283685477587
        ulong ulonValue = 18446744873789551615;     // 0 ~ 18446744873789551615
        char charValue = 'k';

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubyteValue);
        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);
        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulonValue);
        Debug.Log("char Data : " + charValue);
    }
}
