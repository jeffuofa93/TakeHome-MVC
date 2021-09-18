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

## Hosting on Azure 

- For some additional learning I hosted the project on Azure 
- The link is in the results section of the readme
- Challenges 
  - The main challenge I experienced was incorrectly setting the app OS to linux due to 
  my local operating system being linux
  - After using the azure diagnostic tool and googling the 503 get error I was experiencing I 
  saw a comment mentioning that it can be caused by an incorrect operating system which
  resolved my issue when I switched the app OS to windows. 

## Final Thoughts

- Overall it was exciting to get to learn about C# especially in reference to Java which I am more familiar with. I am unsure of which files from the
project are necessary for your evaluation so I have included all, but the only files with significant changes are:
  - Models: CustomerOrderModel.cs, CustomerViewModel.cs
  - Controllers: CustomerController.cs
  - Views: Customer: Orders.cshtml
  - Views: Shared: _Layout.cshtml

### Results

- Zip file attached to email 
- github repo: https://github.com/jeffuofa93/TakeHome-MVC
- azure hosted website: https://webapp-210918125153.azurewebsites.net/customer/orders
- Hope to hear from you soon! 