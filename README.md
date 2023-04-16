# Nightclub-schoolproject
A fun school project where I was given a set of RFID chips, and could basically create anything I wanted using MySQL and VS. The goal of the project was to create a datalogging app connected to a database, and logging data into this database using the app. Everything was created from scratch.


//HOW IT WORKS

Short: The program is a program meant for a CEO of a chain of clubs to use to register new members to his membership scheme. After registering with their name,
nationality, sexuality (no care for privacy restrictions has been made in this project as it was never meant to be published), and the preferred membership plan
the members can then enter the clubs they choose to (virtually, duh). 

As a bit of extra learning for my own sake, I added the fact that only some members can enter the VIP club, and only members who are either bi or gay can enter the 
Berghain in Berlin. A bit of extra coding needed, to check the member ID and compare it to the database registration info. USPs...

Initially this project is meant to used with an RFID-scanner along with a few chips. These chips all have their unique RFID-tag, which I have hard-programmed
into the code to be recognised by the program. For testing purpose, these codes can be found in the class "ConvertIntToString" and you can simply copy one of these
codes to use as a replacement for actually scanning the chip itself when registering yourself as a member to one of the clubs, if you wish to test the code out.
