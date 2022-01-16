using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // 커서 끄기

            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            int laskTick = 0; // 마지막 시간
            
            while (true)
            {
                #region 프레임관리
                // FPS 프레임 ( 60프레임 OK  30프레임 이하 NO // 이 루프가 1초에 몇번도느냐 )
                int currentTick = System.Environment.TickCount; // 시스템이 시작된이후 ms
                
                // 만약에 경과 시간이 1/30초 보다 작다면 1초는 1000ms
                if (currentTick - laskTick < WAIT_TICK)
                    continue;
                laskTick = currentTick;
                #endregion

                // 입력
                // 로직
                // 렌더링
                Console.SetCursorPosition(0, 0); // 커서를 0에 고정

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
