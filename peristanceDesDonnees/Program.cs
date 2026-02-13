using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace ADOExemples
    {
        static class Program
        {
           public static void Main()
            {
            NpgsqlConnection maCnx; 
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");
            int choix, idauteur, puid;
            string lettre; string name; string adress; string city; string zip; string ISBN, titre;
            
            do
            {
                Console.WriteLine("1. Afficher les éditeurs - PubId, Name - dont le nom commence par une lettre donnée");
                Console.WriteLine("2. Ajouter un éditeur (saisis des seuls champs name, adress, city, zip) (affichage id généré)");
                Console.WriteLine("3. Supprimer un titre dans la table Titles (saisie de l'ISBN).");
                Console.WriteLine("4. Ajouter un titre dans la table  Titles, lui affecter un auteur, et un éditeur");
                Console.WriteLine("5. Quitter");
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("quelle lettre");
                        lettre = Console.ReadLine() + "%";
                        try
                        {
                            string requête;
                            maCnx.Open(); // on se connecte
                            // NOTA BENE : title est un nom de champ, titles le nom de la table !
                            // DEBUT requête paramétrée
                            requête = "select * from publishers";
                            var maCde = new NpgsqlCommand(requête, maCnx);
                            jeuEnr = maCde.ExecuteReader();
                            while (jeuEnr.Read())
                            {
                                Console.Write(jeuEnr["pubid"] + "\t");
                                Console.Write(jeuEnr["name"] + "\t");
                                Console.WriteLine();
                            }
                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (jeuEnr is object & !jeuEnr.IsClosed)
                            {
                                jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                            }
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("saisir nom");
                        name = Console.ReadLine();
                        Console.WriteLine("saisir adress");
                        adress = Console.ReadLine();
                        Console.WriteLine("saisir ville");
                        city = Console.ReadLine();
                        Console.WriteLine("saisir zip");
                        zip = Console.ReadLine();
                        try
                        {
                            string requête;
                            maCnx.Open(); // on se connecte
                            // DEBUT requête paramétrée
                            requête = "Insert into publishers(name,address,city,zip) values (@name,@adress,@city,@zip) RETURNING pubid";
                            var maCde = new NpgsqlCommand(requête, maCnx);
                            maCde.Parameters.AddWithValue("@name",name);
                            maCde.Parameters.AddWithValue("@adress", adress);
                            maCde.Parameters.AddWithValue("@city", city);
                            maCde.Parameters.AddWithValue("@zip",zip);
                            int idAuthorGenere;
                            idAuthorGenere = (int)(maCde.ExecuteScalar());
                            Console.WriteLine("id puplisher généré  :" + idAuthorGenere.ToString());
                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("saisie ISBN");
                        ISBN = Console.ReadLine();
                        try
                        {
                            string requête1; string requête2;
                            maCnx.Open(); // on se connecte
                            // DEBUT requête paramétrée
                            requête1 = "DELETE FROM titles WHERE isbn = @ISBN";
                            requête2 = "DELETE FROM titleauthor WHERE isbn = @ISBN";
                            var maCde = new NpgsqlCommand(requête1, maCnx);
                            maCde.Parameters.AddWithValue("@ISBN", ISBN);
                            var maCde2 = new NpgsqlCommand(requête2, maCnx);
                            maCde2.Parameters.AddWithValue("@ISBN", ISBN);
                            maCde2.ExecuteNonQuery();   
                            maCde.ExecuteNonQuery();
                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("titre");
                        titre = Console.ReadLine();
                        Console.WriteLine("saisie ISBN");
                        ISBN = Console.ReadLine();
                        Console.WriteLine("id auteur");
                        idauteur = int.Parse(Console.ReadLine());
                        Console.WriteLine("id editeur");
                        puid = int.Parse(Console.ReadLine());



                        try
                        {
                            string requête1; string requête2;
                            maCnx.Open(); // on se connecte
                            // DEBUT requête paramétrée
                            requête1 = "insert into titles(title,isbn,pubid) values (@title, @ISBN, @puid); insert into titleauthor(isbn,au_id) values (@ISBN , @idauteur)";
                            var maCde = new NpgsqlCommand(requête1, maCnx);
                            maCde.Parameters.AddWithValue("@title", titre);
                            maCde.Parameters.AddWithValue("@ISBN", ISBN);
                            maCde.Parameters.AddWithValue("@puid", puid);
                            maCde.Parameters.AddWithValue("@ISBN", ISBN);
                            maCde.Parameters.AddWithValue("@idauteur",idauteur);
                            maCde.ExecuteNonQuery();

                        }
                        catch (NpgsqlException e)
                        {
                            Console.WriteLine("Erreur " + e.ToString());
                        }
                        finally
                        {
                            if (maCnx is object & maCnx.State == ConnectionState.Open)
                            {
                                maCnx.Close(); // on se déconnecte
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("au revoir");
                        Console.ReadLine();
                        break;


                        

                }
            } while (choix!=5);
            }
        }
    }
