using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using Avalonia.Collections;
using PlaylistParser.XPathsClasses;

namespace PlaylistParser
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var startButton = this.Get<Button>("parseUrlButton");
            startButton.Click += startButton_Click;

        }
        private void startButton_Click(object? sender, RoutedEventArgs e)
        {
            if (urlForParseBox.Text.Contains("album"))
            {
                songsDataGrid.Columns[1].IsVisible = false;
                songsDataGrid.Columns[2].IsVisible = false;
                HtmlParser<AppleMusicXPaths> xPath = new HtmlParser<AppleMusicXPaths>(new AppleMusicXPaths());
                string url = urlForParseBox.Text;
                PlaylistInformation pi = xPath.Parse(url);
                DataGridCollectionView collectionView = new DataGridCollectionView(pi.SongInfo);
                songsDataGrid.Items = collectionView;
                AlbumAvatar.Source = pi.PlayListAvatar;
                descriptionOfAlbum.Text = pi.Description;
                albumName.Text = pi.PlaylistName;
                albumName.Text += string.Format("\n {0}", pi.SongInfo[3].ArtistName);
            }
            else
            {
                songsDataGrid.Columns[1].IsVisible = true;
                songsDataGrid.Columns[2].IsVisible = true;
                HtmlParser<AppleMusicXPaths> xPath = new HtmlParser<AppleMusicXPaths>(new AppleMusicXPaths());
                string url = urlForParseBox.Text;
                PlaylistInformation pi = xPath.Parse(url);
                DataGridCollectionView collectionView = new DataGridCollectionView(pi.SongInfo);
                songsDataGrid.Items = collectionView;
                AlbumAvatar.Source = pi.PlayListAvatar;
                descriptionOfAlbum.Text = pi.Description;
                albumName.Text = pi.PlaylistName;
            }
        }
    }
}
