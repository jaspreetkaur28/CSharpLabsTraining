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
        static User UpdateUser;
        static User DeleteUser;

        static Category CatSelected;
        static Task DoneSelected;

        static Task TaskSelected;
        static Task UpdateTask;
        static Task DeleteTask;
        static Task newTask;
        static Task TaskDisplay;



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
                MainTextBox.Text = null;

                MessageBox.Show($"Welcome {MainTextBox.Text}");

                RefreshUser();

            }
        }

        //Not implemented
        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ToDo())
            {
               // UserSelected = (User)UserSelected.SelectedItem;
                if (UserSelected != null)
                {
                    UpdateUser = db.Users.Where(c => c.UserID == UserSelected.UserID).FirstOrDefault();
                    UpdateUser.UserName = MainTextBox.Text;
                    db.SaveChanges();
                }
                RefreshTask();

                MessageBox.Show("Update has been saved");
            }
        }

        //Working
        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        { // maybe give user an assigned value to see if they are active ( have any pending tasking) else delete all tasks with them. 

            using (var db = new ToDo())
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete this data?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    DeleteUser = db.Users.Where(O => O.UserID == UserSelected.UserID).FirstOrDefault();

                    db.Users.Remove(DeleteUser);

//not working for users with tasks
                    DeleteTask = db.Tasks.Where(O => O.TaskID == TaskSelected.TaskID).FirstOrDefault();

                    db.Tasks.Remove(DeleteTask);
                    


                    db.SaveChanges();


                }
                else return;

                RefreshUser();


            }

            MessageBox.Show("User has been deleted");
        }

 #endregion


 #region TASK  ------ ADD Edit DELETE

        //WORKING
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {

            CatSelected = (Category)CatCB.SelectedItem;
            using (var db = new ToDo())
            {
                newTask = new Task()
                {
                    TaskName = TaskTB.Text,
                    UserID = UserSelected.UserID,
                    CategoryID =  CatSelected.CategoryID

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
                CatSelected = (Category)UpdateCatCB.SelectedItem;
                if (TaskSelected != null)
                {
                    UpdateTask = db.Tasks.Where(c => c.TaskID == TaskSelected.TaskID).FirstOrDefault(); 
                    UpdateTask.Done = Updatecheckbox.IsChecked;
                    UpdateTask.CategoryID = CatSelected.CategoryID;
                 //   UpdateTask.DateStarted = UpdateDateStart. 
                 //   UpdateTask.DateCompleted = UpdateDateCompleted.

                    db.SaveChanges();
                }
                RefreshTask();
                
                MessageBox.Show("Update has been saved");
            }

           
        }


        //Working
        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {

            using (var db = new ToDo())
            {
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete this data?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    DeleteTask = db.Tasks.Where(O => O.TaskID == TaskSelected.TaskID).FirstOrDefault();

                    db.Tasks.Remove(DeleteTask);
                    db.SaveChanges();
                }
                else return;

                TaskList = db.Tasks.Where(O => O.UserID == UserSelected.UserID).ToList();
                MainListBox.ItemsSource = TaskList;
                MainListBox.DisplayMemberPath = "TaskName";

            }

            MessageBox.Show( "Data has been deleted");
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
                UserSelected = (User)UserCB.SelectedItem;
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
            if (MainListBox.SelectedItem != null)
            {
               // DoneSelected = (Task)DoneCB.SelectedItem;
                TaskSelected = (Task)MainListBox.SelectedItem;
                using (var db = new ToDo())
                {
                    //  TaskDisplay = db.Tasks.Where(c => c.TaskID == TaskSelected.TaskID).FirstOrDefault();

                    TaskList = db.Tasks.Where(O => O.TaskID == TaskSelected.TaskID).ToList();


                  //  CatList = db.Categories.Where(O => O.CategoryID = TaskList.CategoryID).ToList();
                    FakeTB4.DisplayMemberPath = "CategoryName";
                    FakeTB4.ItemsSource = TaskList;


                   

                    //Viewcheckbox
                    FakeTB1.ItemsSource = TaskList;
                    FakeTB1.DisplayMemberPath = "Done";  

                    FakeTB2.ItemsSource = TaskList;
                    FakeTB2.DisplayMemberPath = "DateStarted";
                    FakeTB3.ItemsSource = TaskList;
                    FakeTB3.DisplayMemberPath = "DateCompleted";
                  //  FakeTB4.ItemsSource = TaskList;
                 //   FakeTB4.DisplayMemberPath = "CategoryID"; // change to view name instead of id


                }
            }
        }



    }
} 