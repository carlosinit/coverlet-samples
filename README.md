# coverlet-samples

This code is a sample allowing anyone to run test coverage and static analysis based on sonar.

A few steps to use it:

 1. Start docker 
 2. Edit the docker-compose.yml to put a path for volumes that makes sense for you
 3. `docker-compose up` 
 4. Browse http://localhost:9000 
 5. Change admin password 
 6. Create a project named CoverletSamples
 7. Generate the token and add it in the file build.cake "sonarToken"
 8. Run the build.cake
 9. Enjoy
