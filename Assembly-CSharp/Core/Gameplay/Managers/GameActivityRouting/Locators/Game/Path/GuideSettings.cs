using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011DA RID: 4570
	[Token(Token = "0x20011DA")]
	public class GuideSettings : AbstractPathNode
	{
		// Token: 0x06006CBB RID: 27835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBB")]
		[Address(RVA = "0xB7A7", Offset = "0xB7A7", VA = "0xB7A7", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBC")]
		[Address(RVA = "0xB7A8", Offset = "0xB7A8", VA = "0xB7A8", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CBD")]
		[Address(RVA = "0xB7A9", Offset = "0xB7A9", VA = "0xB7A9")]
		public GuideSettings()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_GuideSettings___ctor
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a71c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home_MovCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a71c = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x812613f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x812613f8:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar5 = *(int *)(*(int *)(iVar5 + 0x14) + 0x24);
		  uVar1 = 0;
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x8126147e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8126147e:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar5 == *(int *)(*(int *)(iVar6 + 0x14) + 0x20)) {
		    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home__TransitionCanceled
		              (param1,puVar2);
		    return;
		  }
		  *(undefined4 *)(param1 + 0x18) = param4;
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81261514;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81261514:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 8);
		  param1_00 = *(undefined4 *)(iVar6 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Home_MovCompleteEvent__
		             ,0);
		  iVar5 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar5,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar1 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x81261604;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81261604:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_WorldManager__TryRequestMonsterForCurrentUserIsle(uVar3,0);
		  return;
		}
		*/

		}
	}
}
