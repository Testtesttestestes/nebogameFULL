using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.Tournaments;

namespace Core.Data.Tournaments
{
	// Token: 0x020010CC RID: 4300
	[Token(Token = "0x20010CC")]
	public class TournamentData : ITournament
	{
		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145B")]
		public TournamentDic Dic
		{
			[Token(Token = "0x60064AB")]
			[Address(RVA = "0xB093", Offset = "0xB093", VA = "0xB093")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064AC")]
			[Address(RVA = "0xB094", Offset = "0xB094", VA = "0xB094")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064AE RID: 25774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145C")]
		public TournamentInfo Info
		{
			[Token(Token = "0x60064AD")]
			[Address(RVA = "0xB095", Offset = "0xB095", VA = "0xB095")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064AE")]
			[Address(RVA = "0xB096", Offset = "0xB096", VA = "0xB096")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060064AF RID: 25775 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064B0 RID: 25776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145D")]
		public UserData PreviousWinnerData
		{
			[Token(Token = "0x60064AF")]
			[Address(RVA = "0xB097", Offset = "0xB097", VA = "0xB097")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064B0")]
			[Address(RVA = "0xB098", Offset = "0xB098", VA = "0xB098")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060064B1 RID: 25777 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064B2 RID: 25778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145E")]
		public RewardData[] WinnerRewards
		{
			[Token(Token = "0x60064B1")]
			[Address(RVA = "0xB099", Offset = "0xB099", VA = "0xB099")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064B2")]
			[Address(RVA = "0xB09A", Offset = "0xB09A", VA = "0xB09A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060064B3 RID: 25779 RVA: 0x00013248 File Offset: 0x00011448
		// (set) Token: 0x060064B4 RID: 25780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145F")]
		public Resources BetResource
		{
			[Token(Token = "0x60064B3")]
			[Address(RVA = "0xB09B", Offset = "0xB09B", VA = "0xB09B")]
			[CompilerGenerated]
			get
			{
				return Resources.UnknownResource;
			}
			[Token(Token = "0x60064B4")]
			[Address(RVA = "0xB09C", Offset = "0xB09C", VA = "0xB09C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060064B5 RID: 25781 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x17001460")]
		public uint TypeId
		{
			[Token(Token = "0x60064B5")]
			[Address(RVA = "0xB09D", Offset = "0xB09D", VA = "0xB09D", Slot = "4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064B6")]
		[Address(RVA = "0xB09E", Offset = "0xB09E", VA = "0xB09E")]
		public static TournamentData Create(TournamentInfo tournament, Dictionaries dict)
		{
		/* --- GHIDRA: Create ---
		undefined4 Core_Data_Tournaments_TournamentData__Create(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined **ppuVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a60808 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15134);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15146);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15140);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15142);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15170);
		    DAT_ram_00a60808 = '\x01';
		  }
		  uVar1 = *(int *)(*(int *)(*(int *)(param1 + 0xc) + 0x14) + 0xc) - 1;
		  ppuVar2 = &PTR_StringLiteral_15142_ram_005a3b58 + uVar1;
		  if (5 < uVar1) {
		    ppuVar2 = (undefined **)(DAT_ram_00a66978 + 0x5c);
		  }
		  uVar3 = *(undefined4 *)*ppuVar2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar3,1,0,1,0,0,0,0);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064B7")]
		[Address(RVA = "0xB09F", Offset = "0xB09F", VA = "0xB09F")]
		public string GetTournamentStatusLocalization()
		{
			return null;
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B8")]
		[Address(RVA = "0xB0A0", Offset = "0xB0A0", VA = "0xB0A0")]
		public TournamentData()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_Tournaments_TournamentData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  *(undefined8 *)(iVar1 + 8) = 0;
		  *(undefined8 *)(iVar1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TypeId ---
		int Core_Data_Tournaments_TournamentData__get_TypeId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a60807 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Tournaments_TournamentData_TypeInfo);
		    DAT_ram_00a60807 = '\x01';
		  }
		  iVar3 = Core_Extensions_Dict_DictExt__GetBlitzTournamentsDic
		                    (param2,*(undefined4 *)(param1 + 0xc),0);
		  if (*(int *)(param1 + 0x2c) != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		          goto code_r0x81cea390;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x81cea390:
		    iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    uVar1 = 0;
		    uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x2c) + 0xc) + 0xc);
		    piVar6 = *(int **)(iVar5 + 0x14);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81cea422;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x81cea422:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar2,puVar4[1]);
		  }
		  iVar5 = unnamed_function_1417(Core_Data_Tournaments_TournamentData_TypeInfo);
		  *(undefined4 *)(iVar5 + 0x10) = uVar2;
		  *(int *)(iVar5 + 0xc) = param1;
		  *(int *)(iVar5 + 8) = iVar3;
		  uVar2 = *(undefined4 *)(iVar3 + 0x30);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar2,0);
		  *(undefined4 *)(iVar5 + 0x14) = uVar2;
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(*(undefined4 *)(iVar3 + 0x20),0);
		  uVar2 = System_Linq_Enumerable__ToList_object_
		                    (uVar2,0,Method_System_Collections_Generic_List_Resources__get_Item__);
		  *(undefined4 *)(iVar5 + 0x18) = uVar2;
		  return iVar5;
		}
		*/

}
