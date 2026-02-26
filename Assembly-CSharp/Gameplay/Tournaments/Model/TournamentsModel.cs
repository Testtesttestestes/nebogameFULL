using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Tournaments;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Tournaments;
using UI.Tabs;
using Utils;

namespace Gameplay.Tournaments.Model
{
	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	public class TournamentsModel : AbstractModel
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000524")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001C87")]
			[Address(RVA = "0x6E06", Offset = "0x6E06", VA = "0x6E06")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x6E07", Offset = "0x6E07", VA = "0x6E07")]
		public TournamentsModel(UserData user)
		{
		/* --- GHIDRA: <PopulateTournaments>b__44_0 ---
		void Gameplay_Tournaments_Model_TournamentsModel___PopulateTournaments_b__44_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58514 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo);
		    DAT_ram_00a58514 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000525")]
		public TournamentHistory History
		{
			[Token(Token = "0x6001C89")]
			[Address(RVA = "0x6E08", Offset = "0x6E08", VA = "0x6E08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C8A")]
			[Address(RVA = "0x6E09", Offset = "0x6E09", VA = "0x6E09")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00005F88 File Offset: 0x00004188
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000526")]
		public uint HistoryTournamentTypeId
		{
			[Token(Token = "0x6001C8B")]
			[Address(RVA = "0x6E0A", Offset = "0x6E0A", VA = "0x6E0A")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C8C")]
			[Address(RVA = "0x6E0B", Offset = "0x6E0B", VA = "0x6E0B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00005FA0 File Offset: 0x000041A0
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000527")]
		public bool UIBlocked
		{
			[Token(Token = "0x6001C8D")]
			[Address(RVA = "0x6E0C", Offset = "0x6E0C", VA = "0x6E0C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x6E0D", Offset = "0x6E0D", VA = "0x6E0D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00005FB8 File Offset: 0x000041B8
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000528")]
		public uint CurrentTournamentType
		{
			[Token(Token = "0x6001C8F")]
			[Address(RVA = "0x6E0E", Offset = "0x6E0E", VA = "0x6E0E")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C90")]
			[Address(RVA = "0x6E0F", Offset = "0x6E0F", VA = "0x6E0F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000529")]
		public TournamentData CurrentTournament
		{
			[Token(Token = "0x6001C91")]
			[Address(RVA = "0x6E10", Offset = "0x6E10", VA = "0x6E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00005FD0 File Offset: 0x000041D0
		// (set) Token: 0x06001C93 RID: 7315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052A")]
		public float PrizeCoef
		{
			[Token(Token = "0x6001C92")]
			[Address(RVA = "0x6E11", Offset = "0x6E11", VA = "0x6E11")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x6E12", Offset = "0x6E12", VA = "0x6E12")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00005FE8 File Offset: 0x000041E8
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052B")]
		public UserTNMStatus PlayerStatus
		{
			[Token(Token = "0x6001C94")]
			[Address(RVA = "0x6E13", Offset = "0x6E13", VA = "0x6E13")]
			[CompilerGenerated]
			get
			{
				return UserTNMStatus.Nobody;
			}
			[Token(Token = "0x6001C95")]
			[Address(RVA = "0x6E14", Offset = "0x6E14", VA = "0x6E14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052C")]
		public BackTime NextStateBacktime
		{
			[Token(Token = "0x6001C96")]
			[Address(RVA = "0x6E15", Offset = "0x6E15", VA = "0x6E15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C97")]
			[Address(RVA = "0x6E16", Offset = "0x6E16", VA = "0x6E16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x6E17", Offset = "0x6E17", VA = "0x6E17")]
		public void SetStateInfo(ProtoStateChangedEvt evt)
		{
		/* --- GHIDRA: SetStateInfo ---
		void Gameplay_Tournaments_Model_TournamentsModel__SetStateInfo
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *param1_00;
		  
		  if (DAT_ram_00a58510 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_TournamentInfo__TournamentData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_TournamentData__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentInfo__TournamentData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tournaments_Model_TournamentsModel__PopulateTournaments_b__44_0__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Model_TournamentsModel___c__PopulateTournaments_b__44_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo);
		    DAT_ram_00a58510 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  uVar2 = unnamed_function_1417(System_Func_TournamentInfo__TournamentData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,
		             Method_Gameplay_Tournaments_Model_TournamentsModel__PopulateTournaments_b__44_0__,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,uVar2,
		                     Method_System_Linq_Enumerable_Select_TournamentInfo__TournamentData___);
		  if (*(int *)(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar5[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar5;
		    iVar6 = unnamed_function_1417(System_Func_TournamentData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar6,uVar4,
		               Method_Gameplay_Tournaments_Model_TournamentsModel___c__PopulateTournaments_b__44_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Tournaments_Model_TournamentsModel___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  uVar2 = System_Linq_Enumerable__ToDictionary_object__object_
		                    (uVar2,iVar6,Method_System_Linq_Enumerable_ToDictionary_TournamentData__uint___)
		  ;
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80efe044;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80efe044:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)
		                      (*(int *)(*(int *)(*(int *)(iVar6 + 0x14) + 0x20) + 0x10) + 0x24),2,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  iVar6 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar2,0);
		  if (iVar6 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(param1 + 0x10),0);
		    iVar6 = Core_Extensions_Dict_DictExt__GetTreeLevelDic(uVar2,iVar6,0);
		    uVar2 = *(undefined4 *)(iVar6 + 0x10);
		  }
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  if (param3 != 0) {
		    *(undefined4 *)(param1 + 0x28) = *(undefined4 *)(*(int *)(param3 + 0x14) + 0x30);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param3 + 0xc);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x6E18", Offset = "0x6E18", VA = "0x6E18")]
		public void PopulateTournaments(ProtoGetTournamentListAns msg, TournamentInfo activeTournament)
		{
		/* --- GHIDRA: PopulateTournaments ---
		void Gameplay_Tournaments_Model_TournamentsModel__PopulateTournaments
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  uint *puVar4;
		  longlong lVar5;
		  int iVar6;
		  longlong lVar7;
		  int *piVar8;
		  uint uVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58511 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Fighter__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_Fighter__GetEnumerator__);
		    DAT_ram_00a58511 = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0x10),
		                              Method_Google_Protobuf_Collections_RepeatedField_Fighter__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80efe138:
		  piVar3 = local_4;
		  iVar6 = *local_4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		        puVar1 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		        goto code_r0x80efe1d0;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar1 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80efe218:
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80efe40b;
		  }
		code_r0x80efe1d0:
		  DAT_ram_009d3e38 = 0;
		  iVar6 = import::env::invoke_iii(*puVar1,piVar3,puVar1[1]);
		  piVar3 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80efe218;
		  if (iVar6 == 0) {
		    iVar6 = 0;
		    goto code_r0x80efe454;
		  }
		  iVar6 = *local_4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8);
		      if (System_Collections_Generic_IEnumerator_Fighter__TypeInfo == *piVar8) {
		        puVar1 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		        goto code_r0x80efe2bd;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar1 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_Generic_IEnumerator_Fighter__TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80efe3ef:
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80efe40b;
		  }
		code_r0x80efe2bd:
		  DAT_ram_009d3e38 = 0;
		  iVar6 = import::env::invoke_iii(*puVar1,piVar3,puVar1[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80efe3ef;
		  if (DAT_ram_00a5850e == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi
		              (0x7ff,&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__)
		    ;
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_00a5850e = '\x01';
		      goto code_r0x80efe33f;
		    }
		code_r0x80efe3f9:
		    DAT_ram_009d3e38 = 0;
		    param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80efe40b;
		  }
		code_r0x80efe33f:
		  DAT_ram_009d3e38 = 0;
		  iVar2 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                     *(undefined4 *)(param1 + 0xc),*(undefined4 *)(param1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80efe3f9;
		  *(undefined4 *)(iVar6 + 0x24) = *(undefined4 *)(*(int *)(iVar2 + 8) + 0x10);
		  lVar7 = *(longlong *)(*(int *)(iVar6 + 0xc) + 0x10);
		  DAT_ram_009d3e38 = 0;
		  lVar5 = unnamed_function_184054
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,
		                     *(undefined4 *)(param1 + 8),0);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    if (lVar7 == lVar5) {
		      *(undefined1 *)(iVar6 + 0x28) = 1;
		    }
		    goto code_r0x80efe138;
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80efe40b:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar6 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x80efe454:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar9 = 0;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		              puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80efe4cc;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80efe4cc:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (iVar6 == 0) {
		        *(int *)(param1 + 0x14) = param2;
		        *(undefined4 *)(param1 + 0x18) = param3;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17f,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x6E19", Offset = "0x6E19", VA = "0x6E19")]
		public void PopulateHistory(TournamentHistory history, uint tournamentTypeId)
		{
		/* --- GHIDRA: PopulateHistory ---
		undefined4
		Gameplay_Tournaments_Model_TournamentsModel__PopulateHistory
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  
		  if (DAT_ram_00a58512 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15168);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15149);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15158);
		    DAT_ram_00a58512 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0xc),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x28);
		  iVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta(uVar2,0);
		  if (iVar1 == 0) {
		    puVar3 = &StringLiteral_15149;
		    iVar1 = Core_Extensions_Dict_ResourceSetExt__IsZero(uVar2,param3,0);
		    if (iVar1 == 0) {
		      puVar3 = &StringLiteral_15168;
		    }
		  }
		  else {
		    puVar3 = &StringLiteral_15158;
		  }
		  uVar2 = *puVar3;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x6E1A", Offset = "0x6E1A", VA = "0x6E1A")]
		public string GetPlayerStatusLocalization(uint tournamentTypeId, ResourceSet minBet)
		{
		/* --- GHIDRA: GetPlayerStatusLocalization ---
		undefined4
		Gameplay_Tournaments_Model_TournamentsModel__GetPlayerStatusLocalization
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float4 local_4;
		  
		  if (DAT_ram_00a58513 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15163);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28593);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15167);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15151);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15145);
		    DAT_ram_00a58513 = '\x01';
		  }
		  if (param2 == 1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15151,1,0,1,0,0,0,0);
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15145,1,0,1,0,0,0,0);
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar1,StringLiteral_1481,uVar2,0);
		  }
		  else if (param2 == 2) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15151,1,0,1,0,0,0,0);
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15163,1,0,1,0,0,0,0);
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar1,StringLiteral_1481,uVar2,0);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15167,1,0,1,0,0,0,0);
		    local_4 = (float4)unnamed_function_24934((float)(param2 - 1));
		    uVar2 = func_ii_1081(DAT_ram_00a6696c,&local_4);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28593,uVar1,uVar2,0);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x6E1B", Offset = "0x6E1B", VA = "0x6E1B")]
		public string GetCurrentRoundLocalization(uint currentRound)
		{
		/* --- GHIDRA: GetCurrentRoundLocalization ---
		undefined4
		Gameplay_Tournaments_Model_TournamentsModel__GetCurrentRoundLocalization
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar1 = Core_Data_Tournaments_TournamentData__get_TypeId(param2,uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		private const string LOCALIZATION_GLADIATORS_TOURNAMENT = "TOURNAMENTS/GLADIATORS_TOURNAMENT";

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		private const string LOCALIATION_NOBODY = "TOURNAMENTS/NOBODY";

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		private const string LOCALIATION_GLADIATOR = "TOURNAMENTS/GLADIATOR";

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		private const string LOCALIATION_VIEWER = "TOURNAMENTS/VIEWER";

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		private const string LOCALIZATION_TOURNAMENT_ROUND = "TOURNAMENTS/TOURNAMENT_ROUND";

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		private const string LOCALIZATION_TOURNAMENTS_FINAL = "TOURNAMENTS/FINAL";

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		private const string LOCALIZATION_TOURNAMENTS_SEMIFINAL = "TOURNAMENTS/SEMIFINAL";

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<uint, TournamentData> TournamentsByTypeId;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x10")]
		private DictManager _dictManager;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x30")]
		public TabBarItemData[] TabBarData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Dict ---
		void Gameplay_Tournaments_Model_TournamentsModel__get_Dict
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  uint *puVar6;
		  
		  if (DAT_ram_00a5850d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__TournamentData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15151);
		    DAT_ram_00a5850d = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__TournamentData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__TournamentData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  piVar3 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,1);
		  iVar4 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_15151,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar5 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = iVar4;
		  *(int **)(param1 + 0x30) = piVar3;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80efdd49;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80efdd49:
		  uVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar3,puVar6[1]);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentTournamentType ---
		undefined4
		Gameplay_Tournaments_Model_TournamentsModel__set_CurrentTournamentType(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5850e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    DAT_ram_00a5850e = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_NextStateBacktime ---
		void Gameplay_Tournaments_Model_TournamentsModel__set_NextStateBacktime
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int local_4;
		  
		  if (DAT_ram_00a5850f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a5850f = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0xc),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    iVar1 = *(int *)(local_4 + 0xc);
		    iVar3 = *(int *)(param2 + 0x10);
		    *(int *)(iVar1 + 0x14) = iVar3;
		    if (*(int *)(iVar3 + 0xc) == 1) {
		      uVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		      *(undefined4 *)(iVar1 + 0x28) = uVar2;
		      iVar3 = *(int *)(local_4 + 0xc);
		      uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                        (*(undefined4 *)(param1 + 0x10),0);
		      iVar1 = Core_Extensions_Dict_DictExt__GetBlitzTournamentsDic
		                        (uVar2,*(undefined4 *)(param2 + 0xc),0);
		      *(undefined4 *)(iVar3 + 0x18) = *(undefined4 *)(iVar1 + 0x20);
		    }
		  }
		  if (*(int *)(param2 + 0xc) == *(int *)(param1 + 0x20)) {
		    *(undefined4 *)(param1 + 0x28) = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x30);
		  }
		  return;
		}
		*/

}
