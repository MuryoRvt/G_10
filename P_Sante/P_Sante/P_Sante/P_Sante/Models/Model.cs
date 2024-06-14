using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Sante.Controllers;
using MySql.Data.MySqlClient;
using P_Sante.Classes;

namespace P_Sante.Models
{
    public class Model
    {
        /// <summary>
        /// Controller to manage the model
        /// </summary>
        public Controller Controller { get; set; }

        public User CurrentUser { get; set; }

        public List<User> AllUsers { get; set; }

        public Model()
        {
            CurrentUser = new User();
            AllUsers = new List<User>();
        }

        public void InsertIntoDB()
        {
            string connStr = "server=localhost;user=root;database=db_health;port=3306;password=root";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO t_user (useFirstName, useLastName, useEmail, useCountry, usePassword, useIntMentalHealth, useIntPhysicalHealth, useState, useFriends, useAnxiety, useEaseToRelate, useFavourites1, useFavourites2, useFavourites3, useSleep, useExercises, useWater, useFoodQuality, useMedicines, useMedicines1, useMedicines2, useMedicines3, useHeight, useWeight)" +
                                 "VALUES(@FirstName, @LastName, @Email, @Country, @Password, @IntMentalHealth, @IntPhysicalHealth, @State, @Friends, @Anxiety, @EaseToRelate, @Favourites1, @Favourites2, @Favourites3, @Sleep, @Exercises, @Water, @FoodQuality, @Medicines, @Medicines1, @Medicines2, @Medicines3, @Height, @Weight)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", CurrentUser.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", CurrentUser.LastName);
                        cmd.Parameters.AddWithValue("@Email", CurrentUser.Email);
                        cmd.Parameters.AddWithValue("@Country", CurrentUser.Country);
                        cmd.Parameters.AddWithValue("@Password", CurrentUser.Password);
                        cmd.Parameters.AddWithValue("@IntMentalHealth", CurrentUser.IntMentalHealth);
                        cmd.Parameters.AddWithValue("@IntPhysicalHealth", CurrentUser.IntPhysicalHealth);
                        cmd.Parameters.AddWithValue("@State", CurrentUser.State);
                        cmd.Parameters.AddWithValue("@Friends", CurrentUser.Friends);
                        cmd.Parameters.AddWithValue("@Anxiety", CurrentUser.Anxiety);
                        cmd.Parameters.AddWithValue("@EaseToRelate", CurrentUser.EaseToRelate);
                        cmd.Parameters.AddWithValue("@Favourites1", CurrentUser.Favourites1);
                        cmd.Parameters.AddWithValue("@Favourites2", CurrentUser.Favourites2);
                        cmd.Parameters.AddWithValue("@Favourites3", CurrentUser.Favourites3);
                        cmd.Parameters.AddWithValue("@Sleep", CurrentUser.Sleep);
                        cmd.Parameters.AddWithValue("@Exercises", CurrentUser.Exercises);
                        cmd.Parameters.AddWithValue("@Water", CurrentUser.Water);
                        cmd.Parameters.AddWithValue("@FoodQuality", CurrentUser.FoodQuality);
                        cmd.Parameters.AddWithValue("@Medicines", CurrentUser.Medicines);
                        cmd.Parameters.AddWithValue("@Medicines1", CurrentUser.Medicines1);
                        cmd.Parameters.AddWithValue("@Medicines2", CurrentUser.Medicines2);
                        cmd.Parameters.AddWithValue("@Medicines3", CurrentUser.Medicines3);
                        cmd.Parameters.AddWithValue("@Height", CurrentUser.Height);
                        cmd.Parameters.AddWithValue("@Weight", CurrentUser.Weight);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public List<User> ListUsers()
        {
            List<User> users = new List<User>();

            string connStr = "server=localhost;user=root;database=db_health;port=3306;password=root";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT idUser, useFirstName, useLastName, useEmail, useCountry, usePassword, useIntMentalHealth, useIntPhysicalHealth, useState, useFriends, useAnxiety, useEaseToRelate, useFavourites1, useFavourites2, useFavourites3, useSleep, useExercises, useWater, useFoodQuality, useMedicines, useMedicines1, useMedicines2, useMedicines3, useHeight, useWeight FROM t_user";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                User user = new User
                                {
                                    Id = Convert.ToInt32(rdr["idUser"]),
                                    FirstName = rdr["useFirstName"].ToString(),
                                    LastName = rdr["useLastName"].ToString(),
                                    Email = rdr["useEmail"].ToString(),
                                    Country = rdr["useCountry"].ToString(),
                                    Password = rdr["usePassword"].ToString(),
                                    IntMentalHealth = Convert.ToBoolean(rdr["useIntMentalHealth"]),
                                    IntPhysicalHealth = Convert.ToBoolean(rdr["useIntPhysicalHealth"]),
                                    State = Convert.ToByte(rdr["useState"]),
                                    Friends = Convert.ToBoolean(rdr["useFriends"]),
                                    Anxiety = Convert.ToBoolean(rdr["useAnxiety"]),
                                    EaseToRelate = Convert.ToByte(rdr["useEaseToRelate"]),
                                    Favourites1 = rdr["useFavourites1"].ToString(),
                                    Favourites2 = rdr["useFavourites2"].ToString(),
                                    Favourites3 = rdr["useFavourites3"].ToString(),
                                    Sleep = Convert.ToBoolean(rdr["useSleep"]),
                                    Exercises = Convert.ToBoolean(rdr["useExercises"]),
                                    Water = Convert.ToBoolean(rdr["useWater"]),
                                    FoodQuality = Convert.ToByte(rdr["useFoodQuality"]),
                                    Medicines = Convert.ToBoolean(rdr["useMedicines"]),
                                    Medicines1 = rdr["useMedicines1"].ToString(),
                                    Medicines2 = rdr["useMedicines2"].ToString(),
                                    Medicines3 = rdr["useMedicines3"].ToString(),
                                    Height = Convert.ToInt32(rdr["useHeight"]),
                                    Weight = Convert.ToInt32(rdr["useWeight"])
                                };

                                users.Add(user);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return users;
        }

        public void UpdateData()
        {
            string connStr = "server=localhost;user=root;database=db_health;port=3306;password=root";

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();

                string updateQuery = @"
                UPDATE t_user
                SET
                    useFirstName = @FirstName,
                    useLastName = @LastName,
                    useEmail = @Email,
                    useCountry = @Country,
                    usePassword = @Password,
                    useIntMentalHealth = @IntMentalHealth,
                    useIntPhysicalHealth = @IntPhysicalHealth,
                    useState = @State,
                    useFriends = @Friends,
                    useAnxiety = @Anxiety,
                    useEaseToRelate = @EaseToRelate,
                    useFavourites1 = @Favourites1,
                    useFavourites2 = @Favourites2,
                    useFavourites3 = @Favourites3,
                    useSleep = @Sleep,
                    useExercises = @Exercises,
                    useWater = @Water,
                    useFoodQuality = @FoodQuality,
                    useMedicines = @Medicines,
                    useMedicines1 = @Medicines1,
                    useMedicines2 = @Medicines2,
                    useMedicines3 = @Medicines3,
                    useHeight = @Height,
                    useWeight = @Weight
                WHERE
                    idUser = @IdToUpdate";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", CurrentUser.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", CurrentUser.LastName);
                    cmd.Parameters.AddWithValue("@Email", CurrentUser.Email);
                    cmd.Parameters.AddWithValue("@Country", CurrentUser.Country);
                    cmd.Parameters.AddWithValue("@Password", CurrentUser.Password);
                    cmd.Parameters.AddWithValue("@IntMentalHealth", CurrentUser.IntMentalHealth);
                    cmd.Parameters.AddWithValue("@IntPhysicalHealth", CurrentUser.IntPhysicalHealth);
                    cmd.Parameters.AddWithValue("@State", CurrentUser.State);
                    cmd.Parameters.AddWithValue("@Friends", CurrentUser.Friends);
                    cmd.Parameters.AddWithValue("@Anxiety", CurrentUser.Anxiety);
                    cmd.Parameters.AddWithValue("@EaseToRelate", CurrentUser.EaseToRelate);
                    cmd.Parameters.AddWithValue("@Favourites1", CurrentUser.Favourites1);
                    cmd.Parameters.AddWithValue("@Favourites2", CurrentUser.Favourites2);
                    cmd.Parameters.AddWithValue("@Favourites3", CurrentUser.Favourites3);
                    cmd.Parameters.AddWithValue("@Sleep", CurrentUser.Sleep);
                    cmd.Parameters.AddWithValue("@Exercises", CurrentUser.Exercises);
                    cmd.Parameters.AddWithValue("@Water", CurrentUser.Water);
                    cmd.Parameters.AddWithValue("@FoodQuality", CurrentUser.FoodQuality);
                    cmd.Parameters.AddWithValue("@Medicines", CurrentUser.Medicines);
                    cmd.Parameters.AddWithValue("@Medicines1", CurrentUser.Medicines1);
                    cmd.Parameters.AddWithValue("@Medicines2", CurrentUser.Medicines2);
                    cmd.Parameters.AddWithValue("@Medicines3", CurrentUser.Medicines3);
                    cmd.Parameters.AddWithValue("@Height", CurrentUser.Height);
                    cmd.Parameters.AddWithValue("@Weight", CurrentUser.Weight);
                    cmd.Parameters.AddWithValue("@IdToUpdate", CurrentUser.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }
            }
        }

        public void DeleteUser()
        {
            string connStr = "server=localhost;user=root;database=db_health;port=3306;password=root";

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                connection.Open();

                string delete = "DELETE FROM t_user WHERE idUser = @IdToDelete";

                using (MySqlCommand cmd = new MySqlCommand(delete, connection))
                {
                    cmd.Parameters.AddWithValue("@IdToDelete", CurrentUser.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
