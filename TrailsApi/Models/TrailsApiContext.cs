using Microsoft.EntityFrameworkCore;

namespace TrailsApi.Models
{
  public class TrailsApiContext : DbContext
  {
    public TrailsApiContext(DbContextOptions<TrailsApiContext> options) : base(options)
    {

    }

    public DbSet<TrailMarker> TrailMarkers { get; set; }
    // public DbSet<GeoCoordinate> GeoCoordinates { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<TrailMarker>()
      .HasData(
        new TrailMarker { TrailMarkerId = 1, Name = "Powell Butte Trailhead", Longitude = -122.496992, Latitude = 45.490696, isTrailhead = true, isLandmark = false, Description = "dirt trail off of Springwater" },
        new TrailMarker { TrailMarkerId = 2, Name = "Oaks Bottom Frog Pond", Longitude = -122.649976, Latitude = 45.485812, isTrailhead = false, isLandmark = true, Description = "pond that seasonally has many frogs and frogs sounds" },
        new TrailMarker { TrailMarkerId = 3, Name = "Sauvies Island Lighthouse", Longitude = -122.78835, Latitude = 45.84858, isTrailhead = false, isLandmark = true, Description = "when you arrive to the lighthouse you have reached end of the trail! Enjoy!" }
      );
    }
  }
}