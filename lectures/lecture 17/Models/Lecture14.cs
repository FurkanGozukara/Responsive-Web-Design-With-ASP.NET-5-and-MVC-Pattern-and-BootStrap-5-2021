using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lecture_9.Models
{


    public class Lecture14
    {
        public List<toDoItem> lstAllToDoItems = new List<toDoItem>();

        public toDoItem newToDoTask { get; set; }
        public Lecture14()
        {
            newToDoTask = new toDoItem();
        }
    }

    public class toDoItem : TblToDoList
    {
        [Required]
        [MinLength(2, ErrorMessage = "Title must contain at least two characters!")]
        [MaxLength(200, ErrorMessage = "Title must contain a maximum of 200 characters!")]
        [Display(Name = "Enter Task Description")]
        public new string Title { get; set; }

        public toDoItem(TblToDoList myList)
        {
            this.Title = myList.Title;
            this.Id = myList.Id;
            this.IsDone = myList.IsDone;
            this.AddDate = myList.AddDate;
        }

        public toDoItem()
        {

        }

        public void fixTitle()
        {
            base.Title = this.Title;
        }
    }


}
