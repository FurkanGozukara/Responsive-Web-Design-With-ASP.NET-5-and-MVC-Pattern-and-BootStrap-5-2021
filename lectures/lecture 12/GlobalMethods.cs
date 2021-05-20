using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_9.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using static lecture_9.Controllers.GlobalController;

namespace lecture_9
{
    public class MyOptions
    {
        public MyOptions() {
            Title = "Our Great Options Title";
        }

        public string Title { get; set; }
    }

    public static class TempDataExtensions
    {
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = JsonConvert.SerializeObject(value);
        }

        public static T Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            object o;
            tempData.TryGetValue(key, out o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }
    }

    public static class GlobalMethods
    {
        public static void logErrors(myStatusCodeHandling _statusProblem = null, object _exceptionHandlerPathFeature = null, HttpResponse _response = null)
        {
            using (MVCContext myContext = new MVCContext())
            {
                TblErrorLogs errorObj = new TblErrorLogs();
                if (_exceptionHandlerPathFeature != null)
                {
                    var exceptionHandlerPathFeature = (IExceptionHandlerPathFeature)_exceptionHandlerPathFeature;
                    errorObj.ExMsg = exceptionHandlerPathFeature.Error?.Message;
                    errorObj.ExStackTrace = exceptionHandlerPathFeature.Error?.StackTrace;
                    errorObj.ExPath = exceptionHandlerPathFeature?.Path;
                    errorObj.InnerExMsg = exceptionHandlerPathFeature.Error?.InnerException?.Message;
                    errorObj.InnerExStackTrace = exceptionHandlerPathFeature.Error?.InnerException?.StackTrace;
                }

                if (_response != null)
                {
                    errorObj.HttpErrorStatusCode = (short)_response?.StatusCode;
                    errorObj.HttpErrorCookies = _response?.Cookies.ToString();
                    errorObj.HttpErrorPath = _response?.HttpContext?.Request?.Path;
                    errorObj.HttpErrorRequest = _response?.HttpContext?.Request?.ToString();
                }

                if (_statusProblem != null)
                {
                    errorObj.HttpErrorStatusCode = (short)_statusProblem.irStatusCode;
                    errorObj.HttpErrorPath = _statusProblem.OriginalPath;
                    errorObj.HttpErrorRequest = _statusProblem.OriginalPathBase;
                    errorObj.HttpErrorCookies = _statusProblem.OriginalQueryString;
                }

                myContext.TblErrorLogs.Add(errorObj);
                myContext.SaveChanges();
            }
        }

        public static Lecture9 refreshModel_v9(int _UserId)
        {
            Lecture9 myModel = new Lecture9
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
                    myModel.srEmailRepeated = vrUser.Email;
                    if (vrUser.BirthDay != null)
                        myModel.dtBirthDay = Convert.ToDateTime(vrUser.BirthDay);
                }
            }

            return myModel;
        }

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
