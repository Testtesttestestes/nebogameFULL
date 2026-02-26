using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using Protocol.Dic;

namespace Core.Data.Tournaments
{
	// Token: 0x020010CA RID: 4298
	[Token(Token = "0x20010CA")]
	public class BlitzTournamentData : ITournament
	{
		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060064A3 RID: 25763 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064A4 RID: 25764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001457")]
		public BlitzTournamentsDic Dic
		{
			[Token(Token = "0x60064A3")]
			[Address(RVA = "0xB08C", Offset = "0xB08C", VA = "0xB08C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A4")]
			[Address(RVA = "0xB08D", Offset = "0xB08D", VA = "0xB08D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060064A5 RID: 25765 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064A6 RID: 25766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001458")]
		public RewardData[] Rewards
		{
			[Token(Token = "0x60064A5")]
			[Address(RVA = "0xB08E", Offset = "0xB08E", VA = "0xB08E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A6")]
			[Address(RVA = "0xB08F", Offset = "0xB08F", VA = "0xB08F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060064A7 RID: 25767 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x17001459")]
		public uint TypeId
		{
			[Token(Token = "0x60064A7")]
			[Address(RVA = "0xB090", Offset = "0xB090", VA = "0xB090", Slot = "4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A8")]
		[Address(RVA = "0xB091", Offset = "0xB091", VA = "0xB091")]
		private BlitzTournamentData()
		{
		/* --- GHIDRA: .ctor ---
		int Core_Data_Tournaments_BlitzTournamentData___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a60806 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Tournaments_BlitzTournamentData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a60806 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Data_Tournaments_BlitzTournamentData_TypeInfo);
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar4,0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar4;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x81cea270;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cea270:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetChatBanDic(uVar4,*(undefined4 *)(param1 + 0xc),0);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  return iVar2;
		}
		*/

		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064A9")]
		[Address(RVA = "0xB092", Offset = "0xB092", VA = "0xB092")]
		public static BlitzTournamentData Create(ProtoGetTournamentListAns.Types.TournamentListItem tournament)
		{
			return null;
		}
	}
}
