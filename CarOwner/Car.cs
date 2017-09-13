using System;
using System.Collections.Generic;
using System.Text;

namespace CarOwner
{
    public enum CarColor { Black, White, Gray, Red, Green, Blue };
    public class Car
    {
        /// <summary>
        /// Car klassen bruges til at instanciere car-objekter der skal indeholde antal døre, bilmodel, farve og nummerplade.
        /// </summary>
        //Props
        
        private int _doors;
        public int Doors
        {
            get { return _doors; }
            private set
            {
                if (value <= 1 || value >= 6)
                {
                    throw new ArgumentOutOfRangeException("Antal døre skal være mellem 2 og 5.");
                }
            }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            private set {
                if (value == "" || value.Length == 0 || value == null)
                {
                    throw new ArgumentException("Husk at indtaste en bilmodel.");
                }
            }
        }

        public CarColor Color { get; set; }
        public string RegistrationNo { get; set; }

        private Owner _carOwner;   

        public Owner CarOwner
        {
            get { return _carOwner; }
            set { _carOwner = value; }
        }



        //Constructor
        public Car(int door, string model, string regNo, CarColor _carcolor)
        {
            this.Doors = door;
            

            if (model == "" || model.Length == 0 || model == null)
            {
                throw new ArgumentException("Husk at indtaste en bilmodel.");
            }
            else
            {
                this.Model = model;
            }

            if (!(regNo.Length == 7))
            {
                throw new ArgumentOutOfRangeException("Nummerpladen skal være på præcis 7 tegn.");
            }
            else
            {
                this.RegistrationNo = regNo;
            }

            CheckCarColor(_carcolor);

        }

        private void CheckCarColor(CarColor _carcolor)
        {
            if (_carcolor != CarColor.Black)
            {
                throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            }
            //else if (_carcolor != CarColor.Blue)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (_carcolor != CarColor.Gray)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (_carcolor != CarColor.Green)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (_carcolor != CarColor.Red)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (_carcolor != CarColor.White)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            else
            {
                this.Color = _carcolor;
            }
        }

        private int TjekDoors()
        {
            int temp = Doors;
            if (Doors <= 1 || Doors >= 6)
            {
                throw new ArgumentOutOfRangeException("Antal døre skal være mellem 2 og 5.");
            }
            return temp;
        }

        private string TjekNummerplade()
        {
            string temp = RegistrationNo;
            if (!(RegistrationNo.Length == 7))
            {
                throw new ArgumentOutOfRangeException("Nummerpladen skal være på præcis 7 tegn.");
            }
            return temp;
        }

        private string TjekBilModel()
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
