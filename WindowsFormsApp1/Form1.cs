using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<TextBox> piecesList = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            InitializationData();
        }
        private void InitializationData()
        {
            piecesList.Add(firstPiece);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox txtBox = CreatePieceField;
            this.Controls.Add(txtBox);
            piecesList.Add(txtBox);
        }

        private TextBox CreatePieceField
        {
            get
            {
                TextBox lastPiece = piecesList[piecesList.Count - 1];
                TextBox txtBox = new TextBox();
                txtBox.Location = new Point(lastPiece.Location.X, lastPiece.Location.Y + 30);
                txtBox.Size = new Size(160, 20);
                return txtBox;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = int.Parse(kField.Text);
            int w = int.Parse(wField.Text);
            int h = int.Parse(hField.Text);

            ElTable table = new ElTable(w, h, k);
            table.FillTable('.');
            table.CreatePieces(piecesList, k);
            table.DrawTable(ElPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class ElTable
    {
        private char[,] table;
        
        public ElTable(int w, int h, int k)
        {
            table = new char[(h - 1) * (k - 1) + h, (w - 1) * (k - 1) + w];
        }
        public void FillTable(char point)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = point;
                }
            }
        }
        public void CreatePieces(List<TextBox> piecesList, int k)
        {
            foreach (TextBox piece in piecesList) {
                FillPiece(piece.Text, k);
            }
        }

        public void FillPiece(string piece, int k)
        {
            string[] pieceRow = piece.Split(' '); 
            int x1 = int.Parse(pieceRow[0]) * k;
            int y1 = int.Parse(pieceRow[1]) * k;
            int x2 = int.Parse(pieceRow[2]) * k;
            int y2 = int.Parse(pieceRow[3]) * k;

            int diff = (x2 - x1) != 0 ? (x2 - x1) : (y2 - y1);
            diff = Math.Abs(diff) * k;

            while (diff >= 0)
            {
                table[y1, x1] = '*';

                if (x1 == x2) x1 += 0;
                else if (x1 > x2) x1--;
                else x1++;

                if (y1 == y2) y1 += 0;
                else if (y1 > y2) y1--;
                else y1++;

                diff--;
            }
        }
        public void DrawTable(Panel panel) 
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    char point = table[i, j];
                    Button btn = CreatePanelItem(j, i, point);
                    panel.Controls.Add(btn);
                }
            }
        }
        public Button CreatePanelItem(int x, int y, char point)
        {
            Button item = new Button();
            item.Size = new Size(30, 30);
            item.Location = new Point(30 * x, 30 * y);
            item.Text = point.ToString();
            item.Font = new Font(item.Font.FontFamily, 22);
            item.TextAlign = ContentAlignment.MiddleCenter;
            return item;
        }
    }
}
