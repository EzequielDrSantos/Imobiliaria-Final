﻿using System;
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
                new SqlParameter("@Password", Password)
                };
                return dal.executarReader("select * from Funcionario where Nfunc=@Nfunc and Password=@Password", sqlParams);
            }
        }

        public class Visita
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Visita ", null);
            }

            static public int insertVisita(int NumeroC, string NomeC, string NomeCt, int Telefone, int NumeroI, string Hora,DateTime Data,bool Atividade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                               
                                new SqlParameter("@NumeroC", NumeroC),
                                new SqlParameter("@NomeC", NomeC),
                                new SqlParameter("@NomeCt", NomeCt),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@NumeroI", NumeroI),
                                new SqlParameter("@Hora", Hora),
                                new SqlParameter("@Data", Data),
                                new SqlParameter("@Atividade", Atividade)
            };
                return dal.executarNonQuery("INSERT into Visita (NumeroC, NomeC, NomeCt, Telefone, NumeroI, Hora, Data, Atividade) " +
                    "VALUES(@NumeroC, @NomeC, @NomeCt, @Telefone, @NumeroI, @Hora, @Data, @Atividade)", sqlParams);
            }
            static public int updateVisita(int IdVisita, int NumeroC, string NomeC, string NomeCt, int Telefone, int NumeroI, string Hora, DateTime Data, bool Atividade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                                new SqlParameter("@IdVisita", IdVisita),
                                new SqlParameter("@NumeroC", NumeroC),
                                new SqlParameter("@NomeC", NomeC),
                                new SqlParameter("@NomeCt", NomeCt),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@NumeroI", NumeroI),
                                new SqlParameter("@Hora", Hora),
                                new SqlParameter("@Data", Data),
                                new SqlParameter("@Atividade", Atividade)
                        };
                return dal.executarNonQuery("update [Visita] set [NumeroC]=@NumeroC,  [NomeC]=@NomeC, [NomeCt]=@NomeCt, [Telefone]=@Telefone, [NumeroI]=@NumeroI, [Hora]=@Hora, [Data]=@Data where [IdVisita]=@IdVisita ", sqlParams);
            }

            static public int deleteVisita(int IdVisita)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@IdVisita", IdVisita)
            };
                return dal.executarNonQuery("Delete From Cliente WHERE [IdVisita]@Idvisita", sqlParams);
            }
        }

        public class Imovel
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from NvImovel ", null);
            }

            static public int insertNvImovel(int NºdoImovel, string Morada, string Numero, string Andar, string CodigoPostal, string AreaTotal, string AreaBruta, string Quarto, string CasaDeBanho, bool Elevador, bool Estacionamento, string Eficiencia, string AnoConstrucao, string Distrito, string Cidade, string TipoImovel, string Para, string Preco, string Observacao, byte[] Imagem, bool Atividade)
            {

                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@NºdoImovel",NºdoImovel),
                                new SqlParameter("@Morada", Morada),
                                new SqlParameter("@Numero", Numero),
                                new SqlParameter("@Andar", Andar),
                                new SqlParameter("@CodigoPostal", CodigoPostal),
                                new SqlParameter("@AreaTotal", AreaTotal),
                                new SqlParameter("@AreaBruta", AreaBruta),
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
                                new SqlParameter("@Observacao", Observacao),
                                new SqlParameter("@Imagem", Imagem),
                                new SqlParameter("@Atividade", Atividade)
            };
                return dal.executarNonQuery("INSERT into NvImovel (NºdoImovel, Morada, Numero, Andar, CodigoPostal, " +
                    "AreaTotal, AreaBruta, Quarto, CasaDebanho, Elevador, Estacionamento, Eficiencia, AnoConstrucao, Distrito, " +
                    "Cidade, TipoImovel, Para, Preco, Observacao, Imagem, Atividade) " +
                    "VALUES(@NºdoImovel, @Morada, @Numero, @Andar, @CodigoPostal, @AreaTotal, @AreaBruta, @Quarto," +
                    " @CasaDebanho, @Elevador, @Estacionamento, @Eficiencia, @AnoConstrucao, @Distrito, @Cidade, @TipoImovel, @Para, @Preco, " +
                    "@Observacao, @Imagem, @Atividade)", sqlParams);
            }
            static public int updateNvImovel(int NºdoImovel, string Morada, string Numero, string Andar, string CodigoPostal, string AreaTotal, string AreaBruta, string Quarto, string CasaDeBanho, bool Elevador, bool Estacionamento, string Eficiencia, string AnoConstrucao, string Distrito ,string Cidade, string TipoImovel, string Para, string Preco, string Observacao, byte[] Imagem,bool Atividade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                            new SqlParameter("@NºdoImovel", NºdoImovel),
                                new SqlParameter("@Morada", Morada),
                                new SqlParameter("@Numero", Numero),
                                new SqlParameter("@Andar", Andar),
                                new SqlParameter("@CodigoPostal", CodigoPostal),
                                new SqlParameter("@AreaTotal", AreaTotal),
                                new SqlParameter("@AreaBruta", AreaBruta),
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
                                new SqlParameter("@Observacao", Observacao),
                                new SqlParameter("@Imagem", Imagem),
                                new SqlParameter("@Atividade", Atividade)
                        };
                return dal.executarNonQuery("update [NvImovel] set [NºdoImovel]=@NºdoImovel, " +
                    "[Morada]=@Morada, [Numero]=@Numero, [Andar]=@Andar, [CodigoPostal]=@CodigoPostal, " +
                    " [AreaTotal]=@AreaTotal, [AreaBruta]=@AreaBruta, [Quarto]=@Quarto, [CasaDebanho]=@CasaDebanho, [Elevador]=@Elevador, [Estacionamento]=@Estacionamento, [Eficiencia]=@Eficiencia, " +
                    "[AnoConstrucao]=@AnoConstrucao, [Distrito]=@Distrito, [Cidade]=@Cidade, [TipoImovel]=@TipoImovel, " +
                    "[Para]=@Para, [Preco]=@Preco, [Observacao]=@Observacao, [Imagem]=@Imagem, [Atividade]=@Atividade WHERE[NºdoImovel]=@NºdoImovel", sqlParams);
            }

            static public int updateNvImovel2(int NºdoImovel, string Morada, string Numero, string Andar, string CodigoPostal,
               string AreaBruta, string AreaTotal, string Quarto, string CasaDeBanho, bool Elevador, bool Estacionamento, string Eficiencia, string AnoConstrucao, string Distrito,
               string Cidade, string TipoImovel, string Para, string Preco,
               string Observacao, bool Atividade)
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
                                new SqlParameter("@Observacao", Observacao),
                                new SqlParameter("@Atividade", Atividade)
                        };
                return dal.executarNonQuery("update [NvImovel] set [NºdoImovel]=@NºdoImovel, " +
                    "[Morada]=@Morada, [Numero]=@Numero, [Andar]=@Andar, [CodigoPostal]=@CodigoPostal, " +
                    "[AreaBruta]=@AreaBruta, [AreaTotal]=@AreaTotal, [Quarto]=@Quarto, [CasaDebanho]=@CasaDebanho, [Elevador]=@Elevador, [Estacionamento]=@Estacionamento, [Eficiencia]=@Eficiencia, " +
                    "[AnoConstrucao]=@AnoConstrucao, [Distrito]=@Distrito, [Cidade]=@Cidade, [TipoImovel]=@TipoImovel, " +
                    "[Para]=@Para, [Preco]=@Preco, [Observacao]=@Observacao, [Atividade]=@Atividade WHERE [NºdoImovel]=@NºdoImovel", sqlParams);
            }  
        }

        public class Cliente
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Cliente ", null);
            }

            static public int insertCliente(int IdCliente, string Nome, string Email, int Telefone, int CC, string Distrito, string Cidade, bool Atividade)
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
                                new SqlParameter("@Atividade", Atividade)
            };
                return dal.executarNonQuery("INSERT into Cliente (IdCliente, Nome, Email, Telefone, CC, Distrito , Cidade, Atividade) " +
                    "VALUES(@IdCliente, @Nome, @Email, @Telefone, @CC, @Distrito , @Cidade, @Atividade)", sqlParams);
            }
            static public int updateCliente(int IdClinete, string Nome, string Email, int Telefone, int CC, string Distrito, string Cidade, bool Atividade)
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
                                new SqlParameter("@Atividade", Atividade)

                        };
                return dal.executarNonQuery("update [Cliente] set [IdCliente]=@IdCliente, [Nome]=@Nome,  [Email]=@Email, [Telefone]=@Telefone, [CC]=@CC,  [Distrito]=@Distrito, [Cidade]=@Cidade, [Atividade]=@Atividade WHERE [IdCliente]=@IdCliente  ", sqlParams);
            }
        }

        public class Funcionario
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Funcionario ", null);
            }

            static public int insertFuncionario(int Nfunc, string Nome, string Email, int Telefone, int CC, int NIF, int NIB, bool Cargo, string Password, bool Atividade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@Nfunc", Nfunc),
                                new SqlParameter("@Nome", Nome),
                                new SqlParameter("@Email", Email),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@CC", CC),
                                new SqlParameter("@NIF", NIF),
                                new SqlParameter("@NIB", NIB),
                                new SqlParameter("@Cargo", Cargo),
                                new SqlParameter("@Password", Password),
                                new SqlParameter("@Atividade", Atividade)
            };
                return dal.executarNonQuery("INSERT into Funcionario (Nfunc, Nome, Email, Telefone, CC, NIF, NIB, Cargo, Password, Atividade) " +
                    "VALUES(@Nfunc, @Nome, @Email, @Telefone, @CC, @NIF , @NIB, @Cargo, @Password, @Atividade)", sqlParams);
            }
            static public int updateFuncionario(int Nfunc, string Nome, string Email, int Telefone, int CC, int NIF, int NIB, bool Cargo, string Password, bool Atividade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                new SqlParameter("@Nfunc", Nfunc),
                                new SqlParameter("@Nome", Nome),
                                new SqlParameter("@Email", Email),
                                new SqlParameter("@Telefone", Telefone),
                                new SqlParameter("@CC", CC),
                                new SqlParameter("@NIF", NIF),
                                new SqlParameter("@NIB", NIB),
                                new SqlParameter("@Cargo", Cargo),
                                new SqlParameter("@Password", Password),
                                new SqlParameter("@Atividade", Atividade)
                        };
                return dal.executarNonQuery("update [Funcionario] set [Nfunc]=@Nfunc, [Nome]=@Nome,  [Email]=@Email, [Telefone]=@Telefone, [CC]=@CC,  [NIF]=@NIF, [NIB]=@NIB, [Cargo]=@Cargo, [Password]=@Password, [Atividade]=@Atividade where [Nfunc]=@Nfunc ", sqlParams);
            }           
        }

        public class IdImovel
        {
            static public Object IdoImovel()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                };
                return dal.executarScalar("select Max(NºdoImovel) from NvImovel ", sqlParams);
            }

        }

        public class IdClinete
        {
            static public Object IdoCliente()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                };
                return dal.executarScalar("select Max(IdCliente) from Cliente ", sqlParams);
            }

        }

        public class IdFuncionario
        {
            static public Object IdoFuncionario()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select Max(Nfunc) from Funcionario ", sqlParams);
            }
        }

        public class Atividade
        {
            static public Object AtividadeAt()
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                };
                return dal.executarScalar("select Atividade from Funcionario ", sqlParams);
            }
        }


        //public class Distrito
        //{
        //    static public DataTable Distritos()
        //    {
        //        DAL dal = new DAL();
        //        SqlParameter[] sqlParams = new SqlParameter[]{

        //        };
        //        return dal.executarReader("select NomeDistrito from Distrito ", sqlParams);
        //    }
        //}

        //public class Conselho
        //{
        //    static public DataTable Conselhoo(int IDistrito)
        //    {
        //            DAL dal = new DAL();
        //        SqlParameter[] sqlParams = new SqlParameter[]{
        //                        new SqlParameter("@IDistrito", IDistrito ),
        //        };
        //        return dal.executarReader("select Conselho from Conselhos WHERE IDistrito=@IDistrito", sqlParams);
        //    }
        //}

    }
 }

    
