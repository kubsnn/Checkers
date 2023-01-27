using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class MainForm : Form
    {
        Field[,] fields;
        Field fieldSelected;
        List<Point> highlighted;
        FieldColor turn;
        int moveCount;
        public MainForm()
        {
            InitializeComponent();
            
            LoadBoard();
            highlighted = new List<Point>();
        }

        private void LoadBoard()
        {
            CreateFields();
            PlaceCheckers();
            turn = FieldColor.Red;
            WinnerLabel.Text = string.Empty;
            moveCount = 0;
            MoveCounterLabel.Text = moveCount.ToString();
            TurnLabel.Text = "Czerwone";
            TurnLabel.ForeColor = Color.Red;
        }
        private void CreateFields()
        {
            fields = new Field[8, 8];
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    fields[i, j] = new Field();
                    fields[i, j].AddOnClick(Field_OnClick);
                    fields[i, j].SetLocation(i * 60 + 1, j * 60 + 1);
                    fields[i, j].Pos = new Point(i, j);
                    fields[i, j].SetPawn(PawnType.None);
                    if ((i + j) % 2 == 1) {
                        fields[i, j].SetColor(FieldColor.Black);
                    } else {
                        fields[i, j].SetColor(FieldColor.Red);
                    }
                    this.BoardPanel.Controls.Add(fields[i, j]);
                }
            }
        }
        private void PlaceCheckers()
        {
            for(int i = 0; i < 8; i++) {
                for (int j = 0; j < 3; j++) {
                    if ((i + j) % 2 == 1) {
                        fields[i, j].SetPawn(PawnType.Red);
                    }
                }
            }

            for (int i = 0; i < 8; i++) {
                for (int j = 5; j < 8; j++) {
                    if ((i + j) % 2 == 1) {
                        fields[i, j].SetPawn(PawnType.Black);
                    }
                }
            }
        }
        bool force = false;
        private void Field_OnClick(Field field)
        {
            if (force) {
                if (!highlighted.Contains(field.Pos)) return;
                else force = false;
            }
            if (turn == FieldColor.Red && field.Pawn.IsBlack ||
                   turn == FieldColor.Black && field.Pawn.IsRed) {
                field.Active = false;
                return;
            }
            if (fieldSelected == field) {
                DehighlightAll();
                field.Active = false;
                fieldSelected = null;
                return;
            }
            if (fieldSelected is not null) fieldSelected.Active = false;

            var valid = fieldSelected is not null ? IsMoveValid(ref fieldSelected, ref field) : ValidType.Invalid;
            if (fieldSelected is not null && valid != ValidType.Invalid && highlighted.Contains(field.Pos)) {
                MakeMove(fieldSelected, field);
                field.Active = false;
                DehighlightAll();
                if (valid == ValidType.ValidWithKill) {
                    if (IsAnyKillPossible(ref field, out List<Point> poses) && poses.Contains(field.Pos)) {
                        fieldSelected = field; 
                        fieldSelected.Active = true;
                        HighlightValidMoves(field);
                        force = true;
                    } else {
                        fieldSelected = null;
                        ChangeTurn();
                    }
                } else {
                    fieldSelected = null;
                    ChangeTurn();
                }
                return;
            } else {
                DehighlightAll();
            }
            fieldSelected = field;
            HighlightValidMoves(field);
        }
        private void ChangeTurn()
        {
            if (CheckForWin()) {
                string winner = turn == FieldColor.Red ? "Czerwony" : "Czarny";
                WinnerLabel.Text = winner + " wygrał!";
                return;
            }
            turn = turn == FieldColor.Red ? FieldColor.Black : FieldColor.Red;
            if (turn == FieldColor.Red) {
                TurnLabel.Text = "Czerwone";
                TurnLabel.ForeColor = Color.Red;
                moveCount++;
            } else {
                TurnLabel.Text = "Czarne";
                TurnLabel.ForeColor = Color.Black;
            }

            MoveCounterLabel.Text = moveCount.ToString();
        }
        // returns true on kill
        private bool MakeMove(Field from, Field to)
        {
            bool kill = CleanUpKilledPawn(from, to);
            to.Pawn.SetType(from.Pawn.Type);
            from.Pawn.SetType(PawnType.None);

            if (to.Pawn.Color == PawnType.Red && to.Pos.Y == 7) {
                to.Pawn.SetType(PawnType.RedKing);
            } else if (to.Pawn.Color == PawnType.Black && to.Pos.Y == 0) {
                to.Pawn.SetType(PawnType.BlackKing);
            }
            return kill;
        }
        private bool CheckForWin()
        {
            var colorToCheck = turn == FieldColor.Black ? PawnType.Red : PawnType.Black;
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (fields[i, j].Pawn.Color == colorToCheck) return false;
                }
            }
            return true;
        }
        private bool CleanUpKilledPawn(Field from, Field to)
        {
            int x_diff = from.Pos.X - to.Pos.X;
            int y_diff = from.Pos.Y - to.Pos.Y;
            bool kill = false;
            if (x_diff < 0) {
                if (y_diff < 0) {
                    for (int i = from.Pos.X + 1, j = from.Pos.Y + 1; i < to.Pos.X && j < to.Pos.Y; i++, j++) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color != fields[i, j].Pawn.Color) {
                            fields[i, j].Pawn.SetType(PawnType.None);
                            kill = true;
                            break;
                        }
                    }
                } else {
                    for (int i = from.Pos.X + 1, j = from.Pos.Y - 1; i < to.Pos.X && j > to.Pos.Y; i++, j--) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color != fields[i, j].Pawn.Color) {
                            fields[i, j].Pawn.SetType(PawnType.None);
                            kill = true;
                            break;
                        }
                    }
                }
            } else {
                if (y_diff < 0) {
                    for (int i = from.Pos.X - 1, j = from.Pos.Y + 1; i > to.Pos.X && j < to.Pos.Y; i--, j++) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color != fields[i, j].Pawn.Color) {
                            fields[i, j].Pawn.SetType(PawnType.None);
                            kill = true;
                            break;
                        }
                    }
                } else {
                    for (int i = from.Pos.X - 1, j = from.Pos.Y - 1; i > to.Pos.X && j > to.Pos.Y; i--, j--) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color != fields[i, j].Pawn.Color) {
                            fields[i, j].Pawn.SetType(PawnType.None);
                            kill = true;
                            break;
                        }
                    }
                }
            }

            return kill;
        }
        private void HighlightValidMoves(Field field)
        {
            highlighted.Clear();

            if (IsAnyKillPossible(ref field, out List<Point> poses)) {
                if (!poses.Contains(field.Pos)) {
                    return;
                }
            }
            var fieldsWithKills = new List<Point>();
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (field.Pos.X == i && field.Pos.Y == j) continue;
                    if (i == 4 && j == 5) {
                        Console.Write("XDF");
                    }
                    var valid = IsMoveValid(ref field, ref fields[i, j]);
                    if (valid == ValidType.Invalid) continue;
                    if (valid == ValidType.ValidWithKill) {
                        fieldsWithKills.Add(new Point(i, j));
                    }
                    highlighted.Add(new Point(i, j));
                    fields[i, j].Highlighted = true;
                }
            }
            if (fieldsWithKills.Count > 0) {
                DehighlightAll();
                highlighted.Clear();
                foreach (var p in fieldsWithKills) {
                    fields[p.X, p.Y].Highlighted = true;
                    highlighted.Add(p);
                }
            }
        }
        private void DehighlightAll()
        {
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (fields[i, j].Highlighted) fields[i, j].Highlighted = false;
                }
            }
        }
        enum ValidType
        {
            Invalid,
            Valid,
            ValidWithKill
        }
        private bool IsAnyKillPossible(ref Field from, out List<Point> poses)
        {
            poses = new List<Point>();
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (fields[i, j].Pawn.Type == PawnType.None) continue;
                    if (from.Pawn.Color != fields[i, j].Pawn.Color) continue;

                    for (int k = 0; k < 8; k++) {
                        for (int m = 0; m < 8; m++) {
                            var valid = IsMoveValid(ref fields[i, j], ref fields[k, m]);
                            if (valid == ValidType.ValidWithKill) {
                                poses.Add(new Point(i, j));
                            }
                        }
                    }
                }
            }
            return poses.Count > 0;
        }
        private ValidType IsMoveValid(ref Field from, ref Field to)
        {
            if (to.Pos == new Point(2, 3) && from.Pawn.Type == PawnType.RedKing) {
                Console.WriteLine("XD");
            }
            if (to.IsRed) return ValidType.Invalid;
            if (from.Pawn.Type == PawnType.None) return ValidType.Invalid;
            if (to.Pawn.Type != PawnType.None) return ValidType.Invalid;
            
            int x_diff = from.Pos.X - to.Pos.X;
            int y_diff = from.Pos.Y - to.Pos.Y;
            int x_diff_abs = Math.Abs(x_diff);
            int y_diff_abs = Math.Abs(y_diff);

            if (x_diff_abs != y_diff_abs) return ValidType.Invalid;

            if (x_diff_abs == 1) {
                if (from.Pawn.IsKing) return ValidType.Valid;
                if (from.Pawn.IsRed && y_diff == -1) return ValidType.Valid;
                if (from.Pawn.IsBlack && y_diff == 1) return ValidType.Valid;
                return ValidType.Invalid;
            }
            
            if (from.Pawn.Type == PawnType.Red) {
                if (y_diff_abs == 2 && x_diff_abs == 2) {
                    Field between = fields[(from.Pos.X + to.Pos.X) / 2, (from.Pos.Y + to.Pos.Y) / 2];
                    if (between.Pawn.IsBlack) return ValidType.ValidWithKill;
                }
            } else if (from.Pawn.Type == PawnType.Black) {
                if (y_diff_abs == 2 && x_diff_abs == 2) {
                    Field between = fields[(from.Pos.X + to.Pos.X) / 2, (from.Pos.Y + to.Pos.Y) / 2];
                    if (between.Pawn.IsRed) return ValidType.ValidWithKill;
                }
            } else if (from.Pawn.IsKing) {
                return CheckIfKingHasValidMove(ref from, ref to, x_diff, y_diff);
            }
            return ValidType.Invalid;
        }
        private ValidType CheckIfKingHasValidMove(ref Field from, ref Field to, int x_diff, int y_diff)
        {
            int counter = 0;
            if (x_diff < 0) {
                if (y_diff < 0) {
                    for (int i = from.Pos.X + 1, j = from.Pos.Y + 1; i < to.Pos.X && j < to.Pos.Y; i++, j++) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color == fields[i, j].Pawn.Color)
                            return ValidType.Invalid;
                        else
                            counter++;

                        if (counter > 1) return ValidType.Invalid;
                    }
                } else {
                    for (int i = from.Pos.X + 1, j = from.Pos.Y - 1; i < to.Pos.X && j > to.Pos.Y; i++, j--) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color == fields[i, j].Pawn.Color)
                            return ValidType.Invalid;
                        else
                            counter++;

                        if (counter > 1) return ValidType.Invalid;
                    }
                }
            } else {
                if (y_diff < 0) {
                    for (int i = from.Pos.X - 1, j = from.Pos.Y + 1; i > to.Pos.X && j < to.Pos.Y; i--, j++) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color == fields[i, j].Pawn.Color)
                            return ValidType.Invalid;
                        else
                            counter++;

                        if (counter > 1) return ValidType.Invalid;
                    }
                } else {
                    for (int i = from.Pos.X - 1, j = from.Pos.Y - 1; i > to.Pos.X && j > to.Pos.Y; i--, j--) {
                        if (fields[i, j].Pawn.Type == PawnType.None) continue;
                        if (from.Pawn.Color == fields[i, j].Pawn.Color)
                            return ValidType.Invalid;
                        else
                            counter++;

                        if (counter > 1) return ValidType.Invalid;
                    }
                }
            }

            return counter == 1 ? ValidType.ValidWithKill : ValidType.Valid;
        }
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void RestartGame()
        {
            this.BoardPanel.Controls.Clear();
            LoadBoard();
        }
    }
}
