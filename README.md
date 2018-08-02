# suave-dotnet-heroku


Set the following buildpacks; the 'heroku-buildpack-apt' buildpack is needed to install the library libunwind8 which is required

``
heroku buildpacks:set https://github.com/ademar/dotnetcore-buildpack.git
``

``
heroku buildpacks:add --index 1 https://github.com/heroku/heroku-buildpack-apt.git
``
