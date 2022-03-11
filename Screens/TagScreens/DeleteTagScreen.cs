using System;
using EditorDeTags.Models;
using EditorDeTags.Repositories;

namespace EditorDeTags.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"Exclusão de tags");
            Console.WriteLine($"=============");

            Console.Write($"Informe o ID da Tag: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<TagModel>();
                repository.Delete(id);
                Console.WriteLine($"Tag excluída com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível a exclusão da tag.\nErro: {ex.Message}");
            }
        }
    }
}