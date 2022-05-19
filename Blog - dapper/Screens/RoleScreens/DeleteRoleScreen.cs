using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Excluir um Role");
            Console.WriteLine("---------");
            Console.Write("Id do Role que deseja excluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuRoleScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Role excluido com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir o Role");
                Console.WriteLine(ex.Message);
            }

        }
    }
}