using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Samples
        Sudoku ExtraEasy = new Sudoku(new List<int>() { 
           6, 0, 0, 1, 0, 8, 2, 0, 3,
           0, 2, 0, 0, 4, 0, 0, 9, 0,
           8, 0, 3, 0, 0, 5, 4, 0, 0,
            5, 0, 4, 6, 0, 7, 0, 0, 9,
            0, 3, 0 , 0, 0, 0, 0, 5, 0,
            7, 0, 0, 8, 0, 3, 1, 0, 2,
            0, 0, 1, 7, 0, 0, 9, 0, 6,
            0, 8, 0, 0, 3, 0, 0, 2, 0,
            3, 0, 2, 9, 0, 4, 0, 0, 5
            });

        Sudoku Easy177 = new Sudoku(new List<int>() { 
          9, 0, 0, 0, 0, 7, 1, 0, 0,
          0, 0, 0, 0, 0, 9, 0, 6, 7,
          0, 0, 6, 0, 0, 0, 8, 0, 0,
          0, 8, 1, 6, 0, 0, 3, 0, 0,
          0, 0, 0, 0, 8, 5, 0, 0, 9,
          7, 0, 0, 0, 0, 0, 0, 0, 0,
          0, 5, 0, 0, 2, 0, 0, 0, 4,
          0, 2, 0, 0, 0, 0, 9, 0, 0,
          0, 0, 9, 0, 3, 0, 0, 0, 0
            });

        Sudoku Easy178 = new Sudoku(new List<int>() { 
       0, 0, 6, 2, 0, 7, 0, 0, 0,
       8, 0, 0, 0, 0, 0, 7, 0, 0,
       0, 0, 0, 0, 5, 0, 2, 0, 0,
       0, 0, 0, 0, 0, 6, 8, 0, 4,
       0, 0, 5, 8, 0, 0, 0, 0, 0,
       6, 4, 0, 0, 1, 0, 0, 0, 3,
       0, 3, 0, 7, 0, 0, 0, 0, 5,
       1, 0, 0, 0, 0, 0, 0, 0, 0,
       0, 0, 0, 6, 0, 4, 0, 2, 0
        });

        Sudoku Easy8666076989 = new Sudoku(new List<int>() { 
       1, 0, 3, 0, 0, 6, 5, 0, 0,
       0, 8, 2, 4, 0, 0, 1, 0, 0,
       0, 0, 5, 3, 1, 0, 2, 9, 0,
       2, 0, 0, 0, 9, 0, 6, 5, 3,
       0, 0, 0, 0, 0, 0, 0, 0, 0,
       6, 5, 1, 0, 3, 0,0, 0, 4,
       0, 2, 4, 0, 7, 1, 3, 0, 0,
       0, 0, 6, 0, 0, 5, 8, 2, 0,
       0, 0, 8, 6, 0, 0, 4, 0, 5
        });

        Sudoku Medium9365052984 = new Sudoku(new List<int>() { 
      3, 0, 6, 0, 8, 1, 0, 0, 0,
      4, 2, 0, 0, 0, 3, 0, 1, 0,
      0, 0, 0, 0, 0, 0, 0, 3, 0,
      7, 0, 9, 0, 2, 0, 4, 0, 5,
      0, 0, 0, 0, 9, 0, 0, 0, 0,
      5, 0, 8, 0, 1, 0, 2, 0, 9,
      0, 7, 0, 0, 0, 0, 0, 0, 0,
      0, 4, 0, 8, 0, 0, 0, 9, 6,
      0, 0, 0, 9, 3, 0, 1, 0, 2
        });

        Sudoku Hard1109562280 = new Sudoku(new List<int>() { 
      0, 9, 0, 3, 4, 0, 7, 0, 0,
      0, 0, 0, 0, 0, 0, 1, 0, 2,
      0, 0, 0, 8, 7, 0, 4, 0, 3,
      2, 0, 0, 0, 0, 5, 3, 0, 0,
      7, 0, 0, 0, 0, 0, 0, 0, 5,
      0, 0, 5, 9, 0, 0, 0, 0, 1,
      9, 0, 7, 0, 2, 8, 0, 0, 0,
      5, 0, 1, 0, 0, 0, 0, 0, 0,
      0, 0, 8, 0, 9, 4, 0, 1, 0
        });

        Sudoku Evil8025151644 = new Sudoku(new List<int>() { 
    0, 0, 1, 0, 0, 8, 0, 0, 9,
    0, 0, 4, 0, 1, 0, 0, 0, 7,
    0, 0, 0, 3, 0, 0, 0, 0, 6,
    1, 0, 3, 0, 0, 2, 7, 0, 0,
    0, 5, 0, 0, 0, 0, 0, 8, 0,
    0, 0, 9, 5, 0, 0, 1, 0, 2,
    5, 0, 0, 0, 0, 7, 0, 0, 0,
    7, 0, 0, 0, 8, 0, 4, 0, 0,
    3, 0, 0, 4, 0, 0, 6, 0, 0
        });

        Sudoku NewCreated = new Sudoku(new List<int>() {
            3, 0, 0, 0, 5, 0, 0, 1, 0, 
0, 0, 1, 0, 0, 6, 0, 9, 0, 
0, 6, 7, 0, 0, 0, 2, 0, 8, 
7, 5, 0, 0, 9, 8, 1, 0, 0, 
0, 0, 8, 0, 0, 5, 0, 0, 0, 
0, 3, 0, 0, 0, 4, 9, 0, 0, 
0, 1, 0, 8, 0, 0, 6, 0, 0, 
0, 0, 0, 0, 4, 2, 8, 7, 0, 
0, 7, 0, 0, 1, 0, 0, 0, 3
        });

        Sudoku NewMedium = new Sudoku(new List<int>()
        {
            0, 0, 0, 0, 4, 5, 0, 7, 0, 
0, 0, 0, 0, 3, 0, 0, 4, 0, 
4, 0, 0, 0, 0, 0, 0, 6, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 2, 
5, 0, 0, 0, 0, 0, 0, 1, 0, 
6, 0, 7, 4, 0, 0, 0, 0, 0, 
0, 4, 8, 5, 2, 7, 3, 0, 6, 
9, 5, 3, 0, 0, 0, 0, 2, 0, 
2, 7, 0, 0, 9, 4, 0, 8, 5,
        });

        Sudoku CreatedEasy = new Sudoku(new List<int>()
        {
            0, 8, 0, 0, 4, 7, 0, 2, 1,
            0, 0, 0, 0, 0, 0, 9, 7, 0,
            0, 0, 9, 0, 1, 0, 0, 6, 0,
            0, 3, 0, 0, 0, 4, 1, 0, 0,
            0, 0, 0, 7, 0, 0, 6, 0, 0, 
            0, 0, 6, 0, 0, 0, 2, 4, 0,
            0, 6, 5, 1, 7, 3, 0, 0, 4,
            7, 0, 8, 5, 9, 6, 0, 0, 0, 
            0, 0, 0, 0, 8, 0, 0, 5, 6
        });

        Sudoku CreatedMedium = new Sudoku(new List<int>()
        {
            3, 0, 6, 9, 0, 0, 0, 0, 0,
            0, 0, 0, 3, 1, 0, 8, 6, 2,
            0, 0, 0, 7, 2, 0, 0, 0, 5,
            7, 3, 8, 0, 0, 0, 0, 1, 0,
            0, 0, 0, 0, 0, 3, 0, 0, 9,
            0, 0, 2, 0, 0, 8, 0, 0, 0, 
            0, 1, 7, 0, 5, 0, 0, 4, 8,
            4, 0, 5, 0, 0, 0, 0, 0, 1,
            0, 0, 0, 0, 6, 0, 0, 0, 0
        });

        Sudoku CreatedHard = new Sudoku(new List<int>()
        {
            3, 2, 0, 0, 8, 0, 0, 0, 0,
            0, 0, 7, 0, 0, 0, 0, 9, 0,
            9, 5, 8, 7, 1, 4, 0, 0, 0,
            5, 0, 0, 0, 6, 0, 7, 0, 0,
            6, 0, 0, 3, 0, 0, 0, 0, 8,
            8, 0, 3, 0, 7, 5, 0, 2, 0,
            4, 0, 0, 0, 0, 7, 0, 0, 0, 
            2, 0, 0, 6, 9, 0, 0, 0, 7,
            0, 0, 0, 4, 0, 0, 0, 0, 3
        });

        Sudoku CreatedMedium2 = new Sudoku(new List<int>()
        {
            0, 0, 0, 0, 8, 0, 0, 0, 0, 
            0, 0, 2, 3, 0, 7, 9, 0, 0, 
            0, 0, 0, 0, 9, 6, 0, 3, 4,
            1, 8, 0, 0, 7, 0, 0, 0, 0, 
            0, 0, 0, 0, 3, 0, 6, 0, 0, 
            2, 6, 3, 4, 0, 0, 8, 7, 0,
            7, 0, 4, 0, 0, 0, 0, 8, 0,
            0, 2, 6, 8, 0, 3, 4, 0, 7,
            0, 5, 0, 0, 0, 0, 0, 0, 0
        });

        Sudoku XWINGSAMPLE = new Sudoku(new List<int>()
        {
            0, 0, 0, 0, 0, 0, 0, 9, 4,
            7, 6, 0, 9, 1, 0, 0, 5, 0,
            0, 9, 0, 0, 0, 2, 0, 8, 1,
            0, 7, 0, 0, 5, 0, 0, 1, 0,
            0, 0, 0, 7, 0, 9, 0, 0, 0,
            0, 8, 0, 0, 3, 1, 0, 6, 7,
            2, 4, 0, 1, 0, 0, 0, 7, 0,
            0, 1, 0,0, 9, 0,0, 4, 5,
            9, 0, 0, 0, 0, 0, 1, 0, 0
        });

        Sudoku Diff3 = new Sudoku(new List<int>()
        {
            0, 0, 0, 0, 0, 6, 0, 0, 3,
            0, 0, 2, 0, 0, 3, 4, 0, 8,
            4, 0, 0, 0, 8, 0, 0, 1, 0,
            2, 0, 6, 7, 9, 0, 0, 0, 0, 
            0, 0, 0, 0, 6, 0, 0, 7, 0,
            8, 5, 0, 0, 0, 0, 9, 0, 0,
            0, 0, 0, 0, 0, 9, 0, 0, 0, 
            5, 3, 0, 0, 4, 8, 0, 0, 0,
            0, 0, 8, 0, 0, 0, 3, 0, 2
        });

        Sudoku KniffelSudoku = new Sudoku(new List<int>()
        {
            0, 6, 0, 0, 0, 0, 0, 5, 0,
            3, 0, 0, 0, 0, 0, 0, 0, 1,
            0, 0, 2, 1, 0, 5, 8, 0, 0,
            0, 0, 7, 0, 1, 0, 2, 0, 0, 
            0, 0, 0, 6, 0, 3, 0, 0, 0, 
            0, 0, 5, 0, 2, 0, 7, 0, 0,
            0, 0, 8, 9, 0, 1, 4, 0, 0,
            4, 0, 0, 0, 0, 0, 0, 0, 5,
            0, 9, 0, 0, 0, 0, 0, 2, 0
        });

        #endregion

        TextBox[][] Texts;

        private void Form1_Load(object sender, EventArgs e)
        {
            Texts = new TextBox[9][];
            for (int i = 0; i < 9; i++)
            {
                Texts[i] = new TextBox[9];
                for (int j = 0; j < 9; j++)
                {
                    Texts[i][j] = new TextBox();
                    this.Controls.Add(Texts[i][j]);
                    Texts[i][j].Width = 20;
                    Texts[i][j].Height = 20;
                    Texts[i][j].Left = (j + 1) * 22;
                    Texts[i][j].Top = (i + 1) * 22;
                }
            }
        }

        public void ShowSudoku(Sudoku suk)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.DrawLine(new Pen(new SolidBrush(Color.Black), 3), 22 * 4 - 1, 22 * 1, 22 * 4 - 1, 22 * 10 - 1);
            G.DrawLine(new Pen(new SolidBrush(Color.Black), 3), 22 * 7 - 1, 22 * 1, 22 * 7 - 1, 22 * 10 - 1);

            G.DrawLine(new Pen(new SolidBrush(Color.Black), 3), 22 * 1, 22 * 4 - 1, 22 * 10 - 1, 22 * 4 - 1);
            G.DrawLine(new Pen(new SolidBrush(Color.Black), 3), 22 * 1, 22 * 7 - 1, 22 * 10 - 1, 22 * 7 - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sudoku ToBeSolved;
            List<int> Fields = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Texts[i][j].Text == "")
                        Fields.Add(0);
                    else
                        Fields.Add(int.Parse(Texts[i][j].Text));
                }
            }
            ToBeSolved = new Sudoku(Fields);
            SudokuSolver Solver = new SudokuSolver();
            Sudoku Result = Solver.Solve(ToBeSolved, false, 4);
            Display(Result);
            label1.Text = "Difficulty: " + Result.Difficulty.ToString();
            label2.Text = "Rem1: " + Result.Rem1.ToString();
            label3.Text = "Rem2: " + Result.Rem2.ToString();
            label4.Text = "Rem3: " + Result.Rem3.ToString();
        }

        private void Display(Sudoku suk)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (suk.Fields[i][j].Value == 0)
                        Texts[i][j].Text = "";
                    else
                        Texts[i][j].Text = suk.Fields[i][j].Value.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SudokuCreator Creator = new SudokuCreator();
            int Difficulty = 1;
            int TargetDel = 32;

            if (radioButton1.Checked)
            {
                Difficulty = 1;
                TargetDel = 32;
            }
            if (radioButton2.Checked)
            {
                Difficulty = 1;
                TargetDel = 30;
            }
            if (radioButton3.Checked)
            {
                Difficulty = 2;
                TargetDel = 29;
            }
            if (radioButton4.Checked)
            {
                Difficulty = 3;
                TargetDel = 28;
            }
            if (radioButton5.Checked)
            {
                Difficulty = 4;
                TargetDel = 26;
            }
            Sudoku Created = Creator.CreateRandomSudoku(Difficulty, 81 - TargetDel);
            Display(Created);
        }
    }

    public class Sudoku
    {
        public class Field
        {
            public int Value;
            public List<int> Candidates;
            public bool Filled;

            public int i;
            public int j;
            public bool NewFound;

            public Field(int _i, int _j)
            {
                Candidates = new List<int>();
                Filled = false;
                i = _i;
                j = _j;
                NewFound = false;
            }

            public Field Copy()
            {
                Field Result = new Field(i, j);
                foreach (int ii in Candidates)
                    Result.Candidates.Add(ii);
                Result.Filled = Filled;
                Result.Value = Value;
                Result.NewFound = NewFound;
                return Result;
            }
        }

        public Field[][] Fields;
                    public int Difficulty;
            public int Rem1;
            public int Rem2;
            public int Rem3;
            public int NrSolutions;

        public Sudoku Copy()
        {
            Sudoku Result = new Sudoku(new List<int>());
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Result.Fields[i][j] = Fields[i][j].Copy();
                }
            }
            Result.Difficulty = Difficulty;
            Result.Rem1 = Rem1;
            Result.Rem2 = Rem2;
            Result.Rem3 = Rem3;
            Result.NrSolutions = NrSolutions;

            return Result;
        }

        public Sudoku(List<int> values)
        {
            Difficulty = 1;
            Rem1 = -1;
            Rem2 = -1;
            Rem3 = -1;
            NrSolutions = 0;

            Fields = new Field[9][];
            for (int i = 0; i < 9; i++)
            {
                Fields[i] = new Field[9];
                for (int j = 0; j < 9; j++)
                {
                    Fields[i][j] = new Field(i, j);
                }
            }

            // fills the Sudoku with the given values
            int a = 0;
            int b = 0;
            for (int x = 0; x < values.Count; x++)
            {
                if (values[x] != 0)
                {
                    Fields[b][a].Value = values[x];
                    Fields[b][a].NewFound = true;
                    Fields[b][a++].Filled = true;
                }
                else
                    a++;
                if (a > 8)
                {
                    a = 0;
                    b++;
                }
            }
        }

        public void Draw(string path)
        {
            Bitmap Result = new Bitmap(450, 450);
            Graphics G = Graphics.FromImage(Result);

            G.Clear(Color.White);

            Pen Fat = new Pen(new SolidBrush(Color.Black), 8);
            Pen Thin = new Pen(new SolidBrush(Color.Black), 2);

            for (int i = 0; i < 10; i++)
            {
                Pen Current;
                if (i % 3 == 0)
                    Current = Fat;
                else
                    Current = Thin;
                G.DrawLine(Current, 50 * i, 0, 50 * i, 450);
                G.DrawLine(Current, 0, 50 * i, 450, 50 * i);
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Fields[i][j].Value != 0)
                    G.DrawString(Fields[i][j].Value.ToString(), new Font("Arial", 20), new SolidBrush(Color.Black), j * 50 + 12, i * 50 + 9);
                }
            }
                Result.Save(path);
        }
        // returns all fields in a column
        public List<Field> GetColumn(int i, int j)
        {
            List<Field> Result = new List<Field>();
            for (int a = 0; a < 9; a++)
            {
                if (a != i)
                    Result.Add(Fields[a][j]);
            }
            return Result;
        }

        // returns all fields in a row
        public List<Field> GetRow(int i, int j)
        {
            List<Field> Result = new List<Field>();
            for (int a = 0; a < 9; a++)
            {
                if (a != j)
                    Result.Add(Fields[i][a]);
            }
            return Result;
        }

        // returns all fields in a box
        public List<Field> GetBox(int i, int j)
        {
            List<Field> Result = new List<Field>();
            int iStart = i - i % 3;
            int jStart = j - j % 3;

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    if (iStart + a != i || jStart + b != j)
                        Result.Add(Fields[iStart + a][jStart + b]);
                }

            }
            return Result;
        }

        // returns all fields in a group
        public List<Field> GetGroup(int i, int j)
        {
            List<Field> Row = GetRow(i, j);
            List<Field> Column = GetColumn(i, j);
            List<Field> Box = GetBox(i, j);
            List<Field> Result = new List<Field>();
            Result.AddRange(Row);
            Result.AddRange(Column);
            Result.AddRange(Box);
            return Result;
        }

        // returns all fields from either a row, column or box
        public List<Field> GetGroupPart(int i, int j, int part)
        {
            switch (part)
            {
                case 0:
                    return GetRow(i, j);
                case 1:
                    return GetColumn(i, j);
                case 2:
                    return GetBox(i, j);
                default:
                    return null;
            }
        }

        public string Debug(int Difficulty)
        {
            string Result = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Result += Fields[i][j].Value.ToString() + " ";
                }
                Result += Environment.NewLine;
            }
            Result += "  Difficulty: " + Difficulty.ToString();
            return Result;
        }

        public bool BelongsToBox(int i, int j, Field f)
        {
            int iStart = i - i % 3;
            int jStart = j - j % 3;
            if (f.i >= iStart && f.i <= iStart + 2 && f.j >= jStart && f.j <= jStart + 2)
                return true;
            else
                return false;
        }
    }

    public class SudokuSolver
    {
        Sudoku Input; // Workung Sudoku
        int SolCounter; // Solution counter
        int Remaining; // Fields yet to be found
        bool Finished; // true when done

        bool Changed;

        public Sudoku Solve(Sudoku suk, bool count, int maxDifficulty)
        {
            Remaining = 81;
            Input = suk;
            InitCandidates();
            SolCounter = 0;

            int Difficulty = 1;
            int HighestDifficulty = 1;

            Input.Rem1 = -1;
            Input.Rem2 = -1;
            Input.Rem3 = -1;

            while (Remaining > 0)
            {
                int oldRem = Remaining;

                if (Grade0())
                    continue;

                if (Grade1())
                    continue;

                if (Difficulty >= 2)
                {
                    if (Input.Rem1 == -1)
                        Input.Rem1 = Remaining;

                    if (GradeX(2))
                    {
                        continue;
                    }
                    if (CandidateLine())
                    {
                        continue;
                    }
                }

                if (Difficulty >= 3)
                {
                    if (Input.Rem2 == -1)
                        Input.Rem2 = Remaining;

                    if (GradeX(3))
                        continue;
                    if (XWing())
                    {
                        continue;
                    }
                }

                if (Difficulty >= 4)
                {   // this completes the sudoku in one step
                    if (Input.Rem3 == -1)
                        Input.Rem3 = Remaining;

                    NonLogic(count);
                }

                if (Remaining == oldRem)
                {
                    Difficulty++;
                    if (Difficulty > HighestDifficulty)
                        HighestDifficulty = Difficulty;

                    if (Difficulty > maxDifficulty)
                    {
                        Input.Difficulty = HighestDifficulty;
                        Input.NrSolutions = 0;
                        return null;
                    }
                    if (Difficulty > 4)
                        break;
                }
                else
                    Difficulty = 1;
            }

            // brute force counts the number of solutions
            Input.NrSolutions = SolCounter;
            if (Input.NrSolutions == 0)
                Input.NrSolutions = 1; // no brute force used
            
            Input.Difficulty = HighestDifficulty;
            return Input;
        }

        private void InitCandidates()
        {
            Remaining = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int z = 1; z <= 9; z++)
                        {
                            Input.Fields[i][j].Candidates.Add(z);
                        }
                        Remaining++;
                        Input.Fields[i][j].NewFound = false;
                    }
                    else
                        Input.Fields[i][j].NewFound = true;
                }
            }
        }

        private bool Grade0()
        {
        bool Change = false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Input.Fields[i][j].NewFound)
                    {
                        foreach (Sudoku.Field f in Input.GetGroup(i, j))
                        {
                            if (!f.Filled)
                            {   // remove all candidates which have already been placed in the group
                                if (f.Candidates.Remove(Input.Fields[i][j].Value))
                                    Change = true;
                            }
                        }
                     Input.Fields[i][j].NewFound = false;
                    }
                }
            }

            return Change;
        }

        private bool Grade1()
        {
            // Direct = Naked Single
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled && Input.Fields[i][j].Candidates.Count == 1)
                    {   // for fields with only one remaining candidate chose that
                        Input.Fields[i][j].Value = Input.Fields[i][j].Candidates[0];
                        Input.Fields[i][j].Filled = true;
                        Input.Fields[i][j].NewFound = true;
                        Remaining--;
                        return true;
                    }
                }
            }
            // Inverse = Hidden Single
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int a = 0; a < Input.Fields[i][j].Candidates.Count; a++)
                        {
                            for (int part = 0; part < 3; part++)
                            {
                                bool Found = false;
                                foreach (Sudoku.Field f in Input.GetGroupPart(i, j, part))
                                {
                                    if (!f.Filled && f.Candidates.Contains(Input.Fields[i][j].Candidates[a]))
                                    {
                                        Found = true;
                                        break;
                                    }
                                }
                                if (!Found)
                                {   // if one candidate of field X never occurs in the candidate lists of the other fields in one part of the group of X, chose that
                                    Input.Fields[i][j].Value = Input.Fields[i][j].Candidates[a];
                                    Input.Fields[i][j].Filled = true;
                                    Input.Fields[i][j].NewFound = true;
                                    Remaining--;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool GradeX(int x)
        {
            // Direct = Hidden Double, Triple etc.
            Changed = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled && Input.Fields[i][j].Candidates.Count >= x)
                    {
                        for (int a = 0; a < Input.Fields[i][j].Candidates.Count; a++)
                        {
                            List<int> Temp = new List<int>();
                            Temp.Add(a);
                            RekGradeX(i, j, Temp, 1, x); // recursively try the direct version
                        }
                    }
                }
            }

            // Opposite = Naked Double, Triple etc.
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled && Input.Fields[i][j].Candidates.Count == x)
                    {
                        for (int part = 0; part < 3; part++)
                        {
                            int FoundCounter = 0;
                            List<int> FoundI = new List<int>();
                            List<int> FoundJ = new List<int>();
                            foreach (Sudoku.Field f in Input.GetGroupPart(i, j, part))
                            {
                                if (!f.Filled && f.Candidates.Count == x)
                                {
                                    bool Found = true;
                                    for (int z = 0; z < x; z++)
                                    {
                                        if (!f.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                        {
                                            Found = false;
                                            break;
                                        }
                                    }
                                    if (Found)
                                    {
                                        FoundCounter++;
                                        FoundI.Add(f.i);
                                        FoundJ.Add(f.j);
                                    }
                                }

                            }
                            // now we know that all of the x candidates of field i, j appear in x - 1 other fields in that part of the group
                            if (FoundCounter == x - 1)
                            {   // they have to be filled to one of these x fields, delete the candidates in all other fields of the group part
                                bool ErasedSomething = false;
                                foreach (Sudoku.Field ff in Input.GetGroupPart(i, j, part))
                                {
                                    if (FoundI.Contains(ff.i) && FoundJ.Contains(ff.j))
                                        continue;
                                    for (int z = 0; z < x; z++)
                                    {
                                        if (ff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                            ErasedSomething = true;
                                    }
                                }
                                return ErasedSomething;
                            }
                        }
                    }
                }
            }
            if (Changed)
                return true;
            else
                return false;
        }

        private void RekGradeX(int i, int j, List<int> current, int depth, int x)
        {
            if (depth < x)
            {
                for (int a = 0; a < Input.Fields[i][j].Candidates.Count; a++)
                {
                    if (!current.Contains(a))
                    {
                        List<int> Copied = Copy(current);
                        Copied.Add(a);
                        RekGradeX(i, j, Copied, depth + 1, x);
                    }
                }
            }
            else
            {
                // when reached the bottom of the recursion, x candidates of field i, j have been selected
                for (int part = 0; part < 3; part++)
                {
                    int Found = 0;
                    List<int> FoundI = new List<int>();
                    List<int> FoundJ = new List<int>();

                    foreach (Sudoku.Field f in Input.GetGroupPart(i, j, part))
                    {
                        if (!f.Filled)
                        {
                            for (int z = 0; z < x; z++)
                            {
                                if (f.Candidates.Contains(Input.Fields[i][j].Candidates[current[z]]))
                                {
                                    Found++;
                                    FoundI.Add(f.i);
                                    FoundJ.Add(f.j);
                                    break;
                                }
                            }
                            if (Found > x - 1)
                                break;
                        }
                    }
                    if (Found == x - 1)
                    {
                        // now we know that the selected x candidates only occur in x - 1 fields in that part of the group
                        bool Match = true;
                        for (int a = 0; a < FoundI.Count; a++)
                        {
                            for (int z = 0; z < x; z++)
                            {   // now we check if those x - 1 fields contain all x candidates
                                if (!Input.Fields[FoundI[a]][FoundJ[a]].Candidates.Contains(Input.Fields[i][j].Candidates[current[z]]))
                                {
                                    Match = false;
                                    break;
                                }
                            }
                        }
                        if (Match)
                        {   // if yes, they have to be filled to one of these x fields, delete all other candidates
                            List<int> Candidates = new List<int>();

                            for (int z = 0; z < x; z++)
                            {
                                Candidates.Add(Input.Fields[i][j].Candidates[current[z]]);
                            }

                            if (Input.Fields[i][j].Candidates.Count() != Candidates.Count)
                                Changed = true;
                            Input.Fields[i][j].Candidates = new List<int>();
                            for (int z = 0; z < x; z++)
                            {
                                Input.Fields[i][j].Candidates.Add(Candidates[z]);
                            }
                            for (int a = 0; a < FoundI.Count; a++)
                            {
                                if (Input.Fields[FoundI[a]][FoundJ[a]].Candidates.Count() != Candidates.Count)
                                    Changed = true;
                                Input.Fields[FoundI[a]][FoundJ[a]].Candidates = new List<int>();
                                for (int z = 0; z < x; z++)
                                {
                                    Input.Fields[FoundI[a]][FoundJ[a]].Candidates.Add(Candidates[z]);
                                }
                            }
                            return;
                        }
                    }
                }
            }
        }

        private void NonLogic(bool count)
        {   
            // find all not yet solved fields
            List<Sudoku.Field> ToDo = new List<Sudoku.Field>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                        ToDo.Add(Input.Fields[i][j]);
                }
            }
            Finished = false;
            // solve these by trying out all combinations
            BruteForce(ToDo, 0, Input, count);
        }

        private void BruteForce(List<Sudoku.Field> ToDo, int pos, Sudoku Temp, bool count)
        {
            if (Finished)
                return;
            for (int i = 0; i < ToDo[pos].Candidates.Count; i++)
            {
                Sudoku Copied = Temp.Copy();
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Filled = true;
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].NewFound = false;
                // place a random value and ...
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value = ToDo[pos].Candidates[i];
                bool Valid = true;
                // ... check if solution is still valid
                foreach (Sudoku.Field f in Copied.GetGroup(ToDo[pos].i, ToDo[pos].j))
                {
                    if (f.Filled && f.Value == Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value)
                    {
                        Valid = false;
                        break;
                    }
                }
                if (Valid)
                {   // if yes, go to the next position
                    if (pos % 5 == 0)
                        Grade0();
                    if (pos < ToDo.Count - 1) 
                        BruteForce(ToDo, pos + 1, Copied, count);
                    else
                    {   // or otherwise, we are done
                        if (!count)
                        {
                            Finished = true;
                            Input = Copied;
                            Remaining = 0;
                        }
                        else
                        {   // if we want to count the solutions, we do not stop after having found the first one
                            SolCounter++;
                            Remaining = 0;
                            if (SolCounter > 1)
                            {
                                Finished = true;
                            }
                        }
                    }
                }
            }
        }

        private bool CandidateLine()
        {
            bool Found = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int z = 0; z < Input.Fields[i][j].Candidates.Count; z++)
                        {
                            int Direction = 0; // 1 = Vertical, 2 = Horizontal
                            foreach (Sudoku.Field f in Input.GetBox(i, j))
                            {
                                if (!f.Filled && f.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                {
                                    if (Direction == 0)
                                    {
                                        if (f.i == i)
                                            Direction = 2;
                                        else if (f.j == j)
                                            Direction = 1;
                                        else
                                            Direction = -1;
                                    }
                                    else
                                    {
                                        if (f.i == i && Direction == 2)
                                            Direction = 2;
                                        else
                                        {
                                            Direction = -1;
                                            break;
                                        }
                                        if (f.j == j && Direction == 1)
                                            Direction = 1;
                                        else
                                        {
                                            Direction = -1;
                                            break;
                                        }
                                    }
                                }
                            }

                            if (Direction == 1)
                            {
                                foreach (Sudoku.Field f in Input.GetColumn(i, j))
                                {
                                    if (!Input.BelongsToBox(i, j, f) && !f.Filled)
                                    {
                                        if (f.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                            Found = true;
                                    }
                                }
                            }
                            if (Direction == 2)
                            {
                                foreach (Sudoku.Field f in Input.GetRow(i, j))
                                {
                                    if (!Input.BelongsToBox(i, j, f) && !f.Filled)
                                        if (f.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                            Found = true;
                                }
                            }

                            if (Found)
                                return true;
                        }
                    }
                }
            }

            return Found;
        }

        private bool XWing()
        {
            bool Found = false;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (!Input.Fields[i][j].Filled)
                    {
                        for (int z = 0; z < Input.Fields[i][j].Candidates.Count; z++)
                        {
                            bool RowPossible1 = true;
                            bool ColumnPossible1 = true;
                            bool RowPossible2 = true;
                            bool ColumnPossible2 = true;

                            int RowCounter1 = 1;
                            foreach (Sudoku.Field a in Input.GetColumn(i, j))
                            {
                                if (!a.Filled && a.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                {
                                    RowCounter1++;
                                }
                            }
                            if (RowCounter1 != 2)
                                RowPossible1 = false;

                            int ColumnCounter1 = 1;
                            foreach (Sudoku.Field a in Input.GetRow(i, j))
                            {
                                if (!a.Filled && a.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                {
                                    ColumnCounter1++;
                                }
                            }
                            if (ColumnCounter1 != 2)
                                ColumnPossible1 = false;


                            if (!RowPossible1 && !ColumnPossible1)
                                continue;

                            foreach (Sudoku.Field f in Input.GetRow(i, j))
                            {
                                if (!f.Filled && f.Candidates.Contains(Input.Fields[i][j].Candidates[z]) && !Input.BelongsToBox(i, j, f)) // 2nd point
                                {
                                    int RowCounter2 = 1;
                                    RowPossible2 = true;
                                    foreach (Sudoku.Field b in Input.GetColumn(f.i, f.j))
                                    {
                                        if (!b.Filled && b.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                        {
                                            RowCounter2++;
                                        }
                                    }
                                    if (RowCounter2 != 2)
                                        RowPossible2 = false;

                                    foreach (Sudoku.Field ff in Input.GetColumn(i, j))
                                    {
                                        if (!ff.Filled && ff.Candidates.Contains(Input.Fields[i][j].Candidates[z]) && !Input.BelongsToBox(i, j, ff)) // 3rd point
                                        {
                                            int ColumnCounter2 = 1;
                                            ColumnPossible2 = true;
                                            foreach (Sudoku.Field c in Input.GetRow(ff.i, ff.j))
                                            {
                                                if (!c.Filled && c.Candidates.Contains(Input.Fields[i][j].Candidates[z]))
                                                {
                                                    ColumnCounter2++;
                                                }
                                            }
                                            if (ColumnCounter2 != 2)
                                                ColumnPossible2 = false;

                                            if ((!RowPossible1 || !RowPossible2) && (!ColumnPossible1 || !ColumnPossible2))
                                                continue;

                                            Sudoku.Field fff = Input.Fields[ff.i][f.j];
                                            {
                                                if (!fff.Filled && !Input.BelongsToBox(ff.i, ff.j, fff) && fff.Candidates.Contains(Input.Fields[i][j].Candidates[z])) // 4th point
                                                {
                                                    if (ColumnPossible1 && ColumnPossible2)
                                                    {
                                                        foreach (Sudoku.Field ffff in Input.GetColumn(i, j))
                                                        {
                                                            if (ffff.i == ff.i && ffff.j == ff.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                        foreach (Sudoku.Field ffff in Input.GetColumn(f.i, f.j))
                                                        {
                                                            if (ffff.i == fff.i && ffff.j == fff.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                    }

                                                    if (RowPossible1 && RowPossible2)
                                                    {
                                                        foreach (Sudoku.Field ffff in Input.GetRow(i, j))
                                                        {
                                                            if (ffff.i == f.i && ffff.j == f.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                        foreach (Sudoku.Field ffff in Input.GetRow(ff.i, ff.j))
                                                        {
                                                            if (ffff.i == fff.i && ffff.j == fff.j)
                                                                continue;
                                                            if (ffff.Candidates.Remove(Input.Fields[i][j].Candidates[z]))
                                                                Found = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (Found)
                                return true;
                        }
              
                    }
                }
            }
            return Found;
        }

        private List<int> Copy(List<int> dummy)
        {
            List<int> Result = new List<int>();
            foreach (int i in dummy)
                Result.Add(i);
            return Result;
        }
    }

    public class SudokuCreator
    {
        bool Finished;
        Random Rnd;
        Sudoku Result;

        public Sudoku CreateRandomSudoku(int Difficulty, int targetdels)
        {
            bool Start = true;
           
            bool Done = false;
            int Deleted = 0;
            int Tolerance = 10;

            // Various counters, we count the iterations we do in case the created instance somehow gets stuck, then we reset
            int FieldDelCounter = 0;
            int ResetCounter1 = 0;
            int ResetCounter2 = 0;
            Sudoku NewSudoku = null;
            Sudoku Fallback = null;
            int FallbackCounter = 0;

            while (!Done)
            {
                if (ResetCounter1 > 40)
                {
                    ResetCounter1 = 0;
                    Start = true;
                }
                if (ResetCounter2 > 40)
                {
                    ResetCounter2 = 0;
                    Start = true;
                }

                if (Start)
                {
                    // first, create a complete sudoku using brute force
                    NewSudoku = new Sudoku(new List<int>());
                    List<Sudoku.Field> ToDo = new List<Sudoku.Field>();
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            ToDo.Add(NewSudoku.Fields[i][j]);
                        }
                    }
                    Rnd = new Random();
                    Finished = false;
                    BruteForce(ToDo, 0, NewSudoku);
                    FallbackCounter = 0;
                    NewSudoku = Result.Copy();
                    Start = false;
                    Fallback = null;
                }

                Sudoku Cloned = NewSudoku.Copy();
                int difficulty = Difficulty;
                // take out one field and check if solutions still is unique and not harder than desired
                if (DeleteField(Cloned, ref difficulty))
                {
                    NewSudoku = Cloned;
                    Deleted++;

                    if (NewSudoku.Difficulty == Difficulty && Deleted >= targetdels)
                    {   // in this case we are done   
                        NewSudoku.Difficulty = difficulty;
                        return NewSudoku;
                    }
                    else if (difficulty == Difficulty && Deleted < targetdels)
                    { // matching difficulty found but more fields have to be deleted
                        Fallback = NewSudoku.Copy();
                    }
                    else if (Deleted >= targetdels + Tolerance) // enough fields deleted but not desired difficulty
                    {
                        if (FallbackCounter < 100 && Fallback != null) // first try fallback
                        {
                            NewSudoku = Fallback.Copy();
                        }
                        else
                        {
                            NewSudoku = Result.Copy();
                            ResetCounter1++;
                            FallbackCounter = 0;
                        }
                        Deleted = 0;

                    }
                }
                else
                {
                    FieldDelCounter++;
                    if (FieldDelCounter > 100) // probably no more field can be deleted to get the desired difficulty
                    {
                        FieldDelCounter = 0;
                        NewSudoku = Result.Copy();
                        Deleted = 0;
                        ResetCounter2++;
                    }
                    continue;
                }
            }

            return Result;
        }

        private bool DeleteField(Sudoku temp, ref int difficulty)
        {
            int i = Rnd.Next(0, 9); ;
            int j = Rnd.Next(0, 9); ;

            // select random not yet deleted field
            while (!temp.Fields[i][j].Filled) {
                i = Rnd.Next(0, 9);
                j = Rnd.Next(0, 9);
            }

            temp.Fields[i][j].Value = 0;
            temp.Fields[i][j].Filled = false;
            SudokuSolver Test = new SudokuSolver();
            int counter = 0;
            int Difficulty = difficulty;
            // check the desired characteristics
            Sudoku Temp = Test.Solve(temp.Copy(), true, Difficulty);
            if (Temp == null)
                return false;
            temp.Difficulty = Temp.Difficulty;
            if (Temp.NrSolutions > 1 || Temp.Difficulty > Difficulty)
                return false;
            else
                return true;
        }

        private void BruteForce(List<Sudoku.Field> ToDo, int pos, Sudoku Temp)
        {   // the brute force implementation for creating complete sudokus
            if (Finished)
                return;
            for (int i = 1; i <= 9; i++)
            {
                Sudoku Copied = Temp.Copy();
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Filled = true;
                Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value = Rnd.Next(1, 10);
                bool Valid = true;
                foreach (Sudoku.Field f in Copied.GetGroup(ToDo[pos].i, ToDo[pos].j))
                {
                    if (f.Filled && f.Value == Copied.Fields[ToDo[pos].i][ToDo[pos].j].Value)
                    {
                        Valid = false;
                        break;
                    }
                }
                if (Valid)
                {
                    if (pos < ToDo.Count - 1)
                        BruteForce(ToDo, pos + 1, Copied);
                    else
                    {
                        Finished = true;
                        Result = Copied;
                    }
                }
            }
        }
    }
}
