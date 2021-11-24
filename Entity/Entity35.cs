using System;


namespace ExportGarPostgreSQLCore
{
    
    public class FromHouseXML : IDisposable
    {
        ///// <summary>
        ///// objectId в xml дома
        ///// </summary>
        public void Dispose() { }
        public long id { get; set; }

        public long objectid { get; set; }

        public Guid objectguid { get; set; }

        public long changeid { get; set; }
        
        public string housenum { get; set; }
        
        public string addnum1 { get; set; }
        
        public string addnum2 { get; set; }
        
        public int? housetype { get; set; }
        
        public int? addtype1 { get; set; }
        
        public int? addtype2 { get; set; }
        
        public int? opertypeid { get; set; }
        
        public long previd { get; set; }
        
       
        
        public long nextid { get; set; }
        
       
        
        public System.DateTime updatedate { get; set; }
        
        public System.DateTime startdate { get; set; }
        
        public System.DateTime enddate { get; set; }
        
        public int isactual { get; set; }
        
        public int isactive { get; set; }

    }

    public class FromADDRXML:IDisposable
    {
        public void Dispose(){ }
        /// <summary>
        /// objectId в xml улицы
        /// </summary>
        public long id{ get; set; }
        
        public long objectid { get; set; }
        
        public Guid objectguid { get; set; }
        
        public long changeid { get; set; }
        
        public string name { get; set; }
        
        public string typename { get; set; }
        
        public string level { get; set; }
        
        public int opertypeid { get; set; }
        
        public long previd { get; set; }
        
     
        
        public long nextid { get; set; }
      
        
       
        public System.DateTime updatedate { get; set; }
       
        public System.DateTime startdate { get; set; }
        
        public System.DateTime enddate { get; set; }
        
        public int isactual { get; set; }
        
        public int  isactive { get; set; }

        
    }

    public class FromADMINHIERXML : IDisposable
    {
        /// <summary>
        /// parentId в xml администрации обозначающий улицу
        /// </summary>
        public void Dispose() { }
        public long ID { get; set; }

        public long objectid { get; set; }

        public long parentobjid { get; set; }

      
        
        public long changeid { get; set; }
        
        public string regioncode { get; set; }
        
        public string areacode { get; set; }
        
        public string citycode { get; set; }
        
        public string placecode { get; set; }
        
        public string plancode { get; set; }
        
        public string streetcode { get; set; }
        
        public long previd { get; set; }
        
       
        
        public long nextid { get; set; }
        
       

        public System.DateTime updatedate { get; set; }

        public System.DateTime startdate { get; set; }

        public System.DateTime enddate { get; set; }

        public int isactive { get; set; }


    }

    //public class FromPARAMTYPESXML
    //{
    //    public long ID;

    //    public string name;

    //    public string code;

    //    public string desc;

    //    public System.DateTime updatedate;

    //    public System.DateTime startdate;

    //    public System.DateTime enddate;

    //    public bool isactive;

    //}
}
