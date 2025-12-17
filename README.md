
### *** ###
This simple project is a showcase for:
- React based Admin 'Dashboard' (racing bars, line chart)
- React native mobile application with Cordova (Google Maps API, authentication)
- Simple ticketing system
- single portal application

For the backend, I used the default Serenity demo, which is a straightforward TypeScript/.NET Core framework with useful demos.
You can customize the Dockerfile/docker-compose.yml to use the admin panel in dockerized environments as well.

### 
If you encounter an exception while running PostgreSQL migrations like I did, consider checking these steps:
1- Enable identity insert for tables
2- Change the UnitPrice column in OrderDetails from money to numeric.
