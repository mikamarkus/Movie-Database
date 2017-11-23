using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace movie_database
{
    class DataBaseConnection
    {
        private static MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=windows_project");
        public static long ACTORID { get; set; }

        public void OpenConnection()
        {
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public DataTable ReadValue()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM movies" 
                + " LEFT JOIN genres ON movies.genre_id = Genres.id"
                + " LEFT JOIN producers ON movies.producer_id = Producers.id", conn);
            dataAdapter.Fill(dt);

            return dt;
        }

        public DataSet GetActorsList()
        {
            DataSet dt = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM actors", conn);
            dataAdapter.Fill(dt, "actorsList");

            return dt;
        }

        public DataSet GetProducersList()
        {
            DataSet dt = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM producers", conn);
            dataAdapter.Fill(dt, "producersList");

            return dt;
        }

        public DataSet GetGenresList()
        {
            DataSet dt = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM genres", conn);
            dataAdapter.Fill(dt, "genresList");

            return dt;
        }

        public DataSet GetMoviesActors(int movie_id)
        {
            DataSet dt = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT DISTINCT actor_id, movie_id, actors.id, actors.fullname FROM movies_actor"
                + " INNER JOIN actors ON actors.id = movies_actor.actor_id"
                + " WHERE movie_id = @movie_id", conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@movie_id", movie_id);
            dataAdapter.Fill(dt, "moviesActorsList");

            return dt;
        }

        public int AddMovie(Movie movie)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movies (name, length, budget, rating, genre_id, producer_id) VALUES (@name, @length, @budget, @rating, @genre_id, @producer); select last_insert_id();", conn);
                cmd.Parameters.AddWithValue("@name", movie.MovieName);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@budget", movie.Budget);
                cmd.Parameters.AddWithValue("@rating", movie.Rating);
                cmd.Parameters.AddWithValue("@genre_id", movie.Genre);
                cmd.Parameters.AddWithValue("@producer", movie.Producer);
                cmd.ExecuteNonQuery();
                ACTORID = cmd.LastInsertedId;
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            
        }

        public int EditMovie(Movie movie)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE movies SET name = @name, length = @length, budget = @budget, rating = @rating, genre_id = @genre_id, producer_id =  @producer WHERE id = @movie_id;", conn);
                cmd.Parameters.AddWithValue("@movie_id", movie.Movieid);
                cmd.Parameters.AddWithValue("@name", movie.MovieName);
                cmd.Parameters.AddWithValue("@length", movie.Length);
                cmd.Parameters.AddWithValue("@budget", movie.Budget);
                cmd.Parameters.AddWithValue("@rating", movie.Rating);
                cmd.Parameters.AddWithValue("@genre_id", movie.Genre);
                cmd.Parameters.AddWithValue("@producer", movie.Producer);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public void RemoveMovie(int movieId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movies WHERE id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", movieId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public int AddActorForMovie(int actorId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movies_actor (actor_id, movie_id) VALUES (@actorid, @movieid)", conn);
                cmd.Parameters.AddWithValue("@actorid", actorId);
                cmd.Parameters.AddWithValue("@movieid", ACTORID);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public int RemoveActorFromMovie(int actorId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movies_actor WHERE actor_id = @actorid AND movie_id = @movieid;", conn);
                cmd.Parameters.AddWithValue("@actorid", actorId);
                cmd.Parameters.AddWithValue("@movieid", ACTORID);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public int EditActorForMovie(int actorId, int movie_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movies_actor (actor_id, movie_id) VALUES (@actorid, @movieid)", conn);
                cmd.Parameters.AddWithValue("@actorid", actorId);
                cmd.Parameters.AddWithValue("@movieid", movie_id);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public int EditRemoveActorFromMovie(int actorId, int movie_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movies_actor WHERE actor_id = @actorid AND movie_id = @movieid;", conn);
                cmd.Parameters.AddWithValue("@actorid", actorId);
                cmd.Parameters.AddWithValue("@movieid", movie_id);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public void AddGenre(string genre)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO genres (genre) VALUES (@name);", conn);
                cmd.Parameters.AddWithValue("@name", genre);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Genre added successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void DeleteGenre(int genreId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM genres WHERE id = @genreId;", conn);
                cmd.Parameters.AddWithValue("@genreId", genreId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Genre deleted successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void EditGenre(int genreId, string genre)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE genres SET genre = @genre WHERE id = @genreId;", conn);
                cmd.Parameters.AddWithValue("@genreId", genreId);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Genre edited successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void AddProducer(Producer producer)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO producers (firstname, lastname, fullname, address, postal_code, city, nationality) " +
                    "VALUES (@fname, @lname, @fullname, @address, @pcode, @city, @nation);", conn);
                cmd.Parameters.AddWithValue("@fname", producer.Firstname);
                cmd.Parameters.AddWithValue("@lname", producer.Lastname);
                cmd.Parameters.AddWithValue("@fullname", producer.Firstname + " " + producer.Lastname);
                cmd.Parameters.AddWithValue("@address", producer.Address);
                cmd.Parameters.AddWithValue("@pcode", producer.Postalcode);
                cmd.Parameters.AddWithValue("@city", producer.City);
                cmd.Parameters.AddWithValue("@nation", producer.Nationality);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producer added successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void DeleteProducer(int producerId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM producers WHERE id = @producerId;", conn);
                cmd.Parameters.AddWithValue("@producerId", producerId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producer deleted successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void EditProducer(Producer producer)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE producers SET firstname = @fname, lastname = @lname, fullname = @fullname, address = @address, postal_code = @pcode, city = @city, nationality = @nation WHERE id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", producer.ProducerId);
                cmd.Parameters.AddWithValue("@fname", producer.Firstname);
                cmd.Parameters.AddWithValue("@lname", producer.Lastname);
                cmd.Parameters.AddWithValue("@fullname", producer.Firstname + " " + producer.Lastname);
                cmd.Parameters.AddWithValue("@address", producer.Address);
                cmd.Parameters.AddWithValue("@pcode", producer.Postalcode);
                cmd.Parameters.AddWithValue("@city", producer.City);
                cmd.Parameters.AddWithValue("@nation", producer.Nationality);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producer edited successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void AddActor(Actor actor)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO actors (firstname, lastname, fullname, address, postal_code, city, nationality) " +
                    "VALUES (@fname, @lname, @fullname, @address, @pcode, @city, @nation);", conn);
                cmd.Parameters.AddWithValue("@fname", actor.Firstname);
                cmd.Parameters.AddWithValue("@lname", actor.Lastname);
                cmd.Parameters.AddWithValue("@fullname", actor.Firstname + " " + actor.Lastname);
                cmd.Parameters.AddWithValue("@address", actor.Address);
                cmd.Parameters.AddWithValue("@pcode", actor.Postalcode);
                cmd.Parameters.AddWithValue("@city", actor.City);
                cmd.Parameters.AddWithValue("@nation", actor.Nationality);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actor added successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void DeleteActor(int actorId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM actors WHERE id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", actorId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actor deleted successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void EditActor(Actor actor)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE actors SET firstname = @fname, lastname = @lname, fullname = @fullname, address = @address, postal_code = @pcode, city = @city, nationality = @nation WHERE id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", actor.ActorId);
                cmd.Parameters.AddWithValue("@fname", actor.Firstname);
                cmd.Parameters.AddWithValue("@lname", actor.Lastname);
                cmd.Parameters.AddWithValue("@fullname", actor.Firstname + " " + actor.Lastname);
                cmd.Parameters.AddWithValue("@address", actor.Address);
                cmd.Parameters.AddWithValue("@pcode", actor.Postalcode);
                cmd.Parameters.AddWithValue("@city", actor.City);
                cmd.Parameters.AddWithValue("@nation", actor.Nationality);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actor edited successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
