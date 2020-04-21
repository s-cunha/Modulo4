using System;

namespace Ficha24
{
    public class Ficha24
    {
        #region exercicio2
        //Considera um veículo, representado pela marca, 
        //modelo, e ano de matrícula. Este deverá ser capaz
        //de ser ligado, desligado, podem alterar as 
        //mudanças, podem acelerar, travar, e rodar o 
        //volante. a. Cria uma classe. b. 
        //Identifica e adiciona as propriedades que considerares pertinentes. 
        //Não te esqueças que podem existir valores que não queiras que sejam introduzidos numa propriedade. c. 
        //Identifica e adiciona os métodos que considerares pertinentes.
        
        public class Veiculo
        {
            public Veiculo() { }
            public Veiculo(string marca,string modelo, int ano)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.ano = ano;
            }
            
            
            private string marca;
            public string Marca
            {
                get
                {
                    return marca;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value)) marca = value;
                }

            }

            private string modelo;
            public string Modelo 
            {
                    get
                    {
                        return modelo;
                    }
                    set
                    {
                        if (!string.IsNullOrEmpty(value)) modelo = value;
                    }

            }
            

            private int ano;
            public int Ano
            {
                get
                {
                    return ano;
                }
                set
                {
                    if (value > 0) ano = value;
                }
            }
            
        }
        
        
        #endregion
    }
}
