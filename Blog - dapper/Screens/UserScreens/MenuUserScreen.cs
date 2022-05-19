using System;

namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Usuarios");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Usuarios");
            Console.WriteLine("2 - Cadastrar Usuario");
            Console.WriteLine("3 - Atualizar Usuario");
            Console.WriteLine("4 - Deletar Usuario");
            Console.WriteLine("5 - Voltar para menu principal");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    UpdateUserScreen.Load();
                    break;
                case 4:
                    DeleteUserScreen.Load();
                    break;
                default: MenuUserScreen.Load(); break;
            }

        }

    }

}
