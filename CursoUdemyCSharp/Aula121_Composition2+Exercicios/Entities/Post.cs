using System;
using System.Collections.Generic;
using System.Text;

namespace Aula121_Composition2_Exercicios.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int Likes { get; set; }

        public List<Comment> comments { get; set; } = new List<Comment>();

        Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy hh:mm:ss"));
            sb.AppendLine(Content);

            foreach (Comment c in comments)
                sb.AppendLine(c.Text);

            return sb.ToString();
        }
    }
}
