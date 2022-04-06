using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;
            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';


            int lastTick = 0; // 마지막 측정 시간
            while (true)
            {
                #region 프레임 관리
                // 프레임 관리 (FPS)
                // 60 프레임 OK, 30 프레임 이하 NO
                // while 루프가 1초에 몇번 실행되는가 = FPS
                int currentTick = System.Environment.TickCount; // 절대적 시간x, 시스템 시작이후 경과된 ms 반환

                // 만약 경과 시간이 1/30초 보다 작다면 
                if (currentTick - lastTick < WAIT_TICK) // 1초는 1000ms이다
                    continue;
                lastTick = currentTick;
                #endregion 프레임 관리
                // 입력
                // 사용자의 입력을 받는 행위
                // 로직
                // 입력을 받아 로직 실행
                // 렌더링
                // 게임에 출력 (Direct X, OpenGL 등)
                Console.SetCursorPosition(0, 0);
                
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
