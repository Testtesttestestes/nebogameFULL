using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.RateGame.Model
{
	// Token: 0x020005A8 RID: 1448
	[Token(Token = "0x20005A8")]
	public class RateGameModel : AbstractModel
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x1700065B")]
		public bool IsFeatureAvailable
		{
			[Token(Token = "0x60022C3")]
			[Address(RVA = "0x741A", Offset = "0x741A", VA = "0x741A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x00006D98 File Offset: 0x00004F98
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065C")]
		public int RatePositiveBound
		{
			[Token(Token = "0x60022C4")]
			[Address(RVA = "0x741B", Offset = "0x741B", VA = "0x741B")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022C5")]
			[Address(RVA = "0x741C", Offset = "0x741C", VA = "0x741C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x00006DB0 File Offset: 0x00004FB0
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065D")]
		public uint RequirementId
		{
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0x741D", Offset = "0x741D", VA = "0x741D")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60022C7")]
			[Address(RVA = "0x741E", Offset = "0x741E", VA = "0x741E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065E")]
		public IGame Game
		{
			[Token(Token = "0x60022C8")]
			[Address(RVA = "0x741F", Offset = "0x741F", VA = "0x741F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60022C9")]
			[Address(RVA = "0x7420", Offset = "0x7420", VA = "0x7420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x7421", Offset = "0x7421", VA = "0x7421", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_RateGame_Model_RateGameModel__Dispose
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a580c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27307);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27308);
		    DAT_ram_00a580c9 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(int **)(param1 + 0x14) = param2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80e9f584;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e9f584:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_27308,0);
		  *(undefined4 *)(param1 + 0xc) = uVar3;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80e9f61f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e9f61f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_27307,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x7422", Offset = "0x7422", VA = "0x7422")]
		public RateGameModel(IGame game, UserData user)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		void Gameplay_RateGame_Model_RateGameModel__set_Game(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
