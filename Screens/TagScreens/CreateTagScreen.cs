using System;
using EditorDeTags.Models;
using EditorDeTags.Repositories;

namespace EditorDeTags.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"Criação de tags");
            Console.WriteLine($"=============");

            Console.Write($"Name: ");
            var name = Console.ReadLine();

            Console.Write($"Slug: ");
            var slug = Console.ReadLine();

            Create(new TagModel
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Create(TagModel tag)
        {
            try
            {
                var repository = new Repository<TagModel>();
                repository.Create(tag);
                Console.WriteLine($"Tag cadastrada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível o cadastro da tag.\nErro: {ex.Message}");
            }
        }
    }
}