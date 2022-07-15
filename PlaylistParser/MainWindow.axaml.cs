using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using Avalonia.Collections;

namespace PlaylistParser
{
    public partial class MainWindow : Window
    {
        public string imagePath = "Image/AlbumAvatar.jpg";
        public MainWindow()
        {
            InitializeComponent();
            var startButton = this.Get<Button>("parseUrlButton");
            startButton.Click += startButton_Click;

        }

        private void startButton_Click(object? sender, RoutedEventArgs e)
        {
            //HtmlHelper htmlHelper = new HtmlHelper();
            //string url = urlForParseBox.Text;
            //songs = htmlHelper.GetSongsInformation(url);
            //collectionView = new DataGridCollectionView(songs);
            //songsDataGrid.Items = collectionView;
            PlaylistInformation playlistPresentation = new PlaylistInformation();
            playlistPresentation.PlaylistName = "ПЛЕЙЛИСТ ДЛЯ ЗНИЩЕННЯ ОРКІВ";
            albumName.Text = playlistPresentation.PlaylistName;
            playlistPresentation.Description = $"НАША РУСОФОБІЯ НЕДОСТАТНЯ, ПІДВИЩИТИ ЇЇ МОЖНА ПОСЛУХАВШИ {playlistPresentation.PlaylistName}";
            descriptionOfAlbum.Text = playlistPresentation.Description;
            playlistPresentation.SongInfo = UpdateDataGrid();
            DataGridCollectionView dg = new DataGridCollectionView(playlistPresentation.SongInfo);
            songsDataGrid.Items = dg;
            AlbumAvatar.IsVisible = true;
        }
    
        public List<SongInformation> UpdateDataGrid()
        {
            List<SongInformation> songs = new List<SongInformation>()
            {
                new SongInformation()
                {
                    SongName = "Батько наш Бандера",
                    ArtistName = "Олег Луцан",
                    AlbumName = "Файний альбом",
                    Duration = "2:41"
                },
                new SongInformation()
                {
                    SongName = "Гімп УПА",
                    ArtistName = "Тінь Сонця",
                    AlbumName = "Мальовничий альбом",
                    Duration = "2:40"
                },
                new SongInformation()
                {
                    SongName = "Сон",
                    ArtistName = "Степан Гіга",
                    AlbumName = "Романтичний альбом",
                    Duration = "2:49"
                },
                new SongInformation()
                {
                    SongName = "В мене немає дому",
                    ArtistName = "Один в каное",
                    AlbumName = "Драматичний альбом",
                    Duration = "2:41"
                },
            };
            return songs;
        }
    }
}
