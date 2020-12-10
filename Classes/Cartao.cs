namespace _Introducao_Encapsulamento
{
    public class Cartao
    {
        
        //Atributos

        private string numero;
        public string Numero {

            get{ return numero;}
            set{ numero = value;}

        }
        private string bandeira;
        public string Bandeira {

            get{ return bandeira;}
            set{ bandeira = value;}

        }
        protected string token = "qwertyui";
        public string Token {

            get{ return token;}

        }
        private string cvv;
        public string Cvv {

            get{ return cvv;}
            set{ cvv = value;}

        }
        protected string limite;
        public string Limite {

            get{ return limite;}
            set{ limite = value;}

        }
        private float saldo;
        public float Saldo {

            get{ return saldo; }
            set{ saldo = value; }

        }


        //Métodos

        public string RegistrarCompra( bool validado, float saldo ){

            if (validado == true && saldo != 0){

                return "Compra Registrada";

            }

            return "Compra Não Registrada";

        }

        private bool ValidarCompra(float saldo, float produtoPrice) {

            if (saldo > produtoPrice) {
                
                return true;

            }

            return false;

        }

        protected bool ValidarToken(){

            if ( token != "") {

                return true;

            }

            return false;

        }

    }
}