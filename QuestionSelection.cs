using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enviormental_Issues_Quiz_Program
{
    class QuestionSelection
    {
        static Random _random = new Random();
        
        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
        
        public int[] selectQuestions()
        {
            int[] questionAll = new int[30] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            Shuffle(questionAll);

            int[] questionSelected;
            questionSelected = new int[10];

            for (int i = 0; i < 10; i++)
            {
                questionSelected[i] = questionAll[i];
            }

            return questionSelected;
        }

    }
}
