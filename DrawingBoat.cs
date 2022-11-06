using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boats
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение объекта-сущности
    /// </summary>
    internal class DrawningBoat
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public Boat Boat{ private set; get; }
        /// <summary>`
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Верхняя кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private readonly int _boatWidth = 105;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int _boatHeight = 70;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="bodyColor">Цвет кузова</param>
        public void Init(int speed, float weight, Color bodyColor)
        {
            Boat = new Boat();
            Boat.Init(speed, weight, bodyColor);
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            // TODO проверки
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _boatWidth + ((int)Boat.Step) < _pictureWidth - 20)
                    {
                        _startPosX += ((int)Boat.Step);
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX + _boatWidth + ((int)Boat.Step) > _pictureWidth/4 - 80)
                    {
                        _startPosX -= ((int)Boat.Step);
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY + _boatHeight + ((int)Boat.Step) > _pictureHeight/4 - 20)
                    {
                        _startPosY -= ((int)Boat.Step);
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _boatHeight + ((int)Boat.Step) < _pictureHeight + 30)
                    {
                        _startPosY += ((int)Boat.Step);
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            if (_startPosX < 0 || _startPosY < 0
            || !_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }
            Pen pen = new(Color.Black);
            //корма
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 70, _startPosY);
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX, _startPosY+40);
            g.DrawLine(pen, _startPosX, _startPosY + 40, _startPosX + 70, _startPosY+40);
            //нос
            g.DrawLine(pen, _startPosX + 70, _startPosY + 40, _startPosX + 120, _startPosY+20);
            g.DrawLine(pen, _startPosX + 70, _startPosY, _startPosX + 120, _startPosY+20);
            //внутренность
            Rectangle rect = new Rectangle((int)_startPosX + 5, (int)_startPosY + 5, 60, 30);
            g.DrawRectangle(pen, rect);
            /*//границы автомобиля
            g.DrawEllipse(pen, _startPosX, _startPosY, 20, 20);
            g.DrawEllipse(pen, _startPosX, _startPosY + 30, 20, 20);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY, 20, 20);
            g.DrawEllipse(pen, _startPosX + 70, _startPosY + 30, 20, 20);
            g.DrawRectangle(pen, _startPosX - 1, _startPosY + 10, 10, 30);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 10, 10, 30);
            g.DrawRectangle(pen, _startPosX + 10, _startPosY - 1, 70, 52);
            //задние фары
            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, _startPosX, _startPosY, 20, 20);
            g.FillEllipse(brRed, _startPosX, _startPosY + 30, 20, 20);
            //передние фары
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillEllipse(brYellow, _startPosX + 70, _startPosY, 20, 20);
            g.FillEllipse(brYellow, _startPosX + 70, _startPosY + 30, 20, 20);
            //кузов
            Brush br = new SolidBrush(Boat?.BodyColor ?? Color.Black);
            g.FillRectangle(br, _startPosX, _startPosY + 10, 10, 30);
            g.FillRectangle(br, _startPosX + 80, _startPosY + 10, 10, 30);
            g.FillRectangle(br, _startPosX + 10, _startPosY, 70, 50);
            //стекла
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 60, _startPosY + 5, 5, 40);
            g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 5, 5, 40);
            g.FillRectangle(brBlue, _startPosX + 25, _startPosY + 3, 35, 2);
            g.FillRectangle(brBlue, _startPosX + 25, _startPosY + 46, 35, 2);
            //выделяем рамкой крышу
            g.DrawRectangle(pen, _startPosX + 25, _startPosY + 5, 35, 40);
            g.DrawRectangle(pen, _startPosX + 65, _startPosY + 10, 25, 30);
            g.DrawRectangle(pen, _startPosX, _startPosY + 10, 15, 30);*/
        }
        /// <summary>
        /// Смена границ формы отрисовки
        /// </summary>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= _boatWidth || _pictureHeight <= _boatHeight)
            {
                _pictureWidth = null;
                _pictureHeight = null;
                return;
            }
            if (_startPosX + _boatWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - _boatWidth;
            }
            if (_startPosY + _boatHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - _boatHeight;
            }
        }
    }
}
