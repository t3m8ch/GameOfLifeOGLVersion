using System;
using System.Threading.Tasks;

namespace GameOfLifeLibrary
{
    public class Game
    {
        private Random random = new Random();

        public bool IsStarted { get; private set; }

        public bool[,] Field { get; private set; }
        
        public int Cols { get; private set; } // Ширина
        public int Rows { get; private set; } // Высота

        public int Density { get; private set; } // Плотность

        public int Generations { get; private set; }

        public Game() 
        { 
            IsStarted = false;
            Field = new bool[Cols, Rows];
        }

        public async Task StartAsync(int cols, int rows, int density = 10, bool isMultithread = false)
        {
            Generations = 0;

            Cols = cols;
            Rows = rows;
            Density = density;

            Field = new bool[Cols, Rows];

            IsStarted = true;

            GenerateRandomField();

            await Task.Run(() =>
            {
                while (IsStarted)
                {
                    if (isMultithread)
                        GenerateNextFieldMultithread();
                    else
                        GenerateNextField();

                    Generations++;
                }
            });
        }

        public void Stop()
        {
            IsStarted = false;
        }

        public int GetCountLiving()
        {
            int count = 0;

            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                    if (Field[i, j]) count++;
            }

            return count;
        }

        public async Task<int> GetCountLivingAsync()
        {
            return await Task.Run(GetCountLiving);
        }

        private void GenerateRandomField()
        {
            for (int x = 0; x < Cols; x++)
            {
                for (int y = 0; y < Rows; y++)
                    Field[x, y] = random.Next(0, Density) == 0;
            }
        }

        //private void GenerateRandomFieldMultiThread()
        //{
        //    Parallel.For(0, Cols - 1, x =>
        //    {
        //        Parallel.For(0, Rows - 1, y =>
        //        {
        //            Field[x, y] = random.Next(0, Density) == 0;
        //        });
        //    });
        //}

        private void GenerateNextField()
        {
            var newField = new bool[Cols, Rows];

            for (int x = 0; x < Cols; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    var hasLife = Field[x, y];
                    var countNeighbours = CalculateCountNeighbours(x, y);

                    if (!hasLife && countNeighbours == 3)
                        newField[x, y] = true;
                    else if (hasLife && (countNeighbours < 2 || countNeighbours > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = hasLife;
                }
            }

            Field = newField;
        }

        private void GenerateNextFieldMultithread()
        {
            var newField = new bool[Cols, Rows];

            Parallel.For(0, Cols - 1, x =>
            {
                Parallel.For(0, Rows - 1, y =>
                {
                    var hasLife = Field[x, y];
                    var countNeighbours = CalculateCountNeighbours(x, y);

                    if (!hasLife && countNeighbours == 3)
                        newField[x, y] = true;
                    else if (hasLife && (countNeighbours < 2 || countNeighbours > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = hasLife;
                });
            });

            Field = newField;
        }

        private int CalculateCountNeighbours(int x, int y)
        {
            var count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + Cols) % Cols;
                    var row = (y + j + Rows) % Rows;

                    var hasLife = Field[col, row];

                    var IsSelfChecking = col == x && row == y;

                    if (hasLife && !IsSelfChecking)
                        count++;
                }
            }

            return count;
        }
    }
}
