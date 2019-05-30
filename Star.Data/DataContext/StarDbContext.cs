using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Star.Data.Models
{
    public partial class StarDbContext : DbContext
    {
        public StarDbContext()
        {
        }

        public StarDbContext(DbContextOptions<StarDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthGroup> AuthGroup { get; set; }
        public virtual DbSet<AuthGroupPermissions> AuthGroupPermissions { get; set; }
        public virtual DbSet<AuthPermission> AuthPermission { get; set; }
        public virtual DbSet<AuthUser> AuthUser { get; set; }
        public virtual DbSet<AuthUserGroups> AuthUserGroups { get; set; }
        public virtual DbSet<AuthUserUserPermissions> AuthUserUserPermissions { get; set; }
        public virtual DbSet<DjangoAdminLog> DjangoAdminLog { get; set; }
        public virtual DbSet<DjangoContentType> DjangoContentType { get; set; }
        public virtual DbSet<DjangoMigrations> DjangoMigrations { get; set; }
        public virtual DbSet<DjangoSession> DjangoSession { get; set; }
        public virtual DbSet<StarDefaultskillleveldescription> StarDefaultskillleveldescription { get; set; }
        public virtual DbSet<StarEmployee> StarEmployee { get; set; }
        public virtual DbSet<StarEmployeeskill> StarEmployeeskill { get; set; }
        public virtual DbSet<StarExpertskill> StarExpertskill { get; set; }
        public virtual DbSet<StarGender> StarGender { get; set; }
        public virtual DbSet<StarGeneralskill> StarGeneralskill { get; set; }
        public virtual DbSet<StarOffice> StarOffice { get; set; }
        public virtual DbSet<StarRole> StarRole { get; set; }
        public virtual DbSet<StarSitetext> StarSitetext { get; set; }
        public virtual DbSet<StarTeam> StarTeam { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=!QAZxsw2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("auth_group");

                entity.HasIndex(e => e.Name)
                    .HasName("auth_group_name_a6ea08ec_like")
                    .ForNpgsqlHasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<AuthGroupPermissions>(entity =>
            {
                entity.ToTable("auth_group_permissions");

                entity.HasIndex(e => e.GroupId)
                    .HasName("auth_group_permissions_group_id_b120cbf9");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("auth_group_permissions_permission_id_84c5c92e");

                entity.HasIndex(e => new { e.GroupId, e.PermissionId })
                    .HasName("auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
            });

            modelBuilder.Entity<AuthPermission>(entity =>
            {
                entity.ToTable("auth_permission");

                entity.HasIndex(e => e.ContentTypeId)
                    .HasName("auth_permission_content_type_id_2f476e4b");

                entity.HasIndex(e => new { e.ContentTypeId, e.Codename })
                    .HasName("auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasColumnName("codename")
                    .HasMaxLength(100);

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.AuthPermission)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
            });

            modelBuilder.Entity<AuthUser>(entity =>
            {
                entity.ToTable("auth_user");

                entity.HasIndex(e => e.Username)
                    .HasName("auth_user_username_6821ab7c_like")
                    .ForNpgsqlHasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateJoined)
                    .HasColumnName("date_joined")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(254);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(30);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsStaff).HasColumnName("is_staff");

                entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasMaxLength(150);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(128);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AuthUserGroups>(entity =>
            {
                entity.ToTable("auth_user_groups");

                entity.HasIndex(e => e.GroupId)
                    .HasName("auth_user_groups_group_id_97559544");

                entity.HasIndex(e => e.UserId)
                    .HasName("auth_user_groups_user_id_6a12ed8b");

                entity.HasIndex(e => new { e.UserId, e.GroupId })
                    .HasName("auth_user_groups_user_id_group_id_94350c0c_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthUserUserPermissions>(entity =>
            {
                entity.ToTable("auth_user_user_permissions");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("auth_user_user_permissions_permission_id_1fbb5f2c");

                entity.HasIndex(e => e.UserId)
                    .HasName("auth_user_user_permissions_user_id_a95ead1b");

                entity.HasIndex(e => new { e.UserId, e.PermissionId })
                    .HasName("auth_user_user_permissions_user_id_permission_id_14a6b632_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoAdminLog>(entity =>
            {
                entity.ToTable("django_admin_log");

                entity.HasIndex(e => e.ContentTypeId)
                    .HasName("django_admin_log_content_type_id_c4bce8eb");

                entity.HasIndex(e => e.UserId)
                    .HasName("django_admin_log_user_id_c564eba6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionFlag).HasColumnName("action_flag");

                entity.Property(e => e.ActionTime)
                    .HasColumnName("action_time")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ChangeMessage)
                    .IsRequired()
                    .HasColumnName("change_message");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectRepr)
                    .IsRequired()
                    .HasColumnName("object_repr")
                    .HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.DjangoAdminLog)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoAdminLog)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_admin_log_user_id_c564eba6_fk");
            });

            modelBuilder.Entity<DjangoContentType>(entity =>
            {
                entity.ToTable("django_content_type");

                entity.HasIndex(e => new { e.AppLabel, e.Model })
                    .HasName("django_content_type_app_label_model_76bd3d3b_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppLabel)
                    .IsRequired()
                    .HasColumnName("app_label")
                    .HasMaxLength(100);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DjangoMigrations>(entity =>
            {
                entity.ToTable("django_migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .IsRequired()
                    .HasColumnName("app")
                    .HasMaxLength(255);

                entity.Property(e => e.Applied)
                    .HasColumnName("applied")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DjangoSession>(entity =>
            {
                entity.HasKey(e => e.SessionKey)
                    .HasName("django_session_pkey");

                entity.ToTable("django_session");

                entity.HasIndex(e => e.ExpireDate)
                    .HasName("django_session_expire_date_a5c62663");

                entity.HasIndex(e => e.SessionKey)
                    .HasName("django_session_session_key_c0390e0f_like")
                    .ForNpgsqlHasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.SessionKey)
                    .HasColumnName("session_key")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.SessionData)
                    .IsRequired()
                    .HasColumnName("session_data");
            });

            modelBuilder.Entity<StarDefaultskillleveldescription>(entity =>
            {
                entity.ToTable("star_defaultskillleveldescription");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent100)
                    .HasColumnName("percent100")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent20)
                    .HasColumnName("percent20")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent40)
                    .HasColumnName("percent40")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent60)
                    .HasColumnName("percent60")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent80)
                    .HasColumnName("percent80")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<StarEmployee>(entity =>
            {
                entity.ToTable("star_employee");

                entity.HasIndex(e => e.GenderId)
                    .HasName("star_employee_gender_id_f632e94f");

                entity.HasIndex(e => e.OfficeId)
                    .HasName("star_employee_office_id_d7ecaf97");

                entity.HasIndex(e => e.RoleId)
                    .HasName("star_employee_role_id_cad7e31c");

                entity.HasIndex(e => e.TeamId)
                    .HasName("star_employee_team_id_b5bd97af");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.ExpertSkillsJson).HasColumnName("expertSkillsJSON");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.GeneralSkillsJson).HasColumnName("generalSkillsJSON");

                entity.Property(e => e.GoalsJson).HasColumnName("goalsJSON");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.StartedCreuna)
                    .HasColumnName("started_creuna")
                    .HasColumnType("date");

                entity.Property(e => e.StartedWorking)
                    .HasColumnName("started_working")
                    .HasColumnType("date");

                entity.Property(e => e.TeamId).HasColumnName("team_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(256);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.StarEmployee)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("star_employee_gender_id_f632e94f_fk_star_gender_id");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.StarEmployee)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("star_employee_office_id_d7ecaf97_fk_star_office_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.StarEmployee)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("star_employee_role_id_cad7e31c_fk_star_role_id");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.StarEmployee)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("star_employee_team_id_b5bd97af_fk_star_team_id");
            });

            modelBuilder.Entity<StarEmployeeskill>(entity =>
            {
                entity.ToTable("star_employeeskill");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("star_employeeskill_employee_id_985f3902");

                entity.HasIndex(e => e.ExpertSkillId)
                    .HasName("star_employeeskill_expert_skill_id_b68eb812");

                entity.HasIndex(e => e.GeneralSkillId)
                    .HasName("star_employeeskill_general_skill_id_a2d3ecd5");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.ExpertSkillId).HasColumnName("expert_skill_id");

                entity.Property(e => e.Future).HasColumnName("future");

                entity.Property(e => e.GeneralSkillId).HasColumnName("general_skill_id");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.StarEmployeeskill)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("star_employeeskill_employee_id_985f3902_fk_star_employee_id");

                entity.HasOne(d => d.ExpertSkill)
                    .WithMany(p => p.StarEmployeeskill)
                    .HasForeignKey(d => d.ExpertSkillId)
                    .HasConstraintName("star_employeeskill_expert_skill_id_b68eb812_fk_star_expe");

                entity.HasOne(d => d.GeneralSkill)
                    .WithMany(p => p.StarEmployeeskill)
                    .HasForeignKey(d => d.GeneralSkillId)
                    .HasConstraintName("star_employeeskill_general_skill_id_a2d3ecd5_fk_star_gene");
            });

            modelBuilder.Entity<StarExpertskill>(entity =>
            {
                entity.ToTable("star_expertskill");

                entity.HasIndex(e => e.DefaultDescriptionId)
                    .HasName("star_expertskill_default_description_id_e0bec6ab");

                entity.HasIndex(e => e.RoleId)
                    .HasName("star_expertskill_role_id_c81388bc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.DefaultDescriptionId).HasColumnName("default_description_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent100)
                    .HasColumnName("percent100")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent20)
                    .HasColumnName("percent20")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent40)
                    .HasColumnName("percent40")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent60)
                    .HasColumnName("percent60")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent80)
                    .HasColumnName("percent80")
                    .HasMaxLength(256);

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.DefaultDescription)
                    .WithMany(p => p.StarExpertskill)
                    .HasForeignKey(d => d.DefaultDescriptionId)
                    .HasConstraintName("star_expertskill_default_description__e0bec6ab_fk_star_defa");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.StarExpertskill)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("star_expertskill_role_id_c81388bc_fk_star_role_id");
            });

            modelBuilder.Entity<StarGender>(entity =>
            {
                entity.ToTable("star_gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<StarGeneralskill>(entity =>
            {
                entity.ToTable("star_generalskill");

                entity.HasIndex(e => e.DefaultDescriptionId)
                    .HasName("star_generalskill_default_description_id_1b8e8c85");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.DefaultDescriptionId).HasColumnName("default_description_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent100)
                    .HasColumnName("percent100")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent20)
                    .HasColumnName("percent20")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent40)
                    .HasColumnName("percent40")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent60)
                    .HasColumnName("percent60")
                    .HasMaxLength(256);

                entity.Property(e => e.Percent80)
                    .HasColumnName("percent80")
                    .HasMaxLength(256);

                entity.HasOne(d => d.DefaultDescription)
                    .WithMany(p => p.StarGeneralskill)
                    .HasForeignKey(d => d.DefaultDescriptionId)
                    .HasConstraintName("star_generalskill_default_description__1b8e8c85_fk_star_defa");
            });

            modelBuilder.Entity<StarOffice>(entity =>
            {
                entity.ToTable("star_office");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<StarRole>(entity =>
            {
                entity.ToTable("star_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<StarSitetext>(entity =>
            {
                entity.ToTable("star_sitetext");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.LandingPageBody).HasColumnName("landing_page_body");

                entity.Property(e => e.LandingPageHeading)
                    .HasColumnName("landing_page_heading")
                    .HasMaxLength(256);

                entity.Property(e => e.LandingPagePreamble)
                    .HasColumnName("landing_page_preamble")
                    .HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<StarTeam>(entity =>
            {
                entity.ToTable("star_team");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentfulId)
                    .HasColumnName("contentful_id")
                    .HasMaxLength(64);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);
            });
        }
    }
}
