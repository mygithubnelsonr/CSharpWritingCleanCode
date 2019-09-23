using System;

namespace CleanCode.DuplicatedCode
{
    public class DuplicatedCode
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            // some logic here
            // ...

            #region refactoring the code
            #region Get rid of this duplicated code and replace it with a method
            //int time;
            //int hours = 0;
            //int minutes = 0;
            //if(!string.IsNullOrWhiteSpace(admissionDateTime))
            //{
            //    if(int.TryParse(admissionDateTime.Replace(":", ""), out time))
            //    {
            //        hours = time / 100;
            //        minutes = time % 100;
            //    }
            //    else
            //    {
            //        throw new ArgumentException("admissionDateTime");
            //    }
            //}
            //else
            //    throw new ArgumentException("admissionDateTime");
            #endregion

            // first refactoring step
            //int hours;
            //int minutes;
            //GetTime1(out hours, admissionDateTime, out minutes);

            // second step is replace the out parameters
            //var tuple = GetTime(admissionDateTime);
            // rename tuple to time because we get an time object now
            //var minutes = time.Minutes;
            #endregion

            var time = Time.Parse(admissionDateTime);

            // some more logic
            // ...
            if(time.Hours < 10)
            {

            }

            Console.WriteLine($"{time.Hours} - {time.Minutes}");
        }

        public void UpdateAdmitGuest(int admissionID, string name, string admissionDateTime)
        {
            // some logic here
            // ...

            #region refactoring the code
            #region Get rid of this duplicated code and replace it with a method
            //int time;
            //int hours = 0;
            //int minutes = 0;

            //if(!string.IsNullOrWhiteSpace(admissionDateTime))
            //{
            //    if(int.TryParse(admissionDateTime.Replace(":", ""), out time))
            //    {
            //        hours = time / 100;
            //        minutes = time % 100;
            //    }
            //    else
            //    {
            //        throw new ArgumentException("admissionDateTime");
            //    }
            //}
            //else
            //    throw new ArgumentException("admissionDateTime");

            #endregion

            //GetTime1(out hours, admissionDateTime, out minutes);
            //int hours;
            //int minutes;

            // second step is replace the out parameters
            //var tuple = GetTime(admissionDateTime);
            // rename tuple to time because we get an time object now
            //var minutes = time.Minutes;
            #endregion

            var time = Time.Parse(admissionDateTime);

            // some more logic
            // ...
            if(time.Hours < 10)
            {

            }

            Console.WriteLine($"ID={admissionID}, {time.Hours} - {time.Minutes}");

        }

        // step 1
        private static void GetTime1(out int hours, string admissionDateTime, out int minutes)
        {
            int time;

            if(!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if(int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }
            }
            else
                throw new ArgumentException("admissionDateTime");
        }

        // step 2
        private Tuple<int, int> GetTime2(string admissionDateTime)
        {
            int time;
            int hours;
            int minutes;
            if(!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if(int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }
            }
            else
                throw new ArgumentException("admissionDateTime");

            return Tuple.Create(hours, minutes);
        }

        // step 3 change signature
        private static Time GetTime3(string admissionDateTime)
        {
            int time;
            int hours;
            int minutes;
            if(!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if(int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }
            }
            else
                throw new ArgumentException("admissionDateTime");

            return new Time(hours, minutes);
        }

        // step 4 move the GetTime method to the Time class
        //private static Time GetTime(string admissionDateTime)
        //{
        //    int time;
        //    int hours;
        //    int minutes;
        //    if(!string.IsNullOrWhiteSpace(admissionDateTime))
        //    {
        //        if(int.TryParse(admissionDateTime.Replace(":", ""), out time))
        //        {
        //            hours = time / 100;
        //            minutes = time % 100;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("admissionDateTime");
        //        }
        //    }
        //    else
        //        throw new ArgumentException("admissionDateTime");

        //    return new Time(hours, minutes);
        //}

    }
}
