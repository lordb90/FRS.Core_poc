using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FRS.Core.Application.Services
{
    public interface IEnterpriseDbContext
    {
        DbSet<Activity> Activities { get; set; }

        DbSet<Advtrack> Advtracks { get; set; }

        DbSet<Affiltbl> Affiltbls { get; set; }

        DbSet<Audit> Audits { get; set; }

        DbSet<Auditadd> Auditadds { get; set; }

        DbSet<Auditlst> Auditlsts { get; set; }

        DbSet<Billcod2> Billcod2s { get; set; }

        DbSet<Billcode> Billcodes { get; set; }

        DbSet<BillingHistory> BillingHistories { get; set; }

        DbSet<Billxtra> Billxtras { get; set; }

        DbSet<BkAudit> BkAudits { get; set; }

        DbSet<BkAuditadd> BkAuditadds { get; set; }

        DbSet<BkCrim> BkCrims { get; set; }

        DbSet<BkDlxrq> BkDlxrqs { get; set; }

        DbSet<BkEduc> BkEducs { get; set; }

        DbSet<BkEmpl> BkEmpls { get; set; }

        DbSet<BkIcmrq> BkIcmrqs { get; set; }

        DbSet<BkMlost> BkMlosts { get; set; }

        DbSet<BkMvr> BkMvrs { get; set; }

        DbSet<BkPlic> BkPlics { get; set; }

        DbSet<BkRefrq> BkRefrqs { get; set; }

        DbSet<BkWkcmp> BkWkcmps { get; set; }

        DbSet<Blcdcom2> Blcdcom2s { get; set; }

        DbSet<Blcdcomp> Blcdcomps { get; set; }

        DbSet<Blcdjur> Blcdjurs { get; set; }

        DbSet<Cctran> Cctrans { get; set; }

        DbSet<CeclDrv> CeclDrvs { get; set; }

        DbSet<Chnatstu> Chnatstus { get; set; }

        DbSet<Chwrknbr> Chwrknbrs { get; set; }

        DbSet<Cinst> Cinsts { get; set; }

        DbSet<Cligroup> Cligroups { get; set; }

        DbSet<Clistate> Clistates { get; set; }

        DbSet<CltrSt> CltrSts { get; set; }

        DbSet<CompDpo> CompDpos { get; set; }

        DbSet<CompEcl> CompEcls { get; set; }

        DbSet<Company> Companies { get; set; }

        DbSet<Company2> Company2s { get; set; }

        DbSet<ConRecv> ConRecvs { get; set; }

        DbSet<Conbatch> Conbatches { get; set; }

        DbSet<Conmatch> Conmatches { get; set; }

        DbSet<Conremot> Conremots { get; set; }

        DbSet<Conuser> Conusers { get; set; }

        DbSet<Convctrm> Convctrms { get; set; }

        DbSet<County> Counties { get; set; }

        DbSet<CrimTat> CrimTats { get; set; }

        DbSet<Crimlink> Crimlinks { get; set; }

        DbSet<CtyList> CtyLists { get; set; }

        DbSet<Default> Defaults { get; set; }

        DbSet<Defdiscr> Defdiscrs { get; set; }

        DbSet<Defstate> Defstates { get; set; }

        DbSet<DelPf> DelPfs { get; set; }

        DbSet<Deltrack> Deltracks { get; set; }

        DbSet<Dempqlst> Dempqlsts { get; set; }

        DbSet<Dempqmst> Dempqmsts { get; set; }

        DbSet<Denirea> Denireas { get; set; }

        DbSet<Dict2> Dict2s { get; set; }

        DbSet<DisclSt> DisclSts { get; set; }

        DbSet<Dlcstate> Dlcstates { get; set; }

        DbSet<Dlformat> Dlformats { get; set; }

        DbSet<Dlxakabill> Dlxakabills { get; set; }

        DbSet<DlxreqQ> DlxreqQs { get; set; }

        DbSet<Dragndrop> Dragndrops { get; set; }

        DbSet<Drugpkg> Drugpkgs { get; set; }

        DbSet<EclDeleted> EclDeleteds { get; set; }

        DbSet<Eclresult> Eclresults { get; set; }

        DbSet<Ecltacct> Ecltaccts { get; set; }

        DbSet<Ecltbill> Ecltbills { get; set; }

        DbSet<Eclthelp> Eclthelps { get; set; }

        DbSet<Ecltmsg> Ecltmsgs { get; set; }

        DbSet<Ecltrack> Ecltracks { get; set; }

        DbSet<Ecltrpt> Ecltrpts { get; set; }

        DbSet<EmailQ> EmailQs { get; set; }

        DbSet<Emailatc> Emailatcs { get; set; }

        DbSet<Emailbil> Emailbils { get; set; }

        DbSet<Emailbld> Emailblds { get; set; }

        DbSet<Emplook> Emplooks { get; set; }

        DbSet<Extracst> Extracsts { get; set; }

        DbSet<Farchive> Farchives { get; set; }

        DbSet<Faxattch> Faxattches { get; set; }

        DbSet<Faxqueue> Faxqueues { get; set; }

        DbSet<Fi9reqQ> Fi9reqQs { get; set; }

        DbSet<Formi9Not> Formi9Nots { get; set; }

        DbSet<Frschool> Frschools { get; set; }

        DbSet<Frsdatum> Frsdata { get; set; }

        DbSet<Frsquery> Frsqueries { get; set; }

        DbSet<Frstable> Frstables { get; set; }

        DbSet<FrsupdQ> FrsupdQs { get; set; }

        DbSet<Gistracking> Gistrackings { get; set; }

        DbSet<Global> Globals { get; set; }

        DbSet<Globals2> Globals2s { get; set; }

        DbSet<Globkey> Globkeys { get; set; }

        DbSet<Holiday> Holidays { get; set; }

        DbSet<I3scrnQ> I3scrnQs { get; set; }

        DbSet<IcR> IcRs { get; set; }

        DbSet<IccodesCa> IccodesCas { get; set; }

        DbSet<IcmreqQ> IcmreqQs { get; set; }

        DbSet<IcrreqQ> IcrreqQs { get; set; }

        DbSet<IhrDlx> IhrDlxes { get; set; }

        DbSet<IhrIcm> IhrIcms { get; set; }

        DbSet<IhrMwork> IhrMworks { get; set; }

        DbSet<IhrWork> IhrWorks { get; set; }

        DbSet<InformdatareqQ> InformdatareqQs { get; set; }

        DbSet<Inhouscnty> Inhouscnties { get; set; }

        DbSet<International> Internationals { get; set; }

        DbSet<IntreqQ> IntreqQs { get; set; }

        DbSet<InvDtl> InvDtls { get; set; }

        DbSet<InvPmt> InvPmts { get; set; }

        DbSet<Invoice> Invoices { get; set; }

        DbSet<Lpbacku2> Lpbacku2s { get; set; }

        DbSet<Lpbacku3> Lpbacku3s { get; set; }

        DbSet<Lpbacku4> Lpbacku4s { get; set; }

        DbSet<Lpbackup> Lpbackups { get; set; }

        DbSet<Lpmaster> Lpmasters { get; set; }

        DbSet<LpmasterAudit> LpmasterAudits { get; set; }

        DbSet<Ltrtrack> Ltrtracks { get; set; }

        DbSet<Lucharge> Lucharges { get; set; }

        DbSet<Lucivtyp> Lucivtyps { get; set; }

        DbSet<Lucourt> Lucourts { get; set; }

        DbSet<Ludisp> Ludisps { get; set; }

        DbSet<LxAuth> LxAuths { get; set; }

        DbSet<LxError> LxErrors { get; set; }

        DbSet<LxfrErr> LxfrErrs { get; set; }

        DbSet<Lxreqbtc> Lxreqbtcs { get; set; }

        DbSet<Lxrespar> Lxrespars { get; set; }

        DbSet<Mgrmsdel> Mgrmsdels { get; set; }

        DbSet<Mgrmstpw> Mgrmstpws { get; set; }

        DbSet<NscreqQ> NscreqQs { get; set; }

        DbSet<Olserror> Olserrors { get; set; }

        DbSet<Othdlinx> Othdlinxes { get; set; }

        DbSet<Othstfrm> Othstfrms { get; set; }

        DbSet<Othstin> Othstins { get; set; }

        DbSet<Othstype> Othstypes { get; set; }

        DbSet<PfCrim> PfCrims { get; set; }

        DbSet<PfCrimNoIdentity> PfCrimNoIdentities { get; set; }

        DbSet<PfEduc> PfEducs { get; set; }

        DbSet<PfEducNoIdentity> PfEducNoIdentities { get; set; }

        DbSet<PfEmpl> PfEmpls { get; set; }

        DbSet<PfEmplNoIdentity> PfEmplNoIdentities { get; set; }

        DbSet<PfEmplq> PfEmplqs { get; set; }

        DbSet<PfMlost> PfMlosts { get; set; }

        DbSet<PfMlostNoIdentity> PfMlostNoIdentities { get; set; }

        DbSet<PfMvr> PfMvrs { get; set; }

        DbSet<PfMvrNoIdentity> PfMvrNoIdentities { get; set; }

        DbSet<PfPlic> PfPlics { get; set; }

        DbSet<PfPlicNoIdentity> PfPlicNoIdentities { get; set; }

        DbSet<PfWkcmp> PfWkcmps { get; set; }

        DbSet<PfWkcmpNoIdentity> PfWkcmpNoIdentities { get; set; }

        DbSet<Piitrack> Piitracks { get; set; }

        DbSet<Pinst> Pinsts { get; set; }

        DbSet<PrCrim> PrCrims { get; set; }

        DbSet<PrEduc> PrEducs { get; set; }

        DbSet<PrEmpl> PrEmpls { get; set; }

        DbSet<PrMlost> PrMlosts { get; set; }

        DbSet<PrMvr> PrMvrs { get; set; }

        DbSet<PrPlic> PrPlics { get; set; }

        DbSet<PrWkcmp> PrWkcmps { get; set; }

        DbSet<PstreqQ> PstreqQs { get; set; }

        DbSet<Recsubj> Recsubjs { get; set; }

        DbSet<RefreqQ> RefreqQs { get; set; }

        DbSet<Relform> Relforms { get; set; }

        DbSet<ReqMap> ReqMaps { get; set; }

        DbSet<ReqMap2> ReqMap2s { get; set; }

        DbSet<ReqScr> ReqScrs { get; set; }

        DbSet<ResBack> ResBacks { get; set; }

        DbSet<ResDistribute> ResDistributes { get; set; }

        DbSet<ResGeo> ResGeos { get; set; }

        DbSet<ResList> ResLists { get; set; }

        DbSet<ResSupp> ResSupps { get; set; }

        DbSet<ResSuppCost> ResSuppCosts { get; set; }

        DbSet<Resdarea> Resdareas { get; set; }

        DbSet<Reshist> Reshists { get; set; }

        DbSet<Resnoset> Resnosets { get; set; }

        DbSet<Retryrlk> Retryrlks { get; set; }

        DbSet<RptMap> RptMaps { get; set; }

        DbSet<RptScr> RptScrs { get; set; }

        DbSet<Salestax> Salestaxes { get; set; }

        DbSet<ScrType> ScrTypes { get; set; }

        DbSet<Sinst> Sinsts { get; set; }

        DbSet<Specinst> Specinsts { get; set; }

        DbSet<SqlBypass> SqlBypasses { get; set; }

        DbSet<Srcstate> Srcstates { get; set; }

        DbSet<SsConv> SsConvs { get; set; }

        DbSet<State> States { get; set; }

        DbSet<Stibatch> Stibatches { get; set; }

        DbSet<Stihistory> Stihistories { get; set; }

        DbSet<StireqQ> StireqQs { get; set; }

        DbSet<Subattch> Subattches { get; set; }

        DbSet<Supprtkt> Supprtkts { get; set; }

        DbSet<TdrreqQ> TdrreqQs { get; set; }

        DbSet<Trakfield> Trakfields { get; set; }

        DbSet<Trksetchg> Trksetchgs { get; set; }

        DbSet<TudrTag> TudrTags { get; set; }

        DbSet<Tudrcli> Tudrclis { get; set; }

        DbSet<Tudrcode> Tudrcodes { get; set; }

        DbSet<Tudrercod> Tudrercods { get; set; }

        DbSet<Tudrglob> Tudrglobs { get; set; }

        DbSet<Tudrimport> Tudrimports { get; set; }

        DbSet<Tudrmonitr> Tudrmonitrs { get; set; }

        DbSet<Tudrstate> Tudrstates { get; set; }

        DbSet<UsedFile> UsedFiles { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<Userdic> Userdics { get; set; }

        DbSet<Vcancel> Vcancels { get; set; }

        DbSet<Vmtchlog> Vmtchlogs { get; set; }

        DbSet<Vnarchiv> Vnarchivs { get; set; }

        DbSet<Vnattach> Vnattaches { get; set; }

        DbSet<Vnorder> Vnorders { get; set; }

        DbSet<Vntadmin> Vntadmins { get; set; }

        DbSet<Vntrack> Vntracks { get; set; }

        DbSet<WarchDeleted> WarchDeleteds { get; set; }

        DbSet<Webadmin> Webadmins { get; set; }

        DbSet<Webattch> Webattches { get; set; }

        DbSet<Webccset> Webccsets { get; set; }

        DbSet<Webcctrl> Webcctrls { get; set; }

        DbSet<Webform> Webforms { get; set; }

        DbSet<Webgroup> Webgroups { get; set; }

        DbSet<Webhisti> Webhistis { get; set; }

        DbSet<Webhisto> Webhistos { get; set; }

        DbSet<Webilpkg> Webilpkgs { get; set; }

        DbSet<Webready> Webreadies { get; set; }

        DbSet<Websetup> Websetups { get; set; }

        DbSet<Webxmldu> Webxmldus { get; set; }

        DbSet<Wfjready> Wfjreadies { get; set; }

        DbSet<WknreqQ> WknreqQs { get; set; }

        DbSet<Wmstrgrp> Wmstrgrps { get; set; }

        DbSet<Wrgready> Wrgreadies { get; set; }

        DbSet<Wsignup> Wsignups { get; set; }

        DbSet<Wupdflag> Wupdflags { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        Task AddAsync<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Remove<T>(T entity) where T : class;
    }
}
