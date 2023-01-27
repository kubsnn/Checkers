using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Pawn : UserControl
    {
        public PawnType Type { get; private set; }
        public bool IsKing => Type == PawnType.BlackKing || Type == PawnType.RedKing;
        public bool IsRed => Type == PawnType.Red || Type == PawnType.RedKing;
        public bool IsBlack => Type == PawnType.Black || Type == PawnType.BlackKing;
        public PawnType Color => (Type == PawnType.Red || Type == PawnType.RedKing) ? PawnType.Red : Type == PawnType.None ? PawnType.None : PawnType.Black;
        public Pawn()
        {
            InitializeComponent();
        }
        public void SetType(PawnType type)
        {
            if (type == PawnType.Red) {
                this.BackgroundImage = global::Checkers.Properties.Resources.red;
            } else if (type == PawnType.Black) {
                this.BackgroundImage = global::Checkers.Properties.Resources.black;
            } else if (type == PawnType.RedKing) {
                this.BackgroundImage = global::Checkers.Properties.Resources.red_king;
            } else if (type == PawnType.BlackKing) {
                this.BackgroundImage = global::Checkers.Properties.Resources.black_king;
            } else {
                this.BackgroundImage = null;
            }

            this.Type = type;
        }
    }
}
