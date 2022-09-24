﻿using Dinamo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamo.Entities.Concrete
{
    public class STOK46T : IEntity
    {
        public string EVRAKNO { get; set; }
        public string TRNUM { get; set; }
        public string SRNUM { get; set; }
        public string KOD { get; set; }
        public string TARIH { get; set; }
        public string NOTE0 { get; set; }
        public string NOTE1 { get; set; }
        public float OR_FIYAT { get; set; }
        public string PRICEUNIT { get; set; }
        public float SF_MIKTAR { get; set; }
        public float OR_TUTAR { get; set; }
        public string ACIKKAPALI { get; set; }
        public float SF_OLDTESLIMALINAN { get; set; }
        public string RTESTARIH { get; set; }
        public string TOLERANS { get; set; }
        public string RKAPANISTARIH { get; set; }
        public string TOLERANSTYPE { get; set; }
        public string CH_KODU { get; set; }
        public int ODEMEGUNU { get; set; }
        public string ODEMESEKLI { get; set; }
        public string FOKOD { get; set; }
        public float KDV_ORANI { get; set; }
        public string KURCALCTYPE { get; set; }
        public string ISKONTOTIPI_1 { get; set; }
        public string ISKONTOTIPI_2 { get; set; }
        public string ISKONTOTIPI_3 { get; set; }
        public string ISKONTOTIPI_4 { get; set; }
        public float YISKONTO_1 { get; set; }
        public float YISKONTO_2 { get; set; }
        public float YISKONTO_3 { get; set; }
        public float YISKONTO_4 { get; set; }
        public float OR_TISKONTO_1 { get; set; }
        public float OR_TISKONTO_2 { get; set; }
        public float OR_TISKONTO_3 { get; set; }
        public float OR_TISKONTO_4 { get; set; }
        public float OR_XISKONTO_TUTARI { get; set; }
        public float OR_ISKONTOLU_TUTAR { get; set; }
        public float ISKONTO_EFEKTIF { get; set; }
        public float OR_X_KDVTUT { get; set; }
        public float OR_X_KDVTUT_US { get; set; }
        public float OR_KDVTUT_EFEKTIF { get; set; }
        public float OR_KDVDAHILTUTAR { get; set; }
        public float KUR { get; set; }
        public float FATURALANAN_TISKONTO { get; set; }
        public float FATURALANAN_ORKUR { get; set; }
        public float FATURALANAN_TL { get; set; }
        public string GK_1 { get; set; }
        public string GK_2 { get; set; }
        public string GK_3 { get; set; }
        public string REV_RTESTARIH { get; set; }
        public string REV_TAHVALORTARIH { get; set; }
        public string TAHVALORTARIH { get; set; }
        public float SF_SEVKDEMIK { get; set; }
        public float SF_NEWTESLIMALINAN { get; set; }
        public float SF_FATURALANANMIKTAR { get; set; }
        public float SF_IADEALINANMIKTAR { get; set; }
        public float SF_ODONEMKAPANANMIK { get; set; }
        public float SF_NETKAPANANMIK { get; set; }
        public string HOLDTOSEVK { get; set; }
        public string STATUS { get; set; }
        public float SF_PMIKTAR { get; set; }
        public float SF_IMIKTAR { get; set; }
        public string RTALEPTARIH { get; set; }
        public string RTALEPEDILENTESTARIH { get; set; }
        public string TALEPTEBULUNANBOLUM { get; set; }
        public string TALEPTEBULUNANKISI { get; set; }
        public string CODEDBOLUM { get; set; }
        public string CODEDKISI { get; set; }
        public string SUPPLIERSHIPMENTTAR { get; set; }
        public string ATTHECUSTOMSTARIH { get; set; }
        public string NOTIFYWHO { get; set; }
        public string STOK_NONSTOK { get; set; }
        public float SF_SATICININ_GOND { get; set; }
        public string FATURANO { get; set; }
        public string FATURA_TARIH { get; set; }
        public string DOSYANO { get; set; }
        public string TESVIKNO { get; set; }
        public string TESVIK_GRUP_KODU { get; set; }
        public string NETKAPANANMIK_CTYPE { get; set; }
        public string SUGGESTIONEH { get; set; }
        public string SUGGESTED_TARIH { get; set; }
        public string SUGGESTIONTYPE { get; set; }
        public string ARTIKELGK_1 { get; set; }
        public string ARTIKELGK_2 { get; set; }
        public string ARTIKELGK_3 { get; set; }
        public string ARTIKEL_REF_REF_1 { get; set; }
        public string ARTIKEL_REF_REF_2 { get; set; }
        public string ARTIKEL_REF_REF_3 { get; set; }
        public string ARTIKEL_REF_REF_4 { get; set; }
        public string ARTIKEL_REF_REF_5 { get; set; }
        public string ARTIKEL_REF_REF_6 { get; set; }
        public string ARTIKEL_REF_REF_7 { get; set; }
        public string ARTIKEL_REF_REF_8 { get; set; }
        public string ARTIKEL_REF_TARIH_1 { get; set; }
        public string ARTIKEL_REF_TARIH_2 { get; set; }
        public string ARTIKEL_REF_TARIH_3 { get; set; }
        public string ARTIKEL_REF_TARIH_4 { get; set; }
        public string ARTIKEL_REF_TARIH_5 { get; set; }
        public string ARTIKEL_REF_TARIH_6 { get; set; }
        public string ARTIKEL_REF_TARIH_7 { get; set; }
        public string ARTIKEL_REF_TARIH_8 { get; set; }
        public float ARTIKEL_REF_NUM_1 { get; set; }
        public float ARTIKEL_REF_NUM_2 { get; set; }
        public float ARTIKEL_REF_NUM_3 { get; set; }
        public float ARTIKEL_REF_NUM_4 { get; set; }
        public float ARTIKEL_REF_NUM_5 { get; set; }
        public float ARTIKEL_REF_NUM_6 { get; set; }
        public float ARTIKEL_REF_NUM_7 { get; set; }
        public float ARTIKEL_REF_NUM_8 { get; set; }
        public string VTKOLON { get; set; }
        public string VTSATIR { get; set; }
        public float SF_STOK_MIKTAR { get; set; }
        public string SF_SF_UNIT { get; set; }
        public string SF_AUTOCALC { get; set; }
        public string SF_VRI_RECETE { get; set; }
        public string SF_VRI_VR_C { get; set; }
        public string SF_VRI_VR_R1 { get; set; }
        public string SF_VRI_VR_R2 { get; set; }
        public string SF_VRI_VR_R3 { get; set; }
        public string SF_VRI_NUM1 { get; set; }
        public string SF_VRI_NUM2 { get; set; }
        public string TLOG_USERNAME { get; set; }
        public string TLOG_LOGTARIH { get; set; }
        public string TLOG_LOGTIME { get; set; }
        public string TLOG_PSTATION { get; set; }
        public string TLOG_TVERSION { get; set; }
        public float ASORTI_MIKTARI { get; set; }
        public string VERARTTIPI_1 { get; set; }
        public string VERARTTIPI_2 { get; set; }
        public string VERARTTIPI_3 { get; set; }
        public string VERARTTIPI_4 { get; set; }
        public float YVERART_1 { get; set; }
        public float YVERART_2 { get; set; }
        public float YVERART_3 { get; set; }
        public float YVERART_4 { get; set; }
        public float OR_TVERART_1 { get; set; }
        public float OR_TVERART_2 { get; set; }
        public float OR_TVERART_3 { get; set; }
        public float OR_TVERART_4 { get; set; }
        public float OR_IVD_KH_TUTAR { get; set; }
        public string KULLANIM_YERI { get; set; }
        public string KDV_NOCALC { get; set; }
        public string FASON10 { get; set; }
        public string CHSIPNO { get; set; }
        public string MIKTARONERISIVARMI { get; set; }
        public string MRPICINSABITLEME10 { get; set; }
        public string RECETESABIT10 { get; set; }
        public string PRICEUNIT_DT { get; set; }
        public float SUGGESTED_MIKTAR { get; set; }
        public string TESISKODU { get; set; }
        public string D_ID { get; set; }
        public string D_ID_KAYNAK { get; set; }
        public string KAPANIS_NEDENI { get; set; }
        public string SSPSKOSULU { get; set; }
        public string NONSTOK_AD { get; set; }
        public string ARTNO { get; set; }
        public string CHSIPANO { get; set; }
        public string SPSTATUSU { get; set; }
        public string SIRALIKAPATMADISI { get; set; }
        public float MIKTAR_DT { get; set; }
        public string UNIT_DT { get; set; }
        public string NEICIN_MMPS10T { get; set; }
        public string NEICIN_MMPS10TT { get; set; }
        public string NEICIN_STOK46T3 { get; set; }
        public string NEICIN_STOK46T3T { get; set; }
        public string NEICIN_STOK40T { get; set; }
        public string NEICIN_STOK40TT { get; set; }
        public string NOTE2 { get; set; }
        public string DOKUMAN_NO { get; set; }
        public string SARTNAME_NO { get; set; }
        public string ORIJINAL_ANMA_KODU { get; set; }
        public string CHPROJENO { get; set; }
        public string CHTEKNIKRESIMNO { get; set; }
        public string SGK_1 { get; set; }
        public string SGK_2 { get; set; }
        public string SGK_3 { get; set; }
        public string SGK_4 { get; set; }
        public string REFTEXT01 { get; set; }
        public string REFTEXT02 { get; set; }
        public string REFTEXT03 { get; set; }
        public string KK_KONTOL_PLANI { get; set; }
        public float REFNUM01 { get; set; }
        public float REFNUM02 { get; set; }
        public float REFNUM03 { get; set; }
        public string REFTARIH1 { get; set; }
        public string REFTARIH2 { get; set; }
        public string REFTARIH3 { get; set; }
        public string ALLOW_DLV_ULIMIT_OP { get; set; }
        public string TAX_SPC { get; set; }
        public string ONAY { get; set; }
        public string SF_NETKAPANANMIK_CM { get; set; }
        public float SF_MN_KAPATILAN_MIK { get; set; }
        public float SF_MN_ACILAN_MIK { get; set; }
        public string KAPANMA_CM { get; set; }
        public string D7ROWVERSION { get; set; }
    }
}
