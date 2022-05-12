using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("tbl_story", Schema = "dbo")]

    public class StoryEntity : BaseEntitiy
    {
        [Column(TypeName = "int")]
        [ForeignKey("TopicEntity"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TopicId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PhotoUrl { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string AwardName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string AwardIconUrl { get; set; }
    }
}
