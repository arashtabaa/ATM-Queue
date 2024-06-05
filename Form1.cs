using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ATM_Queue.Properties;

namespace ATM_Queue
{
    public partial class Form1 : Form
    {
        // تعریف یک صف برای نگهداری افراد در صف
        private readonly Queue<int> _queue = new();
        // لیستی از تصاویر برای نمایش افراد در صف
        private readonly List<Bitmap> _images = new() { Resources.Person1, Resources.Person2, Resources.Person3};
        // آرایه‌ای از PictureBox ها برای نمایش تصاویر افراد
        private readonly PictureBox[] _pictureBoxes;
        // شمارنده‌های داخلی برای مدیریت صف
        private int _personCount = 1, _front = 0, _rear = 0;

        public Form1()
        {
            InitializeComponent();
            // گرفتن PictureBox ها از فرم و ذخیره در آرایه
            _pictureBoxes = GetPictureBoxes();
        }

        private void ButtonEnqueue_Click(object sender, EventArgs e)
        {
            // بررسی پر بودن صف
            if (_queue.Count >= _pictureBoxes.Length)
            {
                MessageBox.Show("Queue is full!");
                return;
            }

            // اضافه کردن فرد به صف
            _queue.Enqueue(_personCount);
            _rear++;
            // اضافه کردن فرد به FlowLayoutPanel
            AddPersonToFlowLayout(_personCount.ToString());
            _personCount++;

            // به‌روزرسانی نوار پیشرفت، نمایش‌ها و برچسب‌ها
            UpdateProgressBar();
            UpdateVisuals();
            UpdateFrontRearLabels();
        }

        private void ButtonDequeue_Click(object sender, EventArgs e)
        {
            // بررسی خالی بودن صف
            if (_queue.Count == 0)
            {
                MessageBox.Show("Queue is empty!");
                return;
            }

            // حذف فرد از صف
            _queue.Dequeue();
            _front++;
            // حذف اولین برچسب از FlowLayoutPanel
            flowLayoutPanel1.Controls.RemoveAt(0);

            // جابه‌جایی تصاویر به راست و به‌روزرسانی نمایش‌ها و برچسب‌ها
            ShiftToRight();
            UpdateProgressBar();
            UpdateVisuals();
            UpdateFrontRearLabels();
        }

        private void AddPersonToFlowLayout(string index)
        {
            // اضافه کردن برچسب فرد به FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(new Label
            {
                Text = $"<--| \U0001f9cd Person # {index} |",
                AutoSize = true
            });
        }

        private void ShiftToRight()
        {
            // جابه‌جایی تصویر اول به انتهای لیست
            var firstImage = _images[0];
            _images.RemoveAt(0);
            _images.Add(firstImage);
        }

        private void UpdateVisuals()
        {
            // به‌روزرسانی تصاویر و مرئی بودن PictureBox ها بر اساس تعداد افراد در صف
            for (int i = 0; i < _pictureBoxes.Length; i++)
            {
                _pictureBoxes[i].Image = i < _images.Count ? _images[i] : null;
                _pictureBoxes[i].Visible = i < _queue.Count;
            }
        }

        private void UpdateFrontRearLabels()
        {
            // به‌روزرسانی برچسب‌های Front و Rear
            buttonFront.Text = $"Front = {_front}";
            buttonRear.Text = $"Rear = {_rear}";
        }

        private PictureBox[] GetPictureBoxes() => new[] { pb1, pb2, pb3 };

        private void UpdateProgressBar()
        {
            // محاسبه درصد بر اساس تعداد افراد در صف و طول PictureBox ها
            int percent = (_queue.Count * 100) / _pictureBoxes.Length;
            progressBar1.Value = percent;
        }
    }
}
