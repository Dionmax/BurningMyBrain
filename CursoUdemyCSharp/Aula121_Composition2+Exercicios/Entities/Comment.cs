using System;
using System.Collections.Generic;
using System.Text;

namespace Aula121_Composition2_Exercicios.Entities
{
    class Comment
    {
        public string Text { get; set; }

        Comment() { }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
