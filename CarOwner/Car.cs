using System;
using System.Collections.Generic;
using System.Text;

namespace CarOwner
{
    public class Car
    {
        /// <summary>
        /// Car klassen bruges til at instanciere car-objekter der skal indeholde antal døre, bilmodel, farve og nummerplade.
        /// </summary>
        //Props
        public int Doors { get; set; }
        public string Model { get; set; }
        public Enum Color { get; set; }
        public string RegistrationNo { get; set; }


        enum CarColor { Black, White, Gray, Red, Green, Blue };



        //Constructor
        public Car(int door, string model, /*Enum color,*/ string regNo)
        {
            if (door <= 1 || door >= 6)
            {
                throw new ArgumentOutOfRangeException("Antal døre skal være mellem 2 og 5.");
            }
            else
            {
                this.Doors = door;
            }

            if (model == "")
            {
                throw new ArgumentException("Husk at indtaste en bilmodel.");
            }
            else
            {
                this.Model = model;
            }

            //if (CarColor == "")
            //{
            //    throw new ArgumentException("Husk at indtaste en bilmodel.");
            //}
            //else
            //{
            //    this.Color = color;;
            //}

            if (regNo.Length == 7)
            {
                throw new ArgumentOutOfRangeException("Nummerpladen skal være på præcis 7 tegn.");
            }
            else
            {
                this.RegistrationNo = regNo;
            }
        }

        public int TjekDoors()
        {
            int temp = Doors;
            if (Doors <= 1 || Doors >= 6)
            {
                throw new ArgumentOutOfRangeException("Antal døre skal være mellem 2 og 5.");
            }
            return temp;
        }

        public string TjekNummerplade()
        {
            string temp = RegistrationNo;
            if (RegistrationNo.Length == 7)
            {
                throw new ArgumentOutOfRangeException("Nummerpladen skal være på præcis 7 tegn.");
            }
            return temp;
        }

        public string TjekBilModel()
        {
            string temp = Model;

            if (Model == null)
            {
                throw new ArgumentException("Husk at indtaste en bilmodel.");
            }
            return temp;
        }

    }
}
