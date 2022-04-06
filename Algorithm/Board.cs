using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MyList<T>
    {
        #region 동적배열 연습
        const int DEFAULT_SIZE = 1;
        T[] _data = new T[DEFAULT_SIZE];

        public int Count = 0; // 실제로 사용중인 데이터 갯수
        public int Capacity { get { return _data.Length; } } // 예약된 데이터 갯수

        public void Add(T item)
        {
            // 1. 공간이 충분히 남아 있는지 확인
            if (Count >= Capacity)
            {
                // 공간 다시(늘려서) 확보하기
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = _data[i];  
                }
                _data = newArray;
            }

            // 2. 공간에 데이터를 넣어준다
            _data[Count] = item;
            Count++;
        }

        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[i + 1];
            _data[Count - 1] = default(T);
            Count--;
        }
        #endregion
    }

    class Room<T>
    {
        public T Data;
        public Room<T> Next;
        public Room<T> Prev;

    }

    class RoomList<T>
    {
        public Room<T> Head = null; // 첫번째
        public Room<T> Tail = null; // 마지막
        public int Count = 0;

        public Room<T> AddLast(T data)
        {
            Room<T> newRoom = new Room<T>();
            newRoom.Data = data;

            // 만약 아직 방이 아예 없었다면, 새로 추가한 방이 곧 Head 이다
            if (Head == null)
                Head = newRoom;

            // 101 102 103 (104)
            // 기존의 [마지막 방]과 [새로 추가되는 방]을 연결 해준다.
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }
            // 새로 추가되는 방을 마지막 방으로 인정한다.
            Tail = newRoom;
            Count++;
            return newRoom;

        }
    }




    class Board
    {
        public int[] _data = new int[25]; // 배열
        public List<int> _data2 = new List<int>(); // 동적 배열
        public MyList<int> _data2_1 = new MyList<int>(); // 동적 배열 만든거 연습
        public LinkedList<int> _data3 = new LinkedList<int>(); //(이중) 연결 리스트
        #region 자료구조
        //자료 구조
        /*
         * 선형 구조는 자료를 순차적으로 나열한 형태
         * - 배열
         * - 연결리스트
         * - 스택 / 큐
         * 
         * 
         * 비선형 구조는 하나의 자료 뒤에 다수의 자료가 올 수 있는 형태 (조금 더 어렵다)
         * - 트리
         * - 그래프
         * 
         */


        // 배열 vs 동적 배열 vs 연결 리스트
        /*
         * 배열 : 
         * - 사용할 방 개수를 고정해서 계약하고(절대 변경 불가)
         * - 연속된 방으로 배정 받아 사용
         * 장점 : 연속된 방
         * 단점 : 방을 추가 / 축소 불가
         * 
         * 동적 배열 : 
         * - 사용할 방 개수를 유동적으로 계약
         * - 연속된 방으로 배정 받아 사용
         * 문제점 : 이사 비용은 어떻게?
         * 할당 정책 
         * - 실제로 사용할 방보다 많이, 여유분을 두고 (대략 1.5 ~ 2배) 예약
         * - 이사 횟수를 최소화
         * 장점 : 유동적인 계약 (방 추가 예약으로 이사 횟수 최소화)
         * 단점 : 중간 삽입 / 삭제
         * 
         * 연결 리스트 :
         * - 연속되지 않은 방을 사용
         * 장점 : 중간 추가 / 삭제 이점
         * 단점 : N번째 방을 바로 찾을 수가 없음 (임의 접근 Random Access 불가)
         * 
         */
        #endregion
        
        
        public void Initialize()
        {
            #region 동적배열 연습
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2];

            _data2.RemoveAt(2);

            _data2_1.Add(101);
            _data2_1.Add(102);
            _data2_1.Add(103);
            _data2_1.Add(104);
            _data2_1.Add(105);

            int temp1 = _data2_1[2];

            _data2_1.RemoveAt(2);
            #endregion

            _data3.AddLast(101);
            _data3.AddLast(102);
            LinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}
