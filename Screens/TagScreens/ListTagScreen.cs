using System;
using EditorDeTags.Models;
using EditorDeTags.Repositories;

namespace EditorDeTags.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"Lista de tags");
            Console.WriteLine($"=============");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        private static void List()
        {
            var repository = new Repository<TagModel>();
            var tags = repository.GetAll();

            foreach (var tag in tags)
                Console.WriteLine($"{tag.Id} - {tag.Name} ({tag.Slug})");
        }
    }
}