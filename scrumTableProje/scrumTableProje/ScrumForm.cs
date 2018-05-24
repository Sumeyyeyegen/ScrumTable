using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrumTableProje
{
    public partial class ScrumForm : Form
    {
        List<StoryDetail> storyList = new List<StoryDetail>();
        List<TaskDetail> taskList = new List<TaskDetail>();
        TaskDetail td = new TaskDetail();
        int LocationX = 0;
        int LocationY = 0;
        bool isDragged = false;
        Point ptOffset;
        bool error = false;

        public ScrumForm()
        {
            InitializeComponent();


        }
        
        

        private void btnStory_MouseClick(object sender, MouseEventArgs e)
        {
            StoryDetail sd = new StoryDetail();
            
            if (txtName.Text == "")
            {
                MessageBox.Show("Lütfen boşluk yerleri uygun bir şekilde doldurunuz.");
                error = true;
            }
            
           else if (TxtTittleAndTopic.Text == "")
            {
                MessageBox.Show("Lütfen uygun bir deger giriniz.");
                error = true;
            }
            
           else if (txtComment.Text == "")
            { 
                MessageBox.Show("Lütfen bir deger giriniz.");
                error = true;
            }
            
            else
                error = false;
            if (!error)
            {
                sd.Name = txtName.Text;
                sd.Tittle = TxtTittleAndTopic.Text;
                sd.Comment = txtComment.Text;
                sd.AddDateStory = txtDateAddStory.Value;

                storyList.Add(sd);

                buttonCreateStory();

                cmbStoryChoice.Items.Add(sd.Tittle);
            }
        }
        private void buttonCreateStory()
        {
            Button btn = new Button
            {
                Height = 65,
                Left = 200,
                Width = 65,
                Top = 240 + (LocationX),
                Text = storyList.Last().Tittle,
                
            };

            LocationX += 100;
            btn.MouseDown += btn_MouseDown;
            btn.MouseMove += btn_MouseMove;
            btn.MouseUp += btn_MouseUp;
            btn.MouseClick += btn_MouseClick;
            
            Controls.Add(btn);

        }
        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            int sayac= 0;
            int indis = 0;
            Button dynamicButton = (sender as Button);
            foreach (StoryDetail storyList in storyList)
            {
                if (storyList.Tittle == dynamicButton.Text)
                    indis = sayac;
                sayac++;
            }
            MessageBox.Show(" Author:" + storyList[indis].Name + "\n Project Name:" + storyList[indis].Tittle + "\n Project Comment:" + storyList[indis].Comment + 
                "\n Add Date Story:" + storyList[indis].AddDateStory.ToString());
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button dynamicButton = (sender as Button);
            if (isDragged)
            {
                Point newPoint = dynamicButton.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                dynamicButton.Location = newPoint;
            }
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button dynamicButton = (sender as Button);
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = dynamicButton.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = dynamicButton.Location.X - ptStartPosition.X;
                ptOffset.Y = dynamicButton.Location.Y - ptStartPosition.Y;

            }
            else
            {
                isDragged = false;
            }

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            TaskDetail td = new TaskDetail();
            
          
            if (txtCommentTask.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları uygun bir şekilde doldurunuz.");
                error = true;
            }
            
           else if (txtTittleAndTopicTask.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
                error = true;
            }
           
            
          else  if (txtAuthor.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları uygun bir şekilde doldurunuz.");
                error = true;
            }

            else
                error = false;
           
            

            if (!error)
            {
                td.Comment = txtCommentTask.Text;
                td.Tittle = txtTittleAndTopicTask.Text;
                td.Author = txtAuthor.Text;
                td.deadline = txtDateAddTask.Value;
                taskList.Add(td);

                btnCreateTask();

            }
            
        }

        private void btnCreateTask()
        {   
            
            Button TaskB = new Button
            {
                Height = 55,
                Left = 275,
                Width = 55,
                Top = 240 + (LocationY),
                Text = cmbStoryChoice.SelectedItem.ToString(),
                
            };

            LocationY+=10;
            TaskB.MouseDown += TaskB_MouseDown;
            TaskB.MouseMove += TaskB_MouseMove;
            TaskB.MouseUp += TaskB_MouseUp;
            TaskB.MouseClick += TaskB_MouseClick;
            Controls.Add(TaskB);
        }

       

        private void TaskB_MouseClick(object sender, MouseEventArgs e)
        {
            int sayac = 0;
            int indices = 0;
            Button btndynamicTask = (sender as Button);
            foreach (TaskDetail td in taskList)
            {
                if (td.Tittle  == btndynamicTask.Text)
                    indices = sayac;
                sayac++;
            }
            MessageBox.Show(" Author:   " + taskList[indices].Author + "\n Project Name:" + taskList[indices].Tittle + "\n Project Comment:" 
            + taskList[indices].Comment + "\n Add Date Story:" + taskList[indices].deadline.ToString());

        }

        private void TaskB_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void TaskB_MouseMove(object sender, MouseEventArgs e)
        {
            Button btndynamicTask = (sender as Button);
            if (isDragged)
            {
                Point newPoint = btndynamicTask.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                btndynamicTask.Location = newPoint;
            }
        }

        private void TaskB_MouseDown(object sender, MouseEventArgs e)
        {
            Button dynamicTaskButton = (sender as Button);
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = dynamicTaskButton.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = dynamicTaskButton.Location.X - ptStartPosition.X;
                ptOffset.Y = dynamicTaskButton.Location.Y - ptStartPosition.Y;

            }
            else
            {
                isDragged = false;
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTask_Click(object sender, EventArgs e)
        {

        }

        private void btnStory_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDone_Click(object sender, EventArgs e)
        {

        }

        private void ScrumForm_Load(object sender, EventArgs e)
        {

        }

        

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
