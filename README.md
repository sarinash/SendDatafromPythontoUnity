# SenddatafromPythontoUnity

## Overview
___
![Example](https://user-images.githubusercontent.com/60202851/101588594-16c55280-3a2a-11eb-9c57-6cfb58b6ba4e.jpg)
___

### Usage:

- run the python code 
- you will send a json file to a local server
- create a button in unity
- link the c# code to the button and call back the GetData function
### Contumized Usage:
Sometimes you need to use python Libraries in a unity project, so here is a simple way to link them.
- Make a local server using flask (You can make a non-local server as well)
- Make your wanted python function
- put the function in the flask function
- Send data to the server as a json format per epoch
- recived the json file in unity through acall-back function
