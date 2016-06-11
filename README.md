# RozWorld-API
API for working between the RozWorld server, client and mods for the two.

**This is a work in progress, I'm still developing the project here, consider it done whenever there is a proper 'dev' branch at least, the 'pre-dev' branch is the incomplete work in progress**

## Aims here
This is an API designed to allow single-build mods to work on both servers and clients.

For developing mods/plugins, the server/client implementations will look for classes in libraries you make that it knows of to use (for instance, it will autoload plugins that implement the IPlugin interface).

## Building this ting
As simple as downloading everything, opening the .sln as you normally would and just hit F6.