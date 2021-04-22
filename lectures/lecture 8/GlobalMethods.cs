using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_6.Models;

namespace lecture_6
{
    public static class GlobalMethods
    {

        public static Lecture8 refreshModel_v8(int _UserId)
        {
            Lecture8 myModel = new Lecture8
            {
                irUserId = _UserId
            };

            using (MVCContext myContext = new MVCContext())
            {
                var vrUser = myContext.TblUsers.Where(pr => pr.UserId == _UserId).FirstOrDefault();
                if (vrUser != null)
                {
                    myModel.srFirstName = vrUser.FirstName;
                    myModel.srLastName = vrUser.LastName;
                    myModel.srEmail = vrUser.Email;
                    if (vrUser.BirthDay != null)
                        myModel.dtBirthDay = Convert.ToDateTime(vrUser.BirthDay);
                }
            }

            return myModel;
        }


        public static Lecture7 refreshModel(int _UserId)
        {
            Lecture7 myModel = new Lecture7
            {
                srFirstName = "default first name",
                srLastName = "default last name"
            };

            using (MVCContext myContext = new MVCContext())
            {
                var vrUser = myContext.TblUsers.Where(pr => pr.UserId == _UserId).FirstOrDefault();
                if (vrUser != null)
                {
                    myModel.srFirstName = vrUser.FirstName;
                    myModel.srLastName = vrUser.LastName;
                }
            }

            return myModel;
        }

        public static void updateUser(TblUsers myUser)
        {
            using (MVCContext myContext = new MVCContext())
            {
                var vrUser = myContext.TblUsers.Where(pr => pr.UserId == myUser.UserId).FirstOrDefault();
                if (vrUser != null)
                {
                    vrUser.FirstName = myUser.FirstName;
                    vrUser.LastName = myUser.LastName;
                    vrUser.Email = myUser.Email;
                    vrUser.BirthDay = myUser.BirthDay;
                }
                else
                    myContext.Add(myUser);

                myContext.SaveChanges();
            }
        }
    }
}
