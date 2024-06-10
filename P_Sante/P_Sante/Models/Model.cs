using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Sante.Controllers;
using MySql.Data;
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

        public void InsertIntoDB(User currentUser)
        {
            string connStr = "server=localhost;user=root;database=db_health;port=3306;password=root";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO t_user (useFirstName, useLastName, useEmail, usePassword, useIntMentalHealth, useIntAlimentation, useIntPhysicalActivity, useIntSleep, useState, useFriends, useAnxiety, useEaseToRelate, useFavourites1, useFavourites2, useFavourites3, useSleep, useExercises, useWater, useFoodQuality, useMedicines, useMedicines1, useMedicines2, useMedicines3) " +
                                 "VALUES(@FirstName, @LastName, @Email, @Password, @IntMentalHealth, @IntAlimentation, @IntPhysicalActivity, @IntSleep, @State, @Friends, @Anxiety, @EaseToRelate, @Favourites1, @Favourites2, @Favourites3, @Sleep, @Exercises, @Water, @FoodQuality, @Medicines, @Medicines1, @Medicines2, @Medicines3)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", currentUser.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", currentUser.LastName);
                        cmd.Parameters.AddWithValue("@Email", currentUser.Email);
                        cmd.Parameters.AddWithValue("@Password", currentUser.Password);
                        cmd.Parameters.AddWithValue("@IntMentalHealth", currentUser.IntMentalHealth);
                        cmd.Parameters.AddWithValue("@IntAlimentation", currentUser.IntAlimentation);
                        cmd.Parameters.AddWithValue("@IntPhysicalActivity", currentUser.IntPhysicalActivity);
                        cmd.Parameters.AddWithValue("@IntSleep", currentUser.IntSleep);
                        cmd.Parameters.AddWithValue("@State", currentUser.State);
                        cmd.Parameters.AddWithValue("@Friends", currentUser.Friends);
                        cmd.Parameters.AddWithValue("@Anxiety", currentUser.Anxiety);
                        cmd.Parameters.AddWithValue("@EaseToRelate", currentUser.EaseToRelate);
                        cmd.Parameters.AddWithValue("@Favourites1", currentUser.Favourites1);
                        cmd.Parameters.AddWithValue("@Favourites2", currentUser.Favourites2);
                        cmd.Parameters.AddWithValue("@Favourites3", currentUser.Favourites3);
                        cmd.Parameters.AddWithValue("@Sleep", currentUser.Sleep);
                        cmd.Parameters.AddWithValue("@Exercises", currentUser.Exercises);
                        cmd.Parameters.AddWithValue("@Water", currentUser.Water);
                        cmd.Parameters.AddWithValue("@FoodQuality", currentUser.FoodQuality);
                        cmd.Parameters.AddWithValue("@Medicines", currentUser.Medicines);
                        cmd.Parameters.AddWithValue("@Medicines1", currentUser.Medicines1);
                        cmd.Parameters.AddWithValue("@Medicines2", currentUser.Medicines2);
                        cmd.Parameters.AddWithValue("@Medicines3", currentUser.Medicines3);

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
                    string sql = "SELECT useFirstName, useLastName, useEmail, usePassword, useIntMentalHealth, useIntAlimentation, useIntPhysicalActivity, useIntSleep, useState, useFriends, useAnxiety, useEaseToRelate, useFavourites1, useFavourites2, useFavourites3, useSleep, useExercises, useWater, useFoodQuality, useMedicines, useMedicines1, useMedicines2, useMedicines3 FROM t_user";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                User user = new User
                                {
                                    FirstName = rdr["useFirstName"].ToString(),
                                    LastName = rdr["useLastName"].ToString(),
                                    Email = rdr["useEmail"].ToString(),
                                    Password = rdr["usePassword"].ToString(),
                                    IntMentalHealth = Convert.ToBoolean(rdr["useIntMentalHealth"]),
                                    IntAlimentation = Convert.ToBoolean(rdr["useIntAlimentation"]),
                                    IntPhysicalActivity = Convert.ToBoolean(rdr["useIntPhysicalActivity"]),
                                    IntSleep = Convert.ToBoolean(rdr["useIntSleep"]),
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
                                    Medicines3 = rdr["useMedicines3"].ToString()
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
    }
}
