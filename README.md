# Information for employees
## First steps
If the fair begins, simply press the Start App button on the login screen.
Ideally also start the webcam app, so that the user can take a picture.
## Taking a picture
If a user wonders, how to make a picture, simply press the 
"Take Picture" button.
> **Note**: A user doesn't have to take a picture.
## Editing user 
If a user wants to edit his data, stop the application and restart it.
Then press the "Edit User" button. This will open a new window, where
all local data is displayed. If all changes are made, press enter. 
Else the changes will be discarded. 

Note: If the user has entered wrong address data of a new company, 
remove the user and create a new one with the correct company address.
> **IMPORTANT**: Do not let the user edit the data by himself! We are
already hiding sensitive columns but we want to avoid syncing wrong 
data. There is also no validation of the data, so be aware of changing
the data, especially when it comes to the company related data.
## Syncing with backend
At the end of the fair, please close the WebcamApp, and restart it
to return to the LoginForm. Then enter your credentials and press the
"Sync" button. This will upload all the data to the backend.
> **Note**: We haven´t implemented a return button in the main app, 
to avoid that the user accidentally returns to the login screen

# Information for data protection officers
## Authorization
We are using JWT so that only authorized administrators can access and  
manipulate the data.
## Secure connection
We are using HTTPS to ensure that the data is encrypted during the 
transfer.
