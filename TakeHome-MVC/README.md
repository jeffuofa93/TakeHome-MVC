# TakeHome C# MVC Overview 

## Future Implementation Improvements

- Modifying _Layout.cshtml with inline style as apposed to site.css to change navbar color
  - I was unable to get the css file to accurately update the navbar color from white to black 
  - My solution was instead to use inline style in _Layout.cshtml to make the navbar black 
  - This is my first time using C#, but in other platforms I am familiar with using inline styles with bootstrap is generally frowned upon

- Use of DataTable to display List of customerOrders as an html table
  - I am unsure of what would be the correct approach to this problem
  - I attempted several different approaches including functionally mapping the values inside the view but felt my approach more closely followed
  the MVC architecture

## Final Thoughts

- Overall it was exciting to get to learn about C# especially in reference to Java which I am more familiar with. I am unsure of which files from the
project are necessary for your evaluation so I have included all, but the only files with significant changes are:
  - Models: CustomerOrderModel.cs, CustomerViewModel.cs
  - Controllers: CustomerController.cs
  - Views: Customer: Orders.cshtml
  - Views: Shared: _Layout.cshtml
- Hope to hear from you soon! 