using FRS.Core.Application.Services;
using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FRS.Core.Infrastructure.DataAccess;

public partial class FrsEnterpriseContext : DbContext, IEnterpriseDbContext
{
    public FrsEnterpriseContext()
    {
    }

    public FrsEnterpriseContext(DbContextOptions<FrsEnterpriseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Advtrack> Advtracks { get; set; }

    public virtual DbSet<Affiltbl> Affiltbls { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Auditadd> Auditadds { get; set; }

    public virtual DbSet<Auditlst> Auditlsts { get; set; }

    public virtual DbSet<Billcod2> Billcod2s { get; set; }

    public virtual DbSet<Billcode> Billcodes { get; set; }

    public virtual DbSet<BillingHistory> BillingHistories { get; set; }

    public virtual DbSet<Billxtra> Billxtras { get; set; }

    public virtual DbSet<BkAudit> BkAudits { get; set; }

    public virtual DbSet<BkAuditadd> BkAuditadds { get; set; }

    public virtual DbSet<BkCrim> BkCrims { get; set; }

    public virtual DbSet<BkDlxrq> BkDlxrqs { get; set; }

    public virtual DbSet<BkEduc> BkEducs { get; set; }

    public virtual DbSet<BkEmpl> BkEmpls { get; set; }

    public virtual DbSet<BkIcmrq> BkIcmrqs { get; set; }

    public virtual DbSet<BkMlost> BkMlosts { get; set; }

    public virtual DbSet<BkMvr> BkMvrs { get; set; }

    public virtual DbSet<BkPlic> BkPlics { get; set; }

    public virtual DbSet<BkRefrq> BkRefrqs { get; set; }

    public virtual DbSet<BkWkcmp> BkWkcmps { get; set; }

    public virtual DbSet<Blcdcom2> Blcdcom2s { get; set; }

    public virtual DbSet<Blcdcomp> Blcdcomps { get; set; }

    public virtual DbSet<Blcdjur> Blcdjurs { get; set; }

    public virtual DbSet<Cctran> Cctrans { get; set; }

    public virtual DbSet<CeclDrv> CeclDrvs { get; set; }

    public virtual DbSet<Chnatstu> Chnatstus { get; set; }

    public virtual DbSet<Chwrknbr> Chwrknbrs { get; set; }

    public virtual DbSet<Cinst> Cinsts { get; set; }

    public virtual DbSet<Cligroup> Cligroups { get; set; }

    public virtual DbSet<Clistate> Clistates { get; set; }

    public virtual DbSet<CltrSt> CltrSts { get; set; }

    public virtual DbSet<CompDpo> CompDpos { get; set; }

    public virtual DbSet<CompEcl> CompEcls { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Company2> Company2s { get; set; }

    public virtual DbSet<ConRecv> ConRecvs { get; set; }

    public virtual DbSet<Conbatch> Conbatches { get; set; }

    public virtual DbSet<Conmatch> Conmatches { get; set; }

    public virtual DbSet<Conremot> Conremots { get; set; }

    public virtual DbSet<Conuser> Conusers { get; set; }

    public virtual DbSet<Convctrm> Convctrms { get; set; }

    public virtual DbSet<County> Counties { get; set; }

    public virtual DbSet<CrimTat> CrimTats { get; set; }

    public virtual DbSet<Crimlink> Crimlinks { get; set; }

    public virtual DbSet<CtyList> CtyLists { get; set; }

    public virtual DbSet<Default> Defaults { get; set; }

    public virtual DbSet<Defdiscr> Defdiscrs { get; set; }

    public virtual DbSet<Defstate> Defstates { get; set; }

    public virtual DbSet<DelPf> DelPfs { get; set; }

    public virtual DbSet<Deltrack> Deltracks { get; set; }

    public virtual DbSet<Dempqlst> Dempqlsts { get; set; }

    public virtual DbSet<Dempqmst> Dempqmsts { get; set; }

    public virtual DbSet<Denirea> Denireas { get; set; }

    public virtual DbSet<Dict2> Dict2s { get; set; }

    public virtual DbSet<DisclSt> DisclSts { get; set; }

    public virtual DbSet<Dlcstate> Dlcstates { get; set; }

    public virtual DbSet<Dlformat> Dlformats { get; set; }

    public virtual DbSet<Dlxakabill> Dlxakabills { get; set; }

    public virtual DbSet<DlxreqQ> DlxreqQs { get; set; }

    public virtual DbSet<Dragndrop> Dragndrops { get; set; }

    public virtual DbSet<Drugpkg> Drugpkgs { get; set; }

    public virtual DbSet<EclDeleted> EclDeleteds { get; set; }

    public virtual DbSet<Eclresult> Eclresults { get; set; }

    public virtual DbSet<Ecltacct> Ecltaccts { get; set; }

    public virtual DbSet<Ecltbill> Ecltbills { get; set; }

    public virtual DbSet<Eclthelp> Eclthelps { get; set; }

    public virtual DbSet<Ecltmsg> Ecltmsgs { get; set; }

    public virtual DbSet<Ecltrack> Ecltracks { get; set; }

    public virtual DbSet<Ecltrpt> Ecltrpts { get; set; }

    public virtual DbSet<EmailQ> EmailQs { get; set; }

    public virtual DbSet<Emailatc> Emailatcs { get; set; }

    public virtual DbSet<Emailbil> Emailbils { get; set; }

    public virtual DbSet<Emailbld> Emailblds { get; set; }

    public virtual DbSet<Emplook> Emplooks { get; set; }

    public virtual DbSet<Extracst> Extracsts { get; set; }

    public virtual DbSet<Farchive> Farchives { get; set; }

    public virtual DbSet<Faxattch> Faxattches { get; set; }

    public virtual DbSet<Faxqueue> Faxqueues { get; set; }

    public virtual DbSet<Fi9reqQ> Fi9reqQs { get; set; }

    public virtual DbSet<Formi9Not> Formi9Nots { get; set; }

    public virtual DbSet<Frschool> Frschools { get; set; }

    public virtual DbSet<Frsdatum> Frsdata { get; set; }

    public virtual DbSet<Frsquery> Frsqueries { get; set; }

    public virtual DbSet<Frstable> Frstables { get; set; }

    public virtual DbSet<FrsupdQ> FrsupdQs { get; set; }

    public virtual DbSet<Gistracking> Gistrackings { get; set; }

    public virtual DbSet<Global> Globals { get; set; }

    public virtual DbSet<Globals2> Globals2s { get; set; }

    public virtual DbSet<Globkey> Globkeys { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<I3scrnQ> I3scrnQs { get; set; }

    public virtual DbSet<IcR> IcRs { get; set; }

    public virtual DbSet<IccodesCa> IccodesCas { get; set; }

    public virtual DbSet<IcmreqQ> IcmreqQs { get; set; }

    public virtual DbSet<IcrreqQ> IcrreqQs { get; set; }

    public virtual DbSet<IhrDlx> IhrDlxes { get; set; }

    public virtual DbSet<IhrIcm> IhrIcms { get; set; }

    public virtual DbSet<IhrMwork> IhrMworks { get; set; }

    public virtual DbSet<IhrWork> IhrWorks { get; set; }

    public virtual DbSet<InformdatareqQ> InformdatareqQs { get; set; }

    public virtual DbSet<Inhouscnty> Inhouscnties { get; set; }

    public virtual DbSet<International> Internationals { get; set; }

    public virtual DbSet<IntreqQ> IntreqQs { get; set; }

    public virtual DbSet<InvDtl> InvDtls { get; set; }

    public virtual DbSet<InvPmt> InvPmts { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Lpbacku2> Lpbacku2s { get; set; }

    public virtual DbSet<Lpbacku3> Lpbacku3s { get; set; }

    public virtual DbSet<Lpbacku4> Lpbacku4s { get; set; }

    public virtual DbSet<Lpbackup> Lpbackups { get; set; }

    public virtual DbSet<Lpmaster> Lpmasters { get; set; }

    public virtual DbSet<LpmasterAudit> LpmasterAudits { get; set; }

    public virtual DbSet<Ltrtrack> Ltrtracks { get; set; }

    public virtual DbSet<Lucharge> Lucharges { get; set; }

    public virtual DbSet<Lucivtyp> Lucivtyps { get; set; }

    public virtual DbSet<Lucourt> Lucourts { get; set; }

    public virtual DbSet<Ludisp> Ludisps { get; set; }

    public virtual DbSet<LxAuth> LxAuths { get; set; }

    public virtual DbSet<LxError> LxErrors { get; set; }

    public virtual DbSet<LxfrErr> LxfrErrs { get; set; }

    public virtual DbSet<Lxreqbtc> Lxreqbtcs { get; set; }

    public virtual DbSet<Lxrespar> Lxrespars { get; set; }

    public virtual DbSet<Mgrmsdel> Mgrmsdels { get; set; }

    public virtual DbSet<Mgrmstpw> Mgrmstpws { get; set; }

    public virtual DbSet<NscreqQ> NscreqQs { get; set; }

    public virtual DbSet<Olserror> Olserrors { get; set; }

    public virtual DbSet<Othdlinx> Othdlinxes { get; set; }

    public virtual DbSet<Othstfrm> Othstfrms { get; set; }

    public virtual DbSet<Othstin> Othstins { get; set; }

    public virtual DbSet<Othstype> Othstypes { get; set; }

    public virtual DbSet<PfCrim> PfCrims { get; set; }

    public virtual DbSet<PfCrimNoIdentity> PfCrimNoIdentities { get; set; }

    public virtual DbSet<PfEduc> PfEducs { get; set; }

    public virtual DbSet<PfEducNoIdentity> PfEducNoIdentities { get; set; }

    public virtual DbSet<PfEmpl> PfEmpls { get; set; }

    public virtual DbSet<PfEmplNoIdentity> PfEmplNoIdentities { get; set; }

    public virtual DbSet<PfEmplq> PfEmplqs { get; set; }

    public virtual DbSet<PfMlost> PfMlosts { get; set; }

    public virtual DbSet<PfMlostNoIdentity> PfMlostNoIdentities { get; set; }

    public virtual DbSet<PfMvr> PfMvrs { get; set; }

    public virtual DbSet<PfMvrNoIdentity> PfMvrNoIdentities { get; set; }

    public virtual DbSet<PfPlic> PfPlics { get; set; }

    public virtual DbSet<PfPlicNoIdentity> PfPlicNoIdentities { get; set; }

    public virtual DbSet<PfWkcmp> PfWkcmps { get; set; }

    public virtual DbSet<PfWkcmpNoIdentity> PfWkcmpNoIdentities { get; set; }

    public virtual DbSet<Piitrack> Piitracks { get; set; }

    public virtual DbSet<Pinst> Pinsts { get; set; }

    public virtual DbSet<PrCrim> PrCrims { get; set; }

    public virtual DbSet<PrEduc> PrEducs { get; set; }

    public virtual DbSet<PrEmpl> PrEmpls { get; set; }

    public virtual DbSet<PrMlost> PrMlosts { get; set; }

    public virtual DbSet<PrMvr> PrMvrs { get; set; }

    public virtual DbSet<PrPlic> PrPlics { get; set; }

    public virtual DbSet<PrWkcmp> PrWkcmps { get; set; }

    public virtual DbSet<PstreqQ> PstreqQs { get; set; }

    public virtual DbSet<Recsubj> Recsubjs { get; set; }

    public virtual DbSet<RefreqQ> RefreqQs { get; set; }

    public virtual DbSet<Relform> Relforms { get; set; }

    public virtual DbSet<ReqMap> ReqMaps { get; set; }

    public virtual DbSet<ReqMap2> ReqMap2s { get; set; }

    public virtual DbSet<ReqScr> ReqScrs { get; set; }

    public virtual DbSet<ResBack> ResBacks { get; set; }

    public virtual DbSet<ResDistribute> ResDistributes { get; set; }

    public virtual DbSet<ResGeo> ResGeos { get; set; }

    public virtual DbSet<ResList> ResLists { get; set; }

    public virtual DbSet<ResSupp> ResSupps { get; set; }

    public virtual DbSet<ResSuppCost> ResSuppCosts { get; set; }

    public virtual DbSet<Resdarea> Resdareas { get; set; }

    public virtual DbSet<Reshist> Reshists { get; set; }

    public virtual DbSet<Resnoset> Resnosets { get; set; }

    public virtual DbSet<Retryrlk> Retryrlks { get; set; }

    public virtual DbSet<RptMap> RptMaps { get; set; }

    public virtual DbSet<RptScr> RptScrs { get; set; }

    public virtual DbSet<Salestax> Salestaxes { get; set; }

    public virtual DbSet<ScrType> ScrTypes { get; set; }

    public virtual DbSet<Sinst> Sinsts { get; set; }

    public virtual DbSet<Specinst> Specinsts { get; set; }

    public virtual DbSet<SqlBypass> SqlBypasses { get; set; }

    public virtual DbSet<Srcstate> Srcstates { get; set; }

    public virtual DbSet<SsConv> SsConvs { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Stibatch> Stibatches { get; set; }

    public virtual DbSet<Stihistory> Stihistories { get; set; }

    public virtual DbSet<StireqQ> StireqQs { get; set; }

    public virtual DbSet<Subattch> Subattches { get; set; }

    public virtual DbSet<Supprtkt> Supprtkts { get; set; }

    public virtual DbSet<TdrreqQ> TdrreqQs { get; set; }

    public virtual DbSet<Trakfield> Trakfields { get; set; }

    public virtual DbSet<Trksetchg> Trksetchgs { get; set; }

    public virtual DbSet<TudrTag> TudrTags { get; set; }

    public virtual DbSet<Tudrcli> Tudrclis { get; set; }

    public virtual DbSet<Tudrcode> Tudrcodes { get; set; }

    public virtual DbSet<Tudrercod> Tudrercods { get; set; }

    public virtual DbSet<Tudrglob> Tudrglobs { get; set; }

    public virtual DbSet<Tudrimport> Tudrimports { get; set; }

    public virtual DbSet<Tudrmonitr> Tudrmonitrs { get; set; }

    public virtual DbSet<Tudrstate> Tudrstates { get; set; }

    public virtual DbSet<UsedFile> UsedFiles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Userdic> Userdics { get; set; }

    public virtual DbSet<Vcancel> Vcancels { get; set; }

    public virtual DbSet<Vmtchlog> Vmtchlogs { get; set; }

    public virtual DbSet<Vnarchiv> Vnarchivs { get; set; }

    public virtual DbSet<Vnattach> Vnattaches { get; set; }

    public virtual DbSet<Vnorder> Vnorders { get; set; }

    public virtual DbSet<Vntadmin> Vntadmins { get; set; }

    public virtual DbSet<Vntrack> Vntracks { get; set; }

    public virtual DbSet<WarchDeleted> WarchDeleteds { get; set; }

    public virtual DbSet<Webadmin> Webadmins { get; set; }

    public virtual DbSet<Webattch> Webattches { get; set; }

    public virtual DbSet<Webccset> Webccsets { get; set; }

    public virtual DbSet<Webcctrl> Webcctrls { get; set; }

    public virtual DbSet<Webform> Webforms { get; set; }

    public virtual DbSet<Webgroup> Webgroups { get; set; }

    public virtual DbSet<Webhisti> Webhistis { get; set; }

    public virtual DbSet<Webhisto> Webhistos { get; set; }

    public virtual DbSet<Webilpkg> Webilpkgs { get; set; }

    public virtual DbSet<Webready> Webreadies { get; set; }

    public virtual DbSet<Websetup> Websetups { get; set; }

    public virtual DbSet<Webxmldu> Webxmldus { get; set; }

    public virtual DbSet<Wfjready> Wfjreadies { get; set; }

    public virtual DbSet<WknreqQ> WknreqQs { get; set; }

    public virtual DbSet<Wmstrgrp> Wmstrgrps { get; set; }

    public virtual DbSet<Wrgready> Wrgreadies { get; set; }

    public virtual DbSet<Wsignup> Wsignups { get; set; }

    public virtual DbSet<Wupdflag> Wupdflags { get; set; }

    public async Task AddAsync<T>(T entity) where T : class
    {
        await base.AddAsync(entity);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=frs_ms_sqlv6;User Id=sa;Password=Password123;TrustServerCertificate=true;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FrsEnterpriseContext).Assembly);

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public new void Remove<T>(T entity) where T : class
    {
        base.Remove(entity);
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    void IEnterpriseDbContext.Update<T>(T entity)
    {
        base.Update(entity);
    }
}
