using System; 

namespace EstruturaDoCodigo
{
    public class Pilha
    {
        Posicao primeiro;

        public void Empilha(object item)
        {
           primeiro = Posicao (primeiro, item);
        }

        public object Desempilha()
        {
            if(primeiro == null)
            {
                throw new invalidOperationException();
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao
        {
            public Posicao (Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}