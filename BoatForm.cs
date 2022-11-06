using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boats
{
    public partial class BoatForm : Form
    {
        private DrawningBoat _boat;
        public BoatForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_create_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _boat = new DrawningBoat();
            _boat.Init(rnd.Next(100, 300), rnd.Next(1000, 2000),
           Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            _boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100),
           pictureBoxBoat.Width, pictureBoxBoat.Height);
            toolStripLabel_color.Text = $"Скорость: {_boat.Boat.Speed}";
            toolStripLabel_weight.Text = $"Вес: {_boat.Boat.Weight}";
            toolStripLabel_color.Text = $"Цвет: { _boat.Boat.BodyColor.Name}";
            Draw();
        }
        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_move_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "btn_up":
                    _boat?.MoveTransport(Direction.Up);
                    break;
                case "btn_down":
                    _boat?.MoveTransport(Direction.Down);
                    break;
                case "btn_left":
                    _boat?.MoveTransport(Direction.Left);
                    break;
                case "btn_right":
                    _boat?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        /// <summary>
        /// Метод прорисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new(pictureBoxBoat.Width, pictureBoxBoat.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _boat?.DrawTransport(gr);
            pictureBoxBoat.Image = bmp;
        }
        

        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxCar_Resize(object sender, EventArgs e)
        {
            _boat?.ChangeBorders(pictureBoxBoat.Width, pictureBoxBoat.Height);
            Draw();
        }
    }
}
