using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers.Inventory;
using Gameplay.WorldAxis.Colossus.Combat;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.WorldAxis.Model
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	public class WorldAxisModel : AbstractModel
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000270")]
		public Dictionaries Dict
		{
			[Token(Token = "0x600109F")]
			[Address(RVA = "0x629C", Offset = "0x629C", VA = "0x629C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000271")]
		public IColossusCombatLauncher CombatLauncher
		{
			[Token(Token = "0x60010A0")]
			[Address(RVA = "0x629D", Offset = "0x629D", VA = "0x629D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A1")]
			[Address(RVA = "0x629E", Offset = "0x629E", VA = "0x629E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x629F", Offset = "0x629F", VA = "0x629F", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <DeterminePartyInfo>b__51_1 ---
		void Gameplay_WorldAxis_Model_WorldAxisModel___DeterminePartyInfo_b__51_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58af4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		    DAT_ram_00a58af4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <DeterminePartyInfo>b__51_0 ---
		uint Gameplay_WorldAxis_Model_WorldAxisModel___DeterminePartyInfo_b__51_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  lVar2 = *(longlong *)(param2 + 0x18);
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  return (uint)(lVar2 == lVar1);
		}
		*/

		/* --- GHIDRA: <PopulateDolls>b__50_0 ---
		undefined4
		Gameplay_WorldAxis_Model_WorldAxisModel___PopulateDolls_b__50_0
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58af3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_PartySlot___);
		    Mono_Security_ASN1__get_Item(&System_Func_PartySlot__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Model_WorldAxisModel__DeterminePartyInfo_b__51_1__);
		    DAT_ram_00a58af3 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Func_PartySlot__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Model_WorldAxisModel__DeterminePartyInfo_b__51_1__,0);
		  uVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_Any_PartySlot___);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: <GetAttackState>b__48_0 ---
		undefined4
		Gameplay_WorldAxis_Model_WorldAxisModel___GetAttackState_b__48_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58ae6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58ae6 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f74da7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f74da7:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  uVar3 = Core_Extensions_Dict_DictExt__GetColossusDic
		                    (uVar3,*(undefined8 *)(*(int *)(param2 + 0xc) + 0x10),0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Model_WorldAxisModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58ae7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ColossusBattleData___TypeInfo);
		    DAT_ram_00a58ae7 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(Core_Data_ColossusBattleData___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param5;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x62A0", Offset = "0x62A0", VA = "0x62A0")]
		public WorldAxisModel(IColossusCombatLauncher combatLauncher, UserData user, GolemInventoryManager golemInventoryManager, IDictProvider dictProvider)
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public ColossusBattleData[] ColossusBattles
		{
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0x62A1", Offset = "0x62A1", VA = "0x62A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A5")]
			[Address(RVA = "0x62A2", Offset = "0x62A2", VA = "0x62A2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000273")]
		public BackTime SeasonBacktime
		{
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0x62A3", Offset = "0x62A3", VA = "0x62A3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A7")]
			[Address(RVA = "0x62A4", Offset = "0x62A4", VA = "0x62A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x000045C0 File Offset: 0x000027C0
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		public bool SeasonActive
		{
			[Token(Token = "0x60010A8")]
			[Address(RVA = "0x62A5", Offset = "0x62A5", VA = "0x62A5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010A9")]
			[Address(RVA = "0x62A6", Offset = "0x62A6", VA = "0x62A6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000275")]
		public string SeasonStatusText
		{
			[Token(Token = "0x60010AA")]
			[Address(RVA = "0x62A7", Offset = "0x62A7", VA = "0x62A7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000276")]
		public DollsInfoDic SelectedDoll
		{
			[Token(Token = "0x60010AB")]
			[Address(RVA = "0x62A8", Offset = "0x62A8", VA = "0x62A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AC")]
			[Address(RVA = "0x62A9", Offset = "0x62A9", VA = "0x62A9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000277")]
		public DollsInfoDic[] AvailableDolls
		{
			[Token(Token = "0x60010AD")]
			[Address(RVA = "0x62AA", Offset = "0x62AA", VA = "0x62AA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AE")]
			[Address(RVA = "0x62AB", Offset = "0x62AB", VA = "0x62AB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x000045D8 File Offset: 0x000027D8
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000278")]
		public uint SelectedSlotId
		{
			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x62AC", Offset = "0x62AC", VA = "0x62AC")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x62AD", Offset = "0x62AD", VA = "0x62AD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010B2 RID: 4274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		public ColossusPartiesInfoDic SelectedParty
		{
			[Token(Token = "0x60010B1")]
			[Address(RVA = "0x62AE", Offset = "0x62AE", VA = "0x62AE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010B2")]
			[Address(RVA = "0x62AF", Offset = "0x62AF", VA = "0x62AF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027A")]
		public ResourceSet AttackPrice
		{
			[Token(Token = "0x60010B3")]
			[Address(RVA = "0x62B0", Offset = "0x62B0", VA = "0x62B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027B")]
		public ResourceSet DefencePrice
		{
			[Token(Token = "0x60010B4")]
			[Address(RVA = "0x62B1", Offset = "0x62B1", VA = "0x62B1")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x62B2", Offset = "0x62B2", VA = "0x62B2")]
		public void PopulateSchedule(ProtoGetScheduleAns msg)
		{
		/* --- GHIDRA: PopulateSchedule ---
		void Gameplay_WorldAxis_Model_WorldAxisModel__PopulateSchedule
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a58aeb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_ColossusBattleData__uint___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ScheduleEvent__ColossusBattleData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ColossusBattleData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusBattleData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ScheduleEvent__ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__CreateData_b__45_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass45_0__CreateData_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass45_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		    DAT_ram_00a58aeb = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass45_0_TypeInfo);
		  *(int *)(iVar1 + 0xc) = param1;
		  uVar2 = Gameplay_WorldAxis_Model_WorldAxisModel__UpdateColossusInfo(param1,param2,param1);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  uVar2 = unnamed_function_1417(System_Func_ScheduleEvent__ColossusBattleData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar2,iVar1,
		             Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass45_0__CreateData_b__0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,uVar2,
		                     Method_System_Linq_Enumerable_Select_ScheduleEvent__ColossusBattleData___);
		  if (*(int *)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Func_ColossusBattleData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar1,uVar3,Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__CreateData_b__45_1__,
		               0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x5c) + 4) = iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_OrderBy_ColossusBattleData__uint___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_ColossusBattleData___);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x62B3", Offset = "0x62B3", VA = "0x62B3")]
		public void CreateData(ProtoGetScheduleAns msg)
		{
		/* --- GHIDRA: CreateData ---
		/* WARNING: Removing unreachable block (ram,0x80f7409e) */
		
		void Gameplay_WorldAxis_Model_WorldAxisModel__CreateData(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int param2_00;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  undefined4 param2_01;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58aec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ColossusBattleData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusBattleData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ScheduleEvent__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ScheduleEvent__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass46_0__UpdateData_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass46_0_TypeInfo);
		    DAT_ram_00a58aec = '\x01';
		  }
		  uVar2 = Gameplay_WorldAxis_Model_WorldAxisModel__UpdateColossusInfo(param1,param2,param2);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_ScheduleEvent__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar6 = local_4;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80f73ff3;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7403b:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f742a3;
		      }
		code_r0x80f73ff3:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f7403b;
		      if (iVar8 == 0) {
		        iVar8 = 0;
		        goto code_r0x80f742ec;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass46_0_TypeInfo);
		      piVar6 = local_4;
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f742a3;
		      }
		      iVar5 = *local_4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_ScheduleEvent__TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar5 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80f74139;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ScheduleEvent__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7427d:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f742a3;
		      }
		code_r0x80f74139:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f7427d;
		      *(undefined4 *)(iVar8 + 8) = uVar4;
		      param2_01 = *(undefined4 *)(param1 + 0x18);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_ColossusBattleData__bool__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f74287:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f742a3;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,iVar8,
		                 Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass46_0__UpdateData_b__0__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f74287;
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21c,param2_01,uVar4
		                             ,Method_System_Linq_Enumerable_FirstOrDefault_ColossusBattleData___);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f742a3;
		      }
		    } while (param2_00 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23f,param2_00,
		               *(undefined4 *)(iVar8 + 8),uVar2,param1,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f742a3:
		  iVar8 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80f742ec:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f74364;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f74364:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x240,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x62B4", Offset = "0x62B4", VA = "0x62B4")]
		private void UpdateData(ProtoGetScheduleAns msg)
		{
		/* --- GHIDRA: UpdateData ---
		/* WARNING: Removing unreachable block (ram,0x80f74629) */
		
		void Gameplay_WorldAxis_Model_WorldAxisModel__UpdateData(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int param2_00;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 param2_01;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58aed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ColossusBattleData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusBattleData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ColossusInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ColossusInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass47_0__UpdateColossusInfo_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass47_0_TypeInfo);
		    DAT_ram_00a58aed = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_ColossusInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    do {
		      piVar5 = local_4;
		      iVar7 = *local_4;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		            puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80f7457e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f745c6:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f7482a;
		      }
		code_r0x80f7457e:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f745c6;
		      if (iVar7 == 0) {
		        iVar7 = 0;
		        goto code_r0x80f74873;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass47_0_TypeInfo);
		      piVar5 = local_4;
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f7482a;
		      }
		      iVar4 = *local_4;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_ColossusInfo__TypeInfo == *piVar8) {
		            puVar2 = (undefined4 *)(iVar4 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80f746c4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ColossusInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f74804:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f7482a;
		      }
		code_r0x80f746c4:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f74804;
		      *(undefined4 *)(iVar7 + 8) = uVar3;
		      param2_01 = *(undefined4 *)(param1 + 0x18);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_ColossusBattleData__bool__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7480e:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f7482a;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar3,iVar7,
		                 Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass47_0__UpdateColossusInfo_b__0__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f7480e;
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21c,param2_01,uVar3
		                             ,Method_System_Linq_Enumerable_FirstOrDefault_ColossusBattleData___);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f7482a;
		      }
		    } while (param2_00 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x241,param2_00,
		               *(undefined4 *)(iVar7 + 8),0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f7482a:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar7 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80f74873:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f748eb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f748eb:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar7 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x242,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x62B5", Offset = "0x62B5", VA = "0x62B5")]
		public void UpdateColossusInfo(ProtoGetColossusInfoAns msg)
		{
		/* --- GHIDRA: UpdateColossusInfo ---
		undefined4
		Gameplay_WorldAxis_Model_WorldAxisModel__UpdateColossusInfo(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58aee == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_ScheduleEvent___);
		    Mono_Security_ASN1__get_Item(&System_Func_ScheduleEvent__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Model_WorldAxisModel__GetAttackState_b__48_0__);
		    DAT_ram_00a58aee = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 8) + 0x68) == 0) {
		    return 1;
		  }
		  param1_01 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = unnamed_function_1417(System_Func_ScheduleEvent__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,param1,
		             Method_Gameplay_WorldAxis_Model_WorldAxisModel__GetAttackState_b__48_0__,0);
		  uVar2 = 2;
		  iVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (param1_01,param1_00,Method_System_Linq_Enumerable_Any_ScheduleEvent___);
		  if (iVar1 == 0) {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x62B6", Offset = "0x62B6", VA = "0x62B6")]
		private ColossusBattleData.State GetAttackState(ProtoGetScheduleAns msg)
		{
		/* --- GHIDRA: GetAttackState ---
		undefined4
		Gameplay_WorldAxis_Model_WorldAxisModel__GetAttackState
		          (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58aef == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58aef = '\x01';
		  }
		  if (*(char *)(param1 + 0x20) != '\0') {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar1 = func_ii_7331(param2 + param3,0);
		    uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,fVar1,0);
		    return uVar2;
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar1 = func_ii_7331(param2,0);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,fVar1,0);
		  return uVar2;
		}
		*/

			return ColossusBattleData.State.UNKNOWN_STATE;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x62B7", Offset = "0x62B7", VA = "0x62B7")]
		private BackTime CreateBacktime(long startTime, ulong duration)
		{
		/* --- GHIDRA: CreateBacktime ---
		void Gameplay_WorldAxis_Model_WorldAxisModel__CreateBacktime
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  
		  if (DAT_ram_00a58af0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_DollInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_DollInfo__DollsInfoDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_DollsInfoDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_DollInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_DollInfo__DollsInfoDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__PopulateDolls_b__50_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Model_WorldAxisModel__PopulateDolls_b__50_0__);
		    DAT_ram_00a58af0 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  uVar2 = unnamed_function_1417(System_Func_DollInfo__DollsInfoDic__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,Method_Gameplay_WorldAxis_Model_WorldAxisModel__PopulateDolls_b__50_0__,0)
		  ;
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,uVar2,Method_System_Linq_Enumerable_Select_DollInfo__DollsInfoDic___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_DollsInfoDic___);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  if (*(int *)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar5[2];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar5;
		    iVar6 = unnamed_function_1417(System_Func_DollInfo__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar6,uVar4,
		               Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__PopulateDolls_b__50_1__,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Model_WorldAxisModel___c_TypeInfo + 0x5c) + 8) = iVar6;
		  }
		  uVar1 = 0;
		  iVar6 = System_Func_object__bool____ctor
		                    (uVar2,iVar6,Method_System_Linq_Enumerable_FirstOrDefault_DollInfo___);
		  if (iVar6 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    if (DAT_ram_00a58ae6 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a58ae6 = '\x01';
		    }
		    param1_00 = *(int **)(param1 + 0xc);
		    iVar7 = *param1_00;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x80f74b1c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f74b1c:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))
		                      (param1_00,CONCAT44(in_register_20000014,puVar3[1]));
		    uVar2 = Core_Extensions_Dict_DictExt__GetColossusDic
		                      (uVar2,*(undefined8 *)(*(int *)(iVar6 + 0xc) + 0x10),0);
		  }
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x62B8", Offset = "0x62B8", VA = "0x62B8")]
		public void PopulateDolls(ProtoGetAvailDollsAns msg)
		{
		/* --- GHIDRA: PopulateDolls ---
		void Gameplay_WorldAxis_Model_WorldAxisModel__PopulateDolls(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a58af1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_PartyInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_PartyInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Model_WorldAxisModel__DeterminePartyInfo_b__51_0__);
		    DAT_ram_00a58af1 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0xc);
		  uVar2 = unnamed_function_1417(System_Func_PartyInfo__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_Model_WorldAxisModel__DeterminePartyInfo_b__51_0__,0);
		  iVar3 = System_Func_object__bool____ctor
		                    (param1_00,uVar2,Method_System_Linq_Enumerable_FirstOrDefault_PartyInfo___);
		  if (iVar3 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    if (DAT_ram_00a58ae6 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a58ae6 = '\x01';
		    }
		    param1_01 = *(int **)(param1 + 0xc);
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80f74c3f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f74c3f:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_01,puVar4[1]);
		    uVar2 = Core_Extensions_Dict_DictExt__GetDollInfoDic(uVar2,*(undefined4 *)(iVar3 + 0xc),0);
		  }
		  *(undefined4 *)(param1 + 0x30) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x62B9", Offset = "0x62B9", VA = "0x62B9")]
		public void DeterminePartyInfo(ProtoGetPartyInfoAns msg)
		{
		/* --- GHIDRA: DeterminePartyInfo ---
		uint Gameplay_WorldAxis_Model_WorldAxisModel__DeterminePartyInfo
		               (int param1,undefined8 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58af2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ColossusBattleData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusBattleData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass52_0__TryGetColossusDataByClanId_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass52_0_TypeInfo);
		    DAT_ram_00a58af2 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass52_0_TypeInfo);
		  *(undefined8 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Func_ColossusBattleData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_WorldAxis_Model_WorldAxisModel___c__DisplayClass52_0__TryGetColossusDataByClanId_b__0__
		             ,0);
		  iVar1 = System_Func_object__bool____ctor
		                    (param1_01,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ColossusBattleData___);
		  *param3 = iVar1;
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x62BA", Offset = "0x62BA", VA = "0x62BA")]
		public bool TryGetColossusDataByClanId(ulong clanId, out ColossusBattleData colossusData)
		{
		/* --- GHIDRA: TryGetColossusDataByClanId ---
		uint Gameplay_WorldAxis_Model_WorldAxisModel__TryGetColossusDataByClanId
		               (int param1,int param2,undefined4 param3)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  if (*(int *)(param2 + 0x24) != 0) {
		    lVar2 = *(longlong *)(*(int *)(param2 + 0x24) + 0x10);
		    lVar1 = Core_Data_UserData___ctor(*(undefined4 *)(param1 + 8),0);
		    return (uint)(lVar2 == lVar1);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x10")]
		public readonly GolemInventoryManager GolemInventoryManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SeasonActive ---
		undefined4 Gameplay_WorldAxis_Model_WorldAxisModel__set_SeasonActive(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  
		  if (DAT_ram_00a58ae8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17804);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17805);
		    DAT_ram_00a58ae8 = '\x01';
		  }
		  cVar1 = *(char *)(param1 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar3 = &StringLiteral_17804;
		  if (cVar1 == '\0') {
		    puVar3 = &StringLiteral_17805;
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar3,1,0,1,0,0,0,0);
		  return uVar2;
		}
		*/


		/* --- GHIDRA: set_SelectedParty ---
		undefined4 Gameplay_WorldAxis_Model_WorldAxisModel__set_SelectedParty(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58ae9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21417);
		    DAT_ram_00a58ae9 = '\x01';
		  }
		  if (DAT_ram_00a58ae6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58ae6 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f73b5d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f73b5d:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar3,StringLiteral_21417,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_AttackPrice ---
		undefined4 Gameplay_WorldAxis_Model_WorldAxisModel__get_AttackPrice(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58aea == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21418);
		    DAT_ram_00a58aea = '\x01';
		  }
		  if (DAT_ram_00a58ae6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58ae6 = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f73c30;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f73c30:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar3,StringLiteral_21418,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_DefencePrice ---
		void Gameplay_WorldAxis_Model_WorldAxisModel__get_DefencePrice
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 param2_00;
		  
		  iVar2 = *(int *)(param2 + 0x10);
		  if (iVar2 == 0) {
		    *(undefined1 *)(param1 + 0x20) = 0;
		  }
		  else {
		    param2_00 = *(undefined8 *)(iVar2 + 0x10);
		    *(byte *)(param1 + 0x20) = (byte)((ulonglong)param2_00 >> 0x3f);
		    uVar1 = Gameplay_WorldAxis_Model_WorldAxisModel__GetAttackState
		                      (param1,param2_00,*(undefined8 *)(iVar2 + 0x18),param1);
		    *(undefined4 *)(param1 + 0x1c) = uVar1;
		  }
		  if (*(int *)(*(int *)(param1 + 0x18) + 0xc) != 0) {
		    Gameplay_WorldAxis_Model_WorldAxisModel__CreateData(param1,param2,param1);
		    return;
		  }
		  Gameplay_WorldAxis_Model_WorldAxisModel__PopulateSchedule(param1,param2,param1);
		  return;
		}
		*/

}
