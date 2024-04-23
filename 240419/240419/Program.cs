﻿// 9. 반복문

public class Student
{
    public static void Main()
    {
        // for 반복문: 10번 반복하는 반복문
        // 초기화자;    조건;  증감
        for(int i = 0; i < 10; i++)
        {

        }

        // foreach 반복문
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach(int number in numbers)
        {

        }

        // while 반복문: 10번 반복하는 반복문
        int j = 0;
        while(j < 10)
        {
            j++;
        }

        // do-while 반복문: 최소 한번은 실행되는 반복문
        int z = 0;
        do
        {
            z++;
        } while(z < 10);

        // 실습1. 0~10까지 더한 값을 출력하는 프로그램 만들기
        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            //sum = sum + i;
            sum += i;
        }
        Console.WriteLine(sum);

        // 실습2. 배열의 값을 더하는 프로그램 만들기
        int[] numberArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        sum = 0;
        foreach (int number in numberArray)
        {
            sum += number;
        }
        Console.WriteLine(sum);
        Console.WriteLine("평균: " + (sum / numberArray.Length));

        sum = 0;
        for (int i = 0; i < numberArray.Length; i++)
        {
            sum += numberArray[i];
        }
        Console.WriteLine(sum);

        List<int> list = new List<int>() { 3, 5, 3, 8, 5 };
        list.Add(3);
        sum = 0;
        foreach(int number in list)
        {
            sum += number;
        }
        Console.WriteLine("합계: " + sum + " / 평균: " + (sum / list.Count));

        // 실습3. 이름리스트에서 내 이름이 있는지 확인하고,
        // 있다면, 찾았습니다 000은 4번째에 있습니다. 없다면, 없습니다. 출력하는 프로그램 만들기
        List<string> names = new List<string>(){ "000", "신태욱" };

        int g = 0;
        foreach(string name in names)
        {
            if(name == "신태욱")
            {
                Console.WriteLine("찾았습니다. 신태욱은 " + g + "번째에 있습니다.");
            }
            else
            {
                Console.WriteLine("없습니다.");
            }
            g++;
        }

        string input = Console.ReadLine();
        Console.WriteLine(input + "은 " + names.IndexOf(input) + "번재에 있습니다.");

        // 반복문 안의 반복문
        // 구구단 예(2~9단, 각 1~9 단계)
        // 2단, 2x1=2 / 2x2=4 ..... / 2x9=18
        // 3단, 3x1=3 / 3x3 =9 .... / 3x9=27
        // ...
        
        // 실습4. 구구단 프로그램 만들기
        // for문 1
        for(int i = 2; i < 10; i++)
        {
            Console.Write(i + "단, ");
            // for문 2
            for(int k = 1; k < 10; k++)
            {
                Console.Write($"{i}*{k}={i * k} / ");
            }
            Console.Write("\n");
        }
    }
}
