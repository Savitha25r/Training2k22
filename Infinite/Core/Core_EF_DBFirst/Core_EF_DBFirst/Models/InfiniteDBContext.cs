using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class InfiniteDBContext : DbContext
    {
        public InfiniteDBContext()
        {
        }

        public InfiniteDBContext(DbContextOptions<InfiniteDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditTable> AuditTables { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Dummy> Dummies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<StdMark> StdMarks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<VwDoctorsInfo> VwDoctorsInfos { get; set; }
        public virtual DbSet<Vwempdatum> Vwempdata { get; set; }
        public virtual DbSet<VwemployeeByDept> VwemployeeByDepts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-TJJ7D977;Database=InfiniteDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuditTable");

                entity.Property(e => e.Msg)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__014881AE3C4E2D3B");

                entity.ToTable("Department");

                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Bangalore')");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Did).HasColumnName("DId");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Sp)
                    .WithMany()
                    .HasForeignKey(d => d.SpId)
                    .HasConstraintName("FK__Doctors__SpId__72C60C4A");
            });

            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy");

                entity.Property(e => e.Dummyage).HasColumnName("dummyage");

                entity.Property(e => e.Dummyid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("dummyid");

                entity.Property(e => e.Dummyname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dummyname");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__Employee__AF2EBFA156C110E2");

                entity.ToTable("Employee");

                entity.HasIndex(e => e.Empname, "idxename");

                entity.HasIndex(e => e.Phone, "unqphone")
                    .IsUnique();

                entity.Property(e => e.Empid).ValueGeneratedNever();

                entity.Property(e => e.Empname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Employee__DeptId__267ABA7A");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ProdName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductSale>(entity =>
            {
                entity.HasKey(e => e.ProductSalesId)
                    .HasName("PK__ProductS__1B97309E322F0EE5");

                entity.Property(e => e.ProductSalesId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSales)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductSa__Produ__4BAC3F29");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => new { e.Eid, e.Pid })
                    .HasName("PK__projects__6483E2FCFFE85B7C");

                entity.ToTable("projects");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Duration)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("duration")
                    .IsFixedLength(true);

                entity.Property(e => e.Prjname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("prjname");
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sample");

                entity.HasIndex(e => e.Sampleid, "idx_sid")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Sampleid).HasColumnName("sampleid");

                entity.Property(e => e.Slocation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("slocation");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.HasKey(e => e.SpId)
                    .HasName("PK__Speciali__ACF3E95FADE4ABCC");

                entity.ToTable("Specialization");

                entity.Property(e => e.SpId).ValueGeneratedNever();

                entity.Property(e => e.Splname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StdMark>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Marks).HasColumnName("marks");

                entity.Property(e => e.Stdname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("stdname");

                entity.Property(e => e.Subjects)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("subjects");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sname)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DeptNo)
                    .HasName("PK__tbl_Depa__0148CAAE0D160CDB");

                entity.ToTable("tbl_Department");

                entity.Property(e => e.DeptNo).ValueGeneratedNever();

                entity.Property(e => e.Dname)
                    .IsRequired()
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("DName");

                entity.Property(e => e.Loc)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__tbl_Empl__AF2D66D34E426FD8");

                entity.ToTable("tbl_Employee");

                entity.Property(e => e.EmpNo).ValueGeneratedNever();

                entity.Property(e => e.Commision)
                    .HasColumnType("money")
                    .HasColumnName("commision");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("EName");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("job");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");

                entity.HasOne(d => d.DeptNoNavigation)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.DeptNo)
                    .HasConstraintName("FK__tbl_Emplo__DeptN__34C8D9D1");
            });

            modelBuilder.Entity<VwDoctorsInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwDoctorsInfo");

                entity.Property(e => e.Did).HasColumnName("DId");

                entity.Property(e => e.Doctorname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("doctorname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.Splname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("splname");
            });

            modelBuilder.Entity<Vwempdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwempdata");
            });

            modelBuilder.Entity<VwemployeeByDept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwemployeeByDept");

                entity.Property(e => e.Deptname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptname");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Empname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("empname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("gender")
                    .IsFixedLength(true);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
