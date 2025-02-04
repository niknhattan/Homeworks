﻿var Student = Class.create({
    init: function (fname, lname, marks) {
        this.fname = fname;
        this.lname = lname
        this.marks = marks;
    },
    fullname: function () {
        return this.fname + " " + this.lname;
    }
});

var Mark = Class.create({
    init: function (subject, score) {
        this.subject = subject;
        this.score = score;
    }
});

var people = [
    new Student("Doncho", "Minkov", [new Mark("Math", 4), new Mark("JavaScript", 6)]),
    new Student("Nikolay", "Kostov", [new Mark("MVC", 6), new Mark("JavaScript", 5)]),
    new Student("Ivaylo", "Kendov", [new Mark("OOP", 4), new Mark("C#", 6)]),
    new Student("Svetlin", "Nakov", [new Mark("Unit Testing", 5), new Mark("WPF", 6)]),
    new Student("Asya", "Georgieva", [new Mark("Automation Testing", 6), new Mark("Manual Testing", 4)]),
    new Student("Georgi", "Georgiev")
];

var personTemplate = Mustache.compile(document.getElementById("person-template").innerHTML);
var TableView = controls.getTableView(people,2, 6);

var TableViewHtml = TableView.render(personTemplate);

document.getElementById("content").innerHTML = TableViewHtml;