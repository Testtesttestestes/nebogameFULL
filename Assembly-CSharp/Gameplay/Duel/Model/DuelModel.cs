using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Duel;
using Utils;

namespace Gameplay.Duel.Model
{
	// Token: 0x02000860 RID: 2144
	[Token(Token = "0x2000860")]
	public class DuelModel : AbstractModel
	{
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F0")]
		public DuelModel.DuelUserData Player
		{
			[Token(Token = "0x6003257")]
			[Address(RVA = "0x82AC", Offset = "0x82AC", VA = "0x82AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003258")]
			[Address(RVA = "0x82AD", Offset = "0x82AD", VA = "0x82AD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600325A RID: 12890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F1")]
		public DuelModel.DuelUserData Opponent
		{
			[Token(Token = "0x6003259")]
			[Address(RVA = "0x82AE", Offset = "0x82AE", VA = "0x82AE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600325A")]
			[Address(RVA = "0x82AF", Offset = "0x82AF", VA = "0x82AF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F2")]
		public DuelModel.DuelData CurrentDuel
		{
			[Token(Token = "0x600325B")]
			[Address(RVA = "0x82B0", Offset = "0x82B0", VA = "0x82B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600325C")]
			[Address(RVA = "0x82B1", Offset = "0x82B1", VA = "0x82B1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F3")]
		public BackTime Backtimer
		{
			[Token(Token = "0x600325D")]
			[Address(RVA = "0x82B2", Offset = "0x82B2", VA = "0x82B2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600325E")]
			[Address(RVA = "0x82B3", Offset = "0x82B3", VA = "0x82B3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F4")]
		public RequirementDic RequirementDic
		{
			[Token(Token = "0x600325F")]
			[Address(RVA = "0x82B4", Offset = "0x82B4", VA = "0x82B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003260")]
			[Address(RVA = "0x82B5", Offset = "0x82B5", VA = "0x82B5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003261")]
		[Address(RVA = "0x82B6", Offset = "0x82B6", VA = "0x82B6")]
		public DuelModel(UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Duel_Model_DuelModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57bd7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Model_DuelModel_DuelUserData_TypeInfo);
		    DAT_ram_00a57bd7 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Duel_Model_DuelModel_DuelUserData_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  *(int *)(param1 + 0x14) = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x82B7", Offset = "0x82B7", VA = "0x82B7")]
		public void SetOpponent(UserData opponent)
		{
		/* --- GHIDRA: SetOpponent ---
		void Gameplay_Duel_Model_DuelModel__SetOpponent(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57bd8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Model_DuelModel_DuelData_TypeInfo);
		    DAT_ram_00a57bd8 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Duel_Model_DuelModel_DuelData_TypeInfo);
		  *(int *)(iVar1 + 0xc) = param2;
		  uVar2 = Core_Extensions_Dict_DictExt__GetHordeMonstersByMainMonsterIdSorted
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0xc),0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  *(int *)(param1 + 0x18) = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003263 RID: 12899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003263")]
		[Address(RVA = "0x82B8", Offset = "0x82B8", VA = "0x82B8")]
		public void CreateDuel(ProtoGetDuelsInfoAns.Types.DuelInfo info)
		{
		}

		// Token: 0x04001B9A RID: 7066
		[Token(Token = "0x4001B9A")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x02000861 RID: 2145
		[Token(Token = "0x2000861")]
		public class DuelUserData
		{
			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x06003264 RID: 12900 RVA: 0x0000A428 File Offset: 0x00008628
			[Token(Token = "0x170009F5")]
			public ulong UserId
			{
				[Token(Token = "0x6003264")]
				[Address(RVA = "0x82B9", Offset = "0x82B9", VA = "0x82B9")]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x06003265 RID: 12901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003265")]
			[Address(RVA = "0x82BA", Offset = "0x82BA", VA = "0x82BA")]
			public DuelUserData()
			{
			}

			// Token: 0x04001BA0 RID: 7072
			[Token(Token = "0x4001BA0")]
			[FieldOffset(Offset = "0x8")]
			public UserData Data;

			// Token: 0x04001BA1 RID: 7073
			[Token(Token = "0x4001BA1")]
			[FieldOffset(Offset = "0xC")]
			public SkillCollection Skills;

			// Token: 0x04001BA2 RID: 7074
			[Token(Token = "0x4001BA2")]
			[FieldOffset(Offset = "0x10")]
			public DuelUserInfo DuelUserUnfo;
		}

		// Token: 0x02000862 RID: 2146
		[Token(Token = "0x2000862")]
		public class DuelData
		{
			// Token: 0x06003266 RID: 12902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003266")]
			[Address(RVA = "0x82BB", Offset = "0x82BB", VA = "0x82BB")]
			public DuelData()
			{
			}

			// Token: 0x04001BA3 RID: 7075
			[Token(Token = "0x4001BA3")]
			[FieldOffset(Offset = "0x8")]
			public DuelTypesDict DuelTypeDic;

			// Token: 0x04001BA4 RID: 7076
			[Token(Token = "0x4001BA4")]
			[FieldOffset(Offset = "0xC")]
			public ProtoGetDuelsInfoAns.Types.DuelInfo DuelInfo;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_RequirementDic ---
		void Gameplay_Duel_Model_DuelModel__set_RequirementDic
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57bd6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Model_DuelModel_DuelUserData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57bd6 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80e331dd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e331dd:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  iVar4 = unnamed_function_1417(Gameplay_Duel_Model_DuelModel_DuelUserData_TypeInfo);
		  *(undefined4 *)(iVar4 + 8) = param2;
		  *(int *)(param1 + 0x10) = iVar4;
		  return;
		}
		*/

}
