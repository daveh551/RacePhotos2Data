using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoServer.Domain
{
    public class Photo : GuidEntity
    {
	    public const string DEFAULTSTATION = "FinishLine";

	    public virtual int?  RaceId { get; set; }
	    public Race Race { get; set; }
	    public virtual string Station { get; set; }
	    public virtual string Card { get; set; }
	    public virtual int? Sequence { get; set; }
        public virtual string Path { get; set; }
	    public virtual DateTime? TimeStamp { get; set; }
	    public virtual int? Hres { get; set; }
	    public virtual int? Vres { get; set; }
	    public Guid? BasedOn { get; set; }
	    public long FileSize { get; set; }
	    public DateTime? LastAccessed { get; set; }
	    public string Server { get; set; }
        public virtual string FStop { get; set; }
        public virtual string ShutterSpeed { get; set; }
        public virtual short? ISOSpeed { get; set; }
        public virtual short? FocalLength { get; set; }
        public virtual string PhotographerInitials { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }


	    public Photo()
	    {
		    
	    }

    }
}
