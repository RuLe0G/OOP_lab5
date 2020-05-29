using System;
using System.Collections.Generic;
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

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для cutaway.xaml
    /// </summary>
    public partial class cutaway : UserControl
    {
        private bool ban = false;
        public cutaway()
        {
            InitializeComponent();
        }

        //cwFName
        public static readonly DependencyProperty cwFNameProperty = DependencyProperty.Register(
               "cwFName",
               typeof(string),
               typeof(cutaway),
               new PropertyMetadata(string.Empty, cwFNameChanged));

        public string FName
        {
            get { return (string)GetValue(cwFNameProperty); }
            set { SetValue(cwFNameProperty, value); }
        }

        private static void cwFNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var cwFNameForm = obj as cutaway;
            cwFNameForm.cwFName.Text = cwFNameForm.FName.ToString();
        }

        //cwSName
        public static readonly DependencyProperty cwSNameProperty = DependencyProperty.Register(
               "cwSName",
               typeof(string),
               typeof(cutaway),
               new PropertyMetadata(string.Empty, cwSNameChanged));

        public string SName
        {
            get { return (string)GetValue(cwSNameProperty); }
            set { SetValue(cwSNameProperty, value); }
        }
        
        private static void cwSNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var cwSNameForm = obj as cutaway;
            cwSNameForm.cwSName.Text = cwSNameForm.SName.ToString();
        }

        //cwCompany
        public static readonly DependencyProperty cwCompanyProperty = DependencyProperty.Register(
           "cwCompany",
           typeof(string),
           typeof(cutaway),
           new PropertyMetadata(string.Empty, cwCompanyChanged));

        public string Company
        {
            get { return (string)GetValue(cwCompanyProperty); }
            set { SetValue(cwCompanyProperty, value); }
        }

        private static void cwCompanyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var cwCompanyForm = obj as cutaway;
            cwCompanyForm.cwCompany.Text = cwCompanyForm.Company.ToString();
        }

        //cwAge
        public static readonly DependencyProperty cwAgeProperty = DependencyProperty.Register(
               "cwAge",
               typeof(string),
               typeof(cutaway),
               new PropertyMetadata(string.Empty, cwAgeChanged));

        public string Age
        {
            get { return (string)GetValue(cwAgeProperty); }
            set { SetValue(cwAgeProperty, value); }
        }

        private static void cwAgeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var cwAgeForm = obj as cutaway;
            cwAgeForm.cwAge.Text = cwAgeForm.Age.ToString();
        }

        //Кнопки
        private void BtnCall_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Алло, ну че там с деньгами?");
        }

        private void BtnCam_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(FName + " " + SName + " не добавил фотографий");
        }

        private void BtnSw_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Имя - " + FName + " фамилия - " + SName + " лет - " + Age + ". Больше информации нет");
        }

        private void BtnRep_Click(object sender, RoutedEventArgs e)
        {
            if (ban == false)
            {
                ban = true;
                MessageBox.Show("Пользователь заблокирован");
            }
            else
            {
                ban = false;
                MessageBox.Show("Пользователь разблокирован");
            }
            
        }

        //картинка
        public static readonly DependencyProperty cwImageProperty = DependencyProperty.Register(
           "cwImage",
           typeof(string),
           typeof(cutaway),
           new PropertyMetadata(string.Empty, EmpImgChanged));

        public string Image
        {
            get { return (string)GetValue(cwImageProperty); }
            set { SetValue(cwImageProperty, value); }
        }

        private static void EmpImgChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var cwImageForm = obj as cutaway;
            cwImageForm.cwImage.Source = new BitmapImage(new Uri($"{cwImageForm.Image}"));
        }

    }
}
