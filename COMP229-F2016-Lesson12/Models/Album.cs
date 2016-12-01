namespace COMP229_F2016_Lesson12.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Album
    {
        public Album()
        {
        }

        /// <summary>
        /// This constructor takes one argument title which sets the Title property to its value
        /// </summary>
        /// <param name="title"></param>
        public Album(String title)
        {
            this.Title = title;
        }

        public int AlbumId { get; set; }

        // Genre foreign key
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        // Artist foreign key
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        [Required]
        [StringLength(160)]
        [Display(Name = "Album Title")]
        public string Title { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [StringLength(1024)]
        [Display(Name = "Album Art URL")]
        [ScaffoldColumn(false)]
        public string AlbumArtUrl { get; set; }
    }
}
