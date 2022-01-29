It's a demo how to work with popular GridMvc component.
It can display boolean values as checkboxes.
I'm using browser LocalStorage to persist user checked values on different pages.


This is .Net Framework 4.7.2 and Grid.Mvc 3.0.0

Sam Klok


Used tutorials, all of them just OK, but better than nothing:

1. How to Use MVC Grid in ASP.NET MVC | C# | Razor | Pagination | Sorting | Filtering
https://www.youtube.com/watch?v=d-NCcY-J9B8

2. Filtering was not working, and I was getting error 
"Uncaught ReferenceError: $ is not defined at gridmvc.js:9:1", 
which told me that jQuery is not loaded (see below). 

* Grid.Mvc
* Version: 3.0.0
* Requires: window.jQuery v1.3+

My answer is here: 
https://stackoverflow.com/questions/25894890/sorting-filtering-attributes-not-working-in-grid-mvc/70826011#70826011

3. Adding checkbox field:
https://www.codeproject.com/Questions/1017965/How-to-add-checkbox-in-MVC-grid-using-bootsrap

4. Adding checkbox bounded to object field:
https://stackoverflow.com/questions/25605471/how-to-get-checkbox-row-value-selected-in-grid-mvc

5. Maintain Grid MVC checkbox state from page to page in MVC Razor
https://stackoverflow.com/questions/26403701/maintain-grid-mvc-checkbox-state-from-page-to-page-in-mvc-razor

6. Maintain the value of checkbox in grid.mvc (so-so)
https://stackoverflow.com/questions/38619653/maintain-the-value-of-checkbox-in-grid-mvc