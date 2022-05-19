using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.Write("Atualizando uma Postagem");
            Console.WriteLine("---------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Titulo: ");
            var titulo = Console.ReadLine();

            Console.Write("Summary: ");
            var summary = Console.ReadLine();

            Console.WriteLine("Body: ");
            var body = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            //Console.WriteLine("Data de crianção: ");
            //var datadecriacao = DateTime.Now;

            Console.WriteLine("Data de atualização: ");
            var datadeatualizacao = DateTime.Now;

            Console.WriteLine("Author Id: ");
            var authorid = int.Parse(Console.ReadLine());

            Console.WriteLine("Category Id: ");
            var categoryid = int.Parse(Console.ReadLine());

            Update(new Post
            {
                Id = int.Parse(id),
                Title = titulo,
                Summary = summary,
                Body = body,
                Slug = slug,
                //CreateDate = datadecriacao,
                LastUpdateDate = datadeatualizacao,
                AuthorId = authorid,
                CategoryId = categoryid,

            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }
        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("Postagem atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel atualizar a Postagem");
                Console.WriteLine(ex.Message);
            }

        }

    }
}