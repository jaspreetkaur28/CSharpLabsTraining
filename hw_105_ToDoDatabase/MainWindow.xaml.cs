using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hw_105_ToDoDatabase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<User> UserList;
        static List<Task> TaskList;
        static List<Category> CatList;


        static User UserSelected;
        static User newUser;

        static Category CatSelected;
        static Category CatSelectedShow;
        static Category newCategory;
        static Category CatJoin;


        static Task DateSelected;
        static Task DoneSelected;

        static Task TaskSelected;
        static Task newTask;



        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }
        //view users and categories via ComboBox
        void Initialize()
        {
            using (var db = new ToDo())
            {
                RefreshUser();
                RefreshCategory();
            }
        }

        void selected() {
            UserSelected = (User)UserCB.SelectedItem;
            TaskSelected = (Task)MainListBox.SelectedItem;
            CatSelected = (Category)CatCB.SelectedItem;
            CatSelectedShow = (Category)UpdateCatCB.SelectedItem;


            // DateSelected = (Task)UpdateDateStart.SelectedDate;
            // DoneSelected = (Task)DoneCB.SelectedItem;

        }
        #region USER ------ ADD  EDIT DELETE
        //Working
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ToDo())
            {
                newUser = new User()
                {
                    UserName = MainTextBox.Text
                };
                db.Users.Add(newUser);
                db.SaveChanges();


                MessageBox.Show($"Welcome {MainTextBox.Text}");
                MainTextBox.Text = null;
                RefreshUser();

            }
        }

        //Working
        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            selected();
            if (MainTextBox.Text == "") { return; }
            else if (MainTextBox.Text != null)
            {
                using (var db = new ToDo())
                {
                    // UserSelected = (User)UserSelected.SelectedItem;
                    if (UserSelected != null)
                    {
                        UserSelected = db.Users.Where(c => c.UserID == UserSelected.UserID).FirstOrDefault();
                        UserSelected.UserName = MainTextBox.Text;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Name updated to " + MainTextBox.Text);
                }
            }
            RefreshUser();
            MainTextBox.Text = null;
        }

        //Working for empty users
        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        { // maybe give user an assigned value to see if they are active ( have any pending tasking) else delete all tasks with them. 
            selected();
            using (var db = new ToDo())
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete this data?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {

                    UserSelected = db.Users.Where(O => O.UserID == UserSelected.UserID).FirstOrDefault();
                    db.Users.Remove(UserSelected);

                    db.SaveChanges();
                    MessageBox.Show(UserSelected.UserName + " has been deleted");
                }
                else return;
                RefreshUser();
            }
        }
  ////not working for users with tasks
                    //DeleteTask = db.Tasks.Where(O => O.TaskID == TaskSelected.TaskID).FirstOrDefault();

                    //db.Tasks.Remove(DeleteTask);
        #endregion


        #region TASK  ------ ADD Edit DELETE

        //WORKING
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            selected();
            using (var db = new ToDo())
            {
                newTask = new Task()
                {
                    TaskName = TaskTB.Text,
                    UserID = UserSelected.UserID,
                    CategoryID = CatSelected.CategoryID

                };
                db.Tasks.Add(newTask);
                db.SaveChanges();
                RefreshTask();

            }
        }

        // in progress
        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ToDo())
            {
                selected();
                if (TaskSelected != null)
                {
                    TaskSelected = db.Tasks.Where(c => c.TaskID == TaskSelected.TaskID).FirstOrDefault();
                    CatSelectedShow = db.Categories.Where(o => o.CategoryID == CatSelectedShow.CategoryID).FirstOrDefault();

                    TaskSelected.CategoryID = CatSelectedShow.CategoryID;
                    TaskSelected.TaskName = tb1.Text;

                    //   UpdateTask.DateStarted = UpdateDateStart. 
                    //   UpdateTask.DateCompleted = UpdateDateCompleted.
                    if (FakeTB3 == null) { TaskSelected.Done = false; }
                    else { TaskSelected.Done = true; }


                    db.SaveChanges();
                }
                

                MessageBox.Show("Update has been saved");
            }
            TaskSelect();

        }


        //Working
        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            selected();
            using (var db = new ToDo())
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete this task?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    TaskSelected = db.Tasks.Where(O => O.TaskID == TaskSelected.TaskID).FirstOrDefault();

                    db.Tasks.Remove(TaskSelected);
                    db.SaveChanges();
                }
                else return;

                TaskList = db.Tasks.Where(O => O.UserID == UserSelected.UserID).ToList();
                MainListBox.ItemsSource = TaskList;
                MainListBox.DisplayMemberPath = "TaskName"; 

            }

            MessageBox.Show(TaskSelected.TaskName + " has been deleted");
        }
        #endregion

        #region  REFRESH
        //working 
        void RefreshUser()
        {
            using (var db = new ToDo())
            {
                UserList = db.Users.ToList();
                UserCB.DisplayMemberPath = "UserName";
                UserCB.ItemsSource = UserList;
            }
        }
        void RefreshCategory()
        {
            using (var db = new ToDo())
            {
                CatList = db.Categories.ToList();
                CatCB.DisplayMemberPath = "CategoryName";
                CatCB.ItemsSource = CatList;

                UpdateCatCB.DisplayMemberPath = "CategoryName";
                UpdateCatCB.ItemsSource = CatList;

            }
        }

        //working
        void RefreshTask()
        {
            using (var db = new ToDo())
            {
                TaskList = db.Tasks.Where(O => O.UserID == UserSelected.UserID).ToList();
                MainListBox.ItemsSource = TaskList;
                MainListBox.DisplayMemberPath = "TaskName";
            }
        }
        #endregion


        //Working view tasks
        private void UserCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserCB.SelectedItem != null)
            {
                selected();
                using (var db = new ToDo())
                {
                    TaskList = db.Tasks.Where(O => O.UserID == UserSelected.UserID).ToList();
                    MainListBox.ItemsSource = TaskList;
                    MainListBox.DisplayMemberPath = "TaskName";

                }
            }
        }

        //Working
        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tb1.Text = null;
            if (MainListBox.SelectedItem != null)
            {   selected();
                TaskSelect();
            }
        }

        void TaskSelect()
        {
            using (var db = new ToDo())
            {
                TaskList = db.Tasks.Where(O => O.TaskID == TaskSelected.TaskID).ToList();
                TaskSelected = db.Tasks.Where(O => O.TaskID == TaskSelected.TaskID).FirstOrDefault();

                //     FakeTB1.ItemsSource = TaskList;
                //    FakeTB1.DisplayMemberPath = "Done"; 

                Viewcheckbox.IsChecked = TaskSelected.Done;
                FakeTB2.ItemsSource = TaskList;
                FakeTB2.DisplayMemberPath = "DateStarted";
                FakeTB3.ItemsSource = TaskList;
                FakeTB3.DisplayMemberPath = "DateCompleted";
                FakeTB4.ItemsSource = TaskList;
                FakeTB4.DisplayMemberPath = "CategoryID"; // change to view name instead of id
                UpdateDateStart.DisplayDateStart = TaskSelected.DateStarted;


                //   CatJoin = db.Tasks.Where(c => c.TaskID == TaskSelected.TaskID).FirstOrDefault();
                //   UpdateTask.DateStarted = UpdateDateStart. 
                //   UpdateTask.DateCompleted = UpdateDateCompleted.

                db.SaveChanges();

            }
            tb1.Text = TaskSelected.TaskName;
            //   tb2.Text = TaskSelected.CategoryName;
            //   UpdateDateStart.DisplayDate= TaskSelected.DateStarted;
            UpdateDateStart.DisplayDateStart = TaskSelected.DateStarted;
            UpdateDateCompleted.DisplayDateEnd = TaskSelected.DateCompleted;


            // tb2.Text = UpdateTask.CategoryName;

            //  tbhidden.Text = 
            //    CatSelected.CategoryID = UpdateTask.CategoryID;
            //   UpdateTask.DateStarted = DateSelected.DateStarted;
            // UpdateTask.Done = Updatecheckbox.IsChecked;


        }

    }
}