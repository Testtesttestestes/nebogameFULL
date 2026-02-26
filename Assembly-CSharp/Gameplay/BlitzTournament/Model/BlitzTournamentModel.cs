using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Tournaments;
using Il2CppDummyDll;
using MVC;
using Protocol.BlitzTournaments;
using UI.Tabs;
using Utils;

namespace Gameplay.BlitzTournament.Model
{
	// Token: 0x02000BD2 RID: 3026
	[Token(Token = "0x2000BD2")]
	public class BlitzTournamentModel : AbstractModel
	{
		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A26 RID: 18982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F01")]
		public ProtoGetTournamentInfoAns.Types.TournamentInfo TournamentInfo
		{
			[Token(Token = "0x6004A25")]
			[Address(RVA = "0x9887", Offset = "0x9887", VA = "0x9887")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A26")]
			[Address(RVA = "0x9888", Offset = "0x9888", VA = "0x9888")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		// (set) Token: 0x06004A28 RID: 18984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F02")]
		public bool InQueue
		{
			[Token(Token = "0x6004A27")]
			[Address(RVA = "0x9889", Offset = "0x9889", VA = "0x9889")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A28")]
			[Address(RVA = "0x988A", Offset = "0x988A", VA = "0x988A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F03")]
		public BackTime NextStateBackTime
		{
			[Token(Token = "0x6004A29")]
			[Address(RVA = "0x988B", Offset = "0x988B", VA = "0x988B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A2A")]
			[Address(RVA = "0x988C", Offset = "0x988C", VA = "0x988C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F04")]
		public BlitzTournamentData CurrentTournament
		{
			[Token(Token = "0x6004A2B")]
			[Address(RVA = "0x988D", Offset = "0x988D", VA = "0x988D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A2C")]
			[Address(RVA = "0x988E", Offset = "0x988E", VA = "0x988E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F05")]
		public bool UIBlocked
		{
			[Token(Token = "0x6004A2D")]
			[Address(RVA = "0x988F", Offset = "0x988F", VA = "0x988F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A2E")]
			[Address(RVA = "0x9890", Offset = "0x9890", VA = "0x9890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		// (set) Token: 0x06004A30 RID: 18992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F06")]
		public TournamentStates TournamentState
		{
			[Token(Token = "0x6004A2F")]
			[Address(RVA = "0x9891", Offset = "0x9891", VA = "0x9891")]
			[CompilerGenerated]
			get
			{
				return TournamentStates.UnknownTournamentState;
			}
			[Token(Token = "0x6004A30")]
			[Address(RVA = "0x9892", Offset = "0x9892", VA = "0x9892")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F07")]
		public int RoundsCount
		{
			[Token(Token = "0x6004A31")]
			[Address(RVA = "0x9893", Offset = "0x9893", VA = "0x9893")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004A32")]
			[Address(RVA = "0x9894", Offset = "0x9894", VA = "0x9894")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x9895", Offset = "0x9895", VA = "0x9895")]
		public BlitzTournamentModel(UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_Model_BlitzTournamentModel___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  int param2_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  undefined4 param1_01;
		  bool bVar6;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a608b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_BlitzTournamentData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BlitzTournamentData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BlitzTournamentsDic__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__DisplayClass35_0__SetTournamentInfo_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__DisplayClass35_0_TypeInfo);
		    DAT_ram_00a608b0 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__DisplayClass35_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 8) = param2;
		  *(int *)(param1 + 0x10) = param2;
		  if (param2 == 0) {
		    bVar6 = false;
		  }
		  else {
		    uVar2 = *(undefined4 *)(param2 + 0x18);
		    bVar6 = *(int *)(param2 + 0xc) == 1;
		  }
		  *(bool *)(param1 + 0x14) = bVar6;
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81cf4022;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf4022:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))
		                    (CONCAT44(in_register_20000004,param1_00),
		                     CONCAT44(in_register_20000014,puVar1[1]));
		  iVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(iVar4 + 0xc0),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_BlitzTournamentsDic__get_Item__
		                    );
		  uVar5 = *(uint *)(iVar4 + 0x18);
		  if (DAT_ram_00a6265a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a6265a = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  dVar3 = System_Math__Clamp((double)uVar5,2.0,0);
		  if (DAT_ram_00a63a16 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a63a16 = '\x01';
		  }
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  if (ABS(CEIL((float)dVar3)) < 2.1474836e+09) {
		    iVar4 = (int)CEIL((float)dVar3);
		  }
		  else {
		    iVar4 = -0x80000000;
		  }
		  *(int *)(param1 + 0x28) = iVar4;
		  iVar4 = *(int *)(param2_00 + 8);
		  if (((iVar4 != 0) &&
		      (Gameplay_BlitzTournament_Model_BlitzTournamentModel__PopulateTournaments
		                 (param1,*(undefined4 *)(iVar4 + 0x20),iVar4),
		      *(int *)(*(int *)(param2_00 + 8) + 0x10) != 0)) &&
		     ((*(int *)(param1 + 0x1c) == 0 ||
		      (iVar4 = UnityEngine_UI_Collections_IndexedSet_object___System_Collections_IEnumerable_GetEnumerator
		                         (*(int *)(param1 + 0x1c),0),
		      iVar4 != *(int *)(*(int *)(param2_00 + 8) + 0x10))))) {
		    param1_01 = *(undefined4 *)(param1 + 0xc);
		    uVar2 = unnamed_function_1417(System_Func_BlitzTournamentData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,param2_00,
		               Method_Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__DisplayClass35_0__SetTournamentInfo_b__0__
		               ,0);
		    uVar2 = func_ii_7423(param1_01,uVar2,Method_System_Linq_Enumerable_First_BlitzTournamentData___)
		    ;
		    *(undefined4 *)(param1 + 0x1c) = uVar2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x9896", Offset = "0x9896", VA = "0x9896")]
		public void SetTournamentInfo(ProtoGetTournamentInfoAns.Types.TournamentInfo tournamentInfo)
		{
		/* --- GHIDRA: SetTournamentInfo ---
		void Gameplay_BlitzTournament_Model_BlitzTournamentModel__SetTournamentInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a608b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_BlitzTournamentData__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetTournamentListAns_Types_TournamentListItem__BlitzTournamentData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_BlitzTournamentData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BlitzTournamentData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetTournamentListAns_Types_TournamentListItem__BlitzTournamentData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__PopulateTournaments_b__36_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__PopulateTournaments_b__36_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo);
		    DAT_ram_00a608b1 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param2 + 0xc);
		  if (*(int *)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x5c)
		  ;
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417
		                      (
		                      System_Func_ProtoGetTournamentListAns_Types_TournamentListItem__BlitzTournamentData__TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar3,uVar4,
		               Method_Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__PopulateTournaments_b__36_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x5c) + 4)
		         = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,iVar3,
		                     Method_System_Linq_Enumerable_Select_ProtoGetTournamentListAns_Types_TournamentListItem__BlitzTournamentData___
		                    );
		  if (*(int *)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x5c)
		  ;
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_BlitzTournamentData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar3,uVar4,
		               Method_Gameplay_BlitzTournament_Model_BlitzTournamentModel___c__PopulateTournaments_b__36_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x5c) + 8)
		         = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_OrderBy_BlitzTournamentData__uint___)
		  ;
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_BlitzTournamentData___);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x9897", Offset = "0x9897", VA = "0x9897")]
		public void PopulateTournaments(ProtoGetTournamentListAns msg)
		{
		/* --- GHIDRA: PopulateTournaments ---
		void Gameplay_BlitzTournament_Model_BlitzTournamentModel__PopulateTournaments
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float param2_00;
		  
		  if (DAT_ram_00a608b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a608b2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)param2,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x9898", Offset = "0x9898", VA = "0x9898")]
		public void SetBackTime(uint milliseconds)
		{
		/* --- GHIDRA: SetBackTime ---
		undefined4
		Gameplay_BlitzTournament_Model_BlitzTournamentModel__SetBackTime
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float4 local_4;
		  
		  if (DAT_ram_00a608b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15163);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28593);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3610);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3619);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15145);
		    DAT_ram_00a608b3 = '\x01';
		  }
		  if (param2 == 1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3610,1,0,1,0,0,0,0);
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15145,1,0,1,0,0,0,0);
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar1,StringLiteral_1481,uVar2,0);
		  }
		  else if (param2 == 2) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3610,1,0,1,0,0,0,0);
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15163,1,0,1,0,0,0,0);
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar1,StringLiteral_1481,uVar2,0);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3619,1,0,1,0,0,0,0);
		    local_4 = (float4)unnamed_function_24934((float)(param2 - 1));
		    uVar2 = func_ii_1081(DAT_ram_00a6696c,&local_4);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28593,uVar1,uVar2,0);
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x9899", Offset = "0x9899", VA = "0x9899")]
		public string GetCurrentRoundLocalization(uint currentRound)
		{
		/* --- GHIDRA: GetCurrentRoundLocalization ---
		void Gameplay_BlitzTournament_Model_BlitzTournamentModel__GetCurrentRoundLocalization
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a608b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo);
		    DAT_ram_00a608b4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_BlitzTournament_Model_BlitzTournamentModel___c_TypeInfo + 0x5c) = uVar1
		  ;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		private const string LOCALIZATION_BLITZ_TOURNAMENT = "BLITZ/BLITZ_TOURNAMENT";

		// Token: 0x04002864 RID: 10340
		[Token(Token = "0x4002864")]
		private const string LOCALIZATION_TOURNAMENT_ROUND = "BLITZ/TOURNAMENT_ROUND";

		// Token: 0x04002865 RID: 10341
		[Token(Token = "0x4002865")]
		private const string LOCALIZATION_TOURNAMENTS_FINAL = "TOURNAMENTS/FINAL";

		// Token: 0x04002866 RID: 10342
		[Token(Token = "0x4002866")]
		private const string LOCALIZATION_TOURNAMENTS_SEMIFINAL = "TOURNAMENTS/SEMIFINAL";

		// Token: 0x04002867 RID: 10343
		[Token(Token = "0x4002867")]
		[FieldOffset(Offset = "0xC")]
		public BlitzTournamentData[] BlitzTournaments;

		// Token: 0x0400286F RID: 10351
		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x2C")]
		public TabBarItemData[] TabBarData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_RoundsCount ---
		void Gameplay_BlitzTournament_Model_BlitzTournamentModel__set_RoundsCount
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a608af == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3610);
		    DAT_ram_00a608af = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,1);
		  param1_00 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3610,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = uVar2;
		  iVar3 = func_ii_1082(param1_00,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar3 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = param1_00;
		  *(int **)(param1 + 0x2c) = piVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  return;
		}
		*/

}
