using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D7 RID: 2007
	[Token(Token = "0x20007D7")]
	public class OpenPageGroupActionOnEvent_6 : AbstractActionOnEvent
	{
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002F06 RID: 12038 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x1700092E")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F06")]
			[Address(RVA = "0x7F73", Offset = "0x7F73", VA = "0x7F73", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x7F74", Offset = "0x7F74", VA = "0x7F74", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F08")]
		[Address(RVA = "0x7F75", Offset = "0x7F75", VA = "0x7F75")]
		public OpenPageGroupActionOnEvent_6()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_OpenPageGroupActionOnEvent_6__get_SortOrder
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57501 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21864);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    DAT_ram_00a57501 = '\x01';
		  }
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
		        goto code_r0x80d9b3d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d9b3d2:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_21864,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar3,StringLiteral_19433,0,0);
		  return;
		}
		*/

}
