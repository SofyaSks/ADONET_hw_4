using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_hw_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                DateTime today = DateTime.Now;
                DateTime monthFresh = today.AddMonths(-1);

                Console.WriteLine("Сортировка по дате");
                IReadOnlyList<song> songs = (from song in db.songs
                                             orderby song.date descending
                                             select song).ToList();

                foreach (var item in songs)
                {
                    Console.WriteLine(item);
                }


                Console.WriteLine("\nСортировка по добавлению (месяц назад или позже)");
                IReadOnlyList<song> songs2 = (from song in db.songs
                                              where ((song.date.Year == today.Year) && (song.date.Month > monthFresh.Month))                                            
                                              orderby song.title
                                              select song).ToList();

                foreach (var item in songs2)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nСамая новая песня");


                var newestSong = (from song in db.songs
                                  orderby song.date descending
                                  select song).First();

                Console.WriteLine(newestSong); 
                
                Console.WriteLine("\nСамая старая песня");

                var oldetSong = (from song in db.songs
                                  orderby song.date 
                                  select song).First();

                Console.WriteLine(oldetSong);

            }
        }
    }
}