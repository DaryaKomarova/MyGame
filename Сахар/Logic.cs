using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сахар
{
    internal class Logic
    {
        private Value[,] boardValues = new Value[3, 3];
        public Value[,] BoardValues => boardValues;
        private bool turn;
        public Value Turn => !turn ? Value.X : Value.O;

        //очищаем поле при создании
        public Logic()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardValues[i, j] = Value.empty;
                }
            }
        }

        public void RestartValues()
        {
            for(int i = 0;i < 3;i++)
            {
                for( int j = 0;j < 3;j++)
                {
                    boardValues[i,j] = Value.empty;
                }
            }
        }

        public void MakeTurn(int i, int j)
        {
            Value value = turn ? Value.X : Value.O;
            boardValues[i, j] = value;
            turn = !turn;
        }
           
        public bool CheckWin(Value value)
        {
            for (int stroka = 0; stroka < 3; stroka++)
            {
                if (boardValues[stroka, 0] == value &&
                    boardValues[stroka, 1] == value &&
                    boardValues[stroka, 2] == value)
                {
                    return true;
                }
            }
            for (int stolbec = 0; stolbec < 3; stolbec++)
            {
                if (boardValues[0, stolbec] == value &&
                    boardValues[1, stolbec] == value &&
                    boardValues[2, stolbec] == value)
                {
                    return true;
                }
            }
            if (boardValues[0, 0] == value &&
                    boardValues[1, 1] == value &&
                    boardValues[2, 2] == value)
            {
                return true;
            }
            if (boardValues[0, 2] == value &&
                    boardValues[1, 1] == value &&
                    boardValues[2, 0] == value)
            {
                return true;
            }
            return false;
        }
    }
}
