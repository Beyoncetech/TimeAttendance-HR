using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppDAL.DBModels
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Appuser> Appuser { get; set; }
        
        public virtual DbSet<Tblmdepartment> Tblmdepartment { get; set; }
        public virtual DbSet<Tblmdesignation> Tblmdesignation { get; set; }
        public virtual DbSet<Tblmdevice> Tblmdevice { get; set; }
        public virtual DbSet<Tblmemployee> Tblmemployee { get; set; }
        public virtual DbSet<Tblmholidaygroup> Tblmholidaygroup { get; set; }
        public virtual DbSet<Tblmleavegroup> Tblmleavegroup { get; set; }
        public virtual DbSet<Tblmleavetype> Tblmleavetype { get; set; }
        public virtual DbSet<Tblmoutype> Tblmoutype { get; set; }
        public virtual DbSet<Tblmshift> Tblmshift { get; set; }
        public virtual DbSet<Tblou> Tblou { get; set; }
        public virtual DbSet<Tblrdeviceouassignment> Tblrdeviceouassignment { get; set; }
        public virtual DbSet<Tblremployeeouassignment> Tblremployeeouassignment { get; set; }
        public virtual DbSet<Tblrholidaygroupassignment> Tblrholidaygroupassignment { get; set; }
        public virtual DbSet<Tblrleavegroupassignment> Tblrleavegroupassignment { get; set; }
        public virtual DbSet<Tbltdevicestatus> Tbltdevicestatus { get; set; }
        public virtual DbSet<Tbltholiday> Tbltholiday { get; set; }
        public virtual DbSet<Tbltleaveadjustment> Tbltleaveadjustment { get; set; }
        public virtual DbSet<Tbltleaveapplication> Tbltleaveapplication { get; set; }
        public virtual DbSet<Tbltleavebalance> Tbltleavebalance { get; set; }
        public virtual DbSet<Tbltleaveupdaterule> Tbltleaveupdaterule { get; set; }
        public virtual DbSet<Tbltprocessingyear> Tbltprocessingyear { get; set; }
        public virtual DbSet<Tblttoursiteduty> Tblttoursiteduty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=Password@123;database=btcoreframeworkdb", x => x.ServerVersion("10.4.13-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tblmdepartment>(entity =>
            {
                entity.ToTable("tblmdepartment");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblmdesignation>(entity =>
            {
                entity.ToTable("tblmdesignation");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblmdevice>(entity =>
            {
                entity.ToTable("tblmdevice");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cpuid)
                    .IsRequired()
                    .HasColumnName("CPUID")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ouid)
                    .HasColumnName("OUID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tblmemployee>(entity =>
            {
                entity.ToTable("tblmemployee");

                entity.HasComment("Employee Master");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("CardID")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DesignationId)
                    .HasColumnName("DesignationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HolidayGroupId)
                    .HasColumnName("HolidayGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LeaveGroupId)
                    .HasColumnName("LeaveGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ShiftType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.WeeklyOff)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblmholidaygroup>(entity =>
            {
                entity.ToTable("tblmholidaygroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblmleavegroup>(entity =>
            {
                entity.ToTable("tblmleavegroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblmleavetype>(entity =>
            {
                entity.ToTable("tblmleavetype");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblmoutype>(entity =>
            {
                entity.ToTable("tblmoutype");

                entity.HasComment("Master for OU Type like Company, Branch, Location");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblmshift>(entity =>
            {
                entity.ToTable("tblmshift");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakFrom).HasColumnType("timestamp");

                entity.Property(e => e.BreakTill).HasColumnType("timestamp");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.StartTime)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Tblou>(entity =>
            {
                entity.ToTable("tblou");

                entity.HasComment("Organisation Unit");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OutypeId)
                    .HasColumnName("OUTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParenetOuid)
                    .HasColumnName("ParenetOUID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tblrdeviceouassignment>(entity =>
            {
                entity.ToTable("tblrdeviceouassignment");

                entity.HasComment("Device and OU assignment");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClosedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ouid)
                    .HasColumnName("OUID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tblremployeeouassignment>(entity =>
            {
                entity.ToTable("tblremployeeouassignment");

                entity.HasComment("Employee OU Assignment");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClosedOn).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ouid)
                    .HasColumnName("OUID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tblrholidaygroupassignment>(entity =>
            {
                entity.ToTable("tblrholidaygroupassignment");

                entity.HasComment("Holiday and Group Assignment");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HolidayGroupId).HasColumnType("int(11)");

                entity.Property(e => e.HolidayId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tblrleavegroupassignment>(entity =>
            {
                entity.ToTable("tblrleavegroupassignment");

                entity.HasComment("Leave and Group Assignment");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClosedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LeaveGroupId)
                    .HasColumnName("LeaveGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LeaveTypeId)
                    .HasColumnName("LeaveTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxPerApplication).HasColumnType("int(11)");

                entity.Property(e => e.MinPerApplicaation).HasColumnType("int(11)");

                entity.Property(e => e.YearlyMaximum).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tbltdevicestatus>(entity =>
            {
                entity.ToTable("tbltdevicestatus");

                entity.HasComment("Device Health Status");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClosedOn).HasColumnType("datetime");

                entity.Property(e => e.Cpuid)
                    .IsRequired()
                    .HasColumnName("CPUID")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Firmware)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LastSyncTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tbltholiday>(entity =>
            {
                entity.ToTable("tbltholiday");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tbltleaveadjustment>(entity =>
            {
                entity.ToTable("tbltleaveadjustment");

                entity.HasComment("Leave Adjustment");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdjustmentType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcessLevel).HasColumnType("int(11)");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TrDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tbltleaveapplication>(entity =>
            {
                entity.ToTable("tbltleaveapplication");

                entity.HasComment("Leave Application");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromTime).HasColumnType("timestamp");

                entity.Property(e => e.ProcessLevel).HasColumnType("int(11)");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToTime).HasColumnType("timestamp");
            });

            modelBuilder.Entity<Tbltleavebalance>(entity =>
            {
                entity.ToTable("tbltleavebalance");

                entity.HasComment("Employeee Leave Balance");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Balance).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenBalance).HasColumnType("int(11)");

                entity.Property(e => e.ProcessingYearId)
                    .HasColumnName("ProcessingYearID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Tbltleaveupdaterule>(entity =>
            {
                entity.ToTable("tbltleaveupdaterule");

                entity.HasComment("Leave Update Rule");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddPeriod)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LeaveGroupAssignmentId)
                    .HasColumnName("LeaveGroupAssignmentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeOfUpdate)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UpdateRule)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tbltprocessingyear>(entity =>
            {
                entity.ToTable("tbltprocessingyear");

                entity.HasComment("Processing Year");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblttoursiteduty>(entity =>
            {
                entity.ToTable("tblttoursiteduty");

                entity.HasComment("Tour Site Duty");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FromTime).HasColumnType("timestamp");

                entity.Property(e => e.ProcessLevel).HasColumnType("int(11)");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ToTime).HasColumnType("timestamp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
