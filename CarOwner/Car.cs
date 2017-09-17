using System;
using System.Collections.Generic;
using System.Text;

namespace CarOwner
{
    /// <summary>
    /// Enums are types, just like classes. When you declare an enum inside a class, it's just a nested type. A nested enum just hides other enums with the same name that are declared in outer scopes, but you can still refer to the hidden enum through its fully qualified name (using the namespace prefix, in your example).
    /// The decision whether to declare a top level enum or a nested enum depends on your design and whether those enums will be used by anything other than the class. You can also make a nested enum private or protected to its enclosing type.But, top level enums are far more common.
    /// </summary>
    //Enum er placeret uden for klassen, så alle klasser har adgang til den.
    public enum CarColor { Black, White, Gray, Red, Green, Blue };
    public class Car
    {
        /// <summary>
        /// Car klassen bruges til at instanciere car-objekter der skal indeholde antal døre, bilmodel, farve og nummerplade.
        /// </summary>

        #region -------- Properties --------
        //Properties er alle fullprop, hvilket bl.a. gør det muligt at binde et View til en ViewModel.

        //sætter det tilladte antal bildøre fra 2 til 5.
        private int _doors;
        public int Doors
        {
            get { return _doors; }
            private set
            {
                if (value < 2 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("PROPERTY: Antal døre skal være mellem 2 og 5.");
                }
                _doors = value;
            }
        }

        //sørger for at bilmodellen får min. et tegn.
        private string _model;
        public string Model
        {
            get { return _model; }
            private set {
                if (value == "" || value.Length == 0 || value == null)
                {
                    throw new ArgumentException("PROPERTY: Husk at indtaste en bilmodel.");
                }
                _model = value;
            }
        }

        //sikre at en nummerplade indeholder præcis 7 tegn.
        private string _registrationNo;
        public string RegistrationNo
        {
            get { return _registrationNo; }
            private set {
                if (value.Length != 7)
                {
                    throw new ArgumentOutOfRangeException("Nummerpladen skal være på præcis 7 tegn.");
                }
                _registrationNo = value;
            }
        }

        //sikre vi at bilens farve bliver sat.
        private CarColor _carColor;
        public CarColor Color
        {
            get { return _carColor; }
            set
            {
                if (value != CarColor.Black)
                {
                    throw new ArgumentOutOfRangeException("PROPERTY: Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
                }
                _carColor = value;
            }
        }


        /// <summary>
        /// ifølge opgavens klassediagrammet er forholdet mellen Owner- og Car-klassen en-til-mange 
        /// derfor skal det være muligt at oprette en Owner i Car-klassen, 
        /// da en Owner godt kan eje flere biler.
        /// </summary>

        private Owner _carOwner;   
        public Owner CarOwner
        {
            get { return _carOwner; }
            set { _carOwner = value; }
        }
        #endregion

        #region -------- Constructors --------
        //Car-klassens Constructor
        public Car(int d, string m, string r, CarColor c)
        {
            this.Doors = d;
            this.Model = m;
            this.RegistrationNo = r;
            this.Color = c;
        }
        #endregion

        #region -------- Metoder --------
        /// <summary>
        /// Her starter Car-klassen's metoder. De bruges i UnitTestCar for at sikre at forskellige
        /// if-statements virker efter hensigten.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>

        //metode der tjekker om antallet af bildøre er mellem 2 og 5.
        public int TjekDoors()
        {
            if (!(Doors < 2 || Doors > 5))
            {
                return Doors;
            }
            else
            {
                throw new ArgumentOutOfRangeException("METHOD: Antal døre skal være mellem 2 og 5.");
            }
        }

        //metode der tjekker om bilens farve bliver sat.
        public void TjekCarColor(CarColor c)
        {
            if (c != CarColor.Black)
            {
                throw new ArgumentOutOfRangeException("METHOD: Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            }
            //else if (c != CarColor.Blue)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (c != CarColor.Gray)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (c != CarColor.Green)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (c != CarColor.Red)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            //else if (c != CarColor.White)
            //{
            //    throw new ArgumentOutOfRangeException("Bilens farve skal være enten: Black, White, Gray, Red, Green eller Blue.");
            //}
            else
            {
                this.Color = c;
            }
        }

        //metode der tjekker om antallet af tegn i nummerpladen er præcis 7 tegn.
        public string TjekNummerplade()
        {
            if (RegistrationNo.Length == 7)
            {
                return RegistrationNo;
            }
            else
            {
                throw new ArgumentOutOfRangeException("METHOD: Nummerpladen skal være på præcis 7 tegn.");
            }
        }

        //metode der tjekker om der min. er et tegn i bilmodellen.
        public string TjekBilModel()
        {
            if (!(Model == "" || Model == null || Model.Length == 0))
            {
                return Model;
            }
            else
            {
                throw new ArgumentException("METHOD: Husk at indtaste en bilmodel.");
            }
        }
        #endregion
    }
}
