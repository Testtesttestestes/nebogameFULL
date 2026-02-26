using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Clans.Model;
using Gameplay.Discounts.Model;
using Gameplay.Isles.Clan;
using Gameplay.School.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.School;

namespace Gameplay.Clans.Buildings.MagicTower.Model
{
	// Token: 0x02000AB6 RID: 2742
	[Token(Token = "0x2000AB6")]
	public class MagicTowerModel : AbstractModel
	{
		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004229 RID: 16937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D09")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x6004228")]
			[Address(RVA = "0x90DC", Offset = "0x90DC", VA = "0x90DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004229")]
			[Address(RVA = "0x90DD", Offset = "0x90DD", VA = "0x90DD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D0A")]
		public ClanData ClanData
		{
			[Token(Token = "0x600422A")]
			[Address(RVA = "0x90DE", Offset = "0x90DE", VA = "0x90DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600422C RID: 16940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0B")]
		public Dictionary<uint, ClanSchoolSpellData> SpellsById
		{
			[Token(Token = "0x600422B")]
			[Address(RVA = "0x90DF", Offset = "0x90DF", VA = "0x90DF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600422C")]
			[Address(RVA = "0x90E0", Offset = "0x90E0", VA = "0x90E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x90E1", Offset = "0x90E1", VA = "0x90E1", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <PopulateSpells>b__15_0 ---
		void Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___PopulateSpells_b__15_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57810 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo);
		    DAT_ram_00a57810 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5780c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5780c = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x14) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80de2975;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80de2975:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80de2a2a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de2a2a:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(iVar5 + 0x10);
		  return;
		}
		*/

		}

		// Token: 0x0600422E RID: 16942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x90E2", Offset = "0x90E2", VA = "0x90E2")]
		public MagicTowerModel(UserData user, ClanIsle clanIsle)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a5780d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ShortSpellInfo__ClanSchoolSpellData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_ClanSchoolSpellData__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanSchoolSpellData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ShortSpellInfo__ClanSchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__PopulateSpells_b__15_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c__PopulateSpells_b__15_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo);
		    DAT_ram_00a5780d = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = unnamed_function_1417(System_Func_ShortSpellInfo__ClanSchoolSpellData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__PopulateSpells_b__15_0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ShortSpellInfo__ClanSchoolSpellData___);
		  if (*(int *)(Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo + 0x74) == 0
		       ) {
		      func_ii_306000(Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_ClanSchoolSpellData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar2,
		               Method_Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c__PopulateSpells_b__15_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___c_TypeInfo + 0x5c)
		            + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__object_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_ToDictionary_ClanSchoolSpellData__uint___);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600422F RID: 16943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422F")]
		[Address(RVA = "0x90E3", Offset = "0x90E3", VA = "0x90E3")]
		public void PopulateSpells(ProtoGetSchoolInfoAns msg)
		{
		/* --- GHIDRA: PopulateSpells ---
		undefined4
		Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__PopulateSpells
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  double param2_00;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                    (param2,CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0x114)));
		  uVar1 = Protocol_Common_ResourceSet___ctor(uVar1,0);
		  param2_00 = Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__GetCancelImproveMoneyBack
		                        (param2,param2);
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__Round(uVar1,param2_00,0);
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06004230 RID: 16944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x90E4", Offset = "0x90E4", VA = "0x90E4")]
		public ResourceSet GetCancelImproveMoneyBack(SchoolSpellData spell)
		{
		/* --- GHIDRA: GetCancelImproveMoneyBack ---
		double Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__GetCancelImproveMoneyBack
		                 (undefined4 param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5780e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25050);
		    DAT_ram_00a5780e = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80de3622;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80de3622:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  dVar3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar2,StringLiteral_25050,0);
		  return dVar3;
		}
		*/

			return null;
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x17000D0C")]
		public double LearnCancelRecoilCoeff
		{
			[Token(Token = "0x6004231")]
			[Address(RVA = "0x90E5", Offset = "0x90E5", VA = "0x90E5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x04002486 RID: 9350
		[Token(Token = "0x4002486")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x10")]
		public readonly ClansModel ClansModel;

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x14")]
		public readonly ClanIsle ClanIsle;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DiscountHandler ---
		undefined4
		Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__set_DiscountHandler
		          (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5780b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5780b = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x30);
		}
		*/


		/* --- GHIDRA: set_SpellsById ---
		void Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__set_SpellsById
		               (int param1,undefined4 param2)
		
		{
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_LearnCancelRecoilCoeff ---
		undefined4
		Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel__get_LearnCancelRecoilCoeff
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5780f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_MagicTower_Model_ClanSchoolSpellData_TypeInfo);
		    DAT_ram_00a5780f = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0xc);
		  param3_00 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x18);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Clans_Buildings_MagicTower_Model_ClanSchoolSpellData_TypeInfo);
		  Gameplay_School_Model_SchoolSpellData___ctor(param1_00,param2,param3_00,param4,0);
		  return param1_00;
		}
		*/

}
