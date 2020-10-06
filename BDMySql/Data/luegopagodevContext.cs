using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BDMySql.Data
{
    public partial class luegopagodevContext : DbContext
    {
        public luegopagodevContext()
        {
        }

        public luegopagodevContext(DbContextOptions<luegopagodevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WpActionschedulerActions> WpActionschedulerActions { get; set; }
        public virtual DbSet<WpActionschedulerClaims> WpActionschedulerClaims { get; set; }
        public virtual DbSet<WpActionschedulerGroups> WpActionschedulerGroups { get; set; }
        public virtual DbSet<WpActionschedulerLogs> WpActionschedulerLogs { get; set; }
        public virtual DbSet<WpAdtribesMyConversions> WpAdtribesMyConversions { get; set; }
        public virtual DbSet<WpBrizyLogs> WpBrizyLogs { get; set; }
        public virtual DbSet<WpCommentmeta> WpCommentmeta { get; set; }
        public virtual DbSet<WpComments> WpComments { get; set; }
        public virtual DbSet<WpContacticNotices> WpContacticNotices { get; set; }
        public virtual DbSet<WpContacticSt> WpContacticSt { get; set; }
        public virtual DbSet<WpContacticSubmits> WpContacticSubmits { get; set; }
        public virtual DbSet<WpFmLog> WpFmLog { get; set; }
        public virtual DbSet<WpLinks> WpLinks { get; set; }
        public virtual DbSet<WpMailchimpCarts> WpMailchimpCarts { get; set; }
        public virtual DbSet<WpMailchimpJobs> WpMailchimpJobs { get; set; }
        public virtual DbSet<WpOptions> WpOptions { get; set; }
        public virtual DbSet<WpPmxeExports> WpPmxeExports { get; set; }
        public virtual DbSet<WpPmxeGoogleCats> WpPmxeGoogleCats { get; set; }
        public virtual DbSet<WpPmxePosts> WpPmxePosts { get; set; }
        public virtual DbSet<WpPmxeTemplates> WpPmxeTemplates { get; set; }
        public virtual DbSet<WpPmxiFiles> WpPmxiFiles { get; set; }
        public virtual DbSet<WpPmxiHistory> WpPmxiHistory { get; set; }
        public virtual DbSet<WpPmxiImages> WpPmxiImages { get; set; }
        public virtual DbSet<WpPmxiImports> WpPmxiImports { get; set; }
        public virtual DbSet<WpPmxiPosts> WpPmxiPosts { get; set; }
        public virtual DbSet<WpPmxiTemplates> WpPmxiTemplates { get; set; }
        public virtual DbSet<WpPostmarkLog> WpPostmarkLog { get; set; }
        public virtual DbSet<WpPostmeta> WpPostmeta { get; set; }
        public virtual DbSet<WpPosts> WpPosts { get; set; }
        public virtual DbSet<WpSgpbSubscribers> WpSgpbSubscribers { get; set; }
        public virtual DbSet<WpSgpbSubscriptionErrorLog> WpSgpbSubscriptionErrorLog { get; set; }
        public virtual DbSet<WpTermRelationships> WpTermRelationships { get; set; }
        public virtual DbSet<WpTermTaxonomy> WpTermTaxonomy { get; set; }
        public virtual DbSet<WpTermmeta> WpTermmeta { get; set; }
        public virtual DbSet<WpTerms> WpTerms { get; set; }
        public virtual DbSet<WpUsermeta> WpUsermeta { get; set; }
        public virtual DbSet<WpUsers> WpUsers { get; set; }
        public virtual DbSet<WpWcAdminNoteActions> WpWcAdminNoteActions { get; set; }
        public virtual DbSet<WpWcAdminNotes> WpWcAdminNotes { get; set; }
        public virtual DbSet<WpWcCategoryLookup> WpWcCategoryLookup { get; set; }
        public virtual DbSet<WpWcCustomerLookup> WpWcCustomerLookup { get; set; }
        public virtual DbSet<WpWcDownloadLog> WpWcDownloadLog { get; set; }
        public virtual DbSet<WpWcOrderCouponLookup> WpWcOrderCouponLookup { get; set; }
        public virtual DbSet<WpWcOrderProductLookup> WpWcOrderProductLookup { get; set; }
        public virtual DbSet<WpWcOrderStats> WpWcOrderStats { get; set; }
        public virtual DbSet<WpWcOrderTaxLookup> WpWcOrderTaxLookup { get; set; }
        public virtual DbSet<WpWcProductMetaLookup> WpWcProductMetaLookup { get; set; }
        public virtual DbSet<WpWcTaxRateClasses> WpWcTaxRateClasses { get; set; }
        public virtual DbSet<WpWcWebhooks> WpWcWebhooks { get; set; }
        public virtual DbSet<WpWfblockediplog> WpWfblockediplog { get; set; }
        public virtual DbSet<WpWfblocks7> WpWfblocks7 { get; set; }
        public virtual DbSet<WpWfconfig> WpWfconfig { get; set; }
        public virtual DbSet<WpWfcrawlers> WpWfcrawlers { get; set; }
        public virtual DbSet<WpWffilechanges> WpWffilechanges { get; set; }
        public virtual DbSet<WpWffilemods> WpWffilemods { get; set; }
        public virtual DbSet<WpWfhits> WpWfhits { get; set; }
        public virtual DbSet<WpWfhoover> WpWfhoover { get; set; }
        public virtual DbSet<WpWfissues> WpWfissues { get; set; }
        public virtual DbSet<WpWfknownfilelist> WpWfknownfilelist { get; set; }
        public virtual DbSet<WpWflivetraffichuman> WpWflivetraffichuman { get; set; }
        public virtual DbSet<WpWflocs> WpWflocs { get; set; }
        public virtual DbSet<WpWflogins> WpWflogins { get; set; }
        public virtual DbSet<WpWfls2faSecrets> WpWfls2faSecrets { get; set; }
        public virtual DbSet<WpWflsSettings> WpWflsSettings { get; set; }
        public virtual DbSet<WpWfnotifications> WpWfnotifications { get; set; }
        public virtual DbSet<WpWfpendingissues> WpWfpendingissues { get; set; }
        public virtual DbSet<WpWfreversecache> WpWfreversecache { get; set; }
        public virtual DbSet<WpWfsnipcache> WpWfsnipcache { get; set; }
        public virtual DbSet<WpWfstatus> WpWfstatus { get; set; }
        public virtual DbSet<WpWftrafficrates> WpWftrafficrates { get; set; }
        public virtual DbSet<WpWoocommerceApiKeys> WpWoocommerceApiKeys { get; set; }
        public virtual DbSet<WpWoocommerceAttributeTaxonomies> WpWoocommerceAttributeTaxonomies { get; set; }
        public virtual DbSet<WpWoocommerceDownloadableProductPermissions> WpWoocommerceDownloadableProductPermissions { get; set; }
        public virtual DbSet<WpWoocommerceLog> WpWoocommerceLog { get; set; }
        public virtual DbSet<WpWoocommerceOrderItemmeta> WpWoocommerceOrderItemmeta { get; set; }
        public virtual DbSet<WpWoocommerceOrderItems> WpWoocommerceOrderItems { get; set; }
        public virtual DbSet<WpWoocommercePaymentTokenmeta> WpWoocommercePaymentTokenmeta { get; set; }
        public virtual DbSet<WpWoocommercePaymentTokens> WpWoocommercePaymentTokens { get; set; }
        public virtual DbSet<WpWoocommerceSessions> WpWoocommerceSessions { get; set; }
        public virtual DbSet<WpWoocommerceShippingZoneLocations> WpWoocommerceShippingZoneLocations { get; set; }
        public virtual DbSet<WpWoocommerceShippingZoneMethods> WpWoocommerceShippingZoneMethods { get; set; }
        public virtual DbSet<WpWoocommerceShippingZones> WpWoocommerceShippingZones { get; set; }
        public virtual DbSet<WpWoocommerceTaxRateLocations> WpWoocommerceTaxRateLocations { get; set; }
        public virtual DbSet<WpWoocommerceTaxRates> WpWoocommerceTaxRates { get; set; }
        public virtual DbSet<WpYoastIndexable> WpYoastIndexable { get; set; }
        public virtual DbSet<WpYoastIndexableHierarchy> WpYoastIndexableHierarchy { get; set; }
        public virtual DbSet<WpYoastMigrations> WpYoastMigrations { get; set; }
        public virtual DbSet<WpYoastPrimaryTerm> WpYoastPrimaryTerm { get; set; }
        public virtual DbSet<WpYoastSeoLinks> WpYoastSeoLinks { get; set; }
        public virtual DbSet<WpYoastSeoMeta> WpYoastSeoMeta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseMySql("server=190.158.197.177;port=3306;database=luegopago;uid=admin;pwd=Dna9201,,,;sslmode=Preferred", x => x.ServerVersion("5.7.29-mysql"));
                //optionsBuilder.UseMySql("server=luegopago.mysql.database.azure.com;port=3306;database=luegopago-dev;uid=user12@luegopago;pwd=MWYyZDFlMmU2N2Rm234s;sslmode=Preferred", x => x.ServerVersion("5.7.29-mysql"));
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=luegopago;uid=root;sslmode=Preferred", x => x.ServerVersion("5.7.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WpActionschedulerActions>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_actions");

                entity.HasIndex(e => e.Args)
                    .HasName("args");

                entity.HasIndex(e => e.ClaimId)
                    .HasName("claim_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id");

                entity.HasIndex(e => e.Hook)
                    .HasName("hook");

                entity.HasIndex(e => e.LastAttemptGmt)
                    .HasName("last_attempt_gmt");

                entity.HasIndex(e => e.ScheduledDateGmt)
                    .HasName("scheduled_date_gmt");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Args)
                    .HasColumnName("args")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Attempts)
                    .HasColumnName("attempts")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("claim_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ExtendedArgs)
                    .HasColumnName("extended_args")
                    .HasColumnType("varchar(8000)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Hook)
                    .IsRequired()
                    .HasColumnName("hook")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LastAttemptGmt)
                    .HasColumnName("last_attempt_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LastAttemptLocal)
                    .HasColumnName("last_attempt_local")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Schedule)
                    .HasColumnName("schedule")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ScheduledDateGmt)
                    .HasColumnName("scheduled_date_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ScheduledDateLocal)
                    .HasColumnName("scheduled_date_local")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpActionschedulerClaims>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_claims");

                entity.HasIndex(e => e.DateCreatedGmt)
                    .HasName("date_created_gmt");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("claim_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DateCreatedGmt)
                    .HasColumnName("date_created_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<WpActionschedulerGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_groups");

                entity.HasIndex(e => e.Slug)
                    .HasName("slug")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpActionschedulerLogs>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_actionscheduler_logs");

                entity.HasIndex(e => e.ActionId)
                    .HasName("action_id");

                entity.HasIndex(e => e.LogDateGmt)
                    .HasName("log_date_gmt");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LogDateGmt)
                    .HasColumnName("log_date_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LogDateLocal)
                    .HasColumnName("log_date_local")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpAdtribesMyConversions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_adtribes_my_conversions");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.HasIndex(e => e.OrderId)
                    .HasName("orderId")
                    .IsUnique();

                entity.Property(e => e.ConversionTime)
                    .HasColumnName("conversion_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(9)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProjectHash)
                    .IsRequired()
                    .HasColumnName("project_hash")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UtmCampaign)
                    .IsRequired()
                    .HasColumnName("utm_campaign")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UtmMedium)
                    .IsRequired()
                    .HasColumnName("utm_medium")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UtmSource)
                    .IsRequired()
                    .HasColumnName("utm_source")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UtmTerm)
                    .IsRequired()
                    .HasColumnName("utm_term")
                    .HasColumnType("varchar(256)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpBrizyLogs>(entity =>
            {
                entity.ToTable("wp_brizy_logs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasColumnName("context")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("session_id")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpCommentmeta>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_commentmeta");

                entity.HasIndex(e => e.CommentId)
                    .HasName("comment_id");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.MetaId)
                    .HasColumnName("meta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpComments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_comments");

                entity.HasIndex(e => e.CommentAuthorEmail)
                    .HasName("comment_author_email")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.HasIndex(e => e.CommentDateGmt)
                    .HasName("comment_date_gmt");

                entity.HasIndex(e => e.CommentParent)
                    .HasName("comment_parent");

                entity.HasIndex(e => e.CommentPostId)
                    .HasName("comment_post_ID");

                entity.HasIndex(e => e.CommentType)
                    .HasName("woo_idx_comment_type");

                entity.HasIndex(e => new { e.CommentApproved, e.CommentDateGmt })
                    .HasName("comment_approved_date_gmt")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentAgent)
                    .IsRequired()
                    .HasColumnName("comment_agent")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CommentApproved)
                    .IsRequired()
                    .HasColumnName("comment_approved")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CommentAuthor)
                    .IsRequired()
                    .HasColumnName("comment_author")
                    .HasColumnType("tinytext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CommentAuthorEmail)
                    .IsRequired()
                    .HasColumnName("comment_author_email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CommentAuthorIp)
                    .IsRequired()
                    .HasColumnName("comment_author_IP")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CommentAuthorUrl)
                    .IsRequired()
                    .HasColumnName("comment_author_url")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CommentContent)
                    .IsRequired()
                    .HasColumnName("comment_content")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CommentDate)
                    .HasColumnName("comment_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentDateGmt)
                    .HasColumnName("comment_date_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CommentKarma)
                    .HasColumnName("comment_karma")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentParent)
                    .HasColumnName("comment_parent")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentPostId)
                    .HasColumnName("comment_post_ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasColumnName("comment_type")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpContacticNotices>(entity =>
            {
                entity.ToTable("wp_contactic_notices");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Dismissed)
                    .HasColumnName("dismissed")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpContacticSt>(entity =>
            {
                entity.HasKey(e => e.SubmitTime)
                    .HasName("PRIMARY");

                entity.ToTable("wp_contactic_st");

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submit_time")
                    .HasColumnType("decimal(16,4)");
            });

            modelBuilder.Entity<WpContacticSubmits>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_contactic_submits");

                entity.HasIndex(e => e.FieldName)
                    .HasName("field_name_idx");

                entity.HasIndex(e => e.FormName)
                    .HasName("form_name_idx");

                entity.HasIndex(e => e.SubmitTime)
                    .HasName("submit_time_idx");

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldOrder)
                    .HasColumnName("field_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FieldValue)
                    .HasColumnName("field_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.File).HasColumnName("file");

                entity.Property(e => e.FormName)
                    .HasColumnName("form_name")
                    .HasColumnType("varchar(127)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubmitTime)
                    .HasColumnName("submit_time")
                    .HasColumnType("decimal(16,4)");
            });

            modelBuilder.Entity<WpFmLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_fm_log");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("file_path")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationId)
                    .IsRequired()
                    .HasColumnName("operation_id")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WpLinks>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_links");

                entity.HasIndex(e => e.LinkVisible)
                    .HasName("link_visible");

                entity.Property(e => e.LinkId)
                    .HasColumnName("link_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LinkDescription)
                    .IsRequired()
                    .HasColumnName("link_description")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkImage)
                    .IsRequired()
                    .HasColumnName("link_image")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasColumnName("link_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkNotes)
                    .IsRequired()
                    .HasColumnName("link_notes")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkOwner)
                    .HasColumnName("link_owner")
                    .HasColumnType("bigint(20) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LinkRating)
                    .HasColumnName("link_rating")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LinkRel)
                    .IsRequired()
                    .HasColumnName("link_rel")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkRss)
                    .IsRequired()
                    .HasColumnName("link_rss")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkTarget)
                    .IsRequired()
                    .HasColumnName("link_target")
                    .HasColumnType("varchar(25)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkUpdated)
                    .HasColumnName("link_updated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("link_url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkVisible)
                    .IsRequired()
                    .HasColumnName("link_visible")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'Y'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpMailchimpCarts>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PRIMARY");

                entity.ToTable("wp_mailchimp_carts");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Cart)
                    .IsRequired()
                    .HasColumnName("cart")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WpMailchimpJobs>(entity =>
            {
                entity.ToTable("wp_mailchimp_jobs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasColumnName("job")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ObjId)
                    .HasColumnName("obj_id")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpOptions>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_options");

                entity.HasIndex(e => e.Autoload)
                    .HasName("autoload");

                entity.HasIndex(e => e.OptionName)
                    .HasName("option_name")
                    .IsUnique();

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Autoload)
                    .IsRequired()
                    .HasColumnName("autoload")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'yes'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasColumnName("option_name")
                    .HasColumnType("varchar(191)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OptionValue)
                    .IsRequired()
                    .HasColumnName("option_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPmxeExports>(entity =>
            {
                entity.ToTable("wp_pmxe_exports");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttchId)
                    .HasColumnName("attch_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Canceled).HasColumnName("canceled");

                entity.Property(e => e.CanceledOn)
                    .HasColumnName("canceled_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Executing).HasColumnName("executing");

                entity.Property(e => e.ExportPostType)
                    .IsRequired()
                    .HasColumnName("export_post_type")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Exported)
                    .HasColumnName("exported")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasColumnName("friendly_name")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Iteration)
                    .HasColumnName("iteration")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("last_activity")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Processing).HasColumnName("processing");

                entity.Property(e => e.RegisteredOn)
                    .HasColumnName("registered_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Scheduled)
                    .IsRequired()
                    .HasColumnName("scheduled")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.SettingsUpdateOn)
                    .HasColumnName("settings_update_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Triggered).HasColumnName("triggered");
            });

            modelBuilder.Entity<WpPmxeGoogleCats>(entity =>
            {
                entity.ToTable("wp_pmxe_google_cats");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentName)
                    .IsRequired()
                    .HasColumnName("parent_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPmxePosts>(entity =>
            {
                entity.ToTable("wp_pmxe_posts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ExportId)
                    .HasColumnName("export_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Iteration)
                    .HasColumnName("iteration")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpPmxeTemplates>(entity =>
            {
                entity.ToTable("wp_pmxe_templates");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPmxiFiles>(entity =>
            {
                entity.ToTable("wp_pmxi_files");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.RegisteredOn)
                    .HasColumnName("registered_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<WpPmxiHistory>(entity =>
            {
                entity.ToTable("wp_pmxi_history");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Summary)
                    .HasColumnName("summary")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TimeRun)
                    .HasColumnName("time_run")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('manual','processing','trigger','continue','')")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPmxiImages>(entity =>
            {
                entity.ToTable("wp_pmxi_images");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttachmentId)
                    .HasColumnName("attachment_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ImageFilename)
                    .IsRequired()
                    .HasColumnName("image_filename")
                    .HasColumnType("varchar(600)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnName("image_url")
                    .HasColumnType("varchar(600)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPmxiImports>(entity =>
            {
                entity.ToTable("wp_pmxi_imports");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Canceled).HasColumnName("canceled");

                entity.Property(e => e.CanceledOn)
                    .HasColumnName("canceled_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Executing).HasColumnName("executing");

                entity.Property(e => e.Failed).HasColumnName("failed");

                entity.Property(e => e.FailedOn)
                    .HasColumnName("failed_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.FeedType)
                    .IsRequired()
                    .HasColumnName("feed_type")
                    .HasColumnType("enum('xml','csv','zip','gz','')")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.FirstImport)
                    .HasColumnName("first_import")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasColumnName("friendly_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Imported)
                    .HasColumnName("imported")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Iteration)
                    .HasColumnName("iteration")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("last_activity")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ParentImportId)
                    .HasColumnName("parent_import_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Processing).HasColumnName("processing");

                entity.Property(e => e.QueueChunkNumber)
                    .HasColumnName("queue_chunk_number")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.RegisteredOn)
                    .HasColumnName("registered_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.RootElement)
                    .HasColumnName("root_element")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.SettingsUpdateOn)
                    .HasColumnName("settings_update_on")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Skipped)
                    .HasColumnName("skipped")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Triggered).HasColumnName("triggered");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Xpath)
                    .HasColumnName("xpath")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPmxiPosts>(entity =>
            {
                entity.ToTable("wp_pmxi_posts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ImportId)
                    .HasColumnName("import_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Iteration)
                    .HasColumnName("iteration")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProductKey)
                    .HasColumnName("product_key")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Specified).HasColumnName("specified");

                entity.Property(e => e.UniqueKey)
                    .HasColumnName("unique_key")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPmxiTemplates>(entity =>
            {
                entity.ToTable("wp_pmxi_templates");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.FixCharacters).HasColumnName("fix_characters");

                entity.Property(e => e.IsKeepLinebreaks).HasColumnName("is_keep_linebreaks");

                entity.Property(e => e.IsLeaveHtml).HasColumnName("is_leave_html");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Scheduled)
                    .IsRequired()
                    .HasColumnName("scheduled")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPostmarkLog>(entity =>
            {
                entity.ToTable("wp_postmark_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fromaddress)
                    .HasColumnName("fromaddress")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LogEntryDate)
                    .HasColumnName("log_entry_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Response)
                    .HasColumnName("response")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Toaddress)
                    .HasColumnName("toaddress")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpPostmeta>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_postmeta");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id");

                entity.Property(e => e.MetaId)
                    .HasColumnName("meta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpPosts>(entity =>
            {
                entity.ToTable("wp_posts");

                entity.HasIndex(e => e.PostAuthor)
                    .HasName("post_author");

                entity.HasIndex(e => e.PostName)
                    .HasName("post_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.PostParent)
                    .HasName("post_parent");

                entity.HasIndex(e => new { e.PostType, e.PostStatus, e.PostDate, e.Id })
                    .HasName("type_status_date")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CommentCount)
                    .HasColumnName("comment_count")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CommentStatus)
                    .IsRequired()
                    .HasColumnName("comment_status")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'open'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("guid")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MenuOrder)
                    .HasColumnName("menu_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PingStatus)
                    .IsRequired()
                    .HasColumnName("ping_status")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'open'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Pinged)
                    .IsRequired()
                    .HasColumnName("pinged")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostAuthor)
                    .HasColumnName("post_author")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PostContent)
                    .IsRequired()
                    .HasColumnName("post_content")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostContentFiltered)
                    .IsRequired()
                    .HasColumnName("post_content_filtered")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostDate)
                    .HasColumnName("post_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostDateGmt)
                    .HasColumnName("post_date_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostExcerpt)
                    .IsRequired()
                    .HasColumnName("post_excerpt")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostMimeType)
                    .IsRequired()
                    .HasColumnName("post_mime_type")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostModified)
                    .HasColumnName("post_modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostModifiedGmt)
                    .HasColumnName("post_modified_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PostName)
                    .IsRequired()
                    .HasColumnName("post_name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostParent)
                    .HasColumnName("post_parent")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PostPassword)
                    .IsRequired()
                    .HasColumnName("post_password")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostStatus)
                    .IsRequired()
                    .HasColumnName("post_status")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'publish'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasColumnName("post_title")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostType)
                    .IsRequired()
                    .HasColumnName("post_type")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'post'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ToPing)
                    .IsRequired()
                    .HasColumnName("to_ping")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpSgpbSubscribers>(entity =>
            {
                entity.ToTable("wp_sgpb_subscribers");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12)");

                entity.Property(e => e.CDate)
                    .HasColumnName("cDate")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubmittedData)
                    .IsRequired()
                    .HasColumnName("submittedData")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubscriptionType)
                    .HasColumnName("subscriptionType")
                    .HasColumnType("int(12)");

                entity.Property(e => e.Unsubscribed)
                    .HasColumnName("unsubscribed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpSgpbSubscriptionErrorLog>(entity =>
            {
                entity.ToTable("wp_sgpb_subscription_error_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(12)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PopupType)
                    .HasColumnName("popupType")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpTermRelationships>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.TermTaxonomyId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_term_relationships");

                entity.HasIndex(e => e.TermTaxonomyId)
                    .HasName("term_taxonomy_id");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnName("term_taxonomy_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TermOrder)
                    .HasColumnName("term_order")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WpTermTaxonomy>(entity =>
            {
                entity.HasKey(e => e.TermTaxonomyId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_term_taxonomy");

                entity.HasIndex(e => e.Taxonomy)
                    .HasName("taxonomy");

                entity.HasIndex(e => new { e.TermId, e.Taxonomy })
                    .HasName("term_id_taxonomy")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.TermTaxonomyId)
                    .HasColumnName("term_taxonomy_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Taxonomy)
                    .IsRequired()
                    .HasColumnName("taxonomy")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TermId)
                    .HasColumnName("term_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpTermmeta>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_termmeta");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.TermId)
                    .HasName("term_id");

                entity.Property(e => e.MetaId)
                    .HasColumnName("meta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TermId)
                    .HasColumnName("term_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpTerms>(entity =>
            {
                entity.HasKey(e => e.TermId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_terms");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Slug)
                    .HasName("slug")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.TermId)
                    .HasColumnName("term_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TermGroup)
                    .HasColumnName("term_group")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<WpUsermeta>(entity =>
            {
                entity.HasKey(e => e.UmetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_usermeta");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.UmetaId)
                    .HasColumnName("umeta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpUsers>(entity =>
            {
                entity.ToTable("wp_users");

                entity.HasIndex(e => e.UserEmail)
                    .HasName("user_email");

                entity.HasIndex(e => e.UserLogin)
                    .HasName("user_login_key");

                entity.HasIndex(e => e.UserNicename)
                    .HasName("user_nicename");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("display_name")
                    .HasColumnType("varchar(250)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserActivationKey)
                    .IsRequired()
                    .HasColumnName("user_activation_key")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasColumnName("user_login")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserNicename)
                    .IsRequired()
                    .HasColumnName("user_nicename")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasColumnName("user_pass")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserRegistered)
                    .HasColumnName("user_registered")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserStatus)
                    .HasColumnName("user_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserUrl)
                    .IsRequired()
                    .HasColumnName("user_url")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWcAdminNoteActions>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_admin_note_actions");

                entity.HasIndex(e => e.NoteId)
                    .HasName("note_id");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsPrimary).HasColumnName("is_primary");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.NoteId)
                    .HasColumnName("note_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasColumnName("query")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWcAdminNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_admin_notes");

                entity.Property(e => e.NoteId)
                    .HasColumnName("note_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ContentData)
                    .HasColumnName("content_data")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DateReminder)
                    .HasColumnName("date_reminder")
                    .HasColumnType("datetime");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.IsSnoozable).HasColumnName("is_snoozable");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWcCategoryLookup>(entity =>
            {
                entity.HasKey(e => new { e.CategoryTreeId, e.CategoryId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_wc_category_lookup");

                entity.Property(e => e.CategoryTreeId)
                    .HasColumnName("category_tree_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWcCustomerLookup>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_customer_lookup");

                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id")
                    .IsUnique();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasColumnType("char(2)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.DateLastActive)
                    .HasColumnName("date_last_active")
                    .HasColumnType("timestamp");

                entity.Property(e => e.DateRegistered)
                    .HasColumnName("date_registered")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasColumnName("postcode")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(60)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWcDownloadLog>(entity =>
            {
                entity.HasKey(e => e.DownloadLogId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_download_log");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("permission_id");

                entity.HasIndex(e => e.Timestamp)
                    .HasName("timestamp");

                entity.Property(e => e.DownloadLogId)
                    .HasColumnName("download_log_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserIpAddress)
                    .HasColumnName("user_ip_address")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.WpWcDownloadLog)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("fk_wp_wc_download_log_permission_id");
            });

            modelBuilder.Entity<WpWcOrderCouponLookup>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.CouponId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_wc_order_coupon_lookup");

                entity.HasIndex(e => e.CouponId)
                    .HasName("coupon_id");

                entity.HasIndex(e => e.DateCreated)
                    .HasName("date_created");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CouponId)
                    .HasColumnName("coupon_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");
            });

            modelBuilder.Entity<WpWcOrderProductLookup>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_order_product_lookup");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.DateCreated)
                    .HasName("date_created");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => e.ProductId)
                    .HasName("product_id");

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("order_item_id")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CouponAmount).HasColumnName("coupon_amount");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProductGrossRevenue).HasColumnName("product_gross_revenue");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ProductNetRevenue).HasColumnName("product_net_revenue");

                entity.Property(e => e.ProductQty)
                    .HasColumnName("product_qty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShippingAmount).HasColumnName("shipping_amount");

                entity.Property(e => e.ShippingTaxAmount).HasColumnName("shipping_tax_amount");

                entity.Property(e => e.TaxAmount).HasColumnName("tax_amount");

                entity.Property(e => e.VariationId)
                    .HasColumnName("variation_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWcOrderStats>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_order_stats");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("customer_id");

                entity.HasIndex(e => e.DateCreated)
                    .HasName("date_created");

                entity.HasIndex(e => e.Status)
                    .HasName("status")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DateCreatedGmt)
                    .HasColumnName("date_created_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NetTotal).HasColumnName("net_total");

                entity.Property(e => e.NumItemsSold)
                    .HasColumnName("num_items_sold")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ReturningCustomer).HasColumnName("returning_customer");

                entity.Property(e => e.ShippingTotal).HasColumnName("shipping_total");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxTotal).HasColumnName("tax_total");

                entity.Property(e => e.TotalSales).HasColumnName("total_sales");
            });

            modelBuilder.Entity<WpWcOrderTaxLookup>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.TaxRateId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_wc_order_tax_lookup");

                entity.HasIndex(e => e.DateCreated)
                    .HasName("date_created");

                entity.HasIndex(e => e.TaxRateId)
                    .HasName("tax_rate_id");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaxRateId)
                    .HasColumnName("tax_rate_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderTax).HasColumnName("order_tax");

                entity.Property(e => e.ShippingTax).HasColumnName("shipping_tax");

                entity.Property(e => e.TotalTax).HasColumnName("total_tax");
            });

            modelBuilder.Entity<WpWcProductMetaLookup>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_product_meta_lookup");

                entity.HasIndex(e => e.Downloadable)
                    .HasName("downloadable");

                entity.HasIndex(e => e.Onsale)
                    .HasName("onsale");

                entity.HasIndex(e => e.StockQuantity)
                    .HasName("stock_quantity");

                entity.HasIndex(e => e.StockStatus)
                    .HasName("stock_status");

                entity.HasIndex(e => e.Virtual)
                    .HasName("virtual");

                entity.HasIndex(e => new { e.MinPrice, e.MaxPrice })
                    .HasName("min_max_price")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("bigint(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AverageRating)
                    .HasColumnName("average_rating")
                    .HasColumnType("decimal(3,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Downloadable)
                    .HasColumnName("downloadable")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxPrice)
                    .HasColumnName("max_price")
                    .HasColumnType("decimal(19,4)");

                entity.Property(e => e.MinPrice)
                    .HasColumnName("min_price")
                    .HasColumnType("decimal(19,4)");

                entity.Property(e => e.Onsale)
                    .HasColumnName("onsale")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RatingCount)
                    .HasColumnName("rating_count")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.StockQuantity).HasColumnName("stock_quantity");

                entity.Property(e => e.StockStatus)
                    .HasColumnName("stock_status")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'instock'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxClass)
                    .HasColumnName("tax_class")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxStatus)
                    .HasColumnName("tax_status")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'taxable'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TotalSales)
                    .HasColumnName("total_sales")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Virtual)
                    .HasColumnName("virtual")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WpWcTaxRateClasses>(entity =>
            {
                entity.HasKey(e => e.TaxRateClassId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_tax_rate_classes");

                entity.HasIndex(e => e.Slug)
                    .HasName("slug")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.TaxRateClassId)
                    .HasColumnName("tax_rate_class_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWcWebhooks>(entity =>
            {
                entity.HasKey(e => e.WebhookId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wc_webhooks");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.WebhookId)
                    .HasColumnName("webhook_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ApiVersion)
                    .HasColumnName("api_version")
                    .HasColumnType("smallint(4)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DateCreatedGmt)
                    .HasColumnName("date_created_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DateModified)
                    .HasColumnName("date_modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DateModifiedGmt)
                    .HasColumnName("date_modified_gmt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DeliveryUrl)
                    .IsRequired()
                    .HasColumnName("delivery_url")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.FailureCount)
                    .HasColumnName("failure_count")
                    .HasColumnType("smallint(10)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PendingDelivery).HasColumnName("pending_delivery");

                entity.Property(e => e.Secret)
                    .IsRequired()
                    .HasColumnName("secret")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Topic)
                    .IsRequired()
                    .HasColumnName("topic")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWfblockediplog>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.Unixday, e.BlockType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("wp_wfblockediplog");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                '");

                entity.Property(e => e.Unixday)
                    .HasColumnName("unixday")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.BlockType)
                    .HasColumnName("blockType")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'generic'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BlockCount)
                    .HasColumnName("blockCount")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("countryCode")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWfblocks7>(entity =>
            {
                entity.ToTable("wp_wfblocks7");

                entity.HasIndex(e => e.Expiration)
                    .HasName("expiration");

                entity.HasIndex(e => e.Ip)
                    .HasName("IP");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BlockedHits)
                    .HasColumnName("blockedHits")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BlockedTime)
                    .HasColumnName("blockedTime")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                '");

                entity.Property(e => e.LastAttempt)
                    .HasColumnName("lastAttempt")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Parameters)
                    .HasColumnName("parameters")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("reason")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WpWfconfig>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wfconfig");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Autoload)
                    .IsRequired()
                    .HasColumnName("autoload")
                    .HasColumnType("enum('no','yes')")
                    .HasDefaultValueSql("'yes'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<WpWfcrawlers>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.PatternSig })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_wfcrawlers");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                '");

                entity.Property(e => e.PatternSig)
                    .HasColumnName("patternSig")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ptr)
                    .HasColumnName("PTR")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("char(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWffilechanges>(entity =>
            {
                entity.HasKey(e => e.FilenameHash)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wffilechanges");

                entity.Property(e => e.FilenameHash)
                    .HasColumnName("filenameHash")
                    .HasColumnType("char(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Md5)
                    .IsRequired()
                    .HasColumnName("md5")
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWffilemods>(entity =>
            {
                entity.HasKey(e => e.FilenameMd5)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wffilemods");

                entity.Property(e => e.FilenameMd5)
                    .HasColumnName("filenameMD5")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsSafeFile)
                    .IsRequired()
                    .HasColumnName("isSafeFile")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'?'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KnownFile)
                    .HasColumnName("knownFile")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NewMd5)
                    .IsRequired()
                    .HasColumnName("newMD5")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.OldMd5)
                    .IsRequired()
                    .HasColumnName("oldMD5")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Shac)
                    .IsRequired()
                    .HasColumnName("SHAC")
                    .HasMaxLength(32)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                                '");

                entity.Property(e => e.StoppedOnPosition)
                    .HasColumnName("stoppedOnPosition")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.StoppedOnSignature)
                    .IsRequired()
                    .HasColumnName("stoppedOnSignature")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWfhits>(entity =>
            {
                entity.ToTable("wp_wfhits");

                entity.HasIndex(e => e.AttackLogTime)
                    .HasName("attackLogTime");

                entity.HasIndex(e => e.Ctime)
                    .HasName("k1");

                entity.HasIndex(e => new { e.Ip, e.Ctime })
                    .HasName("k2")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasColumnType("varchar(64)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActionData)
                    .HasColumnName("actionData")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActionDescription)
                    .HasColumnName("actionDescription")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AttackLogTime)
                    .HasColumnName("attackLogTime")
                    .HasColumnType("double(17,6) unsigned");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("double(17,6) unsigned");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.IsGoogle)
                    .HasColumnName("isGoogle")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.JsRun)
                    .HasColumnName("jsRun")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NewVisit)
                    .HasColumnName("newVisit")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Referer)
                    .HasColumnName("referer")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("statusCode")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'200'");

                entity.Property(e => e.Ua)
                    .HasColumnName("UA")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WpWfhoover>(entity =>
            {
                entity.ToTable("wp_wfhoover");

                entity.HasIndex(e => e.HostKey)
                    .HasName("k2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Host)
                    .HasColumnName("host")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HostKey)
                    .HasColumnName("hostKey")
                    .HasMaxLength(124);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWfissues>(entity =>
            {
                entity.ToTable("wp_wfissues");

                entity.HasIndex(e => e.IgnoreC)
                    .HasName("ignoreC");

                entity.HasIndex(e => e.IgnoreP)
                    .HasName("ignoreP");

                entity.HasIndex(e => e.LastUpdated)
                    .HasName("lastUpdated");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IgnoreC)
                    .IsRequired()
                    .HasColumnName("ignoreC")
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IgnoreP)
                    .IsRequired()
                    .HasColumnName("ignoreP")
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("lastUpdated")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LongMsg)
                    .HasColumnName("longMsg")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ShortMsg)
                    .IsRequired()
                    .HasColumnName("shortMsg")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWfknownfilelist>(entity =>
            {
                entity.ToTable("wp_wfknownfilelist");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWflivetraffichuman>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.Identifier })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_wflivetraffichuman");

                entity.HasIndex(e => e.Expiration)
                    .HasName("expiration");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                '");

                entity.Property(e => e.Identifier)
                    .HasColumnName("identifier")
                    .HasMaxLength(32)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                                '");

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WpWflocs>(entity =>
            {
                entity.HasKey(e => e.Ip)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wflocs");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                '");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasColumnType("char(2)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryName)
                    .HasColumnName("countryName")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Failed)
                    .HasColumnName("failed")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("float(10,7)")
                    .HasDefaultValueSql("'0.0000000'");

                entity.Property(e => e.Lon)
                    .HasColumnName("lon")
                    .HasColumnType("float(10,7)")
                    .HasDefaultValueSql("'0.0000000'");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWflogins>(entity =>
            {
                entity.ToTable("wp_wflogins");

                entity.HasIndex(e => e.HitId)
                    .HasName("hitID");

                entity.HasIndex(e => new { e.Ip, e.Fail })
                    .HasName("k1")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("double(17,6) unsigned");

                entity.Property(e => e.Fail)
                    .HasColumnName("fail")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.HitId)
                    .HasColumnName("hitID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.Ua)
                    .HasColumnName("UA")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWfls2faSecrets>(entity =>
            {
                entity.ToTable("wp_wfls_2fa_secrets");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasColumnName("mode")
                    .HasColumnType("enum('authenticator')")
                    .HasDefaultValueSql("'authenticator'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Recovery)
                    .IsRequired()
                    .HasColumnName("recovery")
                    .HasColumnType("blob");

                entity.Property(e => e.Secret)
                    .IsRequired()
                    .HasColumnName("secret")
                    .HasColumnType("tinyblob");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Vtime)
                    .HasColumnName("vtime")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WpWflsSettings>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wfls_settings");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(191)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Autoload)
                    .IsRequired()
                    .HasColumnName("autoload")
                    .HasColumnType("enum('no','yes')")
                    .HasDefaultValueSql("'yes'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<WpWfnotifications>(entity =>
            {
                entity.ToTable("wp_wfnotifications");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Html)
                    .IsRequired()
                    .HasColumnName("html")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Links)
                    .IsRequired()
                    .HasColumnName("links")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.New)
                    .HasColumnName("new")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1000'");
            });

            modelBuilder.Entity<WpWfpendingissues>(entity =>
            {
                entity.ToTable("wp_wfpendingissues");

                entity.HasIndex(e => e.IgnoreC)
                    .HasName("ignoreC");

                entity.HasIndex(e => e.IgnoreP)
                    .HasName("ignoreP");

                entity.HasIndex(e => e.LastUpdated)
                    .HasName("lastUpdated");

                entity.HasIndex(e => e.Status)
                    .HasName("status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IgnoreC)
                    .IsRequired()
                    .HasColumnName("ignoreC")
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IgnoreP)
                    .IsRequired()
                    .HasColumnName("ignoreP")
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("lastUpdated")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LongMsg)
                    .HasColumnName("longMsg")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ShortMsg)
                    .IsRequired()
                    .HasColumnName("shortMsg")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWfreversecache>(entity =>
            {
                entity.HasKey(e => e.Ip)
                    .HasName("PRIMARY");

                entity.ToTable("wp_wfreversecache");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                '");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasColumnName("host")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WpWfsnipcache>(entity =>
            {
                entity.ToTable("wp_wfsnipcache");

                entity.HasIndex(e => e.Expiration)
                    .HasName("expiration");

                entity.HasIndex(e => e.Ip)
                    .HasName("IP");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WpWfstatus>(entity =>
            {
                entity.ToTable("wp_wfstatus");

                entity.HasIndex(e => e.Ctime)
                    .HasName("k1");

                entity.HasIndex(e => e.Type)
                    .HasName("k2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("double(17,6) unsigned");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasColumnName("msg")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("char(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpWftrafficrates>(entity =>
            {
                entity.HasKey(e => new { e.EMin, e.Ip, e.HitType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("wp_wftrafficrates");

                entity.Property(e => e.EMin)
                    .HasColumnName("eMin")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsFixedLength()
                    .HasDefaultValueSql("'                '");

                entity.Property(e => e.HitType)
                    .HasColumnName("hitType")
                    .HasColumnType("enum('hit','404')")
                    .HasDefaultValueSql("'hit'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hits)
                    .HasColumnName("hits")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceApiKeys>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_api_keys");

                entity.HasIndex(e => e.ConsumerKey)
                    .HasName("consumer_key");

                entity.HasIndex(e => e.ConsumerSecret)
                    .HasName("consumer_secret");

                entity.Property(e => e.KeyId)
                    .HasColumnName("key_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ConsumerKey)
                    .IsRequired()
                    .HasColumnName("consumer_key")
                    .HasColumnType("char(64)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ConsumerSecret)
                    .IsRequired()
                    .HasColumnName("consumer_secret")
                    .HasColumnType("char(43)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LastAccess)
                    .HasColumnName("last_access")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nonces)
                    .HasColumnName("nonces")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Permissions)
                    .IsRequired()
                    .HasColumnName("permissions")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TruncatedKey)
                    .IsRequired()
                    .HasColumnName("truncated_key")
                    .HasColumnType("char(7)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceAttributeTaxonomies>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_attribute_taxonomies");

                entity.HasIndex(e => e.AttributeName)
                    .HasName("attribute_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 20 });

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attribute_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AttributeLabel)
                    .HasColumnName("attribute_label")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasColumnName("attribute_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.AttributeOrderby)
                    .IsRequired()
                    .HasColumnName("attribute_orderby")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.AttributePublic)
                    .HasColumnName("attribute_public")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AttributeType)
                    .IsRequired()
                    .HasColumnName("attribute_type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWoocommerceDownloadableProductPermissions>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_downloadable_product_permissions");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.HasIndex(e => new { e.DownloadId, e.OrderId, e.ProductId })
                    .HasName("download_order_product")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.HasIndex(e => new { e.ProductId, e.OrderId, e.OrderKey, e.DownloadId })
                    .HasName("download_order_key_product")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 16, 0 });

                entity.HasIndex(e => new { e.UserId, e.OrderId, e.DownloadsRemaining, e.AccessExpires })
                    .HasName("user_order_remaining_expires")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.Property(e => e.PermissionId)
                    .HasColumnName("permission_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.AccessExpires)
                    .HasColumnName("access_expires")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccessGranted)
                    .HasColumnName("access_granted")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DownloadCount)
                    .HasColumnName("download_count")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.DownloadId)
                    .IsRequired()
                    .HasColumnName("download_id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.DownloadsRemaining)
                    .HasColumnName("downloads_remaining")
                    .HasColumnType("varchar(9)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderKey)
                    .IsRequired()
                    .HasColumnName("order_key")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_log");

                entity.HasIndex(e => e.Level)
                    .HasName("level");

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Context)
                    .HasColumnName("context")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasColumnType("smallint(4)");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WpWoocommerceOrderItemmeta>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_order_itemmeta");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

                entity.HasIndex(e => e.OrderItemId)
                    .HasName("order_item_id");

                entity.Property(e => e.MetaId)
                    .HasColumnName("meta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("order_item_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceOrderItems>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_order_items");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_id");

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("order_item_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.OrderItemName)
                    .IsRequired()
                    .HasColumnName("order_item_name")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OrderItemType)
                    .IsRequired()
                    .HasColumnName("order_item_type")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWoocommercePaymentTokenmeta>(entity =>
            {
                entity.HasKey(e => e.MetaId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_payment_tokenmeta");

                entity.HasIndex(e => e.MetaKey)
                    .HasName("meta_key")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 32 });

                entity.HasIndex(e => e.PaymentTokenId)
                    .HasName("payment_token_id");

                entity.Property(e => e.MetaId)
                    .HasColumnName("meta_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.MetaKey)
                    .HasColumnName("meta_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MetaValue)
                    .HasColumnName("meta_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PaymentTokenId)
                    .HasColumnName("payment_token_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommercePaymentTokens>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_payment_tokens");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.TokenId)
                    .HasColumnName("token_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.GatewayId)
                    .IsRequired()
                    .HasColumnName("gateway_id")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceSessions>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_sessions");

                entity.HasIndex(e => e.SessionKey)
                    .HasName("session_key")
                    .IsUnique();

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SessionExpiry)
                    .HasColumnName("session_expiry")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SessionKey)
                    .IsRequired()
                    .HasColumnName("session_key")
                    .HasColumnType("char(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.SessionValue)
                    .IsRequired()
                    .HasColumnName("session_value")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpWoocommerceShippingZoneLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_shipping_zone_locations");

                entity.HasIndex(e => e.LocationId)
                    .HasName("location_id");

                entity.HasIndex(e => new { e.LocationType, e.LocationCode })
                    .HasName("location_type_code")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10, 20 });

                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("location_code")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LocationType)
                    .IsRequired()
                    .HasColumnName("location_type")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zone_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceShippingZoneMethods>(entity =>
            {
                entity.HasKey(e => e.InstanceId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_shipping_zone_methods");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instance_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasColumnName("is_enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MethodId)
                    .IsRequired()
                    .HasColumnName("method_id")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.MethodOrder)
                    .HasColumnName("method_order")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zone_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceShippingZones>(entity =>
            {
                entity.HasKey(e => e.ZoneId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_shipping_zones");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("zone_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ZoneName)
                    .IsRequired()
                    .HasColumnName("zone_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ZoneOrder)
                    .HasColumnName("zone_order")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceTaxRateLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_tax_rate_locations");

                entity.HasIndex(e => e.TaxRateId)
                    .HasName("tax_rate_id");

                entity.HasIndex(e => new { e.LocationType, e.LocationCode })
                    .HasName("location_type_code")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10, 20 });

                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("location_code")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LocationType)
                    .IsRequired()
                    .HasColumnName("location_type")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxRateId)
                    .HasColumnName("tax_rate_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<WpWoocommerceTaxRates>(entity =>
            {
                entity.HasKey(e => e.TaxRateId)
                    .HasName("PRIMARY");

                entity.ToTable("wp_woocommerce_tax_rates");

                entity.HasIndex(e => e.TaxRateClass)
                    .HasName("tax_rate_class")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

                entity.HasIndex(e => e.TaxRateCountry)
                    .HasName("tax_rate_country");

                entity.HasIndex(e => e.TaxRatePriority)
                    .HasName("tax_rate_priority");

                entity.HasIndex(e => e.TaxRateState)
                    .HasName("tax_rate_state")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 2 });

                entity.Property(e => e.TaxRateId)
                    .HasColumnName("tax_rate_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaxRate)
                    .IsRequired()
                    .HasColumnName("tax_rate")
                    .HasColumnType("varchar(8)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxRateClass)
                    .IsRequired()
                    .HasColumnName("tax_rate_class")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxRateCompound)
                    .HasColumnName("tax_rate_compound")
                    .HasColumnType("int(1)");

                entity.Property(e => e.TaxRateCountry)
                    .IsRequired()
                    .HasColumnName("tax_rate_country")
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxRateName)
                    .IsRequired()
                    .HasColumnName("tax_rate_name")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TaxRateOrder)
                    .HasColumnName("tax_rate_order")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaxRatePriority)
                    .HasColumnName("tax_rate_priority")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TaxRateShipping)
                    .HasColumnName("tax_rate_shipping")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaxRateState)
                    .IsRequired()
                    .HasColumnName("tax_rate_state")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpYoastIndexable>(entity =>
            {
                entity.ToTable("wp_yoast_indexable");

                entity.HasIndex(e => e.PermalinkHash)
                    .HasName("permalink_hash");

                entity.HasIndex(e => new { e.ObjectId, e.ObjectType })
                    .HasName("object_id_and_type")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasIndex(e => new { e.ObjectType, e.ObjectSubType })
                    .HasName("object_type_and_sub_type")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("author_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BreadcrumbTitle)
                    .HasColumnName("breadcrumb_title")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Canonical)
                    .HasColumnName("canonical")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.HasAncestors)
                    .HasColumnName("has_ancestors")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HasPublicPosts).HasColumnName("has_public_posts");

                entity.Property(e => e.IncomingLinkCount)
                    .HasColumnName("incoming_link_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCornerstone)
                    .HasColumnName("is_cornerstone")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsProtected)
                    .HasColumnName("is_protected")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsPublic).HasColumnName("is_public");

                entity.Property(e => e.IsRobotsNoarchive)
                    .HasColumnName("is_robots_noarchive")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsRobotsNofollow)
                    .HasColumnName("is_robots_nofollow")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsRobotsNoimageindex)
                    .HasColumnName("is_robots_noimageindex")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsRobotsNoindex)
                    .HasColumnName("is_robots_noindex")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsRobotsNosnippet)
                    .HasColumnName("is_robots_nosnippet")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.LinkCount)
                    .HasColumnName("link_count")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberOfPages)
                    .HasColumnName("number_of_pages")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ObjectSubType)
                    .HasColumnName("object_sub_type")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("object_type")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OpenGraphDescription)
                    .HasColumnName("open_graph_description")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OpenGraphImage)
                    .HasColumnName("open_graph_image")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OpenGraphImageId)
                    .HasColumnName("open_graph_image_id")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OpenGraphImageMeta)
                    .HasColumnName("open_graph_image_meta")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OpenGraphImageSource)
                    .HasColumnName("open_graph_image_source")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.OpenGraphTitle)
                    .HasColumnName("open_graph_title")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Permalink)
                    .HasColumnName("permalink")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PermalinkHash)
                    .HasColumnName("permalink_hash")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PostParent)
                    .HasColumnName("post_parent")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PostStatus)
                    .HasColumnName("post_status")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PrimaryFocusKeyword)
                    .HasColumnName("primary_focus_keyword")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.PrimaryFocusKeywordScore)
                    .HasColumnName("primary_focus_keyword_score")
                    .HasColumnType("int(3)");

                entity.Property(e => e.ProminentWordsVersion)
                    .HasColumnName("prominent_words_version")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.ReadabilityScore)
                    .HasColumnName("readability_score")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.SchemaArticleType)
                    .HasColumnName("schema_article_type")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.SchemaPageType)
                    .HasColumnName("schema_page_type")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TwitterDescription)
                    .HasColumnName("twitter_description")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TwitterImage)
                    .HasColumnName("twitter_image")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TwitterImageId)
                    .HasColumnName("twitter_image_id")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TwitterImageSource)
                    .HasColumnName("twitter_image_source")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TwitterTitle)
                    .HasColumnName("twitter_title")
                    .HasColumnType("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<WpYoastIndexableHierarchy>(entity =>
            {
                entity.HasKey(e => new { e.IndexableId, e.AncestorId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("wp_yoast_indexable_hierarchy");

                entity.HasIndex(e => e.AncestorId)
                    .HasName("ancestor_id");

                entity.HasIndex(e => e.Depth)
                    .HasName("depth");

                entity.HasIndex(e => e.IndexableId)
                    .HasName("indexable_id");

                entity.Property(e => e.IndexableId)
                    .HasColumnName("indexable_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.AncestorId)
                    .HasColumnName("ancestor_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<WpYoastMigrations>(entity =>
            {
                entity.ToTable("wp_yoast_migrations");

                entity.HasIndex(e => e.Version)
                    .HasName("wp_yoast_migrations_version")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(191)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpYoastPrimaryTerm>(entity =>
            {
                entity.ToTable("wp_yoast_primary_term");

                entity.HasIndex(e => new { e.PostId, e.Taxonomy })
                    .HasName("post_taxonomy")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasIndex(e => new { e.PostId, e.TermId })
                    .HasName("post_term")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Taxonomy)
                    .IsRequired()
                    .HasColumnName("taxonomy")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.TermId)
                    .HasColumnName("term_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<WpYoastSeoLinks>(entity =>
            {
                entity.ToTable("wp_yoast_seo_links");

                entity.HasIndex(e => new { e.PostId, e.Type })
                    .HasName("link_direction")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.TargetPostId)
                    .HasColumnName("target_post_id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_520_ci");
            });

            modelBuilder.Entity<WpYoastSeoMeta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wp_yoast_seo_meta");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("object_id")
                    .IsUnique();

                entity.Property(e => e.IncomingLinkCount)
                    .HasColumnName("incoming_link_count")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.InternalLinkCount)
                    .HasColumnName("internal_link_count")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("bigint(20) unsigned");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
