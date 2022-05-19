using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Excluir uma Category");
            Console.WriteLine("---------");
            Console.Write("Id da Category que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Category excluida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir a Category");
                Console.WriteLine(ex.Message);
            }

        }
    }
}