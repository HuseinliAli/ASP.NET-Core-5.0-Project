# ASP.NET-Core-5.0-Project
## Day: 1

<br/>
        1. **Create** ASP.NET MVC project <br/>
        2. **Add** BusinessLayer, CoreLayer, DataAccsessLayer, EntityLayer`s classes to Project <br/>
        3. **Create** New Folders(Abstracts, Concrete, Context, Repositories) in **DataAccessLayer** <br/>
        4. **Add** New Entities(About, Blog, Category, Comment, Contact, Writer) in **Concrete folder** in **EntityLayer** <br/>
        5. **Install** Four Entity Packages (EF CORE, EF CORE.DESIGN, EF CORE.SQLSERVER, EF CORE.TOOLS) in **DataAccesLayer** <br/>
        6. **Update** Key keyword to **entities** in **EntityLayer** <br/>
        7. **Write** Onconfiguring method in Context class in **Concrete folder** in **DataAccsessLayer** <br />
<br />

## Day: 2
<br />
        1. **Add** references to BusinessLayer(DataAccessLayer, EntityLayer), DataAccessLayer(EntityLayer) <br />
        2. **Add** releation to Blog Entity(Category, Comment), Comment Entity(Blog) <br />
        3. **Create** migration target project DataAccsessLayer add-migration mig_name update-database <br />
        4. **Install** Four Entity Packages (EF CORE, EF CORE.DESIGN, EF CORE.SQLSERVER, EF CORE.TOOLS) in **ASP.NET Core 5.0 Project** <br/>
        5. Create IGenericDal interface in DataAccsessLayer, GenericRepository in Repositories <br/>
       
## Day: 3
<br/>
        1.Create Service and Manager interfaces in BusinessLayer <br/>
        2.Create EntityFrameworkRepository folder and fill this with EFClassNameRepositories <br/>
        3.List Category classes in browser <br/>
