using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    class SudokuFunctionality
    {
        public int[] CreateFullSudokuTable()
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9};
            int[][] sudokuArr = new int[9][];
            for (int i = 0; i < 9; i++) { sudokuArr[i] = new int[9]; }
            int[] arrWithIndex = { 3, 6, 1, 4, 7, 2, 5, 8 };
            sudokuArr[0] = numbers.ToArray();

            for (int r = 1, h = 0, colum = 1; colum < 9; r++, h++, colum++)
            {
                for (int i = 0, x = 0, j = arrWithIndex[h]; i < 9; i++, j++)
                {
                    if (j < numbers.Count)
                    {
                        sudokuArr[colum][i] = numbers[j];
                    }
                    else
                    {
                        sudokuArr[colum][i] = numbers[x];
                        ++x;
                    }
                }
            }
            MyDelegate[] myDelegateArr = new MyDelegate[3];
            myDelegateArr[0] = new MyDelegate(ConvertColumnToRow);
            myDelegateArr[1] = new MyDelegate(PermutationRow);
            myDelegateArr[2] = new MyDelegate(PermutationColon);
            Random random = new Random();
            for (int i = 0; i < myDelegateArr.Length; i++)
            {
                if (random.Next(0,2) == 0)
                {
                    myDelegateArr[i](ref sudokuArr); 
                }
            }
            return ConvertJaggedArrToSimpleArr(sudokuArr);
        }
        public void SudokuOutPut(int[] sudokuArr, TextBox[] textBoxs, int indexLevel)
        {
            int coutn = 0;
            int[] numberTo = { 0, 3, 7, 8, 12, 15 };
            foreach (var item in textBoxs)
            {
                item.Clear();
                item.BackColor = Color.White;
                item.Enabled = true;
                item.BorderStyle = BorderStyle.None;
            }
            Random r = new Random();
            for (int i = 0; i < textBoxs.Length; i++)
            {
                for (int j = 0; j < numberTo.Length; j++)
                {
                    if (r.Next(0, indexLevel) == 3)
                    {
                        textBoxs[i].Text = sudokuArr[i].ToString();
                        coutn++;
                        textBoxs[i].Enabled = false;
                    }
                }
            }
        }
        public bool CheckFunction(TextBox[] textBoxs, int[] sudokuArr, Timer timer1)
        {
            bool result = false;
            int corrent = 0;
            for (int i = 0; i < textBoxs.Length; i++)
            {
                if (textBoxs[i].Text != sudokuArr[i].ToString())
                {
                    corrent++;
                    textBoxs[i].BackColor = Color.Red;
                }
                else
                {
                    textBoxs[i].BackColor = Color.White;
                }
            }
            if (corrent == 0)
            {
                timer1.Enabled = false;
                result = true;
            }
            return result;
        }
        private void ConvertColumnToRow(ref int[][] arr)
        {
            int[][] newArr = new int[9][];
            for (int i = 0; i < 9; i++) { newArr[i] = new int[9]; }
            for (int i = 0, x = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++, x++)
                {
                    newArr[i][j] = arr[j][i];
                }
            }
            arr = newArr;
        }
        private void PermutationRow(ref int[][] arr)
        {
            int[] temp;

            for (int i = 0; i < 9; i += 3)
            {
                temp = arr[i];
                arr[i] = arr[i + 2];
                arr[i + 2] = temp;
            }
        }
        private void PermutationColon(ref int[][] arr)
        {
            for (int i = 0; i < 9; i += 3)
            {
                int[] temp = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    temp[j] = arr[j][i];
                }
                for (int x = 0; x < 9; x++)
                {
                    arr[x][i] = arr[x][i + 2];
                }
                for (int y = 0; y < 9; y++)
                {
                    arr[y][i + 2] = temp[y];
                }
            }
        }
        private int[] ConvertJaggedArrToSimpleArr(int[][] arr)
        {
            int[] simpleArr = new int[arr.Length * arr.Length];
            for (int i = 0, x = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++, x++)
                {
                    simpleArr[x] = arr[i][j];
                }
            }
            return simpleArr;
        }
        private delegate void MyDelegate(ref int[][] arr);
    }
}
