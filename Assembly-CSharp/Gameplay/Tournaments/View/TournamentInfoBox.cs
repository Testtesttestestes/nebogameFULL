using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public class TournamentInfoBox : MonoBehaviourWithStates<TournamentInfoBox.State>
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FF")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x6DBC", Offset = "0x6DBC", VA = "0x6DBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000500")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x6DBD", Offset = "0x6DBD", VA = "0x6DBD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000501")]
		public TextMeshProUGUI Status
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x6DBE", Offset = "0x6DBE", VA = "0x6DBE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000502")]
		public TextMeshProUGUI Annotation
		{
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x6DBF", Offset = "0x6DBF", VA = "0x6DBF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000503")]
		public UserViewWithNickname WinnerView
		{
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x6DC0", Offset = "0x6DC0", VA = "0x6DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000504")]
		public TournamentBank Bank
		{
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x6DC1", Offset = "0x6DC1", VA = "0x6DC1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000505")]
		public BetControlView BetControlView
		{
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0x6DC2", Offset = "0x6DC2", VA = "0x6DC2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000506")]
		public MultilineTextList MultilineInfo
		{
			[Token(Token = "0x6001C44")]
			[Address(RVA = "0x6DC3", Offset = "0x6DC3", VA = "0x6DC3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x6DC4", Offset = "0x6DC4", VA = "0x6DC4")]
		public void SetParticipantsCount(uint count)
		{
		/* --- GHIDRA: SetParticipantsCount ---
		void Gameplay_Tournaments_View_TournamentInfoBox__SetParticipantsCount
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State___ctor__);
		    DAT_ram_00a584fa = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_TournamentInfoBox_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x6DC5", Offset = "0x6DC5", VA = "0x6DC5")]
		public TournamentInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_View_TournamentInfoBox___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  float param2_00;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a584fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_TournamentListElementBase_TournamentData__get_TournamentData__
		              );
		    DAT_ram_00a584fb = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = Core_Extensions_Dict_ThemeRatingKindDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x2c) + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = Core_Extensions_Dict_TournamentDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x2c) + 8),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = Core_Data_Tournaments_TournamentData__Create(*(undefined4 *)(param1 + 0x2c),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  iVar4 = *(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x2c) + 0xc) + 0x14) + 0xc);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  if (iVar4 - 3U < 2) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar3 = *(undefined4 *)(param1 + 0x34);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  uVar1 = *(uint *)(*(int *)(*(int *)(*(int *)(param1 + 0x2c) + 0xc) + 0x14) + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)uVar1,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,param2_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		private const string LOCALIZATION_PARTICIPANTS = "TOURNAMENTS/PARTICIPANTS";

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _status;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private UserViewWithNickname _winnerView;

		// Token: 0x04000F4D RID: 3917
		[Token(Token = "0x4000F4D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TournamentBank _bank;

		// Token: 0x04000F4E RID: 3918
		[Token(Token = "0x4000F4E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _participantsCount;

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BetControlView _betControlView;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MultilineTextList _textList;

		// Token: 0x020004AC RID: 1196
		[Token(Token = "0x20004AC")]
		public enum State
		{
			// Token: 0x04000F52 RID: 3922
			[Token(Token = "0x4000F52")]
			NO_TOURNAMENT,
			// Token: 0x04000F53 RID: 3923
			[Token(Token = "0x4000F53")]
			COLLECT_BETS,
			// Token: 0x04000F54 RID: 3924
			[Token(Token = "0x4000F54")]
			DO_BETS,
			// Token: 0x04000F55 RID: 3925
			[Token(Token = "0x4000F55")]
			BATTLE,
			// Token: 0x04000F56 RID: 3926
			[Token(Token = "0x4000F56")]
			WAITING,
			// Token: 0x04000F57 RID: 3927
			[Token(Token = "0x4000F57")]
			FINISHED,
			// Token: 0x04000F58 RID: 3928
			[Token(Token = "0x4000F58")]
			CANCELED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MultilineInfo ---
		void Gameplay_Tournaments_View_TournamentInfoBox__get_MultilineInfo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 param1_01;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a584f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26036);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15159);
		    DAT_ram_00a584f9 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15159,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26036,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_01,uVar1,0);
		  return;
		}
		*/

}
