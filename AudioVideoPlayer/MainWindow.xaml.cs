using Microsoft.Win32;
using System;
using System.Windows;

namespace AudioVideoPlayer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mpg; *.mpeg; *.avi; *.mp4)| *.mpg; *.mpeg; *.avi; *.mp4";
            if (openFileDialog.ShowDialog() == true)
            {
                avPlayer.Source = new Uri(openFileDialog.FileName);
            }
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            wdwPlayer.Close();
        }

        private void BtnPlay(object sender, RoutedEventArgs e)
        {
            avPlayer.Play();
        }

        private void BtnPause(object sender, RoutedEventArgs e)
        {
            avPlayer.Pause();
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            avPlayer.Close();
        }        
    }
}
