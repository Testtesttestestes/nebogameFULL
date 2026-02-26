using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Core.Data.Effect;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Core.Data.Spells
{
	// Token: 0x020010CF RID: 4303
	[Token(Token = "0x20010CF")]
	public class SpellData
	{
		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060064BF RID: 25791 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C0 RID: 25792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001462")]
		public virtual IBalanceSource Balance
		{
			[Token(Token = "0x60064BF")]
			[Address(RVA = "0xB0A7", Offset = "0xB0A7", VA = "0xB0A7", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C0")]
			[Address(RVA = "0xB0A8", Offset = "0xB0A8", VA = "0xB0A8", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060064C1 RID: 25793 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C2 RID: 25794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001463")]
		public SpellDic SpellDic
		{
			[Token(Token = "0x60064C1")]
			[Address(RVA = "0xB0A9", Offset = "0xB0A9", VA = "0xB0A9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C2")]
			[Address(RVA = "0xB0AA", Offset = "0xB0AA", VA = "0xB0AA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060064C3 RID: 25795 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C4 RID: 25796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001464")]
		public SpellLevelDic SpellLevelDic
		{
			[Token(Token = "0x60064C3")]
			[Address(RVA = "0xB0AB", Offset = "0xB0AB", VA = "0xB0AB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C4")]
			[Address(RVA = "0xB0AC", Offset = "0xB0AC", VA = "0xB0AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060064C5 RID: 25797 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064C6 RID: 25798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001465")]
		public Dictionary<uint, EffectData> Effects
		{
			[Token(Token = "0x60064C5")]
			[Address(RVA = "0xB0AD", Offset = "0xB0AD", VA = "0xB0AD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064C6")]
			[Address(RVA = "0xB0AE", Offset = "0xB0AE", VA = "0xB0AE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060064C7 RID: 25799 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x17001466")]
		public uint Id
		{
			[Token(Token = "0x60064C7")]
			[Address(RVA = "0x1CFD", Offset = "0x1CFD", VA = "0x1CFD")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060064C8 RID: 25800 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x17001467")]
		public virtual uint Level
		{
			[Token(Token = "0x60064C8")]
			[Address(RVA = "0xB0AF", Offset = "0xB0AF", VA = "0xB0AF", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x000132A8 File Offset: 0x000114A8
		[Token(Token = "0x17001468")]
		public bool IsCultSpell
		{
			[Token(Token = "0x60064C9")]
			[Address(RVA = "0x2143", Offset = "0x2143", VA = "0x2143")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060064CA RID: 25802 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x17001469")]
		public long ManaPriceOfUse
		{
			[Token(Token = "0x60064CA")]
			[Address(RVA = "0xB0B0", Offset = "0xB0B0", VA = "0xB0B0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x1700146A")]
		public long ManaBoostPriceOfUse
		{
			[Token(Token = "0x60064CB")]
			[Address(RVA = "0xB0B1", Offset = "0xB0B1", VA = "0xB0B1")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060064CC RID: 25804 RVA: 0x000132F0 File Offset: 0x000114F0
		// (set) Token: 0x060064CD RID: 25805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700146B")]
		public virtual bool Enabled
		{
			[Token(Token = "0x60064CC")]
			[Address(RVA = "0xB0B2", Offset = "0xB0B2", VA = "0xB0B2", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60064CD")]
			[Address(RVA = "0xB0B3", Offset = "0xB0B3", VA = "0xB0B3", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060064CE RID: 25806 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700146C")]
		public ResourceSet PriceOfUse
		{
			[Token(Token = "0x60064CE")]
			[Address(RVA = "0x2A3B", Offset = "0x2A3B", VA = "0x2A3B")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060064CF RID: 25807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700146D")]
		public virtual AbstractSpellsBasedDescription Description
		{
			[Token(Token = "0x60064CF")]
			[Address(RVA = "0xB0B4", Offset = "0xB0B4", VA = "0xB0B4", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060064D0 RID: 25808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D0")]
		[Address(RVA = "0xB0B5", Offset = "0xB0B5", VA = "0xB0B5")]
		public SpellData()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Data_Spells_SpellData___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(param1 + 0xc);
		  if ((iVar2 == 0) || (*(int *)(iVar2 + 0x10) == 0)) {
		    iVar3 = *(int *)(param2 + 0xc);
		    if (*(int *)(iVar3 + 0x10) != 0) {
		      return 0xffffffff;
		    }
		  }
		  else {
		    if (*(int *)(param2 + 0xc) == 0) {
		      return 1;
		    }
		    if (*(int *)(*(int *)(param2 + 0xc) + 0x10) == 0) {
		      return 1;
		    }
		    iVar3 = *(int *)(param2 + 0xc);
		  }
		  uVar1 = 1;
		  if ((*(uint *)(iVar2 + 0x18) <= *(uint *)(iVar3 + 0x18)) &&
		     (uVar1 = 0xffffffff, *(uint *)(iVar3 + 0x18) <= *(uint *)(iVar2 + 0x18))) {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Core_Data_Spells_SpellData___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(param1 + 0xc);
		  if ((iVar2 == 0) || (*(int *)(iVar2 + 0x10) == 0)) {
		    iVar3 = *(int *)(param2 + 0xc);
		    if (*(int *)(iVar3 + 0x10) != 0) {
		      return 0xffffffff;
		    }
		  }
		  else {
		    if (*(int *)(param2 + 0xc) == 0) {
		      return 1;
		    }
		    if (*(int *)(*(int *)(param2 + 0xc) + 0x10) == 0) {
		      return 1;
		    }
		    iVar3 = *(int *)(param2 + 0xc);
		  }
		  uVar1 = 1;
		  if ((*(uint *)(iVar2 + 0x18) <= *(uint *)(iVar3 + 0x18)) &&
		     (uVar1 = 0xffffffff, *(uint *)(iVar3 + 0x18) <= *(uint *)(iVar2 + 0x18))) {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Core_Data_Spells_SpellData___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(param1 + 0xc);
		  if ((iVar2 == 0) || (*(int *)(iVar2 + 0x10) == 0)) {
		    iVar3 = *(int *)(param2 + 0xc);
		    if (*(int *)(iVar3 + 0x10) != 0) {
		      return 0xffffffff;
		    }
		  }
		  else {
		    if (*(int *)(param2 + 0xc) == 0) {
		      return 1;
		    }
		    if (*(int *)(*(int *)(param2 + 0xc) + 0x10) == 0) {
		      return 1;
		    }
		    iVar3 = *(int *)(param2 + 0xc);
		  }
		  uVar1 = 1;
		  if ((*(uint *)(iVar2 + 0x18) <= *(uint *)(iVar3 + 0x18)) &&
		     (uVar1 = 0xffffffff, *(uint *)(iVar3 + 0x18) <= *(uint *)(iVar2 + 0x18))) {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D1")]
		[Address(RVA = "0xB0B6", Offset = "0xB0B6", VA = "0xB0B6")]
		public SpellData(SpellDic spellDic, SpellLevelDic spellLevelDic)
		{
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D2")]
		[Address(RVA = "0xB0B7", Offset = "0xB0B7", VA = "0xB0B7")]
		public SpellData(uint spellId, uint level, Dictionaries dict)
		{
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064D3")]
		public static T Create<T>(SpellDic spellDic, SpellLevelDic spellLevelDic) where T : SpellData, new()
		{
			return null;
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064D4")]
		public static T Create<T>(uint spellId, uint spellLevel) where T : SpellData, new()
		{
			return null;
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064D5")]
		public static T Create<T>(ArtikulDic.Types.SpellInfo spellInfo) where T : SpellData, new()
		{
			return null;
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x60064D6")]
		[Address(RVA = "0xB0B8", Offset = "0xB0B8", VA = "0xB0B8")]
		public static int SortSpells(SpellData a, SpellData b)
		{
		/* --- GHIDRA: SortSpells ---
		void Core_Data_Spells_SpellData__SortSpells
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a60811 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Effect_EffectDescription_TypeInfo);
		    DAT_ram_00a60811 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  iVar1 = unnamed_function_1417(Core_Data_Effect_EffectDescription_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param4;
		  *(undefined4 *)(iVar1 + 0x10) = 0;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  *(int *)(param1 + 0x14) = iVar1;
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x18")]
		public Skills SpellSkills;

		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x1C")]
		public Skills SpellSkillsNext;

		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x24")]
		private ResourceSet _priceOfUse;

		// Token: 0x040035CB RID: 13771
		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x28")]
		protected AbstractSpellsBasedDescription _description;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Id ---
		int * Core_Data_Spells_SpellData__get_Id(int *param1)
		
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


		/* --- GHIDRA: get_Level ---
		undefined8 Core_Data_Spells_SpellData__get_Level(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6080b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a6080b = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x18),0,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_IsCultSpell ---
		void Core_Data_Spells_SpellData__get_IsCultSpell(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xf4));
		  uVar3 = Gameplay_School_Model_SchoolSpellData__get_Level(param2,0);
		  uVar4 = Gameplay_School_Model_SchoolSpellData__set_ActionBacktime(param2,0);
		  *(undefined4 *)(param1 + 8) = 0xffffffff;
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  *(char *)(param1 + 0x18) = (char)uVar4;
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  return;
		}
		*/


		/* --- GHIDRA: get_ManaPriceOfUse ---
		undefined8 Core_Data_Spells_SpellData__get_ManaPriceOfUse(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6080c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a6080c = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x18),7,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: set_Enabled ---
		int Core_Data_Spells_SpellData__set_Enabled(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a6080d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Spells_SpellData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Spells_SpellsBasedDescription_TypeInfo);
		    DAT_ram_00a6080d = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x28);
		  if (iVar4 == 0) {
		    uVar1 = Core_Extensions_Dict_SpellDicExt__GetTitle(*(undefined4 *)(param1 + 0xc),0);
		    piVar2 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_Spells_SpellData___TypeInfo,1);
		    iVar4 = func_ii_1082(param1,*(undefined4 *)(*piVar2 + 0x20));
		    if (iVar4 == 0) {
		      uVar1 = func_ii_1083();
		      func_ii_1050(uVar1,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar2[4] = param1;
		    iVar4 = unnamed_function_1417(Core_Data_Spells_SpellsBasedDescription_TypeInfo);
		    if (DAT_ram_00a60811 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Data_Effect_EffectDescription_TypeInfo);
		      DAT_ram_00a60811 = '\x01';
		    }
		    *(int **)(iVar4 + 0x10) = piVar2;
		    *(undefined4 *)(iVar4 + 0xc) = uVar1;
		    iVar3 = unnamed_function_1417(Core_Data_Effect_EffectDescription_TypeInfo);
		    *(undefined8 *)(iVar3 + 0x10) = 0;
		    *(undefined4 *)(iVar3 + 0xc) = uVar1;
		    *(int *)(iVar4 + 0x14) = iVar3;
		    *(int *)(param1 + 0x28) = iVar4;
		  }
		  return iVar4;
		}
		*/


		/* --- GHIDRA: get_PriceOfUse ---
		int * Core_Data_Spells_SpellData__get_PriceOfUse(int *param1)
		
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


		/* --- GHIDRA: get_Description ---
		void Core_Data_Spells_SpellData__get_Description(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6080e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__EffectData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__EffectData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_Skills_TypeInfo);
		    DAT_ram_00a6080e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__EffectData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__EffectData___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(Core_Data_Skills_Skills_TypeInfo);
		  if (DAT_ram_00a60832 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		    DAT_ram_00a60832 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(Core_Data_Skills_Skills_TypeInfo);
		  if (DAT_ram_00a60832 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		    DAT_ram_00a60832 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_int__Skill___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: Create<object> ---
		void Core_Data_Spells_SpellData__Create_object_(int param1,undefined4 param2,int param3)
		
		{
		  short sVar1;
		  short sVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  *(undefined4 *)(param1 + 0x34) = param2;
		  sVar1 = *(short *)(param1 + 0x12);
		  sVar2 = *(short *)(param1 + 0x10);
		  param1_01 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  param1_00 = unnamed_function_1417(param1_01);
		  UnityEngine_Purchasing_Default_Factory__Create
		            (param1_00,(int)sVar2,(int)sVar1,*(undefined4 *)(*(int *)(param3 + 0x1c) + 4));
		  *(undefined4 *)(param1 + 0x38) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: Create<object> ---
		void Core_Data_Spells_SpellData__Create_object_(int param1,undefined4 param2,int param3)
		
		{
		  short sVar1;
		  short sVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  *(undefined4 *)(param1 + 0x34) = param2;
		  sVar1 = *(short *)(param1 + 0x12);
		  sVar2 = *(short *)(param1 + 0x10);
		  param1_01 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  param1_00 = unnamed_function_1417(param1_01);
		  UnityEngine_Purchasing_Default_Factory__Create
		            (param1_00,(int)sVar2,(int)sVar1,*(undefined4 *)(*(int *)(param3 + 0x1c) + 4));
		  *(undefined4 *)(param1 + 0x38) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: Create<object> ---
		void Core_Data_Spells_SpellData__Create_object_(int param1,undefined4 param2,int param3)
		
		{
		  short sVar1;
		  short sVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  *(undefined4 *)(param1 + 0x34) = param2;
		  sVar1 = *(short *)(param1 + 0x12);
		  sVar2 = *(short *)(param1 + 0x10);
		  param1_01 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  param1_00 = unnamed_function_1417(param1_01);
		  UnityEngine_Purchasing_Default_Factory__Create
		            (param1_00,(int)sVar2,(int)sVar1,*(undefined4 *)(*(int *)(param3 + 0x1c) + 4));
		  *(undefined4 *)(param1 + 0x38) = param1_00;
		  return;
		}
		*/

}
