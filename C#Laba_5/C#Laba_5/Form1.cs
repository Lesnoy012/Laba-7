using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Laba_5
{
    public partial class Form1 : Form
    {
        const int N = 20000000;
        const int COUNT_OF_CICLE = 500000;
        int[] sortedArray = new int[N];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sortedArray[0] = 0;
            for (int i = 1; i < N; i++)
            {
                sortedArray[i] = rnd.Next(1, 3) + sortedArray[i - 1];
            }
        }

        private void ButtonFindClick(object sender, EventArgs e)
        {
            //Неоптимальный бинарный поиск
            int key = (int)InputKey.Value;
            /*            int keyNeOptimIndex = -1;
                        int StartTimeNeOptim = Environment.TickCount;
                        {
                            for (int j = 0; j < COUNT_OF_CICLE; j++)
                            {
                                int LeftNeOptim = 0;
                                int RightNeOptim = N - 1;
                                int index = (LeftNeOptim + RightNeOptim) / 2;
                                while (RightNeOptim >= LeftNeOptim)
                                {
                                    if (key == sortedArray[index])
                                    {
                                        keyNeOptimIndex = index;
                                        break;
                                    }

                                    if (key < sortedArray[index])
                                    {
                                        RightNeOptim = index - 1;
                                    }
                                    else
                                    {
                                        LeftNeOptim = index + 1;
                                    }
                                    index = (LeftNeOptim + RightNeOptim) / 2;
                                }
                            }
                        }
                        int ResultTimeNeOptim = Environment.TickCount - StartTimeNeOptim;
                        TimeForNeoptimBinarySearch.Text = ResultTimeNeOptim.ToString();

                        if (keyNeOptimIndex == -1)
                        {
                            IndexForNeoptimBinarySearch.Text = "Не найден";
                        }
                        else
                        {
                            IndexForNeoptimBinarySearch.Text = keyNeOptimIndex.ToString();
                        }

                        //Оптимальный бинарный поиск
                        int RightOptim = 0;
                        int LeftOptim;
                        int StartTimeOptim = Environment.TickCount;
                        {
                            for (int j = 0; j < COUNT_OF_CICLE; j++)
                            {
                                RightOptim = N - 1;
                                LeftOptim = 0;
                                int index = (LeftOptim + RightOptim) / 2;
                                while (RightOptim > LeftOptim)
                                {
                                    if (key <= sortedArray[index])
                                    {
                                        RightOptim = index;
                                    }
                                    else
                                    {
                                        LeftOptim = index + 1;
                                    }
                                    index = (LeftOptim + RightOptim) / 2;
                                }
                            }
                        }
                        int ResultTimeOptim = Environment.TickCount - StartTimeOptim;
                        TimeForOptimBinarySearch.Text = ResultTimeOptim.ToString();

                        if (sortedArray[RightOptim] == key)
                        {
                            IndexForOptimDinarySearch.Text = RightOptim.ToString();
                        }
                        else
                        {
                            IndexForOptimDinarySearch.Text = "Не найден";
                        }

                        //Интерпаляционный бинарный поиск
                        long keyInterpolIndex = -1;
                        int StartTimeInterpol = Environment.TickCount;
                        {
                            for (int j = 0; j < COUNT_OF_CICLE; j++)
                            {
                                long LeftInterpol = 0;
                                long RightInterpol = N - 1;
                                long index = 0;
                                while (sortedArray[LeftInterpol] < key || key < sortedArray[RightInterpol])
                                {
                                    index = LeftInterpol + (key - sortedArray[LeftInterpol]) * (RightInterpol - LeftInterpol) / (sortedArray[RightInterpol] - sortedArray[LeftInterpol]);
                                    if (key == sortedArray[index])
                                    {
                                        keyInterpolIndex = index;
                                        break;
                                    }
                                    if (key < sortedArray[index])
                                    {
                                        RightInterpol = index - 1;
                                    }
                                    else
                                    {
                                        LeftInterpol = index + 1;
                                    }

                                }
                                if (key == sortedArray[LeftInterpol])
                                {
                                    index = LeftInterpol;
                                }
                                if (key == sortedArray[RightInterpol])
                                {
                                    index = RightInterpol;
                                }
                            }
                        }
                        int ResultTimeInterpol = Environment.TickCount - StartTimeInterpol;
                        TimeForInterBinarySearch.Text = ResultTimeInterpol.ToString();


                        if (keyInterpolIndex == -1)
                        {
                            IndexForInterBinarySearch.Text = "Не найден";
                        }
                        else
                        {
                            IndexForInterBinarySearch.Text = keyInterpolIndex.ToString();
                        }*/

            // Последовательный бинарный поиск
            int P = 0;
            int B = 0;
            int StartTimeBinarniyPosledovatelniyPoisk = Environment.TickCount;
            {
                for (int j = 0; j < COUNT_OF_CICLE; j++)
                {
                    P = 1;
                    B = N / 2;
                    while (B > 0)
                    {
                        while ((P + B < N) && (sortedArray[P + B] < key))
                        {

                            P = P + B;
                        }
                        B = B / 2;
                    }
                }
            }
            int ResultTimeBinarniyPosledovatelniyPoisk = Environment.TickCount - StartTimeBinarniyPosledovatelniyPoisk;
            TimeForPosledBinatySearch.Text = ResultTimeBinarniyPosledovatelniyPoisk.ToString();

            if (sortedArray[P + 1] == key)
            {
                IndexForPosledBinarySearch.Text = (P + 1).ToString();
            }
            else
            {
                IndexForPosledBinarySearch.Text = "Не найдено";
            }

            //Оптимальный последовательный поиск
            sortedArray[N - 1] = key + 1;
            int StartTimeC = Environment.TickCount;
            {
                int indexSortedArray = 0;
                for (int j = 0; j < COUNT_OF_CICLE; j++)
                {
                    indexSortedArray = 0;
                    while (sortedArray[indexSortedArray] < key)
                    {
                        indexSortedArray++;
                    }
                }

                if (sortedArray[indexSortedArray] == key && indexSortedArray != N)
                {
                    TimeForPosledNeupr.Text = indexSortedArray.ToString();
                }
                else
                {
                    TimeForPosledNeupr.Text = "Ключ не найден";
                }
            }
            int ResultTimeC = Environment.TickCount - StartTimeC;
            TimeForPosledUpr.Text = ResultTimeC.ToString();
        }



        private void ButtonExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}