using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePaint
{
    public enum ToolType
    {
        Mouse,
        Pen,
        Rectangle,
        Ellipse,
        Eraser
    }

    public delegate void OnChangePosition(Point position);

    public partial class Canvas : PictureBox
    {
        public Canvas()
        {
            InitializeComponent();
        }

        private Color toolColor;
        private OnChangePosition changePosition;
        public Color ToolColor
        {
            get => toolColor;
            set => toolColor = value;
        }

        private ToolType toolType;
        
        private bool isMouseDown = false;
        private bool isMouseUp = true;
        private bool isGameOver = false;
        
        private List<PointF> points = new List<PointF>();
        public Bitmap Paper { get; set; }
        public int GridSize { get => gridSize; set {
                gridSize = value;
                Invalidate();
            }
        }

        public OnChangePosition ChangePosition { get => changePosition; set => changePosition = value; }

        private Point currentPoint = new Point();

        private int gridSize = 0;
        private bool caroMode = false;
        private List<PointF> playerStep = new List<PointF>();
        private char[,] caroBoard = new char[0, 0];

        public void Draw(ToolType tool, Color color)
        {
            this.toolType = tool;
            this.toolColor = color;

            // Set Cursor type
            switch (tool)
            {
                case ToolType.Mouse:
                    Cursor = Cursors.Default;
                    break;
                case ToolType.Pen:
                    Cursor = Cursors.UpArrow;
                    break;
                case ToolType.Ellipse:
                case ToolType.Rectangle:
                    Cursor = Cursors.Cross;
                    break;
                case ToolType.Eraser:
                    Cursor = Cursors.No;
                    break;
            }

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isMouseDown = true;
            isMouseUp = false;
            currentPoint = PointToClient(Cursor.Position);
            if (caroMode &&!isGameOver)
            {
                playerStep.Add(currentPoint);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isMouseUp = true;
            isMouseDown = false;
            points.Clear();
            switch (toolType)
            {
                case ToolType.Rectangle:
                    using (Graphics g = Graphics.FromImage(Paper))
                    {
                        g.FillRectangle(new SolidBrush(toolColor),
                            TwoPointToRect(currentPoint, PointToClient(Cursor.Position)));
                    }
                    break;
                case ToolType.Ellipse:
                    using (Graphics g = Graphics.FromImage(Paper))
                    {
                        g.FillEllipse(new SolidBrush(toolColor),
                            TwoPointToRect(currentPoint, PointToClient(Cursor.Position)));
                    }
                    break;
            }
            Invalidate();
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
           
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            ChangePosition?.Invoke(this.PointToClient(Cursor.Position));
            Point pos = this.PointToClient(Cursor.Position);
            if (isMouseDown)
            {
                points.Add( this.PointToClient(Cursor.Position));
                using (Graphics g = Graphics.FromImage(Paper)) 
                { 
                    Drawing(g);
                }
                Invalidate();
            }
           
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Paper = new Bitmap(this.Width,this.Height);
            if (gridSize != 0 && caroMode)
            {
                caroBoard = new char[(Width / gridSize) + 1, (Height / gridSize) + 1];
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Paper != null)
            {
                e.Graphics.DrawImage(Paper,0,0);
            }

            switch (toolType)
            {
                case ToolType.Rectangle:
                    e.Graphics.DrawRectangle(new Pen(Color.Black,2f),TwoPointToRect(PointToClient(Cursor.Position),currentPoint) ); 
                    break;
                case ToolType.Ellipse:
                    e.Graphics.DrawEllipse(new Pen(Color.Black,2f),TwoPointToRect(PointToClient(Cursor.Position),currentPoint) ); 
                    break;
            }
            if (gridSize > 0)
            {
                int x = 0;
                while (x < this.Width)
                {
                    e.Graphics.DrawLine(new Pen(Color.Gray, 1f), x, 0, x, this.Height);
                    x += gridSize;
                }
                int y = 0;
                while (y < this.Height)
                {
                    e.Graphics.DrawLine(new Pen(Color.Gray, 1f), 0, y, this.Width, y);
                    y += gridSize;
                }
                if (caroMode)
                {

                    bool isPlayer1 = true;
                    Point finalStep = new Point();
                    foreach (PointF point in playerStep)
                    {
                        x = 0;
                        while (x < Width)
                        {
                            if (point.X > x && point.X < x + gridSize)
                                break;
                            x += gridSize;
                        }
                        y = 0;
                        while (y < Height)
                        {
                            if (point.Y > y && point.Y < y + gridSize)
                                break;
                            y += gridSize;
                        }

                        char current = caroBoard[x / gridSize, y / gridSize];

                        if (isPlayer1)
                        {
                            if (current != 'O')
                            {
                                e.Graphics.DrawLine(new Pen(Color.Red, 5), x + 10, y + 10, x + gridSize - 10, y + gridSize - 10);
                                e.Graphics.DrawLine(new Pen(Color.Red, 5), x + gridSize - 10, y + 10, x + 10, y + gridSize - 10);

                                caroBoard[x / gridSize, y / gridSize] = 'X';
                                finalStep = new Point(x / gridSize, y / gridSize);

                                isPlayer1 = !isPlayer1;
                            }
                        }
                        else
                        {
                            if (current != 'X')
                            {
                                e.Graphics.DrawEllipse(new Pen(Color.Blue, 5), x + 10, y + 10, gridSize - 20, gridSize - 20);
                                caroBoard[x / gridSize, y / gridSize] = 'O';
                                finalStep = new Point(x / gridSize, y / gridSize);

                                isPlayer1 = !isPlayer1;
                            }
                        }
                    }

                    List<Point> checkOver = CheckGameOver(caroBoard, isPlayer1?'O':'X', finalStep.X, finalStep.Y);
                    List<Point> winLine = new List<Point>();
                    if (checkOver != null)
                    {
                        checkOver.ForEach((p) =>
                        {
                            winLine.Add(new Point(p.X * gridSize + gridSize / 2, p.Y * gridSize + gridSize / 2));
                        });
                        e.Graphics.DrawLines(new Pen(isPlayer1?Color.Blue:Color.Red, 5), winLine.ToArray());
                        isGameOver = true;
                    }
                
                   
                }
            }

        }

        private Rectangle TwoPointToRect(Point p1, Point p2)
        {
            int diffX = p1.X - p2.X;
            int diffY = p1.Y - p2.Y;
            int width = Math.Abs(diffX);
            int height = Math.Abs(diffY);
            if (diffX < 0 && diffY < 0)
            {
                return new Rectangle(p1.X, p1.Y, width,height);
            }

            if (diffX > 0 && diffY < 0)
            {
                return new Rectangle(p2.X, p1.Y, width,height);
            }

            if (diffX < 0 && diffY > 0)
            {
                return new Rectangle(p1.X,p2.Y,width,height);
            }

            if (diffX > 0 && diffY > 0)
            {
                return new Rectangle(p2.X,p2.Y,width,height);
            }
            return new Rectangle();
        }

        private void Drawing(Graphics graphics)
        {
            switch (toolType)
            {
                case ToolType.Pen:
                    if (points.Count > 1)
                    {
                        graphics.DrawLines(new Pen(toolColor, 2f), points.ToArray());
                    }
                    break;
                case ToolType.Eraser:
                    if (points.Count > 1)
                    {
                        graphics.DrawLines(new Pen(Color.White, 10f), points.ToArray());
                    }
                    break;
            }

        }

        public void Clear()
        {
            Paper = new Bitmap(this.Width, this.Height);
            playerStep.Clear();
            if (caroMode)
            {
                caroBoard = new char[(Width / gridSize) + 1, (Height / gridSize) + 1];
            }
            isGameOver = false;
            Invalidate();
        }

        public void ToggleGrid(int gridSize)
        {
            if (this.gridSize == 0)
            {
                this.gridSize = gridSize;
            }
            else
            {
                this.gridSize = 0;
            }
            Invalidate();
        }

        public void ToggleCaroMode()
        {
            caroMode = !caroMode;
            caroBoard = new char[(Width / gridSize) + 1, (Height / gridSize) + 1];
            Invalidate();
        }

        private List<Point> SpreadCheck(char[,] board, char player, int x, int y, int goUp, int goRight)
        {
            List<Point> result = new List<Point>();
            try
            {
                while (true)
                {
                    if (board[x, y] == player)
                    {
                        result.Add(new Point(x, y));
                        x += goRight;
                        y += goUp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch{}

            return result;
        }

        private List<Point> CheckGameOver(char[,] board,char player,int x, int y)
        {
            List<Point> rightCrossResult = new List<Point>();
            List<Point> leftCrossResult = new List<Point>();
            List<Point> horizontalResult = new List<Point>();
            List<Point> verticalResult = new List<Point>();

            rightCrossResult.AddRange(SpreadCheck(board, player, x, y, -1, 1));
            rightCrossResult.AddRange(SpreadCheck(board, player, x, y, 1, -1));

            if (rightCrossResult.Count >= 6)
            {
                return rightCrossResult;
            }

            leftCrossResult.AddRange(SpreadCheck(board, player, x, y, -1, -1));
            leftCrossResult.AddRange(SpreadCheck(board, player, x, y, 1, 1));

            if (leftCrossResult.Count >= 6)
            {
                return leftCrossResult;
            }

            horizontalResult.AddRange(SpreadCheck(board, player, x, y, 0, 1));
            horizontalResult.AddRange(SpreadCheck(board, player, x, y, 0, -1));

            if (horizontalResult.Count >= 6)
            {
                return horizontalResult;
            }

            verticalResult.AddRange(SpreadCheck(board, player, x, y, 1, 0));
            verticalResult.AddRange(SpreadCheck(board, player, x, y, -1, 0));

            if (verticalResult.Count >= 6)
            {
                return verticalResult;
            }
           

            return null;
        }

    }
}