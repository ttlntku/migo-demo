using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("tbl_topic", Schema = "dbo")]
    public class TopicEntity : BaseEntitiy
    {
        [Column(TypeName = "varchar(50)")]
        public string TopicName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string TopicIcon { get; set; }
    }
}
