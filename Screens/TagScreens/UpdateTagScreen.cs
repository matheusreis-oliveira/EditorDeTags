using System;
using EditorDeTags.Models;
using EditorDeTags.Repositories;

namespace EditorDeTags.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"Atualização de tags");
            Console.WriteLine($"=============");

            Console.Write($"ID: ");
            var id = Console.ReadLine();

            Console.Write($"Name: ");
            var name = Console.ReadLine();

            Console.Write($"Slug: ");
            var slug = Console.ReadLine();

            Update(new TagModel
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Update(TagModel tag)
        {
            try
            {
                var repository = new Repository<TagModel>();
                repository.Update(tag);
                Console.WriteLine($"Tag atualizada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível a atualização da tag.\nErro: {ex.Message}");
            }
        }
    }
}