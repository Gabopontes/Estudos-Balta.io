using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Post");
            Console.WriteLine("---------");
            Console.Write("Titulo: ");
            var titulo = Console.ReadLine();

            Console.Write("Summary: ");
            var summary = Console.ReadLine();

            Console.WriteLine("Body: ");
            var body = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Console.WriteLine("Data de crianção: ");
            var datadecriacao = DateTime.Now;

            Console.WriteLine("Data de atualização: ");
            var datadeatualizacao = DateTime.Now;

            Console.WriteLine("Author Id: ");
            var authorid = int.Parse(Console.ReadLine());

            Console.WriteLine("Category Id: ");
            var categoryid = int.Parse(Console.ReadLine());


            Create(new Post
            {
                Title = titulo,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = datadecriacao,
                LastUpdateDate = datadeatualizacao,
                AuthorId = authorid,
                CategoryId = categoryid,

            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Post cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel salvar o Post");
                Console.WriteLine(ex.Message);
            }

        }

    }

}