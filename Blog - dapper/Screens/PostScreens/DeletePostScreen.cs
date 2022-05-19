using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class DeletePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Excluir uma Postagem");
            Console.WriteLine("---------");
            Console.Write("Id da Postagem que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Postagem excluido com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir a postagem");
                Console.WriteLine(ex.Message);
            }

        }
    }
}