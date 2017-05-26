C# Generic Windows Application : GwinApp
----------------------------------------

GwinApp is rapid C# winform framework to create Windows Application with minimum effort.

Used Library and Framework
--------------------------
- EF6
- Metroframework

Principle of operation
----------------------
It use attributes to configure Entity-Manager Interface.


Exemple to Create Group Manager in GwinApp
------------------------------------------

    [GwinEntity(Localizable =true,DisplayMember = "Name")]
    [Menu(Group= "Trainee")]
    public class Group : BaseEntity
    {
        [EntryForm]
        [Filter]
        [DataGrid]
        public string Name { set; get; }
        
        [EntryForm]
        [Filter]
        [DataGrid]
        public string Description { set; get; }
    }
   
How to Install Gwin App in Visual Studio 2017
---------------------------------------------
https://youtu.be/_VqAs2ANfBM
    
License
-------

The MIT License (MIT)

Copyright (c) 2011 Sven Walter, http://github.com/viperneo

Copyright (c) 2013 Dennis Magno, http://github.com/dennismagno

Copyright (c) 2015 iMotoGames, http://github.com/imotogames

Permission is hereby granted, free of charge, to any person obtaining a copy of 
this software and associated documentation files (the "Software"), to deal in the 
Software without restriction, including without limitation the rights to use, copy, 
modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
and to permit persons to whom the Software is furnished to do so, subject to the 
following conditions:

The above copyright notice and this permission notice shall be included in 
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

