using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Security2.Models;

namespace Security2.Data
{
    public class Security2Context : IdentityDbContext<ApplicationUser>
    {
        public Security2Context(DbContextOptions<Security2Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }

        public DbSet<SpeakerQuery> Speaker { get; set; }
        public DbSet<SpeakerStatusModel> SpeakerStatusModel { get; set; }
        public DbSet<SpeakerStatusLookupModel> SpeakerStatusLookupModel { get; set; }
        public DbSet<SpeakerTypeOfAgreementLookupModel> SpeakerTypeOfAgreementLookupModel { get; set; }
        public DbSet<SpeakerAddressTypeLookupModel> SpeakerAddressTypeLookupModel { get; set; }
        public DbSet<SpeakerPractitionerTypeLookupModel> SpeakerPractitionerTypeLookupModel { get; set; }
        public DbSet<SpeakerPracticeSpecialtyLookupModel> SpeakerPracticeSpecialtyLookupModel { get; set; }
        public DbSet<TerritoryLookupModel> TerritoryLookupModel { get; set; }
        public DbSet<SpeakerCategoriesLookupModel> SpeakerCategoriesLookupModel { get; set; }
        public DbSet<SpeakerContractDurationLookupModel> SpeakerContractDurationLookupModel { get; set; }
    }
}
