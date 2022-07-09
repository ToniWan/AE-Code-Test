# AE-Code-Test|This solution is response to https://github.com/angloeastern/backend-coding-task
## This solution is using NetCore 6. There are 4 APIs provided in this solution in total.
### Debug - There is two way to debug
1. Debug with docker - Docker Desktop is required. Docker container are containing two services [ae-code-test-api] and [db]
2. Debug without docker - MSSQL server is required. Please update connection string in appsetting.json

### How to start the container
You could start with below command and port 80(api service) and port 1440(db service) is needed
```
docker-compose up docker-compose.yml
```

### APIs Detail:
#### Ships - It is used for add ship, view full ship list and update velocity in Km per hour of a ship


1. Post - Add ships to the system

>Sample Request:
>
>```
>[
>  {
>    "name": "Ship Name 1",
>    "longitude": 0,
>    "latitude": 0,
>    "velocityKmh": 0
>  }
> , {
>    "name": "Ship Name 2",
>    "longitude": 0,
>    "latitude": 0,
>    "velocityKmh": 0
>  }
>]
>```
>
>System will return status code 200 if success.

2. Get - view all ships in the system

>Sample Response:
>
>```
>[
>  {
>    "shipId": 1,
>    "name": "string",
>    "longitude": 0,
>    "latitude": 0,
>    "velocityKmh": 0,
>    "createDate": "2022-07-09T14:36:15.6750289",
>    "modifyDate": "2022-07-09T14:36:15.675025"
>  },
>  {
>    "shipId": 2,
>    "name": "string",
>    "longitude": 0,
>    "latitude": 0,
>    "velocityKmh": 0,
>    "createDate": "2022-07-09T14:45:55.747862",
>    "modifyDate": "2022-07-09T14:45:55.7478598"
>  }
>]
>```

3. Put -  Update velocity of a ship in Km per hour

>Sample Request:
>
>```
>{
>  "shipId": 1,
>  "velocityKmh": 0
>}
>```

>System will return status code 200 if success.

### ShipToPort - View the closest port of a ship with estimated arrival time to the port
1. Post - View the closest port of a ship with estimated arrival time to the port

>Sample Request:
>
>Just post the shipId of target ship.

>Sample Response:
>
>```
>{
>  "shipDetail": {
>    "shipId": 1,
>    "name": "Ship 1",
>    "longitude": 17,
>    "latitude": 22,
>    "velocityKmh": 100,
>    "createDate": "2022-07-09T15:12:12.1982409",
>    "modifyDate": "2022-07-09T15:12:12.1982355"
>  },
>  "portDetail": {
>    "portId": 29,
>    "name": "Port29",
>    "longitude": 29.387282054795918,
>    "latitude": 33.509224000098044,
>    "createDate": "2022-07-08T22:43:57.8971443",
>    "modifyDate": "2022-07-08T22:43:57.8971443"
>  },
>  "timeToPort": "2022-07-10T08:51:54.908912+00:00",
>  "remarks": ""
>}
>```