using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Excluir um Usuario");
            Console.WriteLine("---------");
            Console.Write("Id do Usuario que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuario excluido com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir o Usuario");
                Console.WriteLine(ex.Message);
            }

        }
    }
}