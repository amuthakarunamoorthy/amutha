***********************************************
 MvcSearch10 v1.2.02 (8.24.17)

 Copyright 2017 Better Software Solutions,LLC.
 All rights reserved.
***********************************************

--------------------------

 NuGet package Quickstart

--------------------------


	Installation/Configuration
	--------------------------

	1. Install NuGet package.

	2. Shared/_Layout: 
		add @RenderSection("Styles", required: false) before </head>.

	3. For configuration see web.config mvcSearch_* appsettings.  
	   At a minimum the following appsettings MUST BE SET:
		
		mvcSearch_VirtualRoot - indicates website root.

        Note: If you are using the Local IIS Web Server you must set the port number after localhost, e.g. localhost:50231.
        
		
	Dependencies
	------------
	1. ASP.NET MVC
	2. Razor view engine
	3. JQuery v1.7.1+
	4. JQuery.ui.autocomplete v1.9.2+ for search partial view

	
	Running
	-------

	Request /MvcSearch/Search and enter any search term.  The first time a search is run the catalog is be created and cached. Thereafter, only a search is executed.  

	To modify catalog contents, tweak the following web.config appsettings:

		mvcSearch_FileFilter - specifies file types to include in catalog.

		mvcSearch_ignoreFiles - specifies file(s) to exclude from catalog.

		mvcSearch_ignoreDirs - specifies directories to exclude from catalog.

	
 	Re-building Catalog
	-------------------

	To rebuild the catalog, delete or rename it and run a search.  The catalog is created at the website root.  See the web.config mvcSearch_CatalogFilename appsetting for the name of the catalog.


----------------------------

 Installation information 

----------------------------

 http://bssdev.biz/Docs/MvcSearch/Installation


------------------------

 For usage information

------------------------

 http://bssdev.biz/Docs/MvcSearch/Overview




