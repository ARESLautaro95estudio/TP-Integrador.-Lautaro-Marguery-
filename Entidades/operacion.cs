using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.PrimerOperando = primerOperando;
            this.SegundoOperando = segundoOperando;
        }
        public string Operar(char operador)
        {
            int aux1, aux2, aux3;
            int.TryParse(this.PrimerOperando.Valor, out aux1);
            int.TryParse(this.segundoOperando.Valor, out aux2);

            if (aux2==0)
            { 
                return "Operador no reconocido";
            }
            
            switch (operador)
                {

                    case '+':

                    aux3 = aux1 + aux2; 
                    return aux3.ToString();

                    case '-':
                    
                    aux3 = aux1 - aux2;
                    return aux3.ToString();

                    case '*':

                        aux3 = aux1 * aux2;
                    return aux3.ToString();

                    case '/':
                        
                        aux3 = aux1 / aux2;
                    return aux3.ToString();
                
                default:
                        return "Operador no reconocido";
                }
        }
        public Numeracion PrimerOperando 
        { get => primerOperando; set => primerOperando = value; }
        public Numeracion SegundoOperando
        { get => segundoOperando; set => segundoOperando = value; }
    }
}
