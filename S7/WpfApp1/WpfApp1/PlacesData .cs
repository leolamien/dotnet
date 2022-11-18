using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    internal class PlacesData
    {
        private IList<Place> placesList;

        string pathProject = Environment.CurrentDirectory;

        public PlacesData()
        {
            Place p1 = new Place(pathProject + "/photos/bruxelles.jpg", "Bruxelles");
            Place p2 = new Place(pathProject + "/photos/paris.jpg", "Paris");
            Place p3 = new Place(pathProject + "/photos/moscou.jpg", "Moscou");
            Place p4 = new Place(pathProject + "/photos/amsterdam.jpg", "Amsterdam");
            Place p5 = new Place(pathProject + "/photos/newyork.jpg", "New York");

            placesList = new List<Place>();
            placesList.Add(p1);
            placesList.Add(p2);
            placesList.Add(p3);
            placesList.Add(p4);
            placesList.Add(p5);

        }



        internal IList<Place> PlacesList { get => placesList; set => placesList = value; }


    }
    internal class Place
    {
        private string _description;
        private string _pathImageFile  ;
        private int _nbVotes;
        private Uri _uri;
        private BitmapFrame _image ;
        public Place(string path, string description)
        {
            Description = description;
            PathImageFile = path;
            NbVotes = 0;
            Uri = new Uri(PathImageFile);
            Image = BitmapFrame.Create(Uri);
        }

        public string Description { get => _description; set => _description = value; }
        public string PathImageFile { get => _pathImageFile; set => _pathImageFile = value; }
        public int NbVotes { get => _nbVotes; set => _nbVotes = value; }
        public Uri Uri { get => _uri; set => _uri = value; }
        public BitmapFrame Image { get => _image; set => _image = value; }
    }
}
