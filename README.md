# De-Task
1. Azure Environment https://delinian-api.azurewebsites.net/ ![image](https://github.com/vilkan32/De-Task/assets/42586617/3b97a0b3-4609-4bf0-bc83-3c9424507939)
2. Azure Database ![image](https://github.com/vilkan32/De-Task/assets/42586617/629d5035-623c-4a0b-9d16-eb37cb3b1148)
3. Docker hub ![image](https://github.com/vilkan32/De-Task/assets/42586617/5b3ff5eb-a318-4575-8218-b5ac64ba3bfb)
4. Source control - https://github.com/vilkan32/De-Task
5. Github branch rules - ![image](https://github.com/vilkan32/De-Task/assets/42586617/4321d865-ffdb-4de7-92e8-77e44b33bad2)
6. Database View VS - ![image](https://github.com/vilkan32/De-Task/assets/42586617/56cee8e5-ad27-465a-81cf-257412f22d1f)


Steps:
by creating the master_delinian-api.yml file generated from azure deployment center and edited for my purposes I was able to debug and deploy and build the web app on linux docker container. I have created the web app in VS as docker for linux app.
Pipeline gets triggered by PR merge there are 3 steps for test build and deploy if test fails it does not get deployed
there is a docker-compose.yml
