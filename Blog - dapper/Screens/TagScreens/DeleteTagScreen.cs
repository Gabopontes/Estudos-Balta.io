using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Excluir uma Tags");
            Console.WriteLine("---------");
            Console.Write("Id da tag que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag excluida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir a tag");
                Console.WriteLine(ex.Message);
            }

        }
    }
}