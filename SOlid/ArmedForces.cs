using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SROCprinciples
{/// <summary>
/// Genaral class
/// </summary>
    abstract class ArmedForces
    {
        public double IdNo()
        {
            return 1;
        }
        public void NamesOfPersonnel()
        {
            return;
        }
        public int TotalNoofPersonnel(int count)
        {
            return count;
        }
        public abstract string RegionOfAssignment(string location);
        public abstract double Reward(string position, double salary);
        
    }
    /// <summary>
    /// Army personnel
    /// </summary>
    internal class Army: ArmedForces
    {
        public double IdNo()
        {
            return 1;
        }
        public new void NamesOfPersonnel()
        {
            return;
        }
        public new int TotalNoofPersonnel(int count)
        {
            return count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param ranking></param>
        /// <returns></returns>
        public string Rank(string position)
        {
            try
            {
                if ((position == "Lieutenant") || (position == "Captain"))
                {
                    Console.WriteLine("Your Rank is JuniorOfficer ");

                }
                else if ((position == "Colonel") || (position == "Major"))
                {
                    Console.WriteLine("Your Rank is Field or Senior Officer ");
                }
                else if ((position == "General") || (position == "Field Marshall"))
                {
                    Console.WriteLine("Your Rank is Field or Senior Officer ");
                }
            }
            catch (Exception)
            {

                return "No positions currently";
            }

            return "0";
        }

        /// <summary>
        /// Assigned department
        /// </summary>
        public void Department()
        {
            Console.WriteLine("Your department will be communicated after resumption");

        }
        private double Remuneration { get { return IdNo(); } set { double amt = value; } }

        //Region

        public override string RegionOfAssignment(string location)
        {
            if (location == "Lagos")
            {
                Console.WriteLine("Your Region of Assignment is in the West ");
            }
            else if (location == "Enugu")
            {
                Console.WriteLine("Your Region of Assignment is in the East ");
                
            }
            else if (location == "Taraba")
            {
                Console.WriteLine("Your Region of Assignment is in the North ");
               
            }
            else if (location == "Benue")
            {
                Console.WriteLine("Your Region of Assignment is in the MidBelt ");
                
            }
            return " ";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param position></param>
        /// <param salary></param>
        /// 
        /// <returns></returns>
        public override double Reward(string position, double salary )
        {
            double x;
            double rewards =0;
            try
            {
                if ((position == "Lieutenant") || (position == "Captain"))
                {
                    rewards = salary + (0.1 * salary);
                    x = rewards;

                }
                else if ((position == "Colonel") || (position == "Major"))
                {
                    rewards = salary + (0.2 * salary);
                    x = rewards;
                }
                else if ((position == "General") || (position == "Field Marshall"))
                {
                    rewards = salary + (0.3 * salary);
                    x = rewards;
                }
            }
            catch (Exception)
            {

                return 0;
            }

            return rewards;
        }

    }
    /// <summary>
    /// Airforce group
    /// </summary>
     class Airforce : ArmedForces
     {
        public int IdNo()
        {
            return 11;
        }
        public new void NamesOfPersonnel()
        {
            return;
        }
        public new int TotalNoofPersonnel(int count)
        {
            return count;
        }

        public string Rank(string position)
        {
            try
            {
                if ((position == "Flight Lieutenant") || (position == "Pilot Officer") || (position == "Flying officer"))
                {
                    Console.WriteLine("Your Rank is JuniorOfficer ");

                }
                else if ((position == "Group Captain") || (position == "Squadron leader") || (position == "Squadron leader")) 
                {
                    Console.WriteLine("Your Rank is Field or Senior Officer ");
                }
                else if ((position == "Air Comodore") || (position == "Air ViceMarshall") ||(position == "Air ChiefMarshall") 
                    || (position == "Marshall of the AirForce"))
                {
                    Console.WriteLine("Your Rank is Field or Senior Officer ");
                }
            }
            catch (Exception)
            {

                return "No positions currently";
            }

            return "0";
        }


        public void Department()
        {
            Console.WriteLine("Your department will be communicated after resumption");

        }
        private double Remuneration { get { return IdNo(); } set { double amt = value; } }

        public override string RegionOfAssignment(string location)
        {
            if (location == "Lagos")
            {
                Console.WriteLine("Your Region of Assignment is in the West ");


            }
            else if (location == "Enugu")
            {
                Console.WriteLine("Your Region of Assignment is in the East ");
                
            }
            else if (location == "Taraba")
            {
                Console.WriteLine("Your Region of Assignment is in the North ");
            }
            else if (location == "Benue")
            {
                Console.WriteLine("Your Region of Assignment is in the MidBelt ");
               
            }
            return "Nil ";
        }
        public override double Reward(string position, double salary )
        {
            double x;
            double rewards;
            try
            {
                if ((position == "Flight Lieutenant") || (position == "Pilot Officer") || (position == "Flying officer"))
                {
                    rewards = salary + (0.1 * salary);
                    x = rewards;

                }
                else if ((position == "Group Captain") || (position == "Squadron leader") || (position == "Squadron leader"))
                {
                    rewards = salary + (0.2 * salary);
                    x = rewards;
                }
                else if ((position == "Air Commodore") || (position == "Air ViceMarshall") || (position == "Air ChiefMarshall")
                                    || (position == "Marshall of the AirForce"))
                {
                    rewards = salary + (0.3 * salary);
                    x = rewards;
                }
            }
            catch (Exception)
            {

                return 0;
            }

            return 1;
        }


     }

     class Navy:ArmedForces
     {
        public int IdNo()
        {
            return 111;
        }

        public new void NamesOfPersonnel()
        {
            return;
        }
        public new int TotalNoofPersonnel(int count)
        {
            return count;
        }

        public string Rank(string position)
        {
            try
            {
                if ((position == "Mid Shipman") || (position == "Lieutenant"))
                {
                    Console.WriteLine("Your Rank is JuniorOfficer ");

                }
                else if ((position == "Commander") || (position == "Captain"))
                {
                    Console.WriteLine("Your Rank is Field or Senior Officer ");
                }
                else if ((position == "Commodore") || (position == "Rear Admiral")||(position == "Vice Admiral")||(position == "Admiral of the Fleet"))
                {
                    Console.WriteLine("Your Rank is Field or Senior Officer ");
                }
            }
            catch (Exception)
            {

                return "No positions currently";
            }

            return "0";
        }


        public void Department()
        {
            Console.WriteLine("Your department will be communicated after resumption");

        }
        private double Remuneration { get { return IdNo(); } set { double amt = value; } }

        public override string RegionOfAssignment(string location)
        {
            if (location == "Lagos")
            {
                Console.WriteLine("Your Region of Assignment is in the West ");


            }
            else if (location == "Enugu")
            {
                Console.WriteLine("Your Region of Assignment is in the East ");
                
            }
            else if (location == "Taraba")
            {
                Console.WriteLine("Your Region of Assignment is in the North ");
                
            }
            else if (location == "Benue")
            {
                Console.WriteLine("Your Region of Assignment is in the MidBelt ");
                
            }
            return " ";
        }
        public override double Reward(string position, double salary)
        {
            double x;
            double rewards = 0;
            try
            {
                if ((position == "Lieutenant") || (position == "Captain"))
                {
                    rewards = salary + (0.1 * salary);
                    x = rewards;

                }
                else if ((position == "Colonel") || (position == "Major"))
                {
                    rewards = salary + (0.2 * salary);
                    x = rewards;
                }
                else if ((position == "Commodore") || (position == "Rear Admiral") || (position == "Vice Admiral") || (position == "Admiral of the Fleet"))

                {
                    rewards = salary + (0.3 * salary);
                    x = rewards;
                }
            }
            catch (Exception)
            {

                return 0;
            }

            return rewards;
        }

     }
}
