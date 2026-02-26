using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Effect;
using Core.Data.Skills;
using Gameplay.Combat.Factories;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Combat.Model
{
	// Token: 0x02000998 RID: 2456
	[Token(Token = "0x2000998")]
	public class CombatPlayer : IDisposable
	{
		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x17000B80")]
		public ulong UserId
		{
			[Token(Token = "0x6003A9E")]
			[Address(RVA = "0x1B1F", Offset = "0x1B1F", VA = "0x1B1F")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B81")]
		public PlayerInfo PlayerInfo
		{
			[Token(Token = "0x6003A9F")]
			[Address(RVA = "0x8A14", Offset = "0x8A14", VA = "0x8A14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA0")]
			[Address(RVA = "0x8A15", Offset = "0x8A15", VA = "0x8A15")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B82")]
		public List<CombatSpellData> Spells
		{
			[Token(Token = "0x6003AA1")]
			[Address(RVA = "0x8A16", Offset = "0x8A16", VA = "0x8A16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA2")]
			[Address(RVA = "0x8A17", Offset = "0x8A17", VA = "0x8A17")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B83")]
		public ICombatSpellDataFactory SpellFactory
		{
			[Token(Token = "0x6003AA3")]
			[Address(RVA = "0x8A18", Offset = "0x8A18", VA = "0x8A18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA4")]
			[Address(RVA = "0x8A19", Offset = "0x8A19", VA = "0x8A19")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B84")]
		public UserData User
		{
			[Token(Token = "0x6003AA5")]
			[Address(RVA = "0x8A1A", Offset = "0x8A1A", VA = "0x8A1A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AA6")]
			[Address(RVA = "0x8A1B", Offset = "0x8A1B", VA = "0x8A1B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x17000B85")]
		public uint Level
		{
			[Token(Token = "0x6003AA7")]
			[Address(RVA = "0x8A1C", Offset = "0x8A1C", VA = "0x8A1C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x17000B86")]
		public RankTypes Rank
		{
			[Token(Token = "0x6003AA8")]
			[Address(RVA = "0x8A1D", Offset = "0x8A1D", VA = "0x8A1D")]
			get
			{
				return RankTypes.UnknownRankType;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x17000B87")]
		public bool HasStunned
		{
			[Token(Token = "0x6003AA9")]
			[Address(RVA = "0x8A1E", Offset = "0x8A1E", VA = "0x8A1E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06003AAA RID: 15018 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x17000B88")]
		public bool HasSpellBlocked
		{
			[Token(Token = "0x6003AAA")]
			[Address(RVA = "0x8A1F", Offset = "0x8A1F", VA = "0x8A1F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x8A20", Offset = "0x8A20", VA = "0x8A20", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Combat_Model_CombatPlayer__Dispose
		               (int *param1,int param2,int param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  int param2_00;
		  int *piVar6;
		  uint uVar7;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57e40 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Comparison_CombatSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData__Sort__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_PetData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Spells_SpellData_SortSpells__);
		    DAT_ram_00a57e40 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,
		             Method_System_Collections_Generic_List_Antiq_Types_EffectsDic_Types_EffectID___ctor__);
		  param1[6] = iVar1;
		  param1[5] = param3;
		  param1[2] = param2;
		  param1[4] = param4;
		  iVar1 = *param1;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		            (param1,*(undefined4 *)(param2 + 0x1c),*(undefined4 *)(iVar1 + 0xf4));
		  iVar1 = Gameplay_Combat_Model_CombatPlayer___ctor(param1,iVar1);
		  param1[3] = iVar1;
		  uVar2 = unnamed_function_1417(System_Comparison_CombatSpellData__TypeInfo);
		  System_Collections_Generic_Comparer_object___get_Default
		            (uVar2,0,Method_Core_Data_Spells_SpellData_SortSpells__,0);
		  Google_Protobuf_Collections_RepeatedField_uint___Contains
		            (iVar1,uVar2,Method_System_Collections_Generic_List_CombatSpellData__Sort__);
		  iVar1 = *(int *)(*(int *)(param2 + 0x28) + 0xc);
		  if (0 < iVar1) {
		    do {
		      if (param1[7] != 0) {
		        return;
		      }
		      iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param2 + 0x28),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar5 = *param1_00;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar6) {
		            puVar4 = (uint *)(piVar6[1] * 8 + iVar5 + 0x158);
		            goto code_r0x80e6a7d6;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80e6a7d6:
		      uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		      uVar2 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar2,0);
		      iVar3 = func_ii_8553(uVar2,*(undefined4 *)(iVar3 + 0x10),param3,0);
		      if (*(longlong *)(*(int *)(*(int *)(iVar3 + 8) + 0x10) + 0x40) != 0) {
		        iVar5 = unnamed_function_1417(Gameplay_Combat_Model_PetData_TypeInfo);
		        *(int **)(iVar5 + 0xc) = param1;
		        *(int *)(iVar5 + 8) = iVar3;
		        param1[7] = iVar5;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x8A21", Offset = "0x8A21", VA = "0x8A21")]
		public CombatPlayer(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellFactory)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Combat_Model_CombatPlayer___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined8 in_i2q;
		  undefined8 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int param1_01;
		  int param1_02;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int param2_00;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 *puVar10;
		  int iVar11;
		  undefined4 param2_01;
		  int param2_02;
		  int *piVar12;
		  double param3;
		  
		  uVar5 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  param2_02 = 0;
		  if (DAT_ram_00a57e41 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ArtSkillsConsts_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtifactInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ArtifactSkills_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_long___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_ICombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_ListExtensions_SetLength_double___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellCombat__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellCombat__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_Model_CombatPlayer___c__GetSpellsAndElixirs_b__39_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatPlayer___c_TypeInfo);
		    DAT_ram_00a57e41 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e6a97e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e6a97e:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  param2_00 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x20) + 0xc);
		  iVar7 = unnamed_function_1417(System_Collections_Generic_List_CombatSpellData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar7,param2_00,Method_System_Collections_Generic_List_CombatSpellData___ctor__);
		  if (0 < param2_00) {
		    do {
		      iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(*(int *)(param1 + 8) + 0x20),param2_02,
		                         Method_Google_Protobuf_Collections_RepeatedField_SpellCombat__get_Item__);
		      piVar6 = *(int **)(param1 + 0x10);
		      iVar8 = *piVar6;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (Gameplay_Combat_Factories_ICombatSpellDataFactory_TypeInfo == *piVar12) {
		            puVar3 = (uint *)(iVar8 + piVar12[1] * 8 + 0xc0);
		            goto code_r0x80e6aa47;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,
		                                    Gameplay_Combat_Factories_ICombatSpellDataFactory_TypeInfo,0);
		code_r0x80e6aa47:
		      uVar2 = CONCAT44(uVar5,puVar3[1]);
		      iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,iVar4,uVar2);
		      uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      uVar9 = *(undefined4 *)(iVar4 + 0x14);
		      if (*(int *)(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo);
		      }
		      puVar10 = *(undefined4 **)(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo + 0x5c);
		      iVar11 = puVar10[1];
		      if (iVar11 == 0) {
		        if (*(int *)(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo);
		          puVar10 = *(undefined4 **)(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo + 0x5c);
		        }
		        param2_01 = *puVar10;
		        iVar11 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		        System_Func_uint__Int32Enum___Invoke
		                  (iVar11,param2_01,
		                   Method_Gameplay_Combat_Model_CombatPlayer___c__GetSpellsAndElixirs_b__39_0__,0);
		        *(int *)(*(int *)(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo + 0x5c) + 4) = iVar11;
		      }
		      uVar9 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                        (uVar9,iVar11,Method_System_Linq_Enumerable_Select_uint__long___);
		      uVar9 = System_Linq_Enumerable__ToList_int_
		                        (uVar9,Method_System_Linq_Enumerable_ToList_long___);
		      uVar9 = Core_Data_Skills_Skills__AddMods(uVar9,0);
		      *(int *)(iVar8 + 0x34) = param1;
		      *(undefined4 *)(iVar8 + 0x18) = uVar9;
		      if (*(int *)(*(int *)(iVar4 + 0xc) + 0x10) != 0) {
		        uVar9 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(param1_00,0);
		        iVar11 = Gameplay_Inventory_Model_InventoryBaseModel__GetCount
		                           (uVar9,*(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x10),0);
		        if (iVar11 != 0) {
		          param1_01 = unnamed_function_1417(Protocol_Common_ArtifactInfo_TypeInfo);
		          Protocol_Common_ArtifactInfo__pb__Google_Protobuf_IMessage_get_Descriptor(param1_01,0);
		          *(undefined4 *)(param1_01 + 0x18) = *(undefined4 *)(iVar11 + 0xc);
		          param1_02 = unnamed_function_1417(Protocol_Common_ArtifactSkills_TypeInfo);
		          Protocol_Common_ArtifactSkills__pb__Google_Protobuf_IMessage_get_Descriptor(param1_02,0);
		          *(int *)(param1_01 + 0x20) = param1_02;
		          uVar5 = Protocol_Consts_ArtSkillsConsts_var;
		          uVar9 = *(undefined4 *)(param1_02 + 0xc);
		          if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a669a0);
		          }
		          uVar5 = func_ii_2734(uVar5,0);
		          if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		            func_ii_306000(DAT_ram_00a6697c);
		          }
		          uVar5 = System_Enum__GetUnderlyingType(uVar5,0);
		          uVar5 = System_Array__InternalArray__ICollection_Clear(uVar5,0);
		          Coffee_UISoftMaskInternal_ListExtensions__RemoveAtFast___Il2CppFullySharedGenericType_
		                    (uVar9,uVar5,Method_Sirenix_Utilities_ListExtensions_SetLength_double___);
		          param3 = (double)*(int *)(iVar4 + 0x1c);
		          Google_Protobuf_Collections_RepeatedField_double___get_IsReadOnly
		                    (*(undefined4 *)(*(int *)(param1_01 + 0x20) + 0xc),1,param3,
		                     Method_Google_Protobuf_Collections_RepeatedField_double__set_Item__);
		          uVar5 = (undefined4)((ulonglong)param3 >> 0x20);
		          Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		                    (*(undefined4 *)(*(int *)(param1_01 + 0x20) + 0x10),
		                     *(undefined4 *)(iVar11 + 0x28),
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar4 = *piVar6;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		                puVar3 = (uint *)(piVar12[1] * 8 + iVar4 + 0x140);
		                goto code_r0x80e6aca1;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e6aca1:
		          uVar9 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		          uVar9 = func_ii_7112(uVar9,0);
		          piVar6 = (int *)Core_Data_ArtifactData__IsGuideTarget(param1_01,uVar9,param1_00,0);
		          piVar6[0x1c] = *(int *)(param1 + 0x14);
		          *(int **)(iVar8 + 0x2c) = piVar6;
		          uVar9 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xf8) * 4))
		                            (piVar6,*(undefined4 *)(*piVar6 + 0xfc));
		          *(undefined4 *)(iVar8 + 0x3c) = uVar9;
		        }
		      }
		      iVar4 = Method_System_Collections_Generic_List_CombatSpellData__Add__;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar1 = *(uint *)(iVar7 + 0xc);
		      if (uVar1 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar1 + 1;
		        *(int *)(*(int *)(iVar7 + 8) + uVar1 * 4 + 0x10) = iVar8;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar7,iVar8,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		      }
		      param2_02 = param2_02 + 1;
		    } while (param2_02 != param2_00);
		  }
		  return iVar7;
		}
		*/

		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x8A22", Offset = "0x8A22", VA = "0x8A22")]
		private List<CombatSpellData> GetSpellsAndElixirs()
		{
		/* --- GHIDRA: GetSpellsAndElixirs ---
		undefined4
		Gameplay_Combat_Model_CombatPlayer__GetSpellsAndElixirs
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57e42 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		    DAT_ram_00a57e42 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0xc) + 0xc);
		  if (iVar3 < 1) {
		code_r0x80e6c646:
		    *param3 = 0;
		    return 0;
		  }
		  iVar2 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0xc),0,
		                     Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		  *param3 = iVar2;
		  iVar2 = Google_Protobuf_Reflection_EnumDescriptorProto_Types_EnumReservedRange__Equals
		                    (*(undefined4 *)(*(int *)(iVar2 + 0x38) + 0xc),param2,0);
		  if (iVar2 == 0) {
		    do {
		      param2_00 = param2_00 + 1;
		      if (param2_00 == iVar3) goto code_r0x80e6c646;
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0xc),param2_00,
		                         Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		      *param3 = iVar2;
		      iVar2 = Google_Protobuf_Reflection_EnumDescriptorProto_Types_EnumReservedRange__Equals
		                        (*(undefined4 *)(*(int *)(iVar2 + 0x38) + 0xc),param2,0);
		    } while (iVar2 == 0);
		    uVar1 = (uint)(param2_00 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x8A23", Offset = "0x8A23", VA = "0x8A23")]
		public bool TryGetSpell(SpellKey key, out CombatSpellData spell)
		{
		/* --- GHIDRA: TryGetSpell ---
		void Gameplay_Combat_Model_CombatPlayer__TryGetSpell(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  uint *puVar1;
		  int iVar2;
		  longlong *plVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint uVar8;
		  
		  uVar8 = 0;
		  iVar4 = 0;
		  if (DAT_ram_00a57e43 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_PlayerSkill__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_PlayerSkill__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skill_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skills_TypeInfo);
		    DAT_ram_00a57e43 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Data_Skills_Skills_TypeInfo);
		  Core_Data_Skills_Skills__ToString(param1_00,0);
		  param1_01 = unnamed_function_1417(Core_Data_Skills_Skills_TypeInfo);
		  Core_Data_Skills_Skills__ToString(param1_01,0);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_PlayerSkill__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		        puVar1 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e6c728;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_PlayerSkill__TypeInfo,
		                                0);
		code_r0x80e6c728:
		  iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  if (0 < iVar5) {
		    do {
		      iVar6 = *param2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		          if (System_Collections_Generic_IList_PlayerSkill__TypeInfo == *piVar7) {
		            puVar1 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80e6c7cf;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		      }
		      puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_PlayerSkill__TypeInfo,0)
		      ;
		code_r0x80e6c7cf:
		      iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(param2,iVar4,puVar1[1]);
		      iVar2 = unnamed_function_1417(Core_Data_Skills_Skill_TypeInfo);
		      *(int *)(iVar2 + 8) = iVar4;
		      *(longlong *)(iVar2 + 0x10) = (longlong)*(int *)(iVar6 + 0xc);
		      Core_Data_Skills_Skill___ctor(param1_00,iVar2,0);
		      iVar2 = unnamed_function_1417(Core_Data_Skills_Skill_TypeInfo);
		      *(int *)(iVar2 + 8) = iVar4;
		      *(longlong *)(iVar2 + 0x10) = (longlong)*(int *)(iVar6 + 0x10);
		      Core_Data_Skills_Skill___ctor(param1_01,iVar2,0);
		      iVar2 = *(int *)(param1 + 0x58);
		      if (iVar2 != 0) {
		        if (iVar4 == 0) {
		          iVar6 = *(int *)(iVar6 + 0xc);
		          if (DAT_ram_00a57e48 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		            DAT_ram_00a57e48 = '\x01';
		            iVar2 = *(int *)(param1 + 0x58);
		          }
		          iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                            (iVar2,0,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          plVar3 = (longlong *)(param1 + 0x48);
		        }
		        else if (iVar4 == 1) {
		          iVar6 = *(int *)(iVar6 + 0xc);
		          if (DAT_ram_00a57e47 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		            DAT_ram_00a57e47 = '\x01';
		            iVar2 = *(int *)(param1 + 0x58);
		          }
		          iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                            (iVar2,1,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          plVar3 = (longlong *)(param1 + 0x38);
		        }
		        else if (iVar4 == 2) {
		          iVar6 = *(int *)(iVar6 + 0xc);
		          if (DAT_ram_00a57e45 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		            DAT_ram_00a57e45 = '\x01';
		            iVar2 = *(int *)(param1 + 0x58);
		          }
		          iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                            (iVar2,2,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          plVar3 = (longlong *)(param1 + 0x40);
		        }
		        else if (iVar4 == 3) {
		          iVar6 = *(int *)(iVar6 + 0xc);
		          if (DAT_ram_00a57e46 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		            DAT_ram_00a57e46 = '\x01';
		            iVar2 = *(int *)(param1 + 0x58);
		          }
		          iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                            (iVar2,3,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          plVar3 = (longlong *)(param1 + 0x28);
		        }
		        else {
		          if (iVar4 != 4) goto code_r0x80e6c99d;
		          iVar6 = *(int *)(iVar6 + 0xc);
		          if (DAT_ram_00a57e44 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		            DAT_ram_00a57e44 = '\x01';
		            iVar2 = *(int *)(param1 + 0x58);
		          }
		          iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                            (iVar2,4,
		                             Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		          plVar3 = (longlong *)(param1 + 0x30);
		        }
		        *plVar3 = (longlong)iVar6 - *(longlong *)(iVar2 + 0x10);
		      }
		code_r0x80e6c99d:
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != iVar5);
		  }
		  *(undefined4 *)(param1 + 0x5c) = param1_01;
		  *(undefined4 *)(param1 + 0x58) = param1_00;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x8A24", Offset = "0x8A24", VA = "0x8A24", Slot = "6")]
		public virtual void SetPlayerSkills(IList<PlayerSkill> value)
		{
		/* --- GHIDRA: SetPlayerSkills ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e44 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),4,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/

		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06003AB0 RID: 15024 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x17000B89")]
		public long CurrentMana
		{
			[Token(Token = "0x6003AB0")]
			[Address(RVA = "0x8A25", Offset = "0x8A25", VA = "0x8A25")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x17000B8A")]
		public long TotalMana
		{
			[Token(Token = "0x6003AB1")]
			[Address(RVA = "0x8A26", Offset = "0x8A26", VA = "0x8A26")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x17000B8B")]
		public long CurrentHealth
		{
			[Token(Token = "0x6003AB2")]
			[Address(RVA = "0x8A27", Offset = "0x8A27", VA = "0x8A27")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x17000B8C")]
		public long TotalHealth
		{
			[Token(Token = "0x6003AB3")]
			[Address(RVA = "0x8A28", Offset = "0x8A28", VA = "0x8A28")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x17000B8D")]
		public long CurrentExtraHealth
		{
			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x8A29", Offset = "0x8A29", VA = "0x8A29")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x17000B8E")]
		public long TotalExtraHealth
		{
			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x8A2A", Offset = "0x8A2A", VA = "0x8A2A")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x17000B8F")]
		public long CurrentManaBoost
		{
			[Token(Token = "0x6003AB6")]
			[Address(RVA = "0x8A2B", Offset = "0x8A2B", VA = "0x8A2B")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x17000B90")]
		public long TotalManaBoost
		{
			[Token(Token = "0x6003AB7")]
			[Address(RVA = "0x8A2C", Offset = "0x8A2C", VA = "0x8A2C")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B91")]
		public virtual List<int> FiltredAbsoluteSkillsIndexes
		{
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x8A2D", Offset = "0x8A2D", VA = "0x8A2D", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002063 RID: 8291
		[Token(Token = "0x4002063")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<Antiq.Types.EffectsDic.Types.EffectID> AntiqEffectIndexes;

		// Token: 0x04002064 RID: 8292
		[Token(Token = "0x4002064")]
		[FieldOffset(Offset = "0x1C")]
		public PetData Pet;

		// Token: 0x04002065 RID: 8293
		[Token(Token = "0x4002065")]
		[FieldOffset(Offset = "0x20")]
		public CultDic CultDic;

		// Token: 0x04002066 RID: 8294
		[Token(Token = "0x4002066")]
		[FieldOffset(Offset = "0x24")]
		public List<EffectData> CurrentLongEffects;

		// Token: 0x04002067 RID: 8295
		[Token(Token = "0x4002067")]
		[FieldOffset(Offset = "0x28")]
		public long LastHealthDelta;

		// Token: 0x04002068 RID: 8296
		[Token(Token = "0x4002068")]
		[FieldOffset(Offset = "0x30")]
		public long LastManaDelta;

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0x38")]
		public long TotalHealthDelta;

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		[FieldOffset(Offset = "0x40")]
		public long TotalManaDelta;

		// Token: 0x0400206B RID: 8299
		[Token(Token = "0x400206B")]
		[FieldOffset(Offset = "0x48")]
		public long LastExtraHealthDelta;

		// Token: 0x0400206C RID: 8300
		[Token(Token = "0x400206C")]
		[FieldOffset(Offset = "0x50")]
		public bool SkillsNumbersEnabled;

		// Token: 0x0400206D RID: 8301
		[Token(Token = "0x400206D")]
		[FieldOffset(Offset = "0x54")]
		public uint LoggedUserSide;

		// Token: 0x0400206E RID: 8302
		[Token(Token = "0x400206E")]
		[FieldOffset(Offset = "0x58")]
		public Skills AbsoluteSkills;

		// Token: 0x0400206F RID: 8303
		[Token(Token = "0x400206F")]
		[FieldOffset(Offset = "0x5C")]
		public Skills ReleativeSkills;

		// Token: 0x04002070 RID: 8304
		[Token(Token = "0x4002070")]
		[FieldOffset(Offset = "0x60")]
		private List<int> _absoluteSkillsIndexes;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_UserId ---
		int * Gameplay_Combat_Model_CombatPlayer__get_UserId(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_User ---
		undefined4 Gameplay_Combat_Model_CombatPlayer__set_User(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 0x20);
		}
		*/


		/* --- GHIDRA: get_Level ---
		undefined4 Gameplay_Combat_Model_CombatPlayer__get_Level(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 0x28);
		}
		*/


		/* --- GHIDRA: get_Rank ---
		uint Gameplay_Combat_Model_CombatPlayer__get_Rank(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e3e = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),0xc,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return (uint)(0 < *(longlong *)(iVar1 + 0x10));
		}
		*/


		/* --- GHIDRA: get_HasStunned ---
		uint Gameplay_Combat_Model_CombatPlayer__get_HasStunned(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e3f = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),0xd,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return (uint)(0 < *(longlong *)(iVar1 + 0x10));
		}
		*/


		/* --- GHIDRA: get_HasSpellBlocked ---
		void Gameplay_Combat_Model_CombatPlayer__get_HasSpellBlocked(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x1c) != 0) {
		    *(undefined8 *)(*(int *)(param1 + 0x1c) + 8) = 0;
		  }
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_CurrentMana ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e45 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),2,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_TotalMana ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__get_TotalMana(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e46 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e46 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),3,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_CurrentHealth ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e47 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e47 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),1,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_TotalHealth ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__get_TotalHealth(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e48 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),0,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_CurrentExtraHealth ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__get_CurrentExtraHealth(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e49 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e49 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),0xe,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_TotalExtraHealth ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__get_TotalExtraHealth(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e4a = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),0x10,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_CurrentManaBoost ---
		undefined8 Gameplay_Combat_Model_CombatPlayer__get_CurrentManaBoost(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a57e4b = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x58),0xf,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_TotalManaBoost ---
		undefined4 Gameplay_Combat_Model_CombatPlayer__get_TotalManaBoost(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  longlong lVar2;
		  int iVar3;
		  uint param2_00;
		  uint uVar4;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a57e4c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    DAT_ram_00a57e4c = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x60);
		  if (iVar3 == 0) {
		    iVar3 = unnamed_function_1417(System_Collections_Generic_List_int__TypeInfo);
		    Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		              (iVar3,10,Method_System_Collections_Generic_List_int___ctor__);
		    *(int *)(param1 + 0x60) = iVar3;
		  }
		  *(undefined4 *)(iVar3 + 0xc) = 0;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  iVar3 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 0x58),
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		  if (0 < iVar3) {
		    do {
		      iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                        (*(undefined4 *)(param1 + 0x58),param2_01,
		                         Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		      lVar2 = Core_Data_ModifierData__IsProcent(*(undefined8 *)(iVar1 + 0x10),0);
		      iVar3 = Method_System_Collections_Generic_List_int__Add__;
		      if ((lVar2 != 0) &&
		         (param2_00 = *(uint *)(iVar1 + 8),
		         (1 << (param2_00 & 0x1f) & 0x1f01fU) == 0 || 0x10 < param2_00)) {
		        iVar1 = *(int *)(param1 + 0x60);
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar4 = *(uint *)(iVar1 + 0xc);
		        if (uVar4 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar4 + 1;
		          *(uint *)(*(int *)(iVar1 + 8) + uVar4 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar1,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		      }
		      iVar3 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                        (*(undefined4 *)(param1 + 0x58),
		                         Method_System_Collections_Generic_Dictionary_int__Skill__get_Count__);
		      param2_01 = param2_01 + 1;
		    } while (param2_01 < iVar3);
		  }
		  return *(undefined4 *)(param1 + 0x60);
		}
		*/


		/* --- GHIDRA: get_FiltredAbsoluteSkillsIndexes ---
		void Gameplay_Combat_Model_CombatPlayer__get_FiltredAbsoluteSkillsIndexes(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e4d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatPlayer___c_TypeInfo);
		    DAT_ram_00a57e4d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Combat_Model_CombatPlayer___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

}
