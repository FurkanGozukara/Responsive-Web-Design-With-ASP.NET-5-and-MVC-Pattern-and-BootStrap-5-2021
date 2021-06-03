using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lecture_9.Models;

namespace lecture_9.Controllers
{
    [Route("/", Name = "/")]
    public class Lecture14Controller : Controller
    {
        public IActionResult Index()
        {
            Lecture14 myModel = initModel();
            return View("Index", myModel);
        }

        [Route("/lecture14/ajax")]
        public IActionResult AjaxListing()
        {
            Lecture14 myModel = initModel();
            return PartialView("_ListTaskItems", myModel);
        }

        [Route("/lecture14/ajaxindex")]
        public IActionResult AjaxIndex()
        {
            Lecture14 myModel = new Lecture14();
            return View("AjaxIndex", myModel);
        }

        private Lecture14 initModel()
        {
            Lecture14 myModel = new Lecture14();

            using (MVCContext myContext = new MVCContext())
            {
                myModel.lstAllToDoItems = myContext.TblToDoList.ToList().Select(pr => pr.convert_ToDo()).ToList();
            }

            return myModel;
        }

        [HttpPost]
        [Route("/lecture14/UpdateInsert" , Name ="UpdateInsertNewToDoTask")]
        public IActionResult UpdateInsert(Lecture14 myModel)
        {
            System.Threading.Thread.Sleep(3333);
            if (!ModelState.IsValid)
                return Content("some unexpected error occured. please try again");

            myModel.newToDoTask.fixTitle();

            using (MVCContext myContext = new MVCContext())
            {
                TblToDoList updatedItem = myModel.newToDoTask as TblToDoList;
                GlobalMethods.UpdateAddNewTask(updatedItem);
            }

            return View("Index", myModel);
        }


        [HttpPost]
        [Route("/lecture14/UpdateInsert2", Name = "UpdateInsertNewToDoTask2")]
        public IActionResult UpdateInsert2(Lecture14 myModel)
        {
            if (!ModelState.IsValid)
                return Content("some unexpected error occured. please try again");

            myModel.newToDoTask.fixTitle();

            using (MVCContext myContext = new MVCContext())
            {
                TblToDoList updatedItem = myModel.newToDoTask as TblToDoList;
                GlobalMethods.UpdateAddNewTask2(updatedItem);
            }

            return View("Index", myModel);
        }


        [Route("/lecture14/IsDone/{TaskId}", Name = "ChangeIsDone")]
        public IActionResult changeTaskStatus(int TaskId)
        {
            using (MVCContext myContext = new MVCContext())
            {
                var vrTaskItem = myContext.TblToDoList.Find(TaskId);

                if (vrTaskItem != null)
                {
                    vrTaskItem.IsDone = !vrTaskItem.IsDone;
                    myContext.SaveChanges(); 
                }              
            }
            return RedirectToAction("Index");
        }

        [Route("/lecture14/EditTask/{TaskId}", Name = "EditTask")]
        public IActionResult EditTask(int TaskId)
        {
            Lecture14 myModel = new Lecture14();
       
            using (MVCContext myContext = new MVCContext())
            {
                var vrTaskItem = myContext.TblToDoList.Find(TaskId);

                if (vrTaskItem != null)
                {
                    myModel.newToDoTask = new toDoItem(vrTaskItem);
                }
            }

            return View("Index", myModel);
        }

        [Route("/lecture14/Delete/{TaskId}", Name = "DeleteTask")]
        public IActionResult DeleteTask(int TaskId)
        {
            Lecture14 myModel = new Lecture14();

            using (MVCContext myContext = new MVCContext())
            {
                var vrTaskItem = myContext.TblToDoList.Find(TaskId);
              
                if (vrTaskItem != null)
                {
                    myContext.TblToDoList.Remove(vrTaskItem);
                    myContext.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
