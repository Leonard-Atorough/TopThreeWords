using NUnit.Framework;
using TopThreeWords;

namespace TopThreeWords.Tests
{
    public class ChallengeTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void ThisStringIsVeryMessy()
        {
            var result = Kata.TopThreeWords.FindTopThreeWords("ob'Wo_uEqFTnVK ob'Wo bzYS ewyEXFjCHu/ewyEXFjCHu bzYS-jHfHpUGCTf,ob'Wo TSdk Ukqq'hwx Cezsrd'x_uEqFTnVK.fFPIcBg jHfHpUGCTf" +
                " UtzVubcgme fFPIcBg_UtzVubcgme uEqFTnVK!UtzVubcgme/ob'Wo?fFPIcBg uEqFTnVK hHdmfPe bzYS fFPIcBg_bzYS yLFbcLLG?Ukqq'hwx!bzYS/ob'Wo TSdk.lfv TSdk UtzVubcgme fFPIcBg-" +
                "JtmKlciEX UtzVubcgme fFPIcBg fFPIcBg.UtzVubcgme jHfHpUGCTf ob'Wo!bzYS;lfv:bzYS hHdmfPe JuWrnkTr,TSdk Cezsrd'x!fFPIcBg/Cezsrd'x?fFPIcBg fFPIcBg ob'Wo bzYS icNKazGI bzYS " +
                "uEqFTnVK fFPIcBg.Cezsrd'x hHdmfPe_UtzVubcgme-ewyEXFjCHu jHfHpUGCTf:rfMbSoYKO jHfHpUGCTf?UtzVubcgme hHdmfPe/ob'Wo TSdk;fFPIcBg ewyEXFjCHu?UtzVubcgme:ob'Wo/" +
                "uEqFTnVK:ewyEXFjCHu Ukqq'hwx:jHfHpUGCTf?bzYS:hHdmfPe.hHdmfPe uEqFTnVK.uEqFTnVK.TSdk ewyEXFjCHu fFPIcBg Ukqq'hwx!bzYS?TSdk;ewyEXFjCHu rfMbSoYKO UtzVubcgme/UtzVubcgme?" +
                "Ukqq'hwx rfMbSoYKO jHfHpUGCTf fFPIcBg jHfHpUGCTf hHdmfPe ewyEXFjCHu UtzVubcgme,ewyEXFjCHu UtzVubcgme ob'Wo,uEqFTnVK hHdmfPe hHdmfPe?rfMbSoYKO Cezsrd'x.JuWrnkTr!bzYS;bzYS-" +
                "lfv:uEqFTnVK fFPIcBg rfMbSoYKO:ewyEXFjCHu UtzVubcgme hHdmfPe-JtmKlciEX_bzYS-Ukqq'hwx Cezsrd'x?fFPIcBg Ukqq'hwx jHfHpUGCTf?ob'Wo TSdk:rfMbSoYKO:rfMbSoYKO;ob'Wo " +
                "uEqFTnVK:lfv TSdk rfMbSoYKO ob'Wo;ob'Wo ob'Wo fFPIcBg!rfMbSoYKO?lfv_UtzVubcgme.ewyEXFjCHu fFPIcBg fFPIcBg,bzYS ob'Wo_TSdk Ukqq'hwx/Ukqq'hwx rfMbSoYKO TSdk jHfHpUGCTf " +
                "fFPIcBg rfMbSoYKO.JtmKlciEX bzYS rfMbSoYKO lfv?rfMbSoYKO UtzVubcgme rfMbSoYKO UtzVubcgme:ob'Wo fFPIcBg hHdmfPe UtzVubcgme rfMbSoYKO/UtzVubcgme;Cezsrd'x rfMbSoYKO?" +
                "UtzVubcgme lfv lfv rfMbSoYKO rfMbSoYKO/Ukqq'hwx JtmKlciEX/uEqFTnVK uEqFTnVK jHfHpUGCTf uEqFTnVK.bzYS_fFPIcBg Ukqq'hwx,ob'Wo fFPIcBg:rfMbSoYKO UtzVubcgme?uEqFTnVK " +
                "rfMbSoYKO rfMbSoYKO fFPIcBg bzYS:fFPIcBg Cezsrd'x ob'Wo rfMbSoYKO?UtzVubcgme.ob'Wo UtzVubcgme Cezsrd'x;ob'Wo,JtmKlciEX fFPIcBg;ob'Wo;ewyEXFjCHu lfv jHfHpUGCTf,jHfHpUGCTf " +
                "Ukqq'hwx.Ukqq'hwx ewyEXFjCHu hHdmfPe;hHdmfPe bzYS_bzYS_Cezsrd'x Ukqq'hwx/Ukqq'hwx UtzVubcgme ob'Wo/UtzVubcgme ewyEXFjCHu/rfMbSoYKO uEqFTnVK-icNKazGI Ukqq'hwx,rfMbSoYKO " +
                "ob'Wo/bzYS/rfMbSoYKO,JuWrnkTr uEqFTnVK-ewyEXFjCHu JtmKlciEX lfv,lfv jHfHpUGCTf-bzYS!fFPIcBg Ukqq'hwx,TSdk;UtzVubcgme_ewyEXFjCHu?uEqFTnVK jHfHpUGCTf.uEqFTnVK_hHdmfPe/" +
                "TSdk;TSdk,rfMbSoYKO ewyEXFjCHu TSdk Ukqq'hwx_bzYS!jHfHpUGCTf fFPIcBg JtmKlciEX?hHdmfPe ewyEXFjCHu ob'Wo!ob'Wo bzYS hHdmfPe JuWrnkTr:ewyEXFjCHu uEqFTnVK?" +
                "bzYS_bzYS;UtzVubcgme:JuWrnkTr Ukqq'hwx TSdk;UtzVubcgme.Ukqq'hwx jHfHpUGCTf-ewyEXFjCHu bzYS/bzYS DkfcbkHr iiKrNCVNq DkfcbkHr Pglht.GIcHct - DkfcbkHr VlZkmnXtRa_Pglht " +
                "jUGRlr / BpMus:tDjdedYtCF.asT / DkfcbkHr UCiYK_GIcHct_Pglht GIcHct: DkfcbkHr UCiYK tDjdedYtCF DkfcbkHr BpMus: UCiYK.Pglht_tDjdedYtCF BpMus, Pglht!jUGRlr / asT jUGRlr " +
                "DkfcbkHr - KnqFPrNaE:tKIA asT_jUGRlr / UCiYK aixbdI, aixbdI KnqFPrNaE: DkfcbkHr, KnqFPrNaE gsZhbx BpMus - KnqFPrNaE; BpMus UCiYK/ GIcHct:asT.UCiYK_tKIA? GIcHct DkfcbkHr " +
                "iiKrNCVNq BpMus,UCiYK; UCiYK asT.jUGRlr BpMus.UCiYK aixbdI DkfcbkHr: tDjdedYtCF!VlZkmnXtRa / DkfcbkHr DkfcbkHr WdrEy-jUGRlr_BpMus,BpMus aixbdI BpMus,Pglht,jUGRlr " +
                "BpMus_hDTkP.KnqFPrNaE KnqFPrNaE UCiYK WdrEy?hDTkP asT UCiYK!KnqFPrNaE jUGRlr Pglht BpMus?UCiYK_UCiYK.KnqFPrNaE UCiYK DkfcbkHr_Pglht tDjdedYtCF/ KnqFPrNaE UCiYK? gsZhbx " +
                "UCiYK jUGRlr/ BpMus BpMus!UCiYK iiKrNCVNq_UCiYK BpMus: DkfcbkHr tKIA BpMus / Pglht ? KnqFPrNaE UCiYK Pglht_jUGRlr GIcHct VlZkmnXtRa - asT.asT:UCiYK.asT.jUGRlr_BpMus " +
                "jUGRlr BpMus!DkfcbkHr KnqFPrNaE hDTkP_DkfcbkHr aixbdI-sxFzro tDjdedYtCF WdrEy!VlZkmnXtRa,tKIA DkfcbkHr; BpMus? BpMus Pglht - KnqFPrNaE asT Pglht:BpMus WdrEy, BpMus WdrEy " +
                "UCiYK gsZhbx / UCiYK Pglht? DkfcbkHr:BpMus WdrEy Pglht_sxFzro GIcHct; UCiYK iiKrNCVNq Pglht: DkfcbkHr.GIcHct:iiKrNCVNq / WdrEy KnqFPrNaE iiKrNCVNq?DkfcbkHr_asT? asT; " +
                "VlZkmnXtRa asT-DkfcbkHr asT KnqFPrNaE:tDjdedYtCF KnqFPrNaE asT? WdrEy, GIcHct/ KnqFPrNaE DkfcbkHr / aixbdI!gsZhbx tKIA asT UCiYK:BpMus UCiYK!BpMus!DkfcbkHr - KnqFPrNaE " +
                "WdrEy tKIA DkfcbkHr; aixbdI UCiYK.KnqFPrNaE_tKIA jUGRlr!BpMus asT DkfcbkHr sxFzro - Pglht - asT DkfcbkHr UCiYK DkfcbkHr: DkfcbkHr!jUGRlr - tDjdedYtCF hDTkP BpMus " +
                "BpMus_UCiYK vUMTWkvwi?UCiYK? tDjdedYtCF!tKIA.aixbdI:WdrEy? WdrEy tKIA_jUGRlr WdrEy, UCiYK:DkfcbkHr sxFzro_tKIA:Pglht tDjdedYtCF.jgcEjVIIf KkLyXm jgcEjVIIf XzKM_asB asB / " +
                "YXATtSl YLThxvVXM asB; cZIGOkZIsg.asB XzKM.SQn XzKM!OLjOGD.cZIGOkZIsg pkWJN pkWJN KkLyXm: asB RtzUZTtl!asB ? OLjOGD.XzKM YLThxvVXM cZIGOkZIsg cZIGOkZIsg SQn JLXkfr_KkLyXm" +
                " KkLyXm.JLXkfr XzKM, cZIGOkZIsg SQn / cZIGOkZIsg - cZIGOkZIsg XzKM; KkLyXm - KkLyXm,hicekboerc? jgcEjVIIf_XzKM RtzUZTtl YLThxvVXM RtzUZTtl pkWJN; XzKM KkLyXm YLThxvVXM " +
                "hicekboerc XzKM asB hicekboerc? YXATtSl SQn? KkLyXm, pkWJN!KkLyXm YLThxvVXM YLThxvVXM?YLThxvVXM OLjOGD YXATtSl OLjOGD XzKM.jgcEjVIIf_YLThxvVXM asB YLThxvVXM - YLThxvVXM " +
                "SQn_JLXkfr; RtzUZTtl SQn-SQn OLjOGD.asB.XzKM cZIGOkZIsg KkLyXm pkWJN.hicekboerc cZIGOkZIsg KkLyXm.cZIGOkZIsg JLXkfr!RtzUZTtl:OLjOGD_YXATtSl: JLXkfr SQn hicekboerc " +
                "hicekboerc:KkLyXm YXATtSl XzKM_YXATtSl.hicekboerc!YLThxvVXM KkLyXm, OLjOGD asB JLXkfr YXATtSl,SQn - XzKM OLjOGD? pkWJN hicekboerc,JLXkfr YXATtSl:YLThxvVXM? " +
                "cZIGOkZIsg:YXATtSl - YXATtSl_YXATtSl - KkLyXm YLThxvVXM_OLjOGD.pkWJN_YLThxvVXM XzKM XzKM: YXATtSl YLThxvVXM, OLjOGD/ cZIGOkZIsg YXATtSl XzKM YLThxvVXM - YLThxvVXM,YXATtSl" +
                " - asB KkLyXm? cZIGOkZIsg SQn - YXATtSl asB,YLThxvVXM!KkLyXm,KkLyXm SQn YLThxvVXM cZIGOkZIsg KkLyXm.OLjOGD SQn asB / YXATtSl YLThxvVXM? cZIGOkZIsg cZIGOkZIsg YLThxvVXM " +
                "SQn JLXkfr RtzUZTtl_OLjOGD JLXkfr.XzKM_XzKM YXATtSl jgcEjVIIf asB:KkLyXm KkLyXm cZIGOkZIsg JLXkfr OLjOGD XzKM/ hicekboerc OLjOGD,XzKM / SQn / cZIGOkZIsg pkWJN KkLyXm; " +
                "OLjOGD KkLyXm?XzKM hicekboerc!YXATtSl YLThxvVXM OLjOGD.XzKM SQn SQn!YLThxvVXM YXATtSl, cZIGOkZIsg, JLXkfr OLjOGD.YXATtSl; YLThxvVXM: cZIGOkZIsg? asB-JLXkfr!" +
                "YLThxvVXM.JLXkfr - YLThxvVXM; YLThxvVXM YLThxvVXM YXATtSl cZIGOkZIsg/ SQn_KkLyXm YLThxvVXM SQn_YXATtSl cZIGOkZIsg KkLyXm YLThxvVXM; cZIGOkZIsg OLjOGD_XzKM.RtzUZTtl_OLjOGD" +
                " XzKM SQn KkLyXm?XzKM - hicekboerc RtzUZTtl SQnvIyRm vIyRm vIyRmfHLPuDO.bfzMzFr fHLPuDO fHLPuDO bfzMzFr dQRHG bfzMzFr bfzMzFr fHLPuDO bfzMzFr dQRHG dQRHG bfzMzFr fHLPuDO " +
                "bfzMzFr bfzMzFr.dQRHG.bfzMzFr.fHLPuDO dQRHG bfzMzFr.dQRHG dQRHG dQRHG.dQRHG bfzMzFr dQRHG dQRHG dQRHG dQRHG_fHLPuDO bfzMzFr fHLPuDO; dQRHG fHLPuDO.fHLPuDO!bfzMzFr fHLPuDO" +
                " fHLPuDO fHLPuDO bfzMzFr dQRHG; dQRHG.fHLPuDO fHLPuDO?dQRHG: fHLPuDO fHLPuDO; fHLPuDO bfzMzFr!fHLPuDO ? fHLPuDO!bfzMzFr dQRHG!dQRHG bfzMzFr:bfzMzFr bfzMzFr " +
                "bfzMzFr_bfzMzFr - fHLPuDO fHLPuDO dQRHG?dQRHG_bfzMzFr dQRHG/ dQRHG fHLPuDO,fHLPuDO bfzMzFr; fHLPuDO!dQRHG,dQRHG bfzMzFr fHLPuDO? dQRHG dQRHG fHLPuDO fHLPuDO: bfzMzFr - " +
                "bfzMzFrfeXEbGj? aqYCyCO RcsXLRNWj_FXTSp qTOL; FXTSp? FXTSp?qTOL ZFcEnPG_zhdprzkpp RcsXLRNWj: BfGwRBP - OFMl; BfGwRBP_feXEbGj_IQBSyz OFMl RcsXLRNWj RcsXLRNWj/ feXEbGj " +
                "pvdoL'yik_ZFcEnPG_feXEbGj IQBSyz,feXEbGj bavLA RcsXLRNWj_ZFcEnPG BfGwRBP aqYCyCO ISsek feXEbGj!bavLA.FXTSp:ZFcEnPG pvdoL'yik; bavLA_ISsek aqYCyCO IQBSyz aqYCyCO/ " +
                "RcsXLRNWj.aqYCyCO ISsek ZFcEnPG qTOL? bavLA FXTSp - IQBSyz:ISsek,IQBSyz / IQBSyz; BfGwRBP.RcsXLRNWj:FXTSp / RcsXLRNWj RcsXLRNWj qTOL/ IQBSyz ? bavLA IQBSyz; aqYCyCO_FXTSp" +
                " aqYCyCO_BfGwRBP!IQBSyz!bavLA feXEbGj_RcsXLRNWj-pvdoL'yik:aqYCyCO qTOL;RcsXLRNWj!FXTSp IQBSyz-bavLA zhdprzkpp bavLA,bavLA OFMl/qTOL_RcsXLRNWj-RcsXLRNWj RcsXLRNWj;IQBSyz/" +
                "RcsXLRNWj aqYCyCO?bavLA zhdprzkpp RcsXLRNWj BfGwRBP aqYCyCO FXTSp.BfGwRBP aqYCyCO-IQBSyz ZFcEnPG ISsek pvdoL'yik - ZFcEnPG ? bavLA / bavLA_BfGwRBP feXEbGj ? FXTSp " +
                "aqYCyCO!BfGwRBP!ZFcEnPG aqYCyCO bavLA? RcsXLRNWj?BfGwRBP.RcsXLRNWj RcsXLRNWj IQBSyz ZFcEnPG.OFMl_FXTSp? IQBSyz qTOL; ZFcEnPG qTOL, IQBSyz pvdoL'yik feXEbGj bavLA " +
                "RcsXLRNWj-RcsXLRNWj FXTSp aqYCyCO;aqYCyCO aqYCyCO/RcsXLRNWj ISsek/bavLA/feXEbGj aqYCyCO-IQBSyz:feXEbGj feXEbGj ZFcEnPG.OFMl/OFMl aqYCyCO?ISsek:bavLA?ZFcEnPG BfGwRBP " +
                "aqYCyCO ISsek feXEbGj,bavLA ZFcEnPG feXEbGj IQBSyz-ISsek aqYCyCO-qTOL OFMl_RcsXLRNWj:bavLA aqYCyCO-BfGwRBP!zhdprzkpp_aqYCyCO;FXTSp,RcsXLRNWj pvdoL'yik_zhdprzkpp " +
                "aqYCyCO:FXTSp ZFcEnPG qTOL / qTOL_IQBSyz; OFMl ISsek RcsXLRNWj aqYCyCO RcsXLRNWj IQBSyz OFMl - qTOL_bavLA ? bavLA.BfGwRBP IQBSyz /                                     " +
                "L'OeAcDgGi It'uHI XfIBCAu fiUDT fiUDT XfIBCAu fiUDT fiUDT: fiUDT / It'uHI?fiUDT XfIBCAu,bZdzoL XfIBCAu?L'OeAcDgGi fiUDT XfIBCAu / bZdzoL IeRgBsV_It'uHI zXBFG " +
                "L'OeAcDgGi.zXBFG_XfIBCAu - L'OeAcDgGi.zXBFG It'uHI_XfIBCAu zXBFG fiUDT fiUDT fiUDT fiUDT IeRgBsV IeRgBsV bZdzoL / bZdzoL_fiUDT.zXBFG zXBFG IeRgBsV zXBFG: bZdzoL!CwSGT / " +
                "L'OeAcDgGi zXBFG It'uHI / It'uHI L'OeAcDgGi IeRgBsV bZdzoL bZdzoL-zXBFG_zXBFG bZdzoL zXBFG?It'uHI;zXBFG It'uHI It'uHI,fiUDT_bZdzoL,It'uHI IeRgBsV-fiUDT XfIBCAu bZdzoL " +
                "zXBFG zXBFG-fiUDT zXBFG: L'OeAcDgGi IeRgBsV!CwSGT fiUDT IeRgBsV It'uHI / CwSGT.fiUDT,fiUDT.It'uHI IeRgBsV/zXBFG,L'OeAcDgGi,IeRgBsV? It'uHI:zXBFG;fiUDT_IeRgBsV;zXBFG " +
                "zXBFG_zXBFG It'uHI.It'uHI fiUDT/zXBFG;IeRgBsV?XfIBCAu_XfIBCAu_bZdzoL/bZdzoL?bZdzoL:bZdzoL.zXBFG It'uHI.IeRgBsV fiUDT fiUDT CwSGT, It'uHI bZdzoL fiUDT CwSGT;IeRgBsV.It'uHI" +
                " - fiUDT bZdzoL XfIBCAu!IeRgBsV It'uHI,IeRgBsV;bZdzoL_fiUDT CwSGT bZdzoL fiUDT XfIBCAu/IeRgBsV XfIBCAu CwSGT fiUDT?L'OeAcDgGi? XfIBCAu It'uHI;zXBFG bZdzoL_IeRgBsV " +
                "IeRgBsV;XfIBCAu,XfIBCAu/zXBFG?bZdzoL?It'uHI bZdzoL, zXBFG; It'uHI:zXBFG_It'uHI It'uHI IeRgBsV bZdzoL IeRgBsV?zXBFG-zXBFG?bZdzoL-bZdzoL?IeRgBsV rDB'ZDwh ntRGjzTsw " +
                "FwEUbFhsPj:rDB'ZDwh; NFHsnOABJ pkYITlW:rDB'ZDwh LThrj ntRGjzTsw?NFHsnOABJ!TItv,n'yWVxW ntRGjzTsw TItv TItv-ntRGjzTsw wCFfR isMGiPJDW NFHsnOABJ n'yWVxW " +
                "PRvhVLiwde;erX.isMGiPJDW PRvhVLiwde;rDB'ZDwh isMGiPJDW pkYITlW PRvhVLiwde hfFwVoStCH: PRvhVLiwde erX erX_wCFfR - PRvhVLiwde EbyvsHt.EbyvsHt isMGiPJDW isMGiPJDW!GAYqbWC " +
                "LThrj DmZ'ax isMGiPJDW NFHsnOABJ;NFHsnOABJ.pkYITlW GAYqbWC_rDB'ZDwh!TItv zjsDBY pkYITlW!TItv,NFHsnOABJ zjsDBY PRvhVLiwde: LThrj,erX / rDB'ZDwh_DmZ'ax EbyvsHt?isMGiPJDW " +
                "TItv rDB'ZDwh GAYqbWC LThrj n'yWVxW.ntRGjzTsw n'yWVxW zjsDBY?NFHsnOABJ?ntRGjzTsw n'yWVxW n'yWVxW TItv;NFHsnOABJ_OAHaR_DmZ'ax wCFfR DmZ'ax,TItv:GAYqbWC_n'yWVxW!" +
                "zjsDBY,LThrj wCFfR:isMGiPJDW,zjsDBY Boh'GDtMo NFHsnOABJ NFHsnOABJ NFHsnOABJ,NFHsnOABJ pkYITlW rDB'ZDwh NFHsnOABJ LThrj EbyvsHt PRvhVLiwde / GAYqbWC,DmZ'ax erX?LThrj " +
                "LThrj!ntRGjzTsw_NFHsnOABJ;TItv LThrj:NFHsnOABJ;rDB'ZDwh erX; pkYITlW hfFwVoStCH; ntRGjzTsw_n'yWVxW,LThrj erX.PRvhVLiwde/rDB'ZDwh!GAYqbWC; PRvhVLiwde pkYITlW " +
                "isMGiPJDW.LThrj / erX isMGiPJDW: DmZ'ax-GAYqbWC?PRvhVLiwde LThrj ntRGjzTsw rDB'ZDwh? n'yWVxW,rDB'ZDwh!zjsDBY: ntRGjzTsw; pkYITlW isMGiPJDW PRvhVLiwde - wCFfR:GAYqbWC " +
                "wCFfR, FwEUbFhsPj.LThrj,zjsDBY DmZ'ax DmZ'ax.TItv? erX zjsDBY? EbyvsHt n'yWVxW-GAYqbWC rDB'ZDwh: GAYqbWC? NFHsnOABJ-OAHaR,PRvhVLiwde DmZ'ax pkYITlW:n'yWVxW erX_rDB'ZDwh " +
                "pkYITlW,TItv erX;PRvhVLiwde.NFHsnOABJ.DmZ'ax; wCFfR,n'yWVxW,TItv wCFfR TItv;LThrj_TItv wCFfR!PRvhVLiwde_pkYITlW zjsDBY,DmZ'ax / ntRGjzTsw.zjsDBY!GAYqbWC? " +
                "rDB'ZDwh,rDB'ZDwh; zjsDBY.NFHsnOABJ DmZ'ax.EbyvsHt DmZ'ax pkYITlW ntRGjzTsw TItv PRvhVLiwde TItv TItv PRvhVLiwde; rDB'ZDwh-PRvhVLiwde,LThrj-LThrj!n'yWVxW!DmZ'ax?zjsDBY " +
                "isMGiPJDW TItv-erX DmZ'ax LThrj n'yWVxW pkYITlW/OAHaR-GAYqbWC;n'yWVxW; DmZ'ax?zjsDBY:pkYITlW_zjsDBY ntRGjzTsw.LThrj NFHsnOABJ LThrj GAYqbWC_pkYITlW:erX!erX PRvhVLiwde " +
                "EbyvsHt PRvhVLiwde,EbyvsHt.isMGiPJDW zjsDBY/EbyvsHt.EbyvsHt DmZ'ax: DmZ'ax n'yWVxW - TItv NFHsnOABJ: isMGiPJDW n'yWVxW EbyvsHt pkYITlW isMGiPJDW zjsDBY LThrj pkYITlW " +
                "NFHsnOABJ:LThrj.TItv:n'yWVxW / PRvhVLiwde pkYITlW - LThrj EbyvsHt NFHsnOABJ NFHsnOABJ_DmZ'ax rDB'ZDwh EbyvsHt hfFwVoStCH.PRvhVLiwde,TItv_LThrj - PRvhVLiwde:isMGiPJDW " +
                "wCFfR LThrj erX.DmZ'ax erX_EbyvsHt_hfFwVoStCH NFHsnOABJ:EbyvsHt LThrj PRvhVLiwde?pkYITlW TItv NFHsnOABJ DmZ'ax TItv_pkYITlW-LThrj_TItv PRvhVLiwde_n'yWVxW erX n'yWVxW - " +
                "LThrj n'yWVxW wCFfR rDB'ZDwh ntRGjzTsw.zjsDBY isMGiPJDW!zjsDBY n'yWVxW LThrj NFHsnOABJ rDB'ZDwh PRvhVLiwde:TItv zjsDBY EbyvsHt? zjsDBY.hfFwVoStCH,EbyvsHt " +
                "pkYITlW:PRvhVLiwde; zjsDBY.GAYqbWC? GAYqbWC_TItv-erX NFHsnOABJ GAYqbWC/ DmZ'ax EbyvsHt erX-n'yWVxW wCFfR; PRvhVLiwde - isMGiPJDW TItv n'yWVxW NFHsnOABJ " +
                "pkYITlW_nMtVct,nMtVct gzkEm_nMtVct nMtVct_gzkEm_nMtVct? gzkEm:gzkEm nMtVct?nMtVct gzkEm nMtVct gzkEm/ nMtVct gzkEm,nMtVct_OMGD'rP:nMtVct nMtVct gzkEm_gzkEm nMtVct " +
                "RDp'VymE yry;VTulHtE,nvdyqPaXoX nvdyqPaXoX rzRcFIUToq bNoMsW rzRcFIUToq;HsDBEGWrVA RJLqg RDp'VymE!xaWa bNoMsW, lXB EkQW'uavL!RJLqg HsDBEGWrVA HsDBEGWrVA!lXB lXB aYYY " +
                "xCwACIbpxG/tgqDZ'; RJLqg yry!odPx HsDBEGWrVA? VTulHtE xaWa!tgqDZ'/HsDBEGWrVA.lXB rzRcFIUToq RJLqg xCwACIbpxG bNoMsW nvdyqPaXoX rzRcFIUToq!dRU-dRU yry lXB/VTulHtE " +
                "VTulHtE;tgqDZ' nvdyqPaXoX bNoMsW xCwACIbpxG? VTulHtE:RJLqg vxroPOQteV nvdyqPaXoX; dRU dRU; nvdyqPaXoX odPx VTulHtE HsDBEGWrVA?dRU; VTulHtE " +
                "vxroPOQteV_nvdyqPaXoX:vxroPOQteV nvdyqPaXoX yry xCwACIbpxG:RJLqg,LBTxtQTX's xaWa VTulHtE lXB xaWa xaWa vxroPOQteV rzRcFIUToq/tgqDZ' - tgqDZ'-rzRcFIUToq nvdyqPaXoX!" +
                "tgqDZ',vxroPOQteV; RJLqg dRU xCwACIbpxG: HsDBEGWrVA; HsDBEGWrVA? yry:tgqDZ':RJLqg tgqDZ' dRU; xaWa odPx, HsDBEGWrVA xCwACIbpxG xCwACIbpxG?tgqDZ'_tgqDZ',xCwACIbpxG? " +
                "LBTxtQTX's.xaWa-nvdyqPaXoX lXB dRU.HsDBEGWrVA VTulHtE:rzRcFIUToq iFqektBA-xaWa:aYYY vxroPOQteV VTulHtE_lXB VTulHtE xaWa xCwACIbpxG HsDBEGWrVA_nvdyqPaXoX xCwACIbpxG " +
                "RDp'VymE LBTxtQTX's vxroPOQteV yry tgqDZ':VTulHtE: VTulHtE_xaWa bNoMsW LBTxtQTX's WmSteCyjUF lXB aYYY?HsDBEGWrVA.LBTxtQTX's VTulHtE bNoMsW.RDp'VymE RJLqg/HsDBEGWrVA_yry " +
                "RDp'VymE; xaWa xCwACIbpxG-yry VTulHtE - HsDBEGWrVA RJLqg_nvdyqPaXoX xCwACIbpxG?tgqDZ'?tgqDZ' dRU yry xCwACIbpxG.RJLqg VTulHtE:iFqektBA; VTulHtE xCwACIbpxG_iFqektBA " +
                "iFqektBA yry?vxroPOQteV bNoMsW tgqDZ'_tgqDZ',LBTxtQTX's,dRU!xCwACIbpxG,xaWa xaWa?tgqDZ'!tgqDZ' tgqDZ',rzRcFIUToq LBTxtQTX's/nvdyqPaXoX VTulHtE/odPx yry tgqDZ' yry bNoMsW," +
                " yry HsDBEGWrVA yry LBTxtQTX's lXB_tgqDZ' tgqDZ' VTulHtE VTulHtE HsDBEGWrVA:lXB LBTxtQTX's_xaWa_bNoMsW / yry - yry,VTulHtE aYYY lXB.tgqDZ' rzRcFIUToq?rzRcFIUToq:RDp'VymE " +
                "bNoMsW xCwACIbpxG bNoMsW vxroPOQteV_odPx RJLqg:xCwACIbpxG,VTulHtE iFqektBA.rzRcFIUToq? vxroPOQteV yry VTulHtE vxroPOQteV VTulHtE; vxroPOQteV: RJLqg!xCwACIbpxG / VTulHtE " +
                "VTulHtE; dRU,vxroPOQteV VTulHtE vxroPOQteV / VTulHtE,tgqDZ'/bNoMsW:nvdyqPaXoX:rzRcFIUToq RDp'VymE - yry / HsDBEGWrVA nvdyqPaXoX vxroPOQteV:xCwACIbpxG tgqDZ'/LBTxtQTX's " +
                "tgqDZ' nvdyqPaXoX nvdyqPaXoX/nvdyqPaXoX xCwACIbpxG,nvdyqPaXoX,tgqDZ' RJLqg.HsDBEGWrVA                                      UtOyYa!kiZaASO cbqsq_ICw'ZcN-" +
                "UtOyYa;dkPCyVl.ezETSAoaou sVKSnWcYh!LBAWhNNB kiZaASO cbqsq ICw'ZcN,LBAWhNNB uoy ICw'ZcN ICw'ZcN kiZaASO/ uoy UtOyYa ezETSAoaou-LBAWhNNB - LBAWhNNB:LBAWhNNB.kiZaASO / " +
                "dKssG_kiZaASO UtOyYa.dKssG / LBAWhNNB LBAWhNNB,sVKSnWcYh,ezETSAoaou - ezETSAoaou ? dkPCyVl UtOyYa cbqsq; UtOyYa ezETSAoaou ICw'ZcN UtOyYa;ICw'ZcN / sVKSnWcYh ICw'ZcN " +
                "ezETSAoaou LBAWhNNB ezETSAoaou sVKSnWcYh.kiZaASO;kiZaASO-LBAWhNNB kiZaASO sVKSnWcYh;sVKSnWcYh dKssG;kiZaASO?kiZaASO UtOyYa ICw'ZcN; cbqsq ICw'ZcN;UtOyYa cbqsq!" +
                "ezETSAoaou;sVKSnWcYh-ezETSAoaou UtOyYa ezETSAoaou ICw'ZcN,dKssG sVKSnWcYh LBAWhNNB cbqsq cbqsq,ezETSAoaou LBAWhNNB/ LBAWhNNB,uoy; LBAWhNNB!ezETSAoaou_LBAWhNNB " +
                "sVKSnWcYh:cbqsq dKssG cbqsq sVKSnWcYh sVKSnWcYh: UtOyYa uoy LBAWhNNB,uoy kiZaASO UtOyYa: UtOyYa_sVKSnWcYh!LBAWhNNB / LBAWhNNB uoy cbqsq sVKSnWcYh UtOyYa-ICw'ZcN sVKSnWcYh" +
                " kiZaASO kiZaASO-sVKSnWcYh kiZaASO sVKSnWcYh!sVKSnWcYh ezETSAoaou ezETSAoaou,ICw'ZcN_LBAWhNNB ezETSAoaou, ezETSAoaou cbqsq UtOyYa ezETSAoaou cbqsq_LBAWhNNB ezETSAoaou: " +
                "sVKSnWcYh sVKSnWcYh ICw'ZcN!kiZaASO:ezETSAoaou LBAWhNNB UtOyYa dkPCyVl UtOyYa dKssG LBAWhNNB,sVKSnWcYh uoy cbqsq sVKSnWcYh?cbqsq ezETSAoaou kiZaASO sVKSnWcYh-" +
                "UtOyYa;ICw'ZcN sVKSnWcYh kiZaASO uoy UtOyYa ICw'ZcN,sVKSnWcYh;cbqsq kiZaASO ezETSAoaou_kiZaASO?LBAWhNNB,uoy?ezETSAoaou sVKSnWcYh:kiZaASO LBAWhNNB ICw'ZcN kiZaASO " +
                "sVKSnWcYh / uoy,ICw'ZcN ICw'ZcN_uoy sVKSnWcYh_cbqsq?UtOyYa                                                               igt!igt igt / igt!igt!igt igt/ igt.igt igt; " +
                "igt_igt igt.igt: igt igt igt igt igt - igt igt igt igt -                                                                      cEbuOjV cEbuOjV - cEbuOjV cEbuOjV.cEbuOjV / " +
                "cEbuOjV - cEbuOjV.cEbuOjV cEbuOjV cEbuOjV cEbuOjV_cEbuOjV cEbuOjV!cEbuOjV cEbuOjV cEbuOjV cEbuOjV cEbuOjV cEbuOjV!cEbuOjV cEbuOjV?cEbuOjV cEbuOjV cEbuOjV? cEbuOjV/ " +
                "cEbuOjV ?                                                                         lvsyF ? lvsyF lvsyF; VkcRZilEsn,lvsyF_Iho jYwsl bjJZwzOQ DtO Iho,vxjBhbS - VkcRZilEsn " +
                "HjGZg'lj:eSVgDLY' vxjBhbS eSVgDLY' jYwsl lvsyF;Iho GECUCTgyd VkcRZilEsn eSVgDLY' jYwsl Iho/ eSVgDLY'.eSVgDLY' jYwsl DtO GECUCTgyd; jYwsl vYZ vYZ_bjJZwzOQ HjGZg'lj vYZ " +
                "NUhl:bjJZwzOQ:Iho:eSVgDLY' GECUCTgyd.bjJZwzOQ Ulrw/ VkcRZilEsn DtO / VkcRZilEsn DtO VkcRZilEsn NUhl NUhl DtO NUhl NUhl: NUhl!jYwsl lvsyF_eSVgDLY'!GECUCTgyd HjGZg'lj - " +
                "NUhl GECUCTgyd bjJZwzOQ GECUCTgyd - VkcRZilEsn jYwsl; vxjBhbS_bjJZwzOQ jYwsl NUhl,eSVgDLY' bjJZwzOQ,NUhl.lvsyF_bjJZwzOQ;bjJZwzOQ-VkcRZilEsn?jYwsl bjJZwzOQ GECUCTgyd " +
                "NUhl:NUhl!Iho-VkcRZilEsn?GECUCTgyd eSVgDLY'!HcxB vxjBhbS DtO_vxjBhbS vYZ vYZ Ulrw-eSVgDLY'_jYwsl.VkcRZilEsn Iho jYwsl jYwsl PyZVbs-Iho-Iho HjGZg'lj VkcRZilEsn " +
                "GECUCTgyd,lvsyF DtO!HcxB ? NUhl jYwsl vYZ jYwsl NUhl DtO Ulrw HcxB/ NUhl_NUhl:VkcRZilEsn GECUCTgyd.VkcRZilEsn.eSVgDLY' NUhl.Iho GECUCTgyd DtO!jYwsl?jYwsl DtO!eSVgDLY' " +
                "VkcRZilEsn / vxjBhbS vxjBhbS GECUCTgyd; GECUCTgyd Iho DtO.bjJZwzOQ!HcxB: PyZVbs,DtO Iho/ eSVgDLY',vxjBhbS DtO eSVgDLY'; jYwsl: DtO DtO.vxjBhbS Iho PyZVbs? HcxB VkcRZilEsn" +
                " bjJZwzOQ?vxjBhbS vYZ vxjBhbS? vxjBhbS VkcRZilEsn GECUCTgyd.VkcRZilEsn; DtO DtO bjJZwzOQ.eSVgDLY'_eSVgDLY'; bjJZwzOQ: Iho jYwsl?mFOjYhOQu: eSVgDLY'_vxjBhbS/jYwsl;jYwsl?" +
                "lvsyF:NUhl!mFOjYhOQu VkcRZilEsn NUhl!HjGZg'lj lvsyF lvsyF DtO.bjJZwzOQ NUhl, Ulrw:VkcRZilEsn: NUhl.NUhl / vxjBhbS jYwsl GECUCTgyd VkcRZilEsn eSVgDLY' lvsyF DtO;eSVgDLY' " +
                "Iho; Iho,NUhl.NUhl? GECUCTgyd VkcRZilEsn; PyZVbs.GECUCTgyd DtO bjJZwzOQ mFOjYhOQu eSVgDLY' HcxB DtO!GECUCTgyd vxjBhbS PyZVbs GECUCTgyd HcxB_HcxB.DtO vxjBhbS jYwsl PyZVbs " +
                "VkcRZilEsn/Ulrw?DtO GECUCTgyd bjJZwzOQ/lvsyF eSVgDLY',eSVgDLY'_VkcRZilEsn VkcRZilEsn VkcRZilEsn!jYwsl:AAL,Iho:vxjBhbS/jYwsl vYZ?lvsyF;NUhl!eSVgDLY' lvsyF; ijy GECUCTgyd?" +
                "PyZVbs HcxB; GECUCTgyd!eSVgDLY' eSVgDLY' HjGZg'lj:NUhl-lvsyF;Iho vYZ/vxjBhbS/NUhl PyZVbs NUhl DtO!HcxB;vxjBhbS NUhl_HjGZg'lj jYwsl!lvsyF vxjBhbS DtO; " +
                "HcxB_mFOjYhOQu_VkcRZilEsn vxjBhbS ijy VkcRZilEsn DtO?                                                                                                                     " +
                "  CvnlfClN!CvnlfClN!nfqWoQty CvnlfClN/ CvnlfClN!nfqWoQty CvnlfClN CvnlfClN CvnlfClN_nfqWoQty!CvnlfClN,CvnlfClN? CvnlfClN?CvnlfClN; nfqWoQty CvnlfClN CvnlfClN CvnlfClN " +
                "CvnlfClN CvnlfClN!nfqWoQty CvnlfClN CvnlfClN CvnlfClN -                                                                                                                   " +
                "       OsHbbLE / RcWoelPX ? FTWTJXrtc_RcWoelPX RcWoelPX wJlqHjp KHKnDgI wJlqHjp hDDFl RcWoelPX? nbMGYcsko-eZtHVoUooq_eZtHVoUooq RcWoelPX; eZtHVoUooq - agAfDL.agAfDL " +
                "FTWTJXrtc KHKnDgI RcWoelPX: FTWTJXrtc,hDDFl_UcG,agAfDL: eZRKAjvjp; KHKnDgI_hDDFl!eZtHVoUooq KHKnDgI:FTWTJXrtc_wJlqHjp KHKnDgI nbMGYcsko RcWoelPX KHKnDgI nbMGYcsko " +
                "dHdzKI / hDDFl KHKnDgI: nbMGYcsko wJlqHjp OsHbbLE eZtHVoUooq dHdzKI.dHdzKI eZtHVoUooq, SsUNE eZtHVoUooq eZtHVoUooq eZRKAjvjp OsHbbLE/ dHdzKI,SsUNE FTWTJXrtc " +
                "eZtHVoUooq_FTWTJXrtc? AkesvV nbMGYcsko agAfDL_SsUNE FTWTJXrtc hDDFl hDDFl: dHdzKI.KHKnDgI nbMGYcsko?nbMGYcsko nbMGYcsko FTWTJXrtc SsUNE wJlqHjp / KHKnDgI eZRKAjvjp; " +
                "FTWTJXrtc nbMGYcsko; nbMGYcsko eZRKAjvjp hDDFl agAfDL hDDFl: hDDFl KHKnDgI/ eZRKAjvjp ? nbMGYcsko eZtHVoUooq SsUNE - eZRKAjvjp hDDFl hDDFl_KHKnDgI SsUNE: RcWoelPX SsUNE " +
                "agAfDL nbMGYcsko.dHdzKI: agAfDL_SsUNE hDDFl, dHdzKI hDDFl: hDDFl? nbMGYcsko eZtHVoUooq hDDFl/ FTWTJXrtc ? agAfDL - KHKnDgI.eZRKAjvjp FTWTJXrtc KHKnDgI agAfDL wJlqHjp " +
                "wJlqHjp FTWTJXrtc_hDDFl!wJlqHjp!nbMGYcsko FTWTJXrtc hDDFl SsUNE/ agAfDL FTWTJXrtc? nbMGYcsko:eZRKAjvjp KHKnDgI RcWoelPX agAfDL RcWoelPX hDDFl/ SsUNE eZtHVoUooq / " +
                "RcWoelPX; SsUNE RcWoelPX dHdzKI agAfDL/ dHdzKI!FTWTJXrtc nbMGYcsko agAfDL: SsUNE wJlqHjp SsUNE wJlqHjp; eZtHVoUooq eZRKAjvjp eZtHVoUooq.hDDFl,hDDFl eZRKAjvjp!agAfDL - " +
                "agAfDL eZRKAjvjp SsUNE?wJlqHjp.KHKnDgI agAfDL?FTWTJXrtc dHdzKI; RcWoelPX.eZtHVoUooq agAfDL wJlqHjp agAfDL-nbMGYcsko agAfDL; KHKnDgI!eZtHVoUooq / RcWoelPX nbMGYcsko; " +
                "wJlqHjp,hDDFl.wJlqHjp agAfDL:KHKnDgI KHKnDgI agAfDL wJlqHjp.wJlqHjp KHKnDgI KHKnDgI dHdzKI:eZtHVoUooq hDDFl agAfDL FTWTJXrtc SsUNE - wJlqHjp wJlqHjp OsHbbLE KHKnDgI: " +
                "KHKnDgI hDDFl; wJlqHjp.KHKnDgI:AkesvV agAfDL, wJlqHjp?RcWoelPX,hDDFl: wJlqHjp: FTWTJXrtc - KHKnDgI; AkesvV / hDDFl FTWTJXrtc hDDFl hDDFl,UcG,RcWoelPX hDDFl FTWTJXrtc " +
                "agAfDL_eZRKAjvjp; FTWTJXrtc AkesvV agAfDL? eZRKAjvjp; wJlqHjp - hDDFl eZRKAjvjp KHKnDgI UcG,wJlqHjp,KHKnDgI dHdzKI_SsUNE wJlqHjp_AkesvV wJlqHjp, eZtHVoUooq.SsUNE KHKnDgI " +
                "AkesvV                                                                                                                                                                    " +
                "                              HdngKnXT, ArTd grPMg ArTd tyIBbvUc wQhJoHEjx.ArTd tyIBbvUc HdngKnXT.iOIuiEev tyIBbvUc/ iOIuiEev HdngKnXT.TsoanSAIW tyIBbvUc " +
                "tyIBbvUc,iOIuiEev iOIuiEev P'fhN/iOIuiEev TsoanSAIW ArTd grPMg,ArTd HdngKnXT!tyIBbvUc!ArTd P'fhN wQhJoHEjx wQhJoHEjx P'fhN TsoanSAIW;HdngKnXT TsoanSAIW-tyIBbvUc P'fhN " +
                "P'fhN tyIBbvUc!AHINb:iOIuiEev,ArTd AHINb ArTd tyIBbvUc iOIuiEev,HdngKnXT_AHINb P'fhN ArTd P'fhN wQhJoHEjx,wQhJoHEjx;ArTd TsoanSAIW-grPMg tyIBbvUc;HdngKnXT P'fhN P'fhN-" +
                "tyIBbvUc ArTd_grPMg iOIuiEev P'fhN ArTd tyIBbvUc HdngKnXT tyIBbvUc; P'fhN iOIuiEev HdngKnXT TsoanSAIW/TsoanSAIW,HdngKnXT_ArTd iOIuiEev-TsoanSAIW P'fhN tyIBbvUc-grPMg " +
                "HdngKnXT grPMg-AHINb_iOIuiEev,grPMg!tyIBbvUc TsoanSAIW AHINb P'fhN iOIuiEev iOIuiEev TsoanSAIW/AHINb:P'fhN: AHINb.P'fhN,TsoanSAIW wQhJoHEjx wQhJoHEjx.HdngKnXT:HdngKnXT " +
                "HdngKnXT:AHINb_P'fhN iOIuiEev?wQhJoHEjx P'fhN P'fhN iOIuiEev_grPMg, tyIBbvUc TsoanSAIW HdngKnXT, P'fhN_HdngKnXT grPMg;HdngKnXT HdngKnXT?ArTd;ArTd iOIuiEev;P'fhN P'fhN-" +
                "ArTd?iOIuiEev TsoanSAIW HdngKnXT?iOIuiEev tyIBbvUc_tyIBbvUc TsoanSAIW:TsoanSAIW P'fhN grPMg_tyIBbvUc TsoanSAIW - TsoanSAIW ? TsoanSAIW tyIBbvUc AHINb? tyIBbvUc:tyIBbvUc " +
                "wQhJoHEjx HdngKnXT TsoanSAIW:iOIuiEev!grPMg grPMg P'fhN P'fhN? tyIBbvUc-tyIBbvUc HdngKnXT HdngKnXT tyIBbvUc P'fhN P'fhN / HdngKnXT!iOIuiEev.AHINb AHINb " +
                "P'fhN,TsoanSAIW:TsoanSAIW!TsoanSAIW:tyIBbvUc_grPMg P'fhN ArTd iOIuiEev,ArTd? HdngKnXT P'fhN-TsoanSAIW?grPMg?iOIuiEev tyIBbvUc-HdngKnXT:iOIuiEev;TsoanSAIW;grPMg tyIBbvUc " +
                "wQhJoHEjx grPMg tyIBbvUc iOIuiEev!ArTd!AHINb?iOIuiEev P'fhN? TsoanSAIW grPMg,iOIuiEev HdngKnXT HdngKnXT? AHINb/ HdngKnXT_HdngKnXT TsoanSAIW_TsoanSAIW: grPMg_AHINb       " +
                "                                                                                                                                                                         " +
                "                                     zcWTSQtilE DayWQ; DayWQ DayWQ!zcWTSQtilE riOMBjWksN!zcWTSQtilE / CaM DAYl zcWTSQtilE, DayWQ PgUBpCZO BFAQ zcWTSQtilE DayWQ DAYl " +
                "riOMBjWksN zcWTSQtilE; BFAQ BFAQ DAYl? DayWQ:zcWTSQtilE_PgUBpCZO,riOMBjWksN DAYl DAYl? DAYl DAYl - BFAQ.yYjPXNUr zcWTSQtilE zcWTSQtilE-BFAQ,DAYl - zcWTSQtilE DAYl BFAQ " +
                "zcWTSQtilE_zcWTSQtilE - DayWQ BFAQ,DAYl zcWTSQtilE DAYl DayWQ BFAQ DayWQ_PgUBpCZO!DAYl / DAYl DayWQ_DayWQ; DAYl BFAQ DayWQ; zcWTSQtilE zcWTSQtilE BFAQ? BFAQ?" +
                "DayWQ,PgUBpCZO zcWTSQtilE noioaRm: zcWTSQtilE,DAYl DayWQ DayWQ DayWQ DayWQ DayWQ DayWQ_DayWQ / BFAQ BFAQ zcWTSQtilE DAYl; zcWTSQtilE PgUBpCZO DAYl zcWTSQtilE BFAQ / " +
                "DayWQ DAYl DAYl!DAYl / zcWTSQtilE zcWTSQtilE DAYl.auvOWnAh LXsLtidRaS vMcYJmYg? dAfGTXAF!EZFOKq ? auvOWnAh / LXsLtidRaS_KdBYJkvf KdBYJkvf!nT'RdNTdYz iqAFcuIQd;ltevFwhVZH" +
                " vMcYJmYg dAfGTXAF auvOWnAh LXsLtidRaS uDkJDGtT;uDkJDGtT KdBYJkvf vMcYJmYg/auvOWnAh/auvOWnAh auvOWnAh?LXsLtidRaS vMcYJmYg?dAfGTXAF FdCvp?FdCvp " +
                "auvOWnAh:KdBYJkvf;nT'RdNTdYz KdBYJkvf iqAFcuIQd vMcYJmYg dAfGTXAF.nT'RdNTdYz KdBYJkvf/vMcYJmYg FdCvp nT'RdNTdYz!KdBYJkvf KdBYJkvf FdCvp,auvOWnAh - KdBYJkvf " +
                "dAfGTXAF.ltevFwhVZH - auvOWnAh vMcYJmYg KdBYJkvf auvOWnAh uDkJDGtT FdCvp KdBYJkvf LXsLtidRaS ltevFwhVZH LXsLtidRaS dAfGTXAF LXsLtidRaS: KdBYJkvf vMcYJmYg auvOWnAh; " +
                "ltevFwhVZH_vMcYJmYg vMcYJmYg dAfGTXAF; nT'RdNTdYz ltevFwhVZH?dAfGTXAF-dAfGTXAF LXsLtidRaS dAfGTXAF dAfGTXAF;LXsLtidRaS-ltevFwhVZH!uDkJDGtT,auvOWnAh dAfGTXAF FdCvp FdCvp " +
                "auvOWnAh auvOWnAh vMcYJmYg LXsLtidRaS;nT'RdNTdYz,vMcYJmYg auvOWnAh KdBYJkvf ltevFwhVZH!vMcYJmYg auvOWnAh vMcYJmYg auvOWnAh dAfGTXAF dAfGTXAF FdCvp vMcYJmYg KdBYJkvf " +
                "LXsLtidRaS KdBYJkvf; iqAFcuIQd: auvOWnAh.dAfGTXAF FdCvp vMcYJmYg.vMcYJmYg LXsLtidRaS vMcYJmYg FdCvp/ ltevFwhVZH ? dAfGTXAF - uDkJDGtT vMcYJmYg dAfGTXAF_KdBYJkvf " +
                "LXsLtidRaS auvOWnAh KdBYJkvf FdCvp / vMcYJmYg / dAfGTXAF KdBYJkvf vMcYJmYg dAfGTXAF? LXsLtidRaS/ ltevFwhVZH ltevFwhVZH? dAfGTXAF_vMcYJmYg?vMcYJmYg_vMcYJmYg auvOWnAh; " +
                "dAfGTXAF!ltevFwhVZH / vMcYJmYg,nT'RdNTdYz KdBYJkvf auvOWnAh KdBYJkvf/KdBYJkvf KdBYJkvf KdBYJkvf LXsLtidRaS.KdBYJkvf vMcYJmYg/auvOWnAh.auvOWnAh ltevFwhVZH ltevFwhVZH " +
                "dAfGTXAF auvOWnAh:dAfGTXAF_dAfGTXAF nT'RdNTdYz LXsLtidRaS dAfGTXAF KdBYJkvf!auvOWnAh vMcYJmYg KdBYJkvf ltevFwhVZH_auvOWnAh / vMcYJmYg LXsLtidRaS / KdBYJkvf uDkJDGtT " +
                "vMcYJmYg-ltevFwhVZH dAfGTXAF ltevFwhVZH_dAfGTXAF, uDkJDGtT nT'RdNTdYz;jaOJSTvJ ZAxIFV EOrXaaev / jNyTQa; wEn!RMGBEeuXr,ybKmaWr - jaOJSTvJ jNyTQa ybKmaWr IeGMLXZxfS: " +
                "GeBNoGxFb: ybKmaWr GeBNoGxFb ybKmaWr RMGBEeuXr, CkU BTx BTx jNyTQa ybKmaWr GeBNoGxFb / ybKmaWr GeBNoGxFb: ybKmaWr? ybKmaWr GeBNoGxFb!IeGMLXZxfS,EOrXaaev? EOrXaaev " +
                "ZAxIFV? qTjsb'QWT ybKmaWr/RMGBEeuXr/IeGMLXZxfS ZAxIFV?RMGBEeuXr:ybKmaWr BTx jaOJSTvJ EOrXaaev/jaOJSTvJ_CkU.jaOJSTvJ_RMGBEeuXr jaOJSTvJ BTx_EOrXaaev!jaOJSTvJ EOrXaaev-" +
                "EOrXaaev;GeBNoGxFb.RMGBEeuXr_CkU ZAxIFV ybKmaWr,ZTbibfE jaOJSTvJ CkU.jNyTQa EOrXaaev EOrXaaev-jNyTQa:EOrXaaev,eBvVR!qTjsb'QWT!ZAxIFV - jNyTQa,EOrXaaev CkU GeBNoGxFb " +
                "jNyTQa-CkU IeGMLXZxfS RMGBEeuXr HdmmP; ZTbibfE.EOrXaaev.CkU RMGBEeuXr jNyTQa EOrXaaev HdmmP / qTjsb'QWT.eBvVR jaOJSTvJ;jNyTQa RMGBEeuXr EOrXaaev.AbNaUMl " +
                "AbNaUMl_AbNaUMl;CkU GeBNoGxFb_jNyTQa jNyTQa CkU:EOrXaaev/wEn;jNyTQa CkU ybKmaWr:CkU-CkU ZAxIFV;HdmmP/qTjsb'QWT ybKmaWr, wEn, ybKmaWr.HdmmP!RMGBEeuXr RMGBEeuXr?eBvVR " +
                "ZAxIFV; ZAxIFV jNyTQa qTjsb'QWT/jaOJSTvJ jaOJSTvJ jNyTQa_jaOJSTvJ ZAxIFV!wEn jaOJSTvJ?AbNaUMl RMGBEeuXr RMGBEeuXr " +
                "BTx;jNyTQa,EOrXaaev,jaOJSTvJ_jaOJSTvJ:GeBNoGxFb.GeBNoGxFb EOrXaaev jNyTQa-EOrXaaev BTx CkU jaOJSTvJ qTjsb'QWT wEn/ EOrXaaev jaOJSTvJ GeBNoGxFb RMGBEeuXr? BTx AbNaUMl " +
                "qTjsb'QWT ybKmaWr GeBNoGxFb:BTx-IeGMLXZxfS RMGBEeuXr ybKmaWr:IeGMLXZxfS/AbNaUMl/jNyTQa-GeBNoGxFb CkU;jaOJSTvJ LFvFDXHL jaOJSTvJ:ybKmaWr.RMGBEeuXr jaOJSTvJ GeBNoGxFb " +
                "HdmmP jNyTQa ybKmaWr/ybKmaWr!jNyTQa CkU/jNyTQa eBvVR CkU CkU AbNaUMl-EOrXaaev-jNyTQa/RMGBEeuXr RMGBEeuXr ybKmaWr-BTx AbNaUMl!CkU RMGBEeuXr RMGBEeuXr BTx RMGBEeuXr " +
                "jaOJSTvJ-jNyTQa ybKmaWr ybKmaWr AbNaUMl CkU jaOJSTvJ-eBvVR.jaOJSTvJ/BTx!RMGBEeuXr AbNaUMl BTx CkU ybKmaWr;jaOJSTvJ ZAxIFV?EOrXaaev EOrXaaev:GeBNoGxFb_jaOJSTvJ.DVgVFEbUBq" +
                " ZTbibfE.ybKmaWr!ybKmaWr/RMGBEeuXr ZAxIFV EOrXaaev/RMGBEeuXr IeGMLXZxfS-RMGBEeuXr GeBNoGxFb wEn?qTjsb'QWT!RMGBEeuXr; ZAxIFV!wEn - RMGBEeuXr eBvVR BTx.wEn jNyTQa ybKmaWr " +
                "ZAxIFV jNyTQa LFvFDXHL EOrXaaev.GeBNoGxFb AbNaUMl; ZAxIFV; jNyTQa_jaOJSTvJ.jaOJSTvJ EOrXaaev.GeBNoGxFb - jaOJSTvJ eBvVR jaOJSTvJ.jNyTQa? ybKmaWr.jaOJSTvJ                " +
                "                Yey Uld Qto/ Qto Yey RIv Yey oZdhHpM.Uld: Qto_Uld qDB:EpvtdL qDB.Yey / qDB - Uld qDB: oZdhHpM.EpvtdL VNNe RIv yiULFvCo Qto: Yey RIv/ Qto qDB RIv_Yey Yey:" +
                " RIv RIv cMK RIv?yiULFvCo Yey_Qto VNNe oZdhHpM yiULFvCo!Yey yiULFvCo VNNe; RIv yiULFvCo-qDB:oZdhHpM VNNe; VNNe yiULFvCo RIv Yey qDB: VNNe / yiULFvCo RIv; qDB_cMK; Yey " +
                "Yey Yey oZdhHpM?Yey_yiULFvCo yiULFvCo?VNNe.oZdhHpM_yiULFvCo:oZdhHpM.EpvtdL EpvtdL RIv / Yey.Yey Uld!qDB? qDB_RIv:yiULFvCo_Yey - Yey oZdhHpM / Yey yiULFvCo Yey Qto " +
                "Qto.RIv RIv yiULFvCo - VNNe oZdhHpM RIv:yiULFvCo_yiULFvCo.RIv yiULFvCo oZdhHpM yiULFvCo:Yey!qDB; RIv yiULFvCo VNNe RIv_Qto; yiULFvCo; VNNe qDB-cMK.qDB RIv!qDB / yiULFvCo" +
                " qDB qDB.Uld!RIv yiULFvCo VNNe.RIv - cMK qDB_Uld Yey!yiULFvCo oZdhHpM cMK VNNe qDB.yiULFvCo Qto qDB Yey yiULFvCo_Qto - qDB yiULFvCo Yey:qDB yiULFvCo Uld Uld.RIv " +
                "qFaJukyopw Yey                                                                   UjL UjL FHzDNfhYMs!UjL,oKmrZygxUp oKmrZygxUp/ oKmrZygxUp oKmrZygxUp oKmrZygxUp.UjL - " +
                "oKmrZygxUp UjL.oKmrZygxUp oKmrZygxUp?UjL? oKmrZygxUp!UjL_UjL UjL FHzDNfhYMs.FHzDNfhYMs - oKmrZygxUp,UjL!FHzDNfhYMs UjL FHzDNfhYMs oKmrZygxUp_UjL oKmrZygxUp: oKmrZygxUp " +
                "UjL; oKmrZygxUp UjL UjL.oKmrZygxUp_FHzDNfhYMs!UjL.FHzDNfhYMs FHzDNfhYMs FHzDNfhYMs oKmrZygxUp, UjL oKmrZygxUp_UjL FHzDNfhYMs oKmrZygxUp oKmrZygxUp!UjL FHzDNfhYMs UjL " +
                "oKmrZygxUp FHzDNfhYMs, oKmrZygxUp UjL UjL oKmrZygxUp / FHzDNfhYMs FHzDNfhYMs oKmrZygxUp FHzDNfhYMs - UjL FHzDNfhYMs oKmrZygxUp:UjL UjL/ oKmrZygxUp UjL: oKmrZygxUp - UjL " +
                "FHzDNfhYMs; UjL.                                                                                      JmN'bInq JmN'bInq - FkswNWQXbe!MsNJRRZpwF wgohClz?SvRnMOZgy " +
                "CztlUsza JmN'bInq,JmN'bInq_JmN'bInq MsNJRRZpwF fxFgL:wgohClz SvRnMOZgy MsNJRRZpwF JmN'bInq SvRnMOZgy.fxFgL - MsNJRRZpwF ? MsNJRRZpwF,wgohClz; JmN'bInq.fxFgL " +
                "JmN'bInq_fxFgL SvRnMOZgy MsNJRRZpwF? JmN'bInq MsNJRRZpwF JmN'bInq MsNJRRZpwF.fxFgL: MsNJRRZpwF; fxFgL? MsNJRRZpwF-JmN'bInq FkswNWQXbe fxFgL wgohClz MsNJRRZpwF/" +
                "HLazWOGpv'.MsNJRRZpwF wgohClz SvRnMOZgy_wgohClz, wgohClz_MsNJRRZpwF fxFgL - JmN'bInq fxFgL fxFgL-MsNJRRZpwF fxFgL-SvRnMOZgy wgohClz?JmN'bInq,SvRnMOZgy JmN'bInq:fxFgL-" +
                "fxFgL/fxFgL HLazWOGpv' fxFgL_MsNJRRZpwF!MsNJRRZpwF: wgohClz JmN'bInq SvRnMOZgy JmN'bInq fxFgL!FkswNWQXbe MsNJRRZpwF MsNJRRZpwF wgohClz? JmN'bInq FkswNWQXbe:FkswNWQXbe-" +
                "fxFgL JmN'bInq MsNJRRZpwF JmN'bInq MsNJRRZpwF/fxFgL_MsNJRRZpwF NZW?JmN'bInq: fxFgL fxFgL JmN'bInq!JmN'bInq CztlUsza:fxFgL / SvRnMOZgy JmN'bInq/HLazWOGpv' - pUwwksNwu " +
                "SvRnMOZgy SvRnMOZgy_JmN'bInq fxFgL JmN'bInq fxFgL JmN'bInq fxFgL MsNJRRZpwF fxFgL FkswNWQXbe_MsNJRRZpwF CztlUsza-JmN'bInq,fxFgL? pUwwksNwu?MsNJRRZpwF!fxFgL MsNJRRZpwF-" +
                "hoadczqI / JmN'bInq MsNJRRZpwF:JmN'bInq!UaJCUOsMG_SvRnMOZgy JmN'bInq/wMhLgmc'Er,wNj:NShCm HMDzxjJBI wzbaHzgIOT Ksld HMDzxjJBI:wNj wNj?Ksld,HMDzxjJBI wzbaHzgIOT " +
                "QEqiVZQbD,cgtWNvCq.kYbYYUrT HMDzxjJBI,HMDzxjJBI.HMDzxjJBI HMDzxjJBI NShCm HMDzxjJBI bTXgYidIt nSWfo'i HMDzxjJBI bTXgYidIt - QEqiVZQbD wNj wMhLgmc'Er wzbaHzgIOT/" +
                "wMhLgmc'Er wNj, NMxhJqFKfn wMhLgmc'Er.oaHaUtz/Ksld nSWfo'i; oaHaUtz? oaHaUtz-Ksld:oaHaUtz: kYbYYUrT.oaHaUtz oaHaUtz HMDzxjJBI; wzbaHzgIOT.nSWfo'i?wzbaHzgIOT.wNj nSWfo'i?" +
                " NMxhJqFKfn nSWfo'i nSWfo'i ndbTN.Ksld; wzbaHzgIOT wMhLgmc'Er;kzQnl'syVa,HMDzxjJBI wMhLgmc'Er wNj.bTXgYidIt!nSWfo'i wMhLgmc'Er NMxhJqFKfn-Ksld/wzbaHzgIOT/nSWfo'i " +
                "QEqiVZQbD:ndbTN? QEqiVZQbD nSWfo'i!NMxhJqFKfn wzbaHzgIOT/VEoC Ksld.QEqiVZQbD,bTXgYidIt NMxhJqFKfn:ndbTN cgtWNvCq QEqiVZQbD bTXgYidIt bTXgYidIt,QEqiVZQbD_wNj?wMhLgmc'Er /" +
                " wMhLgmc'Er;wMhLgmc'Er,wMhLgmc'Er kYbYYUrT,bTXgYidIt nSWfo'i wNj NMxhJqFKfn!wzbaHzgIOT - wzbaHzgIOT:HMDzxjJBI wzbaHzgIOT; wzbaHzgIOT nSWfo'i-wzbaHzgIOT HMDzxjJBI " +
                "oaHaUtz,wzbaHzgIOT NMxhJqFKfn wzbaHzgIOT;HMDzxjJBI NShCm HMDzxjJBI kzQnl'syVa!wzbaHzgIOT.wzbaHzgIOT? bTXgYidIt HMDzxjJBI / ndbTN bTXgYidIt VEoC_wNj bTXgYidIt oaHaUtz " +
                "wMhLgmc'Er QEqiVZQbD oaHaUtz_VEoC,HMDzxjJBI HMDzxjJBI bTXgYidIt Ksld-QEqiVZQbD NShCm:wNj NMxhJqFKfn Ksld kzQnl'syVa: nSWfo'i-ndbTN oaHaUtz wMhLgmc'Er bTXgYidIt-ndbTN " +
                "HMDzxjJBI wMhLgmc'Er kzQnl'syVa QEqiVZQbD; jQvrxKlQ - bTXgYidIt bTXgYidIt - wNj bTXgYidIt oaHaUtz, bTXgYidIt ndbTN wzbaHzgIOT NMxhJqFKfn!bTXgYidIt QEqiVZQbD NShCm? " +
                "oaHaUtz wMhLgmc'Er Ksld nSWfo'i - NShCm; wzbaHzgIOT ndbTN ndbTN: jQvrxKlQ? wzbaHzgIOT QEqiVZQbD nSWfo'i nSWfo'i Ksld bTXgYidIt.ndbTN!wMhLgmc'Er HMDzxjJBI bTXgYidIt " +
                "nSWfo'i nSWfo'i!wMhLgmc'Er wMhLgmc'Er cgtWNvCq NMxhJqFKfn wNj.ndbTN.NShCm!HMDzxjJBI QEqiVZQbD wzbaHzgIOT!NMxhJqFKfn/wzbaHzgIOT HMDzxjJBI ndbTN nSWfo'i? HMDzxjJBI " +
                "HMDzxjJBI ndbTN; QEqiVZQbD; wzbaHzgIOT wNj?wMhLgmc'Er-ndbTN nSWfo'i; wMhLgmc'Er:ndbTN wMhLgmc'Er: HMDzxjJBI: wMhLgmc'Er;nSWfo'i bTXgYidIt?kzQnl'syVa ndbTN " +
                "HMDzxjJBI;kYbYYUrT wNj!QEqiVZQbD!kzQnl'syVa HMDzxjJBI wNj NMxhJqFKfn NMxhJqFKfn wzbaHzgIOT HMDzxjJBI cgtWNvCq wzbaHzgIOT.HMDzxjJBI wzbaHzgIOT " +
                "nSWfo'i:HMDzxjJBI:nSWfo'i.NShCm - nSWfo'i nSWfo'i kYbYYUrT NShCm? NShCm:bTXgYidIt wNj JErwPhYsLx!QEqiVZQbD oaHaUtz nSWfo'i.NZtHv Ina irsKgog tWR MkdzWybeak wKTGtDugsM " +
                "UtAFmMt irsKgog fxjetpy; ay'urqpu Ina wKTGtDugsM jeccmWmgv-gmtW BvksERUd BvksERUd wKTGtDugsM.UtAFmMt;BvksERUd.wKTGtDugsM YtKMDzX-Ina wKTGtDugsM YtKMDzX!SQIaU fxjetpy " +
                "gmtW.SQIaU SQIaU.RWXzjQXgd BvksERUd BvksERUd.wKTGtDugsM:NZtHv BvksERUd?BvksERUd wKTGtDugsM MaBUEHmHtK/MkdzWybeak fxjetpy MkdzWybeak NZtHv NZtHv/NZtHv SQIaU;YtKMDzX/" +
                "SQIaU;Ina?NZtHv,NZtHv;gmtW irsKgog.gmtW:BvksERUd UtAFmMt NLKl UtAFmMt Ina UtAFmMt wKTGtDugsM wKTGtDugsM?MkdzWybeak;gmtW!UtAFmMt NZtHv YtKMDzX_BvksERUd-SQIaU ay'urqpu " +
                "wKTGtDugsM!irsKgog Ina jeccmWmgv:RWXzjQXgd BvksERUd MkdzWybeak; Ina irsKgog BvksERUd ay'urqpu!Ina YtKMDzX SQIaU YtKMDzX wKTGtDugsM-tWR-ay'urqpu SQIaU wKTGtDugsM? irsKgog" +
                " MkdzWybeak BvksERUd.SQIaU gmtW!fxjetpy gmtW ay'urqpu/jeccmWmgv RWXzjQXgd SQIaU ay'urqpu ay'urqpu wKTGtDugsM!BvksERUd jeccmWmgv UtAFmMt MkdzWybeak BvksERUd wKTGtDugsM " +
                "SQIaU:Ina RWXzjQXgd.Ina:YtKMDzX BvksERUd:gmtW?SQIaU ay'urqpu fxjetpy-RWXzjQXgd jeccmWmgv ay'urqpu,RWXzjQXgd UtAFmMt-BvksERUd ay'urqpu UtAFmMt:wKTGtDugsM Ina Ina_irsKgog " +
                "- YtKMDzX gmtW - NZtHv - NZtHv UtAFmMt.NZtHv gmtW YtKMDzX; fxjetpy wKTGtDugsM fxjetpy? Ina fxjetpy Ina gmtW!NZtHv? UtAFmMt SQIaU.ay'urqpu Ina?wKTGtDugsM MkdzWybeak!NZtHv" +
                " irsKgog/RWXzjQXgd RWXzjQXgd NZtHv UtAFmMt MkdzWybeak fxjetpy/MkdzWybeak YtKMDzX irsKgog,jeccmWmgv YtKMDzX gmtW.MkdzWybeak UtAFmMt_BvksERUd RWXzjQXgd-gmtW/SQIaU " +
                "BvksERUd?wKTGtDugsM tWR?gmtW ay'urqpu irsKgog ay'urqpu Ina ay'urqpu gmtW ay'urqpu RWXzjQXgd SQIaU gmtW_MkdzWybeak,wKTGtDugsM!fxjetpy NZtHv wKTGtDugsM ay'urqpu? " +
                "wKTGtDugsM?gmtW SQIaU:UtAFmMt RWXzjQXgd UtAFmMt_jeccmWmgv.YtKMDzX gmtW fxjetpy wKTGtDugsM_SQIaU wKTGtDugsM / NZtHv_MkdzWybeak:tWR MkdzWybeak:YtKMDzX MkdzWybeak-" +
                "irsKgog,UtAFmMt; BvksERUd UtAFmMt, SQIaU YtKMDzX NZtHv_wKTGtDugsM ay'urqpu?BvksERUd UtAFmMt BvksERUd-wKTGtDugsM MkdzWybeak_irsKgog!YtKMDzX?irsKgog-RWXzjQXgd Ina " +
                "BvksERUd-RWXzjQXgd_fxjetpy RWXzjQXgd wKTGtDugsM wKTGtDugsM:NLKl_fxjetpy.ay'urqpu wKTGtDugsM.SQIaU SQIaU?jeccmWmgv: MaBUEHmHtK ay'urqpu?SQIaU/UtAFmMt irsKgog/BvksERUd " +
                "gmtW.wKTGtDugsM SQIaU irsKgog-MkdzWybeak,SQIaU tWR fxjetpy fxjetpy?MkdzWybeak BvksERUd Ina:fxjetpy BvksERUd gmtW SQIaU SQIaU Ina Ina irsKgog;BvksERUd wKTGtDugsM?irsKgog " +
                "MkdzWybeak ay'urqpu ay'urqpu/ay'urqpu fxjetpy; fxjetpy NZtHv/                   eAmUQpmq; eAmUQpmq eAmUQpmq VArzy'k lard'f OWgJZUNcHx; wVUtoO OWgJZUNcHx; eAmUQpmq; UOY " +
                "lard'f,wVUtoO lard'f wVUtoO/ wVUtoO UOY OWgJZUNcHx OWgJZUNcHx_lard'f_wVUtoO lard'f - eGJCpUf lard'f VArzy'k lard'f;wVUtoO,VArzy'k,eAmUQpmq; eAmUQpmq: wVUtoO!wVUtoO " +
                "lard'f.OWgJZUNcHx?wVUtoO?lard'f lard'f eAmUQpmq lard'f VArzy'k_lard'f / UOY UOY UOY, OWgJZUNcHx:eAmUQpmq? eAmUQpmq UOY_eAmUQpmq - OWgJZUNcHx wVUtoO OWgJZUNcHx " +
                "OWgJZUNcHx!eAmUQpmq - OWgJZUNcHx lard'f,wVUtoO VArzy'k lard'f-VArzy'k wVUtoO!eAmUQpmq VArzy'k lard'f VArzy'k_VArzy'k,VArzy'k UOY.VArzy'k,OWgJZUNcHx wVUtoO VArzy'k lard'f" +
                " OWgJZUNcHx UOY UOY.UOY VArzy'k/lard'f OWgJZUNcHx VArzy'k eAmUQpmq!eAmUQpmq:wVUtoO/wVUtoO-lard'f? OWgJZUNcHx.VArzy'k-lard'f eAmUQpmq; OWgJZUNcHx_eAmUQpmq? lard'f_eGJCpUf" +
                " OWgJZUNcHx wVUtoO.eAmUQpmq,eAmUQpmq-eAmUQpmq:lard'f OWgJZUNcHx.OWgJZUNcHx eAmUQpmq UOY.eAmUQpmq; eAmUQpmq UOY.OWgJZUNcHx_wVUtoO,eAmUQpmq - VArzy'k lard'f? wVUtoO, " +
                "eAmUQpmq lard'f eAmUQpmq?OWgJZUNcHx VArzy'k!VArzy'k OWgJZUNcHx lard'f UOY.OWgJZUNcHx wVUtoO OWgJZUNcHx VArzy'k.zVa!epG: ODPpchb eqRz ODPpchb,eqRz eqRz?DfcORPW: UxCSudkZ?" +
                " epG zVa / hZaMxWappI ? qedCF epG DfcORPW hZaMxWappI; qedCF DfcORPW zVa zVa ODPpchb: WaSUfGIkU epG?gsSqahg_DfcORPW DfcORPW hZaMxWappI hZaMxWappI, ODPpchb-ODPpchb " +
                "hZaMxWappI ODPpchb UxCSudkZ,UKR gsSqahg; UxCSudkZ!DfcORPW? UxCSudkZ gsSqahg epG gsSqahg: UxCSudkZ gsSqahg:ODPpchb DfcORPW UKR.gsSqahg? DfcORPW ODPpchb UxCSudkZ eqRz / " +
                "gsSqahg!UxCSudkZ DfcORPW qedCF; UKR epG zVa ODPpchb cDVKUPJ DfcORPW.UxCSudkZ: qedCF / cDVKUPJ epG gsSqahg hZaMxWappI_DfcORPW? yAYdwC:gsSqahg: dsbmfErHK; UxCSudkZ; zVa " +
                "yAYdwC epG / hZaMxWappI zVa UxCSudkZ hZaMxWappI zVa!ODPpchb UKR / cDVKUPJ UKR ODPpchb ODPpchb LW'wk-qedCF/eqRz yAYdwC qedCF UKR gsSqahg qedCF?zVa gsSqahg eqRz.hZaMxWappI" +
                " qedCF qedCF.hZaMxWappI:qedCF qedCF gsSqahg eqRz qedCF_zVa UxCSudkZ qedCF DfcORPW epG;DfcORPW.cDVKUPJ?DfcORPW eqRz cDVKUPJ:UKR/qedCF LW'wk qedCF?cDVKUPJ qedCF eqRz!" +
                "DfcORPW: UxCSudkZ: UxCSudkZ_LW'wk;UxCSudkZ eqRz qedCF/UKR ODPpchb?LW'wk qedCF gsSqahg UxCSudkZ/ qedCF:eqRz hZaMxWappI ODPpchb hZaMxWappI gsSqahg.eqRz:qedCF UxCSudkZ " +
                "LW'wk qedCF?epG?hZaMxWappI:hZaMxWappI/UxCSudkZ zVa-ODPpchb.epG?hZaMxWappI DfcORPW:eqRz UxCSudkZ hZaMxWappI/eqRz gsSqahg DfcORPW qedCF cDVKUPJ-epG zVa cDVKUPJ zVa " +
                "ODPpchb_UxCSudkZ hZaMxWappI,ODPpchb!hZaMxWappI ODPpchb DfcORPW DfcORPW:WaSUfGIkU,DfcORPW ODPpchb UKR DfcORPW DfcORPW DfcORPW UxCSudkZ zVa-UxCSudkZ:qedCF zVa zVa!" +
                "zVa,WaSUfGIkU epG cDVKUPJ,LW'wk LW'wk cDVKUPJ DfcORPW/UxCSudkZ LW'wk? WaSUfGIkU/ zVa,UKR hZaMxWappI_ODPpchb-qedCF UxCSudkZ ODPpchb_hZaMxWappI; ODPpchb UxCSudkZ!ODPpchb!" +
                "UxCSudkZ / LW'wk:epG-hZaMxWappI zVa,zVa,DfcORPW zVa:DfcORPW_gsSqahg gsSqahg hZaMxWappI ODPpchb?cDVKUPJ!hZaMxWappI.epG:eqRz hZaMxWappI DfcORPW yAYdwC UxCSudkZ.DfcORPW " +
                "hZaMxWappI WaSUfGIkU/gsSqahg-UxCSudkZ;eqRz_LW'wk; qedCF gsSqahg:UKR cDVKUPJ UxCSudkZ qedCF.DfcORPW: cDVKUPJ.ODPpchb_hZaMxWappI zVa cDVKUPJ hZaMxWappI!UKR ? qedCF,qedCF? " +
                "hZaMxWappI?UxCSudkZ UxCSudkZ, zVa gsSqahg hZaMxWappI ODPpchb gsSqahg zVa - ODPpchb / UKR / LW'wk!cDVKUPJ hZaMxWappI gsSqahg gsSqahg-zVa_epG.DfcORPW UKR,IkhdlpSo'd " +
                "GLfGpFuz GLfGpFuz/Z'nNSolf jeDvdRvG'?IkhdlpSo'd; rmDB GLfGpFuz; ygq rmDB:uxyMISml jQQwy!IkhdlpSo'd ygq!vARxSqf?uxyMISml Z'nNSolf Z'nNSolf rmDB EyYOXDoTZe rmDB:WkLOs:ygq!" +
                "uxyMISml Z'nNSolf: IkhdlpSo'd IkhdlpSo'd WkLOs/ GLfGpFuz rmDB IkhdlpSo'd?Z'nNSolf GLfGpFuz/ WkLOs ? IkhdlpSo'd?vARxSqf!GLfGpFuz ygq ygq:jQQwy;uxyMISml?uxyMISml " +
                "vARxSqf,IkhdlpSo'd IkhdlpSo'd Z'nNSolf Z'nNSolf:IkhdlpSo'd jQQwy ygq? GLfGpFuz/ uxyMISml:IkhdlpSo'd jQQwy;jQQwy jeDvdRvG' Z'nNSolf_Z'nNSolf GLfGpFuz IkhdlpSo'd?GLfGpFuz " +
                "rmDB WkLOs:jQQwy_Z'nNSolf: uxyMISml uxyMISml WkLOs? WkLOs rmDB / rmDB uxyMISml vARxSqf, Z'nNSolf vARxSqf uxyMISml_ygq GLfGpFuz jQQwy Z'nNSolf IkhdlpSo'd rmDB-" +
                "IkhdlpSo'd,Z'nNSolf!IkhdlpSo'd rmDB.GLfGpFuz? ygq vARxSqf GLfGpFuz_uxyMISml!WkLOs jQQwy.rmDB GLfGpFuz jQQwy EyYOXDoTZe_ygq.Z'nNSolf,WkLOs ygq;Z'nNSolf? GLfGpFuz GLfGpFuz" +
                " GLfGpFuz/ GLfGpFuz_jeDvdRvG' jQQwy IkhdlpSo'd GLfGpFuz WkLOs IkhdlpSo'd_GLfGpFuz/IkhdlpSo'd WkLOs.jeDvdRvG' jeDvdRvG' rmDB jQQwy GLfGpFuz: jQQwy jeDvdRvG'-WkLOs WkLOs-" +
                "ygq_Z'nNSolf: IkhdlpSo'd_rmDB rmDB:Z'nNSolf WkLOs jQQwy; jQQwy ygq?Z'nNSolf:EyYOXDoTZe IkhdlpSo'd jQQwy; jQQwy? jQQwy ygq vARxSqf!rmDB ygq GLfGpFuz IkhdlpSo'd/IkhdlpSo'd" +
                " IkhdlpSo'd;GLfGpFuz uxyMISml jQQwy.EyYOXDoTZe-uxyMISml Z'nNSolf? Z'nNSolf Z'nNSolf? rmDB IkhdlpSo'd!WkLOs jQQwy GLfGpFuz Z'nNSolf Z'nNSolf GLfGpFuz?rmDB ygq?IkhdlpSo'd " +
                "vARxSqf IkhdlpSo'd_ygq/WkLOs rmDB,IkhdlpSo'd,jQQwy: uxyMISml.WkLOs.IkhdlpSo'd?GLfGpFuz-rmDB;jQQwy uxyMISml Z'nNSolf / jQQwy,GLfGpFuz IkhdlpSo'd WkLOs jQQwy Z'nNSolf " +
                "Z'nNSolf Z'nNSolf: rmDB uxyMISml-uxyMISml rmDB WkLOs rmDB; Z'nNSolf GLfGpFuz_ygq EyYOXDoTZe!vARxSqf!ygq rmDB/GLfGpFuz?WkLOs jQQwy,GLfGpFuz BQed / AvTGXuJqMl; " +
                "CQWnvSp.WthUsonbQO GHzxVpTlG AvTGXuJqMl,WthUsonbQO KUjaagW BQm BQed BQed KUjaagW, eVWnT_KUjaagW; BQed KUjaagW, WthUsonbQO AvTGXuJqMl CQWnvSp-BQed KUjaagW BQm " +
                "AvTGXuJqMl_KUjaagW - mYEf - wzg'gb.AvTGXuJqMl;wzg'gb,CQWnvSp_KUjaagW,GHzxVpTlG!AvTGXuJqMl wzg'gb AvTGXuJqMl-KUjaagW;BQm mYEf.CQWnvSp?CQWnvSp AvTGXuJqMl CQWnvSp BQm_BQed/" +
                "BQed CQWnvSp mYEf BQed.BQed wzg'gb / KUjaagW mYEf eVWnT KUjaagW? KUjaagW KUjaagW CQWnvSp KUjaagW,mYEf!BQm_WthUsonbQO!AvTGXuJqMl: WthUsonbQO CQWnvSp eVWnT mYEf WthUsonbQO" +
                " eVWnT WJNpJ KUjaagW mYEf KUjaagW wzg'gb,KUjaagW AvTGXuJqMl?WthUsonbQO KUjaagW,CQWnvSp?mYEf BQed KUjaagW.BQm wzg'gb BQm GHzxVpTlG? WJNpJ!KUjaagW / nJGyL wzg'gb wzg'gb " +
                "eVWnT CQWnvSp BQm-KUjaagW,BQed AvTGXuJqMl AvTGXuJqMl.nJGyL; BQm KUjaagW-WJNpJ_mYEf; AvTGXuJqMl.CQWnvSp BQed mYEf; mYEf CQWnvSp/ CQWnvSp mYEf: BQed.KUjaagW wzg'gb.wzg'gb " +
                "mYEf BQm - CQWnvSp eVWnT_AvTGXuJqMl BQed_BQed.WthUsonbQO CQWnvSp CQWnvSp AvTGXuJqMl.CQWnvSp wzg'gb?CQWnvSp eVWnT mYEf AvTGXuJqMl?mYEf WthUsonbQO/mYEf;wzg'gb BQed " +
                "AvTGXuJqMl AvTGXuJqMl-eVWnT eVWnT CQWnvSp/ wzg'gb AvTGXuJqMl;BQed CQWnvSp KUjaagW_mYEf:RgCO AvTGXuJqMl/nJGyL BQed.KUjaagW AvTGXuJqMl,wzg'gb mYEf wzg'gb BQed,KUjaagW BQm-" +
                "WthUsonbQO,KUjaagW WthUsonbQO WthUsonbQO mYEf.CQWnvSp,BQm/AvTGXuJqMl.CQWnvSp:CQWnvSp,wzg'gb AvTGXuJqMl; KUjaagW.CQWnvSp; CQWnvSp mYEf.WthUsonbQO WJNpJ?eVWnT!DGk " +
                "pRSQnlAPeY; ZaDMJQPtz: zW'q lNtbdIvO!lNtbdIvO.lNtbdIvO:lNtbdIvO lNtbdIvO lNtbdIvO;pRSQnlAPeY-zW'q,PqOFKTh zW'q/DGk wOTGoMFZ;lNtbdIvO_thnBkwtkU;ZaDMJQPtz!zW'q thnBkwtkU; " +
                "zW'q ZaDMJQPtz.zW'q!AHO,pRSQnlAPeY pRSQnlAPeY YVgJ YVgJ ZaDMJQPtz ZaDMJQPtz?ZaDMJQPtz thnBkwtkU pRSQnlAPeY pRSQnlAPeY thnBkwtkU wOTGoMFZ pRSQnlAPeY / lNtbdIvO lNtbdIvO: " +
                "pRSQnlAPeY!zW'q/tWmCpE AHO,DGk lNtbdIvO?thnBkwtkU PqOFKTh AHO,lNtbdIvO zW'q; DGk - pRSQnlAPeY / lNtbdIvO:pRSQnlAPeY pRSQnlAPeY, PqOFKTh; ZaDMJQPtz / ZaDMJQPtz - wOTGoMFZ" +
                " ZaDMJQPtz pRSQnlAPeY YVgJ; DGk thnBkwtkU, thnBkwtkU pRSQnlAPeY zW'q_lNtbdIvO.ZaDMJQPtz ZaDMJQPtz PqOFKTh AHO:DGk_YVgJ?DGk zW'q YVgJ AHO PqOFKTh/ thnBkwtkU!ZaDMJQPtz - " +
                "tWmCpE ? thnBkwtkU wOTGoMFZ zW'q;thnBkwtkU,lNtbdIvO thnBkwtkU pRSQnlAPeY/ZaDMJQPtz pRSQnlAPeY lNtbdIvO lNtbdIvO.DGk pRSQnlAPeY lNtbdIvO.ZaDMJQPtz thnBkwtkU " +
                "pRSQnlAPeY,DGk wOTGoMFZ pRSQnlAPeY ZaDMJQPtz!zW'q - ZaDMJQPtz_tWmCpE zW'q-AHO_AHO AHO YVgJ?YVgJ?ZaDMJQPtz ZaDMJQPtz PqOFKTh lNtbdIvO pRSQnlAPeY-pRSQnlAPeY pRSQnlAPeY " +
                "zW'q? AHO!ZaDMJQPtz!AHO!AHO zW'q ZaDMJQPtz thnBkwtkU?tWmCpE/zW'q DGk-AHO / lNtbdIvO - thnBkwtkU ? AHO DGk ? pRSQnlAPeY,ZaDMJQPtz lNtbdIvO-ZaDMJQPtz - DGk ZaDMJQPtz? " +
                "thnBkwtkU pRSQnlAPeY DGk thnBkwtkU AHO-DGk_YVgJ pRSQnlAPeY thnBkwtkU thnBkwtkU: YVgJ_DGk pRSQnlAPeY, thnBkwtkU DGk,tWmCpE lQbyfCg'h AHO?wOTGoMFZ zW'q zW'q:AHO_wOTGoMFZ " +
                "ZaDMJQPtz YVgJ PqOFKTh:lNtbdIvO;lNtbdIvO:lNtbdIvO lNtbdIvO ZaDMJQPtz DGk zW'q YVgJ-DGk!thnBkwtkU zW'q wOTGoMFZ.zW'q zW'q_thnBkwtkU.tWmCpE AHO/lNtbdIvO_YVgJ.pRSQnlAPeY " +
                "ZaDMJQPtz wOTGoMFZ_thnBkwtkU.DGk_ZaDMJQPtz ZaDMJQPtz thnBkwtkU?lNtbdIvO:pRSQnlAPeY.zW'q DGk:lNtbdIvO,tWmCpE lNtbdIvO?lNtbdIvO - pRSQnlAPeY_thnBkwtkU zW'q!tWmCpE " +
                "thnBkwtkU;pRSQnlAPeY ZaDMJQPtz!DGk thnBkwtkU/ZaDMJQPtz mhJ'r iHJmNjG_mhJ'r xub MfnmsnC.MkdQK? ZIIe'g;mhJ'r? mhJ'r iHJmNjG.xub wNGdDVp/wNGdDVp uCeQwufNXn MkdQK/uCeQwufNXn" +
                " BwxqMaQtg mhJ'r wNGdDVp uCeQwufNXn!KtoM? MkdQK!wNGdDVp:wNGdDVp - mhJ'r.adOZIYw MkdQK iHJmNjG?mhJ'r iHJmNjG jAX'Cfns_KtoM;MfnmsnC mhJ'r / qwFrUMvDsL adOZIYw? qwFrUMvDsL " +
                "MkdQK iHJmNjG/ KtoM / bPRWxTRXT ydxQb mhJ'r,KtoM?KtoM mhJ'r; KtoM.MkdQK uCeQwufNXn!dBjeNBRBK MfnmsnC KtoM ydxQb ydxQb/ iHJmNjG - eRTaNPYZ adOZIYw KtoM uCeQwufNXn!" +
                "jAX'Cfns iHJmNjG KtoM MkdQK_wNGdDVp KtoM ydxQb wNGdDVp-mhJ'r_eRTaNPYZ ydxQb KtoM!KtoM.xub wNGdDVp!jAX'Cfns.eRTaNPYZ dBjeNBRBK wNGdDVp:eRTaNPYZ?iHJmNjG " +
                "ydxQb:qwFrUMvDsL:adOZIYw dBjeNBRBK xub uCeQwufNXn;qwFrUMvDsL?mhJ'r uCeQwufNXn, MkdQK MkdQK - mhJ'r MkdQK.jAX'Cfns wNGdDVp xub mhJ'r uCeQwufNXn,MkdQK.MfnmsnC bPRWxTRXT " +
                "iHJmNjG_mhJ'r_MkdQK MkdQK MkdQK - dBjeNBRBK eRTaNPYZ uCeQwufNXn xub,jAX'Cfns,MfnmsnC KtoM jAX'Cfns MkdQK:ydxQb / eRTaNPYZ,xub qwFrUMvDsL iHJmNjG!eRTaNPYZ / " +
                "MfnmsnC,ydxQb: eRTaNPYZ / mhJ'r_mhJ'r MkdQK_jAX'Cfns jAX'Cfns!iHJmNjG,MkdQK - MkdQK; iHJmNjG: iHJmNjG; MkdQK dBjeNBRBK.qwFrUMvDsL bPRWxTRXT, wNGdDVp; wNGdDVp - mhJ'r " +
                "mhJ'r qwFrUMvDsL?KtoM!iHJmNjG ydxQb_iHJmNjG wNGdDVp.jAX'Cfns MfnmsnC/ydxQb eRTaNPYZ_ydxQb uCeQwufNXn uCeQwufNXn,eRTaNPYZ adOZIYw_MkdQK uCeQwufNXn,jAX'Cfns_MkdQK " +
                "ydxQb_eRTaNPYZ.adOZIYw wNGdDVp.bPRWxTRXT.mhJ'r qwFrUMvDsL bPRWxTRXT MfnmsnC/dBjeNBRBK mhJ'r MkdQK-jAX'Cfns_ydxQb!wNGdDVp eRTaNPYZ-dBjeNBRBK?bPRWxTRXT iHJmNjG-jAX'Cfns " +
                "KtoM?adOZIYw mhJ'r uCeQwufNXn uCeQwufNXn wNGdDVp_eRTaNPYZ mhJ'r_iHJmNjG_KtoM ydxQb ydxQb eRTaNPYZ!qwFrUMvDsL mhJ'r wNGdDVp wNGdDVp KtoM uCeQwufNXn?wNGdDVp mhJ'r wNGdDVp " +
                "" +
                "MkdQK wNGdDVp:MfnmsnC jAX'Cfns qwFrUMvDsL;wNGdDVp mhJ'r ydxQb-ydxQb ydxQb / jAX'Cfns,bPRWxTRXT uCeQwufNXn eRTaNPYZ RScLNGud qwFrUMvDsL,MkdQK:qwFrUMvDsL dBjeNBRBK " +
                "" +
                "eRTaNPYZ,qwFrUMvDsL.eRTaNPYZ_qwFrUMvDsL bPRWxTRXT!uCeQwufNXn.ydxQb BwxqMaQtg-adOZIYw jAX'Cfns ydxQb MkdQK qwFrUMvDsL ydxQb_ZIIe'g mhJ'r MfnmsnC ydxQb; wNGdDVp ydxQb " +
                "" +
                "KtoM / dBjeNBRBK qwFrUMvDsL,KtoM; jAX'Cfns bPRWxTRXT.MfnmsnC KtoM mhJ'r qwFrUMvDsL:jAX'Cfns MkdQK_ydxQb MfnmsnC.wNGdDVp!MkdQK qwFrUMvDsL.wNGdDVp ydxQb adOZIYw?mhJ'r ydxQb, adOZIYw, adOZIYw?iHJmNjG: ydxQb.iHJmNjG KtoM wNGdDVp_iHJmNjG!MkdQK,bPRWxTRXT qwFrUMvDsL:ydxQb MkdQK_MkdQK dBjeNBRBK_");

            //Assertions
            Assert.Contains("dfcorpw", result);
            Assert.Contains("hmdzxjjbi", result);
            Assert.Contains("hzamxwappi", result);
        }
    }
}
