using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.School.Model
{
	// Token: 0x02000647 RID: 1607
	[Token(Token = "0x2000647")]
	public class SchoolModel : AbstractModel
	{
		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074B")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x60026E6")]
			[Address(RVA = "0x781B", Offset = "0x781B", VA = "0x781B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026E7")]
			[Address(RVA = "0x781C", Offset = "0x781C", VA = "0x781C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700074C")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60026E8")]
			[Address(RVA = "0x781D", Offset = "0x781D", VA = "0x781D")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x781E", Offset = "0x781E", VA = "0x781E")]
		public SchoolModel(UserData user, UserData loggedUser)
		{
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026EB RID: 9963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074D")]
		public UserData LoggedUser
		{
			[Token(Token = "0x60026EA")]
			[Address(RVA = "0x781F", Offset = "0x781F", VA = "0x781F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026EB")]
			[Address(RVA = "0x7820", Offset = "0x7820", VA = "0x7820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x00007728 File Offset: 0x00005928
		// (set) Token: 0x060026ED RID: 9965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074E")]
		public int RequestFlags
		{
			[Token(Token = "0x60026EC")]
			[Address(RVA = "0x7821", Offset = "0x7821", VA = "0x7821")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60026ED")]
			[Address(RVA = "0x7822", Offset = "0x7822", VA = "0x7822")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026EF RID: 9967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700074F")]
		public List<SpellModifierInfo> Modifiers
		{
			[Token(Token = "0x60026EE")]
			[Address(RVA = "0x7823", Offset = "0x7823", VA = "0x7823")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026EF")]
			[Address(RVA = "0x7824", Offset = "0x7824", VA = "0x7824")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000750")]
		public Dictionary<uint, SchoolSpellData> Spells
		{
			[Token(Token = "0x60026F0")]
			[Address(RVA = "0x7825", Offset = "0x7825", VA = "0x7825")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F1")]
			[Address(RVA = "0x7826", Offset = "0x7826", VA = "0x7826")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x17000751")]
		public double LearnCancelRecoilCoeff
		{
			[Token(Token = "0x60026F2")]
			[Address(RVA = "0x7827", Offset = "0x7827", VA = "0x7827")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x7828", Offset = "0x7828", VA = "0x7828", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDictProvider _dictProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DiscountHandler ---
		undefined4 Gameplay_School_Model_SchoolModel__set_DiscountHandler(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a050 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5a050 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811b9cff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811b9cff:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_Dict ---
		void Gameplay_School_Model_SchoolModel__get_Dict
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a051 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a051 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x14) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x811b9ddd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b9ddd:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  return;
		}
		*/


		/* --- GHIDRA: set_Spells ---
		double Gameplay_School_Model_SchoolModel__set_Spells(undefined4 param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a052 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25050);
		    DAT_ram_00a5a052 = '\x01';
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
		        goto code_r0x811b9eb8;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b9eb8:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  dVar3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar2,StringLiteral_25050,0);
		  return dVar3;
		}
		*/


		/* --- GHIDRA: get_LearnCancelRecoilCoeff ---
		void Gameplay_School_Model_SchoolModel__get_LearnCancelRecoilCoeff(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  *(undefined4 *)(param1 + 0xc) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
