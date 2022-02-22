using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
namespace BusinessLogicLayer
{
    public class BLL
    {

        public class login
        {
            static public DataTable loginUtilizador(int Nfunc, string Password)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nfunc", Nfunc),
                new SqlParameter("@Password", Password),
                
                };
                return dal.executarReader("select * from login where Nfunc=@Nfunc and Password=@Password", sqlParams);
            }
        }

        public class Visita
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Visita ", null);
            }

            static public int insertVisita(int IdVisita, int NumeroC, string NomeC, int NumeroCt, string NomeCt, int Telefone, int NumeroI, string Hora, string Data, byte[] Imagem)

            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@IdVisita", IdVisita),
                                new SqlParameter("@NumeroC", NumeroC),
                                new SqlParameter("@NomeC", NomeC),
                                new SqlParameter("@NumeroCt", NumeroCt),
                                new SqlParameter("@NomeCt", NomeCt),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@NumeroI", NumeroI),
                                new SqlParameter("@Hora", Hora),
                                new SqlParameter("@Data", Data),
                                new SqlParameter("@Imagem", Imagem),
            };
                return dal.executarNonQuery("INSERT into Clinete (IdVisita, NumeroC, NomeC, NumeroCt, NomeCt, Telefone, NumeroI, Hora, Data, Imagem) " +
                    "VALUES(@IdVisita, @NumeroC, @NomeC, @NumeroCt, @NomeCt, @Telefone, @NumeroI, @Hora, @Data, @Imagem)", sqlParams);
            }
            static public int updateVisita(int IdVisita, int NumeroC, string NomeC, int NumeroCt, string NomeCt, int Telefone, int NumeroI, string Hora, string Data, byte[] Imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@IdVisita", IdVisita),
                                new SqlParameter("@NumeroC", NumeroC),
                                new SqlParameter("@NomeC", NomeC),
                                new SqlParameter("@NumeroCt", NumeroCt),
                                new SqlParameter("@NomeCt", NomeCt),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@NumeroI", NumeroI),
                                new SqlParameter("@Hora", Hora),
                                new SqlParameter("@Data", Data),
                                new SqlParameter("@Imagem", Imagem),
                        };
                return dal.executarNonQuery("update [Visita] set [IdVisita]=@IdVisita, [NumeroC]=@NumeroC,  [NomeC]=@NomeC, [NumeroCT]=@NumeroCt,  [NomeCt]=@NomeCt, [Telefone]=@Telefone, [NumeroI]=@NumeroI,  [Hora]=@Hora,  [Data]=@Data where [Imagem]=@Imagem", sqlParams);
            }

            static public int deleteVisita(int IdVisita)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@IdVisita", IdVisita),

            };
                return dal.executarNonQuery("Delete From Cliente WHERE[IdVisita]@Idvisita", sqlParams);
            }
        }

        public class Imovel
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from NvImovel ", null);
            }

            static public int insertNvImovel(int NºdoImovel, string Morada, string Numero, string Andar, string CodigoPostal, string AreaBruta, string AreaTotal, string Quarto, string CasaDeBanho, bool Elevador, bool Estacionamento, string Eficiencia, string AnoConstrucao, string Distrito, string Cidade, string TipoImovel, string Para, string Preco, string Nfunc, string Observacao, byte[] Imagem)

            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@NºdoImovel", NºdoImovel),
                                new SqlParameter("@Morada", Morada),
                                new SqlParameter("@Numero", Numero),
                                new SqlParameter("@Andar", Andar),
                                new SqlParameter("@CodigoPostal", CodigoPostal),
                                new SqlParameter("@AreaBruta", AreaBruta),
                                new SqlParameter("@AreaTotal", AreaTotal),
                                new SqlParameter("@Quarto", Quarto),
                                new SqlParameter("@CasaDebanho", CasaDeBanho),
                                new SqlParameter("@Elevador", Elevador),
                                new SqlParameter("@Estacionamento", Estacionamento),
                                new SqlParameter("@Eficiencia", Eficiencia),
                                new SqlParameter("@AnoConstrucao", AnoConstrucao),
                                new SqlParameter("@Distrito", Distrito),
                                new SqlParameter("@Cidade", Cidade),
                                new SqlParameter("@TipoImovel", TipoImovel),
                                new SqlParameter("@Para", Para),
                                new SqlParameter("@Preco", Preco),
                                new SqlParameter("@Nfunc", Nfunc),
                                new SqlParameter("@Observacao", Observacao),
                                new SqlParameter("@Imagem", Imagem)
            };
                return dal.executarNonQuery("INSERT into NvImovel (NºdoImovel, Morada, Numero, Andar, CodigoPostal, " +
                    "AreaBruta , AreaTotal, Quarto, CasaDebanho, Elevador, Estacionamento, Eficiencia, AnoConstrucao, Distrito, " +
                    "Cidade, TipoImovel, Para, Preco, Nfunc, Observacao, Imagem) " +
                    "VALUES(@NºdoImovel, @Morada, @Numero, @Andar, @CodigoPostal, @AreaBruta , @AreaTotal, @Quarto," +
                    " @CasaDebanho, @Elevador, @Estacionamento, @Eficiencia, @AnoConstrucao, @Distrito, @Cidade, @TipoImovel, @Para, @Preco, " +
                    "@Nfunc, @Observacao, @Imagem)", sqlParams);
            }
            static public int updateNvImovel(int NºdoImovel, string Morada, string Numero, string Andar, string CodigoPostal,
                string AreaBruta, string AreaTotal, string Quarto, string CasaDeBanho, bool Elevador, bool Estacionamento, string Eficiencia, string AnoConstrucao, string Distrito,
                string Cidade, string TipoImovel, string Para, string Preco, string Nfunc,
                string Observacao, byte[] Imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                            new SqlParameter("@NºdoImovel", NºdoImovel),
                                new SqlParameter("@NºdoImovel", NºdoImovel),
                                new SqlParameter("@Morada", Morada),
                                new SqlParameter("@Numero", Numero),
                                new SqlParameter("@Andar", Andar),
                                new SqlParameter("@CodigoPostal", CodigoPostal),
                                new SqlParameter("@AreaBruta", AreaBruta),
                                new SqlParameter("@AreaTotal", AreaTotal),
                                new SqlParameter("@Quarto", Quarto),
                                new SqlParameter("@CasaDebanho", CasaDeBanho),
                                new SqlParameter("@Elevador", Elevador),
                                new SqlParameter("@Estacionamento", Estacionamento),
                                new SqlParameter("@Eficiencia", Eficiencia),
                                new SqlParameter("@AnoConstrucao", AnoConstrucao),
                                new SqlParameter("@Distrito", Distrito),
                                new SqlParameter("@Cidade", Cidade),
                                new SqlParameter("@TipoImovel", TipoImovel),
                                new SqlParameter("@Para", Para),
                                new SqlParameter("@Preco", Preco),
                                new SqlParameter("@Nfunc", Nfunc),
                                new SqlParameter("@Observacao", Observacao),
                                new SqlParameter("@Imagem", Imagem)
                        };
                return dal.executarNonQuery("update [NvImoveis] set [NºdoImovel]=@NºdoImovel, " +
                    "[Morada]=@Morada, [Numero]=@Numero, [Andar]=@Andar, [CodigoPostal]=@CodigoPostal, " +
                    "[AreaBruta]=@AreaBruta, [AreaTotal]=@AreaTotal, [Quarto]=@Quarto, [CasaDebanho]=@CasaDebanho, [Elevador]=@Elevador, [Estacionamento]=@Estacionamento, [Eficiencia]=@Eficiencia" +
                    "[AnoDeConstrucao]=@AnoDeConstrucao, [Distrito]=@Distrito, [Cidade]=@Cidade, [TipoImovel]=@TipoImovel, " +
                    "[Para]=@Para, [Preco]=@Preco, [Nfunc]=@Nfunc, [Observacao]=@Observacao where [Imagem]=@Imagem", sqlParams);
            }

            static public int deleteImovel(int NºdoImovel)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NºdoImovel", NºdoImovel),

            };
                return dal.executarNonQuery("Delete From Cliente WHERE[NºdoImovel]@NºdoImovel", sqlParams);
            }
        }

        public class Cliente
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Cliente ", null);
            }

            static public int insertCliente(int IdCliente, string Nome, string Email, int Telefone, int CC, string Distrito, string Cidade, int Nfunc)

            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@IdCliente", IdCliente),
                                new SqlParameter("@Nome", Nome),
                                new SqlParameter("@Email", Email),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@CC", CC),
                                new SqlParameter("@Distrito", Distrito),
                                new SqlParameter("@Cidade", Cidade),
                                new SqlParameter("@Nfunc", Nfunc),
            };
                return dal.executarNonQuery("INSERT into Clinete (IdCliente, Nome, Email, Telefone, CC, Distrito , Cidade, Nfunc) " +
                    "VALUES(@IdCliente, @Nome, @Email, @Telefone, @CC, @Distrito , @Cidade, @Nfunc)", sqlParams);
            }
            static public int updateClinete(int IdClinete, string Nome, string Email, int Telefone, int CC, string Distrito, string Cidade, int Nfunc)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@IdCliente", IdClinete),
                                new SqlParameter("@Nome", Nome),
                                new SqlParameter("@Email", Email),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@CC", CC),
                                new SqlParameter("@Distrito", Distrito),
                                new SqlParameter("@Cidade", Cidade),
                                new SqlParameter("@Nfunc", Nfunc),
                               
                        };
                return dal.executarNonQuery("update [Cliente] set [IdCliente]=@IdCliente, [Nome]=@Nome,  [Email]=@Email, [Telefone]=@Telefone, [CC]=@CC,  [Distrito]=@Distrito, [Cidade]=@Cidade, [Nfunc]=@Nfunc where [Imagem]=@Imagem", sqlParams);
            }

            static public int deleteCliente(int IdCliente)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@IdClinete", IdCliente),

            };
                return dal.executarNonQuery("Delete From Cliente WHERE[IdCliente]@IdCliente", sqlParams);
            }
        }

        }
    }

    
