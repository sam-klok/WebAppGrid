It's a demo how to work with popular GridMvc component.
It can display boolean values as checkboxes.
I'm using browser LocalStorage to persist user checked values on different pages.

Use URL: 
http://localhost:50832
or 
http://localhost:50832/Home/Index

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

7.Open app at the URL:
http://localhost:50830/

8. Google Chrome redirecting localhost to https.
Scroll all the way down to the section below and enter “localhost”, then click “Delete”.
Steps:
Go to Chrome or Edge browser and type following statement in address bar:
chrome://net-internals/#hsts
edge://net-internals/#hsts
DELETE the localhost domain security polices using, by removing "localhost".
https://stackoverflow.com/questions/25277457/google-chrome-redirecting-localhost-to-https
https://stackoverflow.com/questions/63825407/microsoft-edge-redirects-http-localhost-to-https-localhost

9. Apparently there is issue filterning date fields, if they contain time.
Date filter is not working in GridMvc
https://stackoverflow.com/questions/33658193/date-filter-is-not-working-in-gridmvc

Possible solution is to remove time part from the DateTime
Example: use DateTime.Now.Date
https://stackoverflow.com/questions/6121271/how-to-remove-time-portion-of-date-in-c-sharp-in-datetime-object-only


10. Partial View rendering could be tricky too
use URL:
http://localhost:50832/Home/DynamicLoad


11. Email attibutes
https://stackoverflow.com/questions/16712043/email-address-validation-using-asp-net-mvc-data-type-attributes

12. Link button style
https://stackoverflow.com/questions/596444/html-actionlink-as-a-button-or-an-image-not-a-link
https://www.w3schools.com/bootstrap/bootstrap_grid_medium.asp

13. Multiselet Dropdown - JQuery widget
https://ehynds.github.io/jquery-ui-multiselect-widget/
https://github.com/ehynds/jquery-ui-multiselect-widget
I didnt' use command: npm i jquery-ui-multiselect-widget But added folder manually.
See screen shot 08.

13.2 To display comma separated list in the header (see screen shot 09)
https://stackoverflow.com/questions/29058753/jquery-ui-multi-select-shows-comma-separated-texts
13.3 Issue with width of this component
https://stackoverflow.com/questions/41017788/unable-to-set-the-width-of-jquery-multi-select/78374927#78374927