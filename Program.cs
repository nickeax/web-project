// See https://aka.ms/new-console-template for more information
using System;
using web_project;
using web_project.Modules.Logging;

var pm = new ProjectManager(args, new InfoFeedback(), new WarningFeedback(), new ErrorFeedback());

System.Console.WriteLine("Attempting to Process, please wait...");
pm.CreateDirectories();
pm.ErrorLog.Display();
pm.InfoLog.Display();