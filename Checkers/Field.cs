using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public enum FieldColor
    {
        Black,
        Red
    }
    public partial class Field : UserControl
    {
        FieldColor color;
        Color redColor = Color.Crimson;
        Color activeColor = Color.Gainsboro;
        public Point Pos { get; set; }
        private bool active = false;
        public bool Active { get => active; set { active = value; UpdateActive(); } }
        private bool highlighted = false;
        public bool Highlighted { get => highlighted; set { highlighted = value; UpdateHighlight(); } }
        public bool IsRed => color == FieldColor.Red;
        public bool IsBlack => color == FieldColor.Black;
        public Field()
        {
            InitializeComponent();
            Pawn.MouseClick += new MouseEventHandler(Field_MouseClick);
            Active = false;
        }
        public void SetPawn(PawnType type)
        {
            Pawn.SetType(type);
        }
        public void AddOnClick(Action<Field> action)
        {
            MouseClick += new MouseEventHandler((s, e) => action((Field)s));
            Pawn.MouseClick += new MouseEventHandler((s, e) => action((Field)((Pawn)s).Parent));
        }
        public void SetColor(FieldColor color)
        {
            this.BackColor = color == FieldColor.Black ? Color.Black : redColor;
            this.color = color;
        }
        public void SetLocation(int x, int y)
        {
            this.Location = new Point(x, y);
        }
        private void Field_MouseClick(object sender, MouseEventArgs e)
        {
            if (color == FieldColor.Red) return;
            this.Enabled = false;
            Pawn.Enabled = false;

            Active = !Active;

            Pawn.Enabled = true;
            this.Enabled = true;
        }
        private void UpdateActive()
        {
            if (this.color == FieldColor.Red) return;
            Color color = active ? activeColor : Color.Transparent;
            LeftBorderPanel.BackColor = color;
            RightBorderPanel.BackColor = color;
            TopBorderPanel.BackColor = color;
            BottomBorderPanel.BackColor = color;
        }
        private void UpdateHighlight()
        {
            if (this.color == FieldColor.Red) return;
            Color color = highlighted ? Color.White : Color.Transparent;
            LeftBorderPanel.BackColor = color;
            RightBorderPanel.BackColor = color;
            TopBorderPanel.BackColor = color;
            BottomBorderPanel.BackColor = color;
        }
    }
}
