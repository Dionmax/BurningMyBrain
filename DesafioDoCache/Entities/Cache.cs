using System;

namespace DesafioDoCache.Entities
{
    public class Cache
    {
        private int _tamanhoMaximo = 0;

        public Cache() { }

        public Cache(int tamanhoMaximo)
        {
            this._tamanhoMaximo = tamanhoMaximo;
        }

        public int getTamanhoMaximo()
            => _tamanhoMaximo;
    }
}