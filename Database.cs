using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Final_Project
{
    public static class Database
    {
        // List of users in the system
        public static List<User> Users { get; set; } = new List<User>
        {
            new User
            {
                Name = "Alice",
                Username = "alice123",
                Password = "password123",
                Pets = new List<Pet>
                {
                    new Pet
                    {
                        Name = "Bella",
                        Type = "Dog",
                        Breed = "Golden Retriever",
                        Tasks = new List<Task>
                        {
                            new Task { Description = "Morning Walk", IsCompleted = false },
                            new Task { Description = "Feed Lunch", IsCompleted = false }
                        },
                        Schedule = new List<Schedule>
                        {
                            new Schedule { Description = "Vet Appointment", ScheduledDate = new DateTime(2024, 12, 5) }
                        }
                    },
                    new Pet
                    {
                        Name = "Max",
                        Type = "Cat",
                        Breed = "Siamese",
                        Tasks = new List<Task>
                        {
                            new Task { Description = "Change Litter Box", IsCompleted = false }
                        },
                        Schedule = new List<Schedule>
                        {
                            new Schedule { Description = "Grooming", ScheduledDate = new DateTime(2024, 12, 10) }
                        }
                    }
                }
            },
            new User
            {
                Name = "Bob",
                Username = "bob456",
                Password = "securepass",
                Pets = new List<Pet>
                {
                    new Pet
                    {
                        Name = "Charlie",
                        Type = "Dog",
                        Breed = "Beagle",
                        Tasks = new List<Task>
                        {
                            new Task { Description = "Evening Walk", IsCompleted = false }
                        },
                        Schedule = new List<Schedule>
                        {
                            new Schedule { Description = "Vaccination", ScheduledDate = new DateTime(2024, 12, 15) }
                        }
                    }
                }
            }
        };

        // Method to authenticate user based on Username and Password
        public static User Authenticate(string username, string password)
        {
            return Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        // Method to add a new user
        public static void AddUser(User user)
        {
            Users.Add(user);
        }

        // Method to add a pet for a specific user
        public static void AddPet(User user, Pet pet)
        {
            var foundUser = Users.FirstOrDefault(u => u.Username == user.Username);
            if (foundUser != null)
            {
                foundUser.Pets.Add(pet);
            }
        }

        // Method to add a task to a specific pet
        public static void AddTaskToPet(User user, Pet pet, Task task)
        {
            var foundUser = Users.FirstOrDefault(u => u.Username == user.Username);
            var foundPet = foundUser?.Pets.FirstOrDefault(p => p.Name == pet.Name);
            if (foundPet != null)
            {
                foundPet.Tasks.Add(task);
            }
        }

        // Method to add a schedule event to a specific pet
        public static void AddScheduleToPet(User user, Pet pet, Schedule schedule)
        {
            var foundUser = Users.FirstOrDefault(u => u.Username == user.Username);
            var foundPet = foundUser?.Pets.FirstOrDefault(p => p.Name == pet.Name);
            if (foundPet != null)
            {
                foundPet.Schedule.Add(schedule);
            }
        }
    }
}
