using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfPictures = double.Parse(Console.ReadLine());
            var filterTime = double.Parse(Console.ReadLine());
            var filterFactor = double.Parse(Console.ReadLine()) / 100;
            var uploadTime = double.Parse(Console.ReadLine());

            var filteredPictures = Math.Ceiling(amountOfPictures * filterFactor);
            var timeToFilter = amountOfPictures * filterTime;
            var timeToUpload = filteredPictures * uploadTime;
            var totalTime = timeToFilter + timeToUpload;
            
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string result = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);

        }
    }
}
