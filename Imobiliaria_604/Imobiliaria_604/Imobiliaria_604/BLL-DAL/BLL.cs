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

        public class Imagem
        {

            static public object loadpic()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", 1),
             };
                return dal.executarScalar("select Img from Imagem where id=1", sqlParams);

            }
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Imagem", null);
            }

            static public int insertImagem(byte[] img)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@img", img),

           };

                return dal.executarNonQuery("INSERT into Imagem (Img) VALUES(@img)", sqlParams);
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
                    " @CasaDebanho, @Elevador, @Estacionamento, @Eficiencia, @AnoDeConstrucao, @Distrito, @Cidade, @TipoImovel, @Para, @Preco, " +
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
        }

        public class login
        {
            static public DataTable loginUtilizador(int Nfunc, string Password)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nfunc", Nfunc),
                 new SqlParameter("@Password", Password)
                };
                return dal.executarReader("select * from login where Nfunc=@Nfunc and Password=@Password", sqlParams);
            }
        }

        public class Func
            {


                static public DataTable queryFunc_Like(String nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome + "%")
                };
                    return dal.executarReader("select * from Func where Nome like @nome", sqlParams);
                }
                static public DataTable queryFunc(int id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                    return dal.executarReader("select * from Func where ID=@id", sqlParams);
                }
                static public DataTable queryCliente_2(int id, string nome)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                 new SqlParameter("@Nome", nome)
                };
                    return dal.executarReader("select * from Clientes where ID=@id and Nome=@nome", sqlParams);
                }
                static public DataTable queryCliente_3(int id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                    return dal.executarReader("select * from Clientes where ID=@id", sqlParams);
                }
            }
            static public int deleteCliente(string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),

            };
                return dal.executarNonQuery("Delete From Clientes WHERE[id]=@id", sqlParams);
            }
            static public int alterarPerfil(string utilizador, String password, string imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@password", password),
                    new SqlParameter("@imagem", imagem)};

                return dal.executarNonQuery("update [utilizadores] set [password]=@password, [imagem]=@imagem where [utilizador]=@utilizador", sqlparams);
            }

            static public int alterarEstado(string utilizador, int estado)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@estado", estado)};

                return dal.executarNonQuery("update utilizadores set estado=@estado where utilizador=@utilizador", sqlparams);
            }

        }
    }

    
